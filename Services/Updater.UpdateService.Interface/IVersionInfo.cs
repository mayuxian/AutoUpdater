
namespace Updater.UpdateService.Interface
{
    public interface IVersionInfo
    {
        /// <summary>
        /// �汾ID
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// �汾����
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// ������Ϣ
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// ʱ���
        /// </summary>
        string TimeStamp { get; set; }
    }
}