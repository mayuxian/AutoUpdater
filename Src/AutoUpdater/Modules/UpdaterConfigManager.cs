using Ma.ConfigManager;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration.Xml;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoUpdater.Modules
{
    /// <summary>
    /// 
    /// </summary>
    public static class UpdaterConfigManager
    {
        static UpdaterConfigManager()
        {
            ConfigManager.Load("Configs");
        }

        #region 更新服务配置
        /// <summary>
        /// 请求大版本号Url
        /// </summary>
        public static string MajorVerionNumUrl
        {
            get { return ConfigManager.GetConnectionString(nameof(MajorVerionNumUrl)); }
        }

        /// <summary>
        /// 版本信息Url
        /// </summary>
        public static string VersionInfoUrl
        {
            get { return ConfigManager.GetConnectionString(nameof(VersionInfoUrl)); }
        }

        /// <summary>
        /// 下载文件Url
        /// </summary>
        public static string DownloadFileUrl
        {
            get { return ConfigManager.GetConnectionString(nameof(DownloadFileUrl)); }
        }
        #endregion

        #region 运行环境配置信息
        /// <summary>
        /// 根目录
        /// </summary>
        public static string BaseDirectory
        {
            get { return AppDomain.CurrentDomain.BaseDirectory; }
        }

        /// <summary>
        /// 主程序名称
        /// </summary>
        public static string MainAppName
        {
            get { return ConfigManager.GetConfig(nameof(MainAppName)); }
        }

        /// <summary>
        /// 更新器路径
        /// </summary>
        public static string UpdaterDir
        {
            get { return ConfigManager.GetConfig(nameof(UpdaterDir)); }
        }

        /// <summary>
        /// 更新应用名称
        /// </summary>
        public static string UpdaterAppName
        {
            get { return ConfigManager.GetConfig(nameof(UpdaterAppName)); }
        }

        /// <summary>
        /// 更新器运行临时目录
        /// </summary>
        public static string UpdaterRunTempDir
        {
            get { return ConfigManager.GetConfig(nameof(UpdaterRunTempDir)); }
        }
        #endregion

        #region  通信配置文件

        /// <summary>
        /// 使用Gzip
        /// </summary>
        public static bool UseGzip
        {
            get { return Boolean.Parse(ConfigManager.GetConfig(nameof(UseGzip))); }
        }

        /// <summary>
        /// 通信方法 GET/POST
        /// </summary>
        public static string CommMethod
        {
            get { return ConfigManager.GetConfig(nameof(CommMethod)); }
        }

        /// <summary>
        /// 重试连接次数
        /// </summary>
        public static string ReconnectCount
        {
            get { return ConfigManager.GetConfig(nameof(ReconnectCount)); }
        }

        /// <summary>
        /// 重试连接间隔 单位：毫秒
        /// </summary>
        public static string ReconnectInterval
        {
            get { return ConfigManager.GetConfig(nameof(ReconnectInterval)); }
        }
        #endregion
    }
}
