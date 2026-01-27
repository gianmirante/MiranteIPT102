using MenuDomain.Commands;
using MenuDomain.Queries;
using MenuFramework.Commands;
using MenuFramework.Queries;
using MenuRepository;
using MenuRepository.Interface;
using MenuRepository.Interface;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace MenuWpfApp
{
    public partial class App : Application
    {
        public static IHost AppHost { get; private set; }

        public App()
        {
            AppHost = Microsoft.Extensions.Hosting.Host
                .CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<IRepository, Repository>();

                    services.AddTransient<ICreateMenu, CreateMenu>();
                    services.AddTransient<IUpdateMenu, UpdateMenu>();
                    services.AddTransient<IDeleteMenu, DeleteMenu>();
                    services.AddTransient<IGetMenuById, GetMenuById>();

                    services.AddSingleton<MainWindow>();
                })
                .Build();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            AppHost.Start();
            AppHost.Services.GetRequiredService<MainWindow>().Show();
            base.OnStartup(e);
        }
    }
}
