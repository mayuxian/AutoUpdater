using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdater.Utils
{
    internal static class FileUtil
    {
        public static async Task<bool> CopyDirectoryFilesAsync(string sourcePath, string destinationPath, bool overwriteexisting = true)
        {
            sourcePath = sourcePath.EndsWith(@"\") ? sourcePath : sourcePath + @"\";
            destinationPath = destinationPath.EndsWith(@"\") ? destinationPath : destinationPath + @"\";

            if (Directory.Exists(sourcePath))
            {
                if (!Directory.Exists(destinationPath))
                    Directory.CreateDirectory(destinationPath);

                foreach (string fls in Directory.GetFiles(sourcePath))
                {
                    FileInfo fileInfo = new FileInfo(fls);
                    var destFileName = destinationPath + fileInfo.Name;
                    //_logger.InfoFormat("拷贝文件：源文件：{0}\r\n目标文件:{1}", fls, destFileName);
                    fileInfo.CopyTo(destFileName, overwriteexisting);
                }
                foreach (string drs in Directory.GetDirectories(sourcePath))
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(drs);
                    await CopyDirectoryFilesAsync(drs, destinationPath + dirInfo.Name, overwriteexisting);
                }
            }
            return true;
        }
    }
}
