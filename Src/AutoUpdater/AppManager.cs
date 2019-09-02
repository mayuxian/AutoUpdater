using AutoUpdater.Core;
using AutoUpdater.Updaters;
using AutoUpdater.Utils;
using Ma.DIService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Updater.UpdateService.Interface;
using AutoUpdater.Modules;

namespace AutoUpdater
{
    public class AppManager : IAppUpdateFlow
    {
        public AppManager()
        {

        }

        public async Task<bool> CheckUpdate()
        {
            await ProcessHelper.CloseAppAsync(UpdaterConfigManager.UpdaterAppName);
            await ProcessHelper.DeleteDirectory(UpdaterConfigManager.UpdaterRunTempDir);

            var sourceDir = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, UpdaterConfigManager.UpdaterDir));
            var targetDir = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, UpdaterConfigManager.UpdaterRunTempDir));
            await FileUtil.CopyDirectoryFilesAsync(sourceDir, targetDir);
            return true;
        }
    }
}
