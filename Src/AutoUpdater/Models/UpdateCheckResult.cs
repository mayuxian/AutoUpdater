using System;
using System.Collections.Generic;
using System.Text;
using Updater.UpdateService.Interface;

namespace AutoUpdater.Models
{
    internal class UpdateCheckResult : IUpdateCheckResult
    {
        public bool NeedUpdate { get; set; }
        public ICollection<string> DownloadFiles { get; set; }
        public ICollection<string> DeleteFiles { get; set; }
    }
}
