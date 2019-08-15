using AutoUpdater.Core;
using AutoUpdater.Enums;
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

        public override async Task<int> Start()
        {
            try
            {
                var versionInfo = await this.GetVersionInfo();
                var checkResult = await this.CheckUpdate(versionInfo);
                if (!checkResult.NeedUpdate)
                {
                    return (int)UpdateResult.NoUpdate;
                }
                var downloadResult =await this.Download(checkResult);
                var closeAppResul = await this.CloseApp();
                var applyResult = await this.ApplyUpdate(checkResult);

                return (int)UpdateResult.UpdateSuccess;
            }
            catch (Exception ex)
            {
                //throw;
                return (int)UpdateResult.UpdateError;
            }
        }
    }
}
