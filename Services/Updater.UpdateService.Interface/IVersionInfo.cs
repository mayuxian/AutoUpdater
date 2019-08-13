
namespace Updater.UpdateService.Interface
{
    public interface IVersionInfo
    {
        /// <summary>
        /// 版本ID
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// 版本名称
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        string TimeStamp { get; set; }
    }
}