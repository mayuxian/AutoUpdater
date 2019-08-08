using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AutoUpdater.Services
{
    public class CommOptions
    {
        /// <summary>
        ///  Gets or sets the value of the Content-type HTTP header.
        ///  The default value is "application/json; charset=UTF-8".
        /// </summary>
        public string ContentType { get; set; } = "application/json; charset=UTF-8";

        /// <summary>
        /// Gets or sets the value of the User-agent HTTP header.
        /// The default value is "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36"
        /// </summary>
        public string UserAgent { get; set; } = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36";

        /// <summary>
        /// Gets or sets the value of the ContentEncoding HTTP header.
        /// The default value is UTF-8;
        /// </summary>
        public Encoding ContentEncoding { get; set; } = Encoding.UTF8;

        /// <summary>
        /// Gets or sets the value of the AutomaticDecompression HTTP Request.
        /// The default value is true.
        /// </summary>
        public bool GzipEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value that indicates whether to make a persistent connection to the Internet resource.
        /// The default value is true.
        /// </summary>
        public bool KeepAlive { get; set; } = true;

        /// <summary>
        /// Gets or sets a time-out in milliseconds when writing to or reading from a stream.
        /// The default value is 300,000 milliseconds (5 minutes).
        /// </summary>
        public int ReadWriteTimeout { get; set; } = 300000;

        /// <summary>
        /// Gets or sets the time-out value in milliseconds for the System.Net.HttpWebRequest.GetResponse
        /// and System.Net.HttpWebRequest.GetRequestStream methods.
        /// The default value is 100,000 milliseconds (100 seconds).
        /// </summary>
        public int Timeout { get; set; }
    }
}
