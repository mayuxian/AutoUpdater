using System;
using System.Collections.Generic;
using System.Text;

namespace Updater.UpdateService.Interface
{
    public interface IResponse<T>
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        bool Success { get; set; } 

        /// <summary>
        /// 结果
        /// </summary>
        T Result { get; set; }

        /// <summary>
        /// 异常信息
        /// </summary>
        IResponseError Error { get; set; }
    }

    public interface IResponseError
    {
        string Message { get; set; }

        string Code { get; set; }

        string StackTrace { get; set; }
    }
}
