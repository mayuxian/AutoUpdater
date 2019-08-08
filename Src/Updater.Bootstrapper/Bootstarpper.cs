using log4net;
using Ma.DIService;
using Ma.Logging;
using Ma.Logging.Log4net;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Updater.Bootstrapper
{
    public class Bootstarpper
    {
        //TODO:引入Autofac  依赖注入
        public void Startup()
        {
            //TODO:
            //1.把各个接口实现类的startup的进行期中执行。
            //2.依赖注册自定义的内容
            var services = DependencyService.Instance;
            services.AddSingleton<ILogProvider, LogProvider>();
            //DependencyService.Instance.AddSingleton(typeof(ILogProvider), new LogProvider());

            var provider = services.BuildServiceProvider();
            var logProvider = provider.GetService<ILogProvider>();

            var serviceScope = provider.CreateScope();
            var scopeLogProvider = serviceScope.ServiceProvider.GetService<ILogProvider>();

        }

        public void Shutdown()
        {

        }
    }
}
