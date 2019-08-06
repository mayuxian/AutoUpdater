using System;
using System.Collections.Generic;
using System.Text;

namespace Ma.Logging
{
    public interface ILogProvider
    {
        ILog GetLogger(string name);

        ILog GetLogger(Type type);

        void Dispose();
    }
}
