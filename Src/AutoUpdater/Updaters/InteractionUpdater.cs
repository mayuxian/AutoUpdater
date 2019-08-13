using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Updater.UpdateService.Interface;

namespace AutoUpdater.Updaters
{
    /// <summary>
    /// 交互更新器
    /// </summary>
    /// <remarks>
    /// 默认更新器
    /// </remarks>
    internal class InteractionUpdater : IUpdateFlow
    {
        public Task<bool> ApplyUpdate()
        {
            throw new NotImplementedException();
        }

        public Task<bool> CheckUpdate()
        {
            throw new NotImplementedException();
        }

        public Task<bool> CloseApp(string processName)
        {
            throw new NotImplementedException();
        }

        public void CommunicationExceptionHandle()
        {
            throw new NotImplementedException();
        }

        public void DownloadFileExceptionHandle()
        {
            throw new NotImplementedException();
        }

        public Task<bool> StartUpate()
        {
            throw new NotImplementedException();
        }

        public void UnhandlePlatformExceptionHandle()
        {
            throw new NotImplementedException();
        }

        public Task<bool> WaitAppExit()
        {
            throw new NotImplementedException();
        }
    }
}
