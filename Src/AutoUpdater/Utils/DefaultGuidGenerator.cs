using System;
using System.Collections.Generic;
using System.Text;
using Updater.UpdateService.Interface;

namespace AutoUpdater.Utils
{
    //TODO:此生成器，将来可重写
    public class DefaultGuidGenerator : IGuidGenerator
    {
        public string GetGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
