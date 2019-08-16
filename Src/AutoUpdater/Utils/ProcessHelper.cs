using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdater.Utils
{
    internal static class ProcessHelper
    {
        public static async Task<bool> CloseAppAsync(string appName)
        {
            var processes = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(appName));
            if (processes == null || processes.Length == 0)
                return true;

            var waitExitTasks = new List<Task<bool>>();
            foreach (var process in processes)
            {
                try
                {
                    var tcs = new TaskCompletionSource<bool>();
                    process.Exited += delegate
                    {
                        tcs.SetResult(true);
                        process.Close();
                        process.Dispose();
                    };
                    process.EnableRaisingEvents = true;
                    waitExitTasks.Add(tcs.Task);
                }
                catch (Exception ex)
                {
                    //_logger.InfoFormat("关闭程序：{0}发生错误：{1}", appName, ex.Message);
                }
            }
            bool[] result = Task.WhenAll(waitExitTasks).Result;
            foreach (var execResult in result)
            {
                if (!execResult)
                {
                    await CloseAppAsync(appName);
                }
            }
            return true;
        }

        public static async Task<bool> DeleteDirectory(string dirPath)
        {
            if (!Directory.Exists(dirPath))
            {
                return true;
            }

            var now = DateTime.Now;
            await Task.Delay(400); //先休眠一段时间，尽量保证下次删除时无被占用，正常删除
            //_logger.InfoFormat("DeleteDirectory Start时间：{0}", now);
            try
            {
                if (Directory.Exists(dirPath))
                {
                    Directory.Delete(dirPath, true);
                }
            }
            catch (Exception e)
            {
                //_logger.ErrorFormat("删除目录{0}发生错误：{1}", dirPath, e);
                return await DeleteDirectory(dirPath);  //如果发生错误，则直接强制删除
            }
            //_logger.InfoFormat("DeleteDirectory End时间：{0}", DateTime.Now);
            return true;
        }
    }
}
