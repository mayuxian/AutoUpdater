using System;
using System.Collections.Generic;
using System.Text;

namespace Updater.UpdateService.Interface
{
    public interface IUpdateStrategy
    {
        /// <summary>
        /// 配置ID
        /// </summary>
        string OptionId { get; set; }

        /// <summary>
        /// 文件匹配模式
        /// </summary>
        string MatchPatterns { get; set; }

        /// <summary>
        /// 排除的文件
        /// </summary>
        string ExcludedFiles { get; set; }

        /// <summary>
        /// 排除的目录
        /// </summary>
        string ExcludedDirectories { get; set; }

        /// <summary>
        /// 只更新一次的文件
        /// </summary>
        string OnceUpdateFiles { get; set; }

        /// <summary>
        /// 只更新一次的文件目录
        /// </summary>
        string OnceUpdateDirectories { get; set; }
    }
}
