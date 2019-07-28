using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdater.Interface
{
    /// <summary>
    /// 应用程序更新流程
    /// </summary>
    public interface IAppUpdateFlow
    {
        /// <summary>
        /// 检查更新
        /// </summary>
        /// <returns></returns>
        Task<bool> CheckUpdate();
    }
}
