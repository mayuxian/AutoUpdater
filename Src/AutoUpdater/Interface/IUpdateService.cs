using System.Threading.Tasks;

public interface IUpdateService
{
    Task<IVersionInfo> GetVersionInfo();

    Task<bool> DownloadFile(string url,string downloadPath);
}