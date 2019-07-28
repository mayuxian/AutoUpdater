using AutoUpdater.Core;
using AutoUpdater.Interface;
using System;
using System.Threading.Tasks;

namespace AutoUpdater
{
    public class AutoUpdater : IAppUpdateFlow
    {
        public Task<bool> CheckUpdate()
        {
            return Task.FromResult(true); 

            //AssemeblyLoader.CreateInstance()
        }
    }
}
