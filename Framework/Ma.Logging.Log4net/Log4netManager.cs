using log4net;
using log4net.Config;
using log4net.Repository;
using System;
using System.IO;

namespace Ma.Logging.Log4net
{
    internal class Log4netManager
    {
        private string _configFilePath;
        private string _repositoryDomain;

        public Log4netManager(string configFilePath = "log4net.config", string repositoryDomain = "NETCoreRepository")
        {
            _configFilePath = configFilePath;
            _repositoryDomain = repositoryDomain;

            this.Initialize();
        }

        public void Initialize()
        {
            ILoggerRepository repository = log4net.LogManager.CreateRepository(_repositoryDomain);
            XmlConfigurator.Configure(repository, new FileInfo(_configFilePath));
        }

        public log4net.ILog GetLogger(string name)
        {
            return log4net.LogManager.GetLogger(_repositoryDomain, name);
        }

        public void Dispose()
        {
            log4net.LogManager.Shutdown();
            log4net.LogManager.ShutdownRepository(_repositoryDomain);
        }

    }
}
