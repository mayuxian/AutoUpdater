using AutoUpdater.Core;
using System;
using System.Net;
using System.Threading.Tasks;
using Updater.UpdateService.Interface;

namespace AutoUpdater
{
    public class AutoUpdater : IAppUpdateFlow
    {
        public Task<bool> CheckUpdate()
        {
            return Task.FromResult(true);

            //HttpWebRequest
            //AssemeblyLoader.CreateInstance()
        }
    }
}
