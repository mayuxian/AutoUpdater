using Microsoft.Extensions.DependencyInjection;
using System;

namespace Ma.DIService
{
    public static class DependencyService
    {
        public static IServiceCollection Instance = new ServiceCollection();

        static DependencyService()
        {
            //Instance.AddSingleton
        }

        public static void AddSingleton()
        {

        }

    }
}
