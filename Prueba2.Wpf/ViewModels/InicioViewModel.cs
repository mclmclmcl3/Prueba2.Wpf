using Pureba2.Wpf.Models;
using System.Collections.ObjectModel;

namespace Pureba2.Wpf.ViewModels
{
    public class InicioViewModel : ViewModelBase
    {
        private LateralViewModel lateralViewModel;
        private CentralViewModel centralViewModel;
        private ObservableCollection<Persona> personaListCentral;
        public ObservableCollection<Persona> PersonaListCentral
        {
            get => personaListCentral;
            set { personaListCentral = value; OnPropertyChanged(); }
        }
        public LateralViewModel LateralViewModel
        {
            get => lateralViewModel;
            set
            {
                lateralViewModel = value;
                OnPropertyChanged();
            }
        }
        public CentralViewModel CentralViewModel
        {
            get => centralViewModel;
            set
            {
                centralViewModel = value;
                OnPropertyChanged();
            }
        }

        public InicioViewModel(LateralViewModel lateralViewModel, CentralViewModel centralViewModel )
        {
            this.lateralViewModel = lateralViewModel;
            this.CentralViewModel = centralViewModel;
        }
    }
}
