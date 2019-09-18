using System;
using System.IO;
using System.Reflection;

namespace Ma.Bootstrapper
{
    public static class Bootstrapper
    {
        public static void Load(string runtimePath = null)
        {
            runtimePath = (string.IsNullOrEmpty(runtimePath)) ? AppDomain.CurrentDomain.BaseDirectory : runtimePath;

            var dllFilePaths = Directory.GetFileSystemEntries(runtimePath, "*.dll", SearchOption.AllDirectories);
            foreach (var filePath in dllFilePaths)
            {
                try
                {

                    var assembly = Assembly.LoadFrom(filePath);
                    foreach (var type in assembly.GetExportedTypes())
                    {
                        if (/*type.IsInterface*/type.IsClass && type.IsAssignableFrom(typeof(IStartup)))
                        {
                            var obj = Activator.CreateInstance(type) as IStartup;
                            obj.Start();
                        }
                        if (/*type.IsInterface*/type.IsClass && type.IsAssignableFrom(typeof(IShutdown)))
                        {
                            var obj = Activator.CreateInstance(type) as IShutdown;
                            obj.Shutdown();
                        }
                    }

                }
                catch (Exception ex)
                {
                    //TODO:需要做成未加载日志模块时，依旧可调用Log输出日志。
                    var errorFilePath = Path.Combine(runtimePath, "error.log");
                    File.AppendAllText(errorFilePath, ex.Message);
                    throw;
                }
            }
        }
    }
}
