using System;
using System.Collections.Generic;
using System.Text;

namespace Updater.UpdateService.Interface
{
    public interface IUpdateCheckResult
    {
        bool NeedUpdate { get; set; }

        ICollection<string> DownloadFiles { get; set; }

        ICollection<string> DeleteFiles { get; set; }
    }
}
