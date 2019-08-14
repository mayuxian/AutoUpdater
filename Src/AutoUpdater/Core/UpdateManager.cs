using AutoUpdater.Models;
using AutoUpdater.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Updater.UpdateService.Interface;

namespace AutoUpdater.Core
{
    //TODO：可使用状态机 设计模式
    //TODO: 需要触发生命周期的各个钩子。可配置执行任务
    public abstract class UpdateManager : IUpdateFlow
    {
        //TODO:可通过依赖注入
        //public UpdateManager(IUpdateService updateService)
        private IUpdateService _updateService = new UpdateService();
        private ISignatureGenerator signatureGenerator = new Md5SignatureGenerator();

        public abstract void Start();

        public virtual async Task<IVersionInfo> GetVersionInfo()
        {
            var versionInfo = await _updateService.GetVersionInfo(ConfigManager.VersionInfoUrl);
            return versionInfo;

            //ConfigManager.RequestVersionInfoUrl
        }

        public virtual Task<IUpdateCheckResult> CheckUpdate(IVersionInfo versionInfo)
        {
            IUpdateCheckResult updateCheckResult = new UpdateCheckResult();
            updateCheckResult.DownloadFiles = new Collection<string>();
            updateCheckResult.DeleteFiles = new Collection<string>();

            foreach (var fileInfo in versionInfo.FileInfos)
            {
                var fullPath = Path.GetFullPath(fileInfo.RelativePath);
                var signature = signatureGenerator.GetSignature(fullPath);
                if (fileInfo.Signature != signature)
                {
                    updateCheckResult.DownloadFiles.Add(fileInfo.RelativePath);
                }
            }
            //TODO：删除文件列表 

            return Task.FromResult<IUpdateCheckResult>(updateCheckResult);
        }



        public virtual Task<bool> Download(IUpdateCheckResult updateCheckResult)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> CloseApp(string processName)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> ApplyUpdate(IUpdateCheckResult updateCheckResult)
        {
            throw new NotImplementedException();
        }
    }
}
