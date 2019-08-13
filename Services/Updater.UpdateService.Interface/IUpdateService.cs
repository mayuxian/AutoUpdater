using System.Threading.Tasks;


namespace Updater.UpdateService.Interface
{
    public interface IUpdateService
    {
        Task<IVersionInfo> GetVersionInfo();

        Task<bool> DownloadFile(string url, string downloadPath);
    }
}