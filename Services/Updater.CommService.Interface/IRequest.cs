using System;
using System.Collections.Generic;
using System.Text;

namespace Updater.CommService.Interface
{
    public interface IRequest<T>
    {
        /// <summary>
        /// 内容
        /// </summary>
        T Content { get; set; }
    }
}
