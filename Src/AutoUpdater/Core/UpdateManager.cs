using AutoUpdater.Models;
using AutoUpdater.Modules;
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
        private ISignatureGenerator _signatureGenerator = new Md5SignatureGenerator();
        private IUrlAssembler _urlAssembler = new UrlAssembler();

        public abstract Task<int> Start();

        public virtual async Task<IVersionInfo> GetVersionInfo()
        {
            var url = _urlAssembler.GetVersionInfoUrl(UpdaterConfigManager.VersionInfoUrl, _updateService.GetCommOptions());
            var versionInfo = await _updateService.GetVersionInfo(url);
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
                var signature = _signatureGenerator.GetSignature(fullPath);
                if (fileInfo.Signature != signature)
                {
                    updateCheckResult.DownloadFiles.Add(fileInfo.RelativePath);
                }
            }
            //TODO：生成删除文件列表 

            return Task.FromResult<IUpdateCheckResult>(updateCheckResult);
        }

        public virtual async Task<bool> Download(IUpdateCheckResult updateCheckResult)
        {
            if (updateCheckResult == null || updateCheckResult.DownloadFiles == null)
            {
                return true;
            }
            foreach (var filePath in updateCheckResult.DownloadFiles)
            {
                var url = _urlAssembler.GetVersionInfoUrl(UpdaterConfigManager.DownloadFileUrl, _updateService.GetCommOptions());
                var fileFullPath = Path.GetFullPath(Path.Combine(UpdaterConfigManager.BaseDirectory, filePath));

                //TODO:下载失败，则进行尝试
                await _updateService.DownloadFile(url, fileFullPath);
            }
            return true;
        }

        public virtual Task<bool> CloseApp()
        {
            return ProcessHelper.CloseAppAsync(UpdaterConfigManager.MainAppName);
        }

        public virtual Task<bool> ApplyUpdate(IUpdateCheckResult updateCheckResult)
        {
            throw new NotImplementedException();
        }
    }
}
