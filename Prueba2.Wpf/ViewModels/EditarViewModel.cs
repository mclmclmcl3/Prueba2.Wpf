using Pureba2.Wpf.Command;
using Pureba2.Wpf.Controller;
using Pureba2.Wpf.Messages;
using Pureba2.Wpf.Models;
using System.Windows.Input;

namespace Pureba2.Wpf.ViewModels
{
    public class EditarViewModel : ViewModelBase
    {
        private CentralViewModel centralViewModel;
        private readonly IPersonasController personasController;

        private MensajePersona mensajePersona;
        public MensajePersona MensajePersona
        {
            get { return mensajePersona; }
            set
            {
                mensajePersona = value;
                OnPropertyChanged();
                mensajePersona.ParameterPassed += OnParameterPassed;
            }
        }
        private Persona persona;
        public Persona Persona
        {
            get => persona;
            set
            {
                persona = value;
                OnPropertyChanged();
            }
        }

        public ICommand EditarCommand { get; set; }

        public EditarViewModel(CentralViewModel centralViewModel, IPersonasController personasController, MensajePersona mensajePersona)
        {
            this.Persona = persona;
            this.centralViewModel = centralViewModel;
            this.personasController = personasController;
            Persona = new Persona();
            EditarCommand = new DelegateCommand(EditarPersona);
        }

        private void OnParameterPassed(Persona persona)
        {
            Persona = persona;
        }

        private void EditarPersona()
        {
            personasController.UpdatePersona(Persona);
            centralViewModel.Update();
        }
    }
}
