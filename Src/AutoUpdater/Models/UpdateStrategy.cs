using System;
using System.Collections.Generic;
using System.Text;
using Updater.UpdateService.Interface;

namespace AutoUpdater.Models
{
    public class UpdateStrategy : IUpdateStrategy
    {
        /// <summary>
        /// 配置ID
        /// </summary>
       public string OptionId { get; set; }

        /// <summary>
        /// 文件匹配模式
        /// </summary>
        public string MatchPatterns { get; set; }

        /// <summary>
        /// 排除的文件
        /// </summary>
        public string ExcludedFiles { get; set; }

        /// <summary>
        /// 排除的目录
        /// </summary>
        public string ExcludedDirectories { get; set; }

        /// <summary>
        /// 只更新一次的文件
        /// </summary>
        public string OnceUpdateFiles { get; set; }

        /// <summary>
        /// 只更新一次的文件目录
        /// </summary>
        public string OnceUpdateDirectories { get; set; }
    }
}
