using Microsoft.Extensions.DependencyInjection;
using Prueba2.Wpf;
using Pureba2.Wpf.ViewModels;
using System.Windows;

namespace Pureba2.Wpf.Views
{
    /// <summary>
    /// Lógica de interacción para InsertarView.xaml
    /// </summary>
    public partial class EditarView : Window
    {
        public EditarView()
        {
            InitializeComponent();
            this.DataContext = App.AppHost.Services.GetService<EditarViewModel>();
        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Editar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
