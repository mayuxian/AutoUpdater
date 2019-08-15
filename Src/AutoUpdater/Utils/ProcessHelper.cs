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
        public static async Task<bool> WaitAppExitAsync(string appName)
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
                    await WaitAppExitAsync(appName);
                }
            }
            return true;
        }
    }
}
