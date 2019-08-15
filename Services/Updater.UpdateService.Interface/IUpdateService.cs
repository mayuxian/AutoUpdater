using System.Threading.Tasks;
using Updater.CommService.Interface;

namespace Updater.UpdateService.Interface
{
    public interface IUpdateService
    {
        CommOptions GetCommOptions();

        Task<string> GetMajorVersion(string url);

        Task<IVersionInfo> GetVersionInfo(string url);

        Task<bool> DownloadFile(string url, string downloadFilePath);
    }
}