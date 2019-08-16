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
                //TODO:若需要更新，则需要提醒用户是否进行更新，取消则不更新。
                var downloadResult = await this.Download(checkResult);
                var closeAppResult = await this.CloseApp();
                if (closeAppResult)
                {
                    var applyResult = await this.ApplyUpdate(checkResult);
                }

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
