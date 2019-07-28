using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdater.Utils
{
    public interface IHttp : IHttpBase<object, object>
    {
        Task<HttpWebResponse> HttpGetResponseAsync();

        Task<HttpWebResponse> HttpPostResponseAsync();
    }

    public interface IHttpBase<GetResponseT, PostResponseT>
    {
        Task<GetResponseT> HttpGetAsync();

        Task<string> HttpGetStringAsync();

        Task<Stream> HttpGetStreamAsync();

        Task<byte[]> HttpGetBytesAsync();

        Task<PostResponseT> HttpPostAsync();
    }

    interface HttpConfig
    {

    }
}
