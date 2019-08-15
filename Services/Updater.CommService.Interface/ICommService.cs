using System;
using System.IO;
using System.Threading.Tasks;

namespace Updater.CommService.Interface
{
    //public interface ICommService<IResponse> : ICommServiceBase<IResponse<object>, object>
    //{

    //}


    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 通信接口入参，统一增加字符串类型的requestContent，字符串参数则接口实现都会转成bytes或者string发送，
    /// 服务端接受再处理。不在支持不同类型、不同对象。因为所有的结构最终都会转成流，不如在接口调用之前调用者将数据提前转换好。
    /// requestContent如果是结构化的建议是json字符串
    /// 暂不考虑post的方式
    /// </remarks>
    public interface ICommService
    {
        CommOptions GetCommOptions();

        Task<string> GetStringAsync(string url, string requestContent = null, CommOptions options = null);

        Task<byte[]> GetBytesAsync(string url, string requestContent = null, CommOptions options = null);

        Task<Stream> GetStreamAsync(string url, string requestContent = null, CommOptions options = null);
    }
}
