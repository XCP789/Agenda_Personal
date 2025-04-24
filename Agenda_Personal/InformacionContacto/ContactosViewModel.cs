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

        public void AgregarContactos(DatosContacto NuevoContacto)
        {
            if (NuevoContacto != null && !string.IsNullOrWhiteSpace(NuevoContacto.Nombre))
            { 
                Contactos.Add(NuevoContacto);
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        
    }
}
