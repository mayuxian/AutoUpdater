using System;
using System.Collections.Generic;
using System.Text;

namespace AutoUpdater.Core
{
    internal static class ConfigManager
    {
        /// <summary>
        /// 请求大版本号
        /// </summary>
        public static string MajorVerionNumUrl
        {
            get { return ""; }
        }

        public static string VersionInfoUrl { get; }

        public static string DownloadFileUrl { get; }

        public static string BaseDirectory { get; }

        public static string MainAppName { get; }

        public static string UpdaterName { get; }
    }
}
