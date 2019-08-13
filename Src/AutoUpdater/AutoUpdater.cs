using AutoUpdater.Core;
using AutoUpdater.Updaters;
using System;
using System.Net;
using System.Threading.Tasks;
using Updater.UpdateService.Interface;

namespace AutoUpdater
{
    public class AutoUpdater  
    {
        //TODO：根据配置选择启用哪种模式。可扩展
        //使用策略设计模式：
        private UpdateManager _updateManager = new InteractionUpdater(); 

        public void Start()
        {
            _updateManager.Start();
        }
    }
}
