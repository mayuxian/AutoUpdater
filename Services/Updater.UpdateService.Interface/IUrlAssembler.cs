using System;
using System.Collections.Generic;
using System.Text;
using Updater.CommService.Interface;

namespace Updater.UpdateService.Interface
{
    public interface IUrlAssembler
    {
        string GetVersionInfoUrl(string orginUrl, CommOptions options);

        string GetDownloadUrl(string orginUrl, CommOptions options);
    }
}
