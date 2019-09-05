using System;
using System.Collections.Generic;
using System.Text;

namespace Ma.Bootstrapper
{
    public interface IShutdown
    {
        void Shutdown();

        void DeActivate();
    }
}
