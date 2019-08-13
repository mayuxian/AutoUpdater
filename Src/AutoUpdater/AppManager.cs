using AutoUpdater.Updaters;
using Ma.DIService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Updater.UpdateService.Interface;

namespace AutoUpdater
{
    public class AppManager : IAppUpdateFlow
    {
        public AppManager()
        {
            
        }

        public Task<bool> CheckUpdate()
        {
            return null;
        }
    }
}
