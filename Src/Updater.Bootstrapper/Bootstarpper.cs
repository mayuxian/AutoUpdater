using log4net;
using Ma.DIService;
using Ma.Logging;
using Ma.Logging.Log4net;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Updater.CommService.Interface;
using Updater.gRPCService.Impl;
using Updater.UpdateService.Interface;

namespace Updater.Bootstrapper
{
    public class Bootstarpper : IBootstrapper
    {
        //TODO:引入Autofac  依赖注入
        public Task<bool> Startup()
        {
            //TODO:
            //1.把各个接口实现类的startup的进行期中执行。
            //2.依赖注册自定义的内容
            var services = DependencyService.Instance;
            services.AddSingleton<ILogProvider, LogProvider>();
            services.AddSingleton<ICommService,GrpcService>();

            //DependencyService.Instance.AddSingleton(typeof(ILogProvider), new LogProvider());

            var provider = services.BuildServiceProvider();
            var logProvider = provider.GetService<ILogProvider>();

            var serviceScope = provider.CreateScope();
            var scopeLogProvider = serviceScope.ServiceProvider.GetService<ILogProvider>();

            return Task.FromResult<bool>(true);
        }

        public Task<bool> Shutdown()
        {
            return Task.FromResult<bool>(true);
        }
    }
}
