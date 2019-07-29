using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdater.Utils
{
    public class HttpHelper : IHttp
    {
        public Task<object> HttpGetAsync(string url, HttpSetting setting = null)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> HttpGetBytesAsync(string url, HttpSetting setting = null)
        {
            throw new NotImplementedException();
        }

        public Task<Stream> HttpGetStreamAsync(string url, HttpSetting setting = null)
        {
            throw new NotImplementedException();
        }

        public Task<string> HttpGetStringAsync(string url, HttpSetting setting = null)
        {
            throw new NotImplementedException();
        }

        public Task<object> HttpPostAsync(string url, HttpSetting setting = null)
        {
            throw new NotImplementedException();
        }

        public async Task<HttpWebResponse> HttpGetResponseAsync(string url, HttpSetting setting = null)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = setting.ContentType;

            return (HttpWebResponse)await request.GetResponseAsync();
        }

        public async Task<HttpWebResponse> HttpPostResponseAsync(string url, HttpSetting setting = null)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";

            return (HttpWebResponse)await request.GetResponseAsync();
        }
    }
}
