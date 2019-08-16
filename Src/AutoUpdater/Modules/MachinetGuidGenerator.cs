using System;
using System.Collections.Generic;
using System.Text;
using Updater.UpdateService.Interface;

namespace AutoUpdater.Modules
{
    //TODO:此生成器，将来可重写
    public class MachinetGuidGenerator : IMachineGuidGenerator
    {
        public string GetGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
