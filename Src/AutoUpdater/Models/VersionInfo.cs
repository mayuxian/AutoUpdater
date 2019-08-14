using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Updater.UpdateService.Interface;

namespace AutoUpdater.Models
{
    internal class VersionInfo : IVersionInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TimeStamp { get; set; }

        public ICollection<IFileInfo> FileInfos { get; set; }

        /// <summary>
        /// 更新策略
        /// </summary>
        public IUpdateStrategy UpdateStrategy { get; set; }
    }
}
