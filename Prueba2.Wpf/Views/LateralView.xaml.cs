using Microsoft.Extensions.DependencyInjection;
using Prueba2.Wpf;
using Pureba2.Wpf.ViewModels;
using System.Windows.Controls;

namespace Pureba2.Wpf.Views
{
    /// <summary>
    /// Lógica de interacción para LateralView.xaml
    /// </summary>
    public partial class LateralView : UserControl
    {
        private LateralViewModel viewModel;
        public LateralView()
        {
            InitializeComponent();
            this.DataContext = viewModel = App.AppHost.Services.GetService<LateralViewModel>();
        }
    }
}
