using System;
using System.Collections.Generic;
using System.Text;

namespace Ma.Logging
{
    public class  LogManager
    {
        private static ILogProvider _logProvider;

        static LogManager()
        {

        }
        public LogManager()
        {
            _logProvider = null;
        }

        public static ILog GetLogger(string name)
        {
            return _logProvider.GetLogger(name);
        }

        public static ILog GetLogger(Type type)
        {
            return _logProvider.GetLogger(type);
        }

        public static void Dispose()
        {
            _logProvider.Dispose();
        }
    }
}
