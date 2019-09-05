using Microsoft.Extensions.DependencyInjection;
using System;

namespace Ma.DIService
{
    public static class DependencyService
    {
        public static IServiceCollection Instance = new ServiceCollection();
        public static ServiceProvider ServiceProvider = Instance.BuildServiceProvider();

        static DependencyService()
        {

        }

        //
        // 摘要:
        //     Adds a singleton service of the type specified in TService with an implementation
        //     type specified in TImplementation to the specified Microsoft.Extensions.DependencyInjection.IServiceCollection.
        //
        // 参数:
        //   services:
        //     The Microsoft.Extensions.DependencyInjection.IServiceCollection to add the service
        //     to.
        //
        // 类型参数:
        //   TService:
        //     The type of the service to add.
        //
        //   TImplementation:
        //     The type of the implementation to use.
        //
        // 返回结果:
        //     A reference to this instance after the operation has completed.
        public static IServiceCollection Register<TService, TImplementation>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            return null;
        }
    }
}
