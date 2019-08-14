
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

        /// <summary>
        /// 文件信息
        /// </summary>
        ICollection<IFileInfo> FileInfos { get; set; }

        /// <summary>
        /// 更新策略
        /// </summary>
        IUpdateStrategy UpdateStrategy { get; set; }
    }
}