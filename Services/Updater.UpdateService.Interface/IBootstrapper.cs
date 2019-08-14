using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Updater.UpdateService.Interface
{
    public interface IBootstrapper
    {
        Task<bool> Startup();

        Task<bool> Shutdown();
    }
}
