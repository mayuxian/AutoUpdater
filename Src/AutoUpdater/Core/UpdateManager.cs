using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Updater.UpdateService.Interface;

namespace AutoUpdater.Core
{
    //TODO：可使用状态机 设计模式
    public abstract class UpdateManager : IUpdateFlow
    {
        public Task<bool> CloseApp(string processName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> WaitAppExit()
        {
            throw new NotImplementedException();
        }

        public Task<IVersionInfo> GetVersionInfo()
        {
            throw new NotImplementedException();
        }

        public Task<IUpdateCheckResult> CheckUpdate(IVersionInfo versionInfo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Download(IUpdateCheckResult updateCheckResult)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ApplyUpdate(IUpdateCheckResult updateCheckResult)
        {
            throw new NotImplementedException();
        }

        public abstract void Start();
    }
}
