using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Updater.UpdateService.Interface;

namespace AutoUpdater.Modules
{
    internal class Md5SignatureGenerator : ISignatureGenerator
    {
        public string GetSignature(string filePath)
        {
            string md5 = null;
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var md5Provider = new MD5CryptoServiceProvider())
                {
                    var md5Bytes = md5Provider.ComputeHash(fs);
                    md5 = Convert.ToBase64String(md5Bytes);
                }
            }
            return md5;
        }
    }
}
