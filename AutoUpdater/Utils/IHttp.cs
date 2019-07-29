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
        Task<HttpWebResponse> HttpGetResponseAsync(string url, HttpSetting setting = null);

        Task<HttpWebResponse> HttpPostResponseAsync(string url, HttpSetting setting = null);
    }

    public interface IHttpBase<GetResponseT, PostResponseT>
    {
        Task<GetResponseT> HttpGetAsync(string url, HttpSetting setting = null);

        Task<string> HttpGetStringAsync(string url, HttpSetting setting = null);

        Task<Stream> HttpGetStreamAsync(string url, HttpSetting setting = null);

        Task<byte[]> HttpGetBytesAsync(string url, HttpSetting setting = null);

        Task<PostResponseT> HttpPostAsync(string url, HttpSetting setting = null);
    }
}
