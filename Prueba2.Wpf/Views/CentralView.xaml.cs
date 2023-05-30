using Microsoft.Extensions.DependencyInjection;
using Prueba2.Wpf;
using Pureba2.Wpf.ViewModels;
using System.Windows.Controls;

namespace Pureba2.Wpf.Views
{
    /// <summary>
    /// Lógica de interacción para CentralView.xaml
    /// </summary>
    public partial class CentralView : UserControl
    {
        private CentralViewModel viewModel;
        public CentralView()
        {
            InitializeComponent();
            this.DataContext = viewModel = App.AppHost.Services.GetService<CentralViewModel>();
        }
    }
}
