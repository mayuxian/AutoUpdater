using System.Threading.Tasks;


namespace Updater.UpdateService.Interface
{
    public interface IUpdateService
    {
        Task<string> GetMajorVersion(string url);

        Task<IVersionInfo> GetVersionInfo(string url);

        Task<bool> DownloadFile(string url, string downloadFilePath);
    }
}