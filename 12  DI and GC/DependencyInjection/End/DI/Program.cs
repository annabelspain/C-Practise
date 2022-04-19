using Microsoft.Extensions.DependencyInjection;
using System;

namespace DI2
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceProvider serviceProvider = ConfigureServices();

            //Controller controller = new Controller(new ViewModel(new Model(new ConsoleLog())));
            Controller controller = serviceProvider.GetRequiredService<Controller>();
            controller.ControllerAction();
        }

        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<Controller>();
            services.AddSingleton<ViewModel>();
            services.AddSingleton<Model>();
            services.AddSingleton<ILog, ConsoleLog>();

            var serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
