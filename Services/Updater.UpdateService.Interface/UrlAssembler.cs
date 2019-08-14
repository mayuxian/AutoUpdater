using System;
using System.Collections.Generic;
using System.Text;

namespace Updater.UpdateService.Interface
{
    public interface UrlAssembler
    {
        string GetVersionInfoUrl();

        string GetDownloadUrl(string fileRelativePath);
    }
}
