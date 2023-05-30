using Pureba2.Wpf.Controller;
using Pureba2.Wpf.Models;
using System.Windows.Input;
using DelegateCommand = Pureba2.Wpf.Command.DelegateCommand;

namespace Pureba2.Wpf.ViewModels
{
    public class InsertarViewModel : ViewModelBase
    {
        private CentralViewModel centralViewModel;
        private readonly IPersonasController personasController;
        private Persona persona;
        public Persona Persona
        {
            get => persona;
            set { persona = value; OnPropertyChanged(); }
        }


        public ICommand InsertarCommand { get; set; }

        public InsertarViewModel(CentralViewModel centralViewModel, IPersonasController personasController)
        {
            this.centralViewModel = centralViewModel;
            this.personasController = personasController;
            Persona = new Persona();
            InsertarCommand = new DelegateCommand(InsertarPersona);
        }

        private void InsertarPersona()
        {
            personasController.InsertarPersona(Persona);
            centralViewModel.Update();
        }
    }
}
