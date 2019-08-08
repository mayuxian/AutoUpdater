using Ma.DIService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ma.Logging.Log4net
{
    public class Startup
    {
        public Startup()
        {
            //TODO:
            //1.平台加载，则加载此方法
            //2.使用Ma.DIService把接口和实现类注册。
            var dependencyService = DependencyService.Instance;
        }
    }
}
