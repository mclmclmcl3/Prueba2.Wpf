using Pureba2.Wpf.Controller;
using Pureba2.Wpf.Messages;
using Pureba2.Wpf.Models;
using System.Collections.ObjectModel;

namespace Pureba2.Wpf.ViewModels
{
    public class CentralViewModel : ViewModelBase
    {
        private Persona personaSeleccionada;
        private ObservableCollection<Persona> personaListCentral;
        private LateralViewModel lateralViewModel;
        private readonly IPersonasController personasController;
        private EventUpdate eventUpdate;

        public EventUpdate EventUpdate
        {
            get { return eventUpdate; }
            set
            {
                eventUpdate = value;
                OnPropertyChanged();
                eventUpdate.ParameterPassed += OnParameterPassed;
            }
        }

        public LateralViewModel LateralViewModel
        {
            get { return lateralViewModel; }
            set { lateralViewModel = value; OnPropertyChanged(); }
        }
        public Persona PersonaSeleccionada
        {
            get => personaSeleccionada;
            set
            {
                personaSeleccionada = value;
                OnPropertyChanged();
                LateralViewModel.Persona = this.PersonaSeleccionada;
            }
        }

        public ObservableCollection<Persona> PersonaListCentral
        {
            get => personaListCentral;
            set { personaListCentral = value; OnPropertyChanged(); }
        }
        public CentralViewModel(LateralViewModel lateralViewModel, IPersonasController personasController)
        {
            PersonaListCentral = new ObservableCollection<Persona>();
            LateralViewModel = lateralViewModel;
            this.personasController = personasController;
            Update();
        }
        public void Update()
        {
            personaListCentral.Clear();
            foreach (var item in personasController.GetAll())
            {
                PersonaListCentral.Add(item);
            }
            

        }

        public void OnParameterPassed()
        {
            Update();
        }
    }
}
