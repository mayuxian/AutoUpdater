using System;
using System.Threading.Tasks;

namespace Updater.CommService.Interface
{
    //public interface ICommService<IResponse> : ICommServiceBase<IResponse<object>, object>
    //{

    //}

    public interface ICommServiceBase<TResponse, TResult>
        where TResponse : IResponse<TResult>
    {
        Task<TResponse> GetAsync(string url, CommOptions setting = null);

        Task<string> GetStringAsync(string url, CommOptions setting = null);

        //Task<Stream> HttpGetStreamAsync(string url, CommOptions setting = null);

        Task<byte[]> GetBytesAsync(string url, CommOptions setting = null);

        Task<TResponse> PostAsync(string url, CommOptions setting = null);
    }
}
