using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Updater.UpdateService.Interface;

namespace AutoUpdater.Core
{
    internal class AssemeblyLoader<T>
        where T : class
    {
        private Dictionary<object, object> _interfaceDics = new Dictionary<object, object>();

        public AssemeblyLoader()
        {
            _interfaceDics.Add(typeof(IUpdateFlow), null);
        }

        private T CreateInstance(string typeName)
        {
            //var ass = Assembly.Load(new AssemblyName());
            //return ass.CreateInstance(typeName, true) as T;
            return Activator.CreateInstance(Type.GetType(typeName, true, true)) as T;
        }

        void LoadExtension()
        {

        }

    }
}
