using System.Threading.Tasks;

namespace Updater.UpdateService.Interface
{
    //TODO:做成抽象函数，让外部可以重载
    public interface IUpdateFlow //: IUpdateException
    {
        //TODO:发指令或者直接关闭进程

        //先检查大版本
        //Task<string> GetMajorVersion(); 

        //Task<bool> CheckMajorVersion(string majorVersion);

        //Task<bool> UpdateSnapshot();

        //获取版本信息
        Task<IVersionInfo> GetVersionInfo();

        Task<IUpdateCheckResult> CheckUpdate(IVersionInfo versionInfo);

        Task<bool> Download(IUpdateCheckResult updateCheckResult);

        Task<bool> CloseApp(string processName);

        Task<bool> ApplyUpdate(IUpdateCheckResult updateCheckResult);
    }
}