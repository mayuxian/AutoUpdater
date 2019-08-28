using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;

namespace Ma.ConfigManager
{
    //TODO:参考：https://www.jianshu.com/p/b9416867e6e6
    //IConfiguration
    public static class ConfigManager
    {
        private static IConfigurationBuilder _configBuilder = new ConfigurationBuilder();
        private static IConfigurationRoot _configRoot = null;

        static ConfigManager()
        {
            _configBuilder.SetBasePath(AppDomain.CurrentDomain.BaseDirectory);

            //TODO:做成动态加载Configs下的配置文件

            var appSettings = new JsonConfigurationSource();
            appSettings.Build(_configBuilder);
            appSettings.Path = "Configs/appSettings.json";
            _configBuilder.Add(appSettings);

            var logSettings = new JsonConfigurationSource();
            logSettings.Build(_configBuilder);
            logSettings.Path = "Configs/loggingSettings.json";
            _configBuilder.Add(logSettings);


            _configRoot = _configBuilder.Build();
        }

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

        public static string UpdaterDir { get; }

        public static string UpdaterAppName { get; }

        public static string UpdaterRunTempDir { get; }

        public static string GetConnectionString(string key)
        {
            return _configRoot.GetConnectionString(key);
        }

        public static string GetConfig(string key)
        {
            //configBuilder.AddConfiguration(new UpdaterConfiguration());

            //var b = new XmlConfigurationSource();
            //configBuilder.Sources

            return _configRoot.GetSection(key).Value;
        }
    }


    public class UpdaterConfiguration : IConfiguration
    {
        public string this[string key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable<IConfigurationSection> GetChildren()
        {
            throw new NotImplementedException();
        }

        public IChangeToken GetReloadToken()
        {
            throw new NotImplementedException();
        }

        public IConfigurationSection GetSection(string key)
        {
            throw new NotImplementedException();
        }
    }
}
