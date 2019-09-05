using System;
using System.Collections.Generic;
using System.Text;

namespace Ma.Bootstrapper
{
    public interface IStartup
    {
        void Start();

        void Activate();
       
    }
}
