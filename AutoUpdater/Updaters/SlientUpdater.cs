using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdater.Updaters
{
    internal class SlientUpdater : IUpdateFlow
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
