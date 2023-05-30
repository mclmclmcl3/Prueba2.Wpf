using Pureba2.Wpf.Command;
using Pureba2.Wpf.Controller;
using Pureba2.Wpf.Messages;
using Pureba2.Wpf.Models;
using Pureba2.Wpf.Views;
using System.Windows.Input;

namespace Pureba2.Wpf.ViewModels
{
    public class LateralViewModel : ViewModelBase
    {
        private Persona persona;
        private EventUpdate eventUpdate;
        private MensajePersona mensaje;
        private readonly IPersonasController personasController;

        public Persona Persona
        {
            get { return persona == null ? new Persona() { Nombre = "" } : persona; }
            set { persona = value; OnPropertyChanged(); }
        }

        public ICommand AddCommand { get; set; }
        public ICommand ModificarCommand { get; set; }
        public ICommand BorrarCommand { get; set; }

        public LateralViewModel(EventUpdate eventUpdate, MensajePersona mensaje, IPersonasController personasController)
        {
            AddCommand = new DelegateCommand(AddPersona);
            ModificarCommand = new DelegateCommand(ModificarPersona);
            BorrarCommand = new DelegateCommand(BorrarPersona);
            this.eventUpdate = eventUpdate;
            this.mensaje = mensaje;
            this.personasController = personasController;
        }
        private void BorrarPersona()
        {
            personasController.DeletePersona(Persona.Id);
            eventUpdate.PublishParameter();
        }

        private void ModificarPersona()
        {
            mensaje.PublishParameter(Persona);
            EditarView editar = new EditarView();
            editar.Show();
        }

        private void AddPersona()
        {
            InsertarView insertar = new InsertarView();
            insertar.Show();
        }
    }
}
