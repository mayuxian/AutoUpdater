using System;
using System.Collections.Generic;
using System.Text;

namespace Updater.UpdateService.Interface
{
    public class Response /*: IResponse<object>*/
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        public object Result { get; set; }

        /// <summary>
        /// 异常信息
        /// </summary>
        public IResponseError Error { get; set; }
    }
}
