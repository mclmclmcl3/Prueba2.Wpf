using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pureba2.Wpf.Controller;
using Pureba2.Wpf.Messages;
using Pureba2.Wpf.ViewModels;
using Pureba2.Wpf.Views;
using System.Windows;

namespace Prueba2.Wpf
{
    public partial class App : Application
    {
        public static IHost AppHost { get; private set; }
        public App()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddSingleton<InicioViewModel>();
                    services.AddSingleton<CentralViewModel>();
                    services.AddSingleton<LateralViewModel>();
                    services.AddSingleton<InsertarViewModel>();
                    services.AddSingleton<EditarViewModel>();

                    services.AddSingleton<InicioView>();
                    services.AddSingleton<CentralView>();
                    services.AddSingleton<LateralView>();
                    services.AddSingleton<InsertarView>();
                    services.AddSingleton<EditarView>();

                    services.AddSingleton<EventUpdate>();
                    services.AddSingleton<MensajePersona>();
                    services.AddSingleton<IPersonasController, PersonasController>();


                }).Build();

            var cVm = AppHost.Services.GetRequiredService<CentralViewModel>();
            var eventUpdate = AppHost.Services.GetRequiredService<EventUpdate>();
            cVm.EventUpdate = eventUpdate;

            var mensaje = AppHost.Services.GetRequiredService<EditarViewModel>();
            var eventmensajee = AppHost.Services.GetRequiredService<MensajePersona>();
            mensaje.MensajePersona = eventmensajee;
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost.StartAsync();
            var ventana = AppHost.Services.GetService<InicioView>();
            ventana.DataContext = AppHost.Services.GetService(typeof(InicioViewModel));
            ventana.Show();
            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost.StopAsync();
            base.OnExit(e);
        }
    }
}
