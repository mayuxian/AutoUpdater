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

        public static void AddSingleton()
        {

        }

    }
}
