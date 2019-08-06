using System;
using System.Collections.Generic;
using System.Text;

namespace Ma.Logging.Log4net
{
    public class LogProvider : ILogProvider
    {
        private Log4netManager _logManager;

        static LogProvider()
        {

        }
        public LogProvider()
        {
            _logManager = new Log4netManager();
        }

        public ILog GetLogger(string name)
        {
            return new LogWrapper(_logManager.GetLogger(name));
        }

        public ILog GetLogger(Type type)
        {
            return new LogWrapper(_logManager.GetLogger(type.FullName));
        }

        public void Dispose()
        {
            _logManager.Dispose();
        }
    }
}
