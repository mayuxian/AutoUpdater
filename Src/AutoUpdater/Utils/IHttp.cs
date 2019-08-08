using AutoUpdater.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdater.Utils
{
    public interface IHttp 
    {
        Task<HttpWebResponse> HttpGetResponseAsync(string url, CommOptions setting = null);

        Task<HttpWebResponse> HttpPostResponseAsync(string url, CommOptions setting = null);
    }
  
}
