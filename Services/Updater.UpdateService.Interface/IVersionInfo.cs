
using System.Collections;
using System.Collections.Generic;

namespace Updater.UpdateService.Interface
{
    public interface IFileInfo
    {
        string RelativePath { get; set; }

        string Signature { get; set; }
    }

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

        /// <summary>
        /// �ļ���Ϣ
        /// </summary>
        ICollection<IFileInfo> FileInfos { get; set; }

        /// <summary>
        /// ���²���
        /// </summary>
        IUpdateStrategy UpdateStrategy { get; set; }
    }
}