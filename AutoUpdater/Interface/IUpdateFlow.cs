using System.Threading.Tasks;

public interface IUpdateFlow : IUpdateException
{
  //TODO:发指令或者直接关闭进程
  Task<bool> CloseApp(string processName);

  Task<bool> WaitAppExit();

  Task<bool> CheckUpdate();

  Task<bool> StartUpate();

  Task<bool> ApplyUpdate();

}