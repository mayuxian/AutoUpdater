using AutoUpdater.Core;
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
    internal class InteractionUpdater : UpdateManager
    {
        public void CheckUpdate()
        {

        }

        public override void Start()
        {
            throw new NotImplementedException();
        }
    }
}
