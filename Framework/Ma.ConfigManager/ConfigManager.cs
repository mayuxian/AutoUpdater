using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration.Xml;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.IO;

namespace Ma.ConfigManager
{
    //TODO:参考：https://www.jianshu.com/p/b9416867e6e6
    //IConfiguration
    /// <summary>
    /// 配置管理器
    /// </summary>
    public static class ConfigManager
    {
        private static IConfigurationBuilder _configBuilder = new ConfigurationBuilder();
        private static IConfigurationRoot _configRoot = null;

        static ConfigManager()
        {
            _configBuilder.SetBasePath(AppDomain.CurrentDomain.BaseDirectory);
        }

        /// <summary>
        /// 加载配置文件
        /// </summary>
        /// <param name="configPath"></param>
        public static void Load(string configPath = "Configs")
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var fullPath = Path.GetFullPath(Path.Combine(baseDir, configPath));
            var filePaths = Directory.GetFileSystemEntries(fullPath, "*", SearchOption.AllDirectories);

            foreach (var filePath in filePaths)
            {
                if (Path.GetExtension(filePath).ToLower() == ".json")
                {
                    var jsonSettings = new JsonConfigurationSource();
                    jsonSettings.Build(_configBuilder);
                    jsonSettings.Path = Path.GetFullPath(filePath).Replace(Path.GetFullPath(baseDir), "");
                    //jsonSettings.Path = "Configs/appSettings.json";
                    _configBuilder.Add(jsonSettings);
                }
                if (Path.GetExtension(filePath).ToLower() == ".xml")
                {
                    var xmlSettings = new XmlConfigurationSource();
                    xmlSettings.Build(_configBuilder);
                    xmlSettings.Path = filePath;
                    _configBuilder.Add(xmlSettings);
                }
            }
            _configRoot = _configBuilder.Build();
        }

        /// <summary>
        /// 获取配置文件值
        /// </summary>
        /// <param name="key">主键</param>
        /// <returns></returns>
        public static string GetConfig(string key)
        {
            //configBuilder.AddConfiguration(new UpdaterConfiguration());
            //var b = new XmlConfigurationSource();
            //configBuilder.Sources

            return _configRoot.GetSection(key).Value;
        }

        /// <summary>
        /// 获取连接字符串
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetConnectionString(string name)
        {
            return _configRoot.GetConnectionString(name);
        }
    }
}
