using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Agenda_Personal.InformacionContacto
{
    public class ContactosViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<DatosContacto> Contactos { get; set; } = new ObservableCollection<DatosContacto> ();
        public ICommand AgregarContactoCommand { get; private set; }

        public ContactosViewModel() 
        {
            AgregarContactoCommand = new Command<DatosContacto>(AgregarContactos);
        }

        private async void AgregarContactos(DatosContacto NuevoContacto)
        {
            if (Contactos.Any(c => c.Telefono == NuevoContacto.Telefono))
            {
                if (App.Current != null && App.Current.Windows.Count>0 && App.Current.Windows[0].Page != null)
                { 
                    await App.Current.Windows[0].Page.DisplayAlert("Advertencia", "Este Numero esta repetido, por favor ingresa otro.", "Aceptar");
                }
                    return;
            }
            if (!string.IsNullOrWhiteSpace(NuevoContacto.Nombre) && !string.IsNullOrWhiteSpace(NuevoContacto.Telefono)) 
            {
                Contactos.Add(NuevoContacto);
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        
    }
}
