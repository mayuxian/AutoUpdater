using System;
using System.Collections.Generic;
using System.Text;
using Updater.CommService.Interface;
using Updater.UpdateService.Interface;

namespace AutoUpdater.Core
{
    public class UrlAssembler : IUrlAssembler
    {
        public string GetDownloadUrl(string orginUrl, CommOptions options)
        {
            if (options.Method == CommMethod.POST)
            {
                return orginUrl;
            }
            //TODO:若为Get则需要拼接
            return orginUrl;
        }

        public string GetVersionInfoUrl(string orginUrl, CommOptions options)
        {
            if (options.Method == CommMethod.POST)
            {
                return orginUrl;
            }
            return orginUrl;
        }
    }
}
