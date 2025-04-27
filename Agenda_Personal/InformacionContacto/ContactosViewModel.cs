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
        public ICommand MostrarDetallesCommand { get; private set; }

        private DatosContacto _contactoSeleccionado;
        public DatosContacto ContactoSeleccionado
        {
            get => _contactoSeleccionado;
            set
            {
                if (_contactoSeleccionado != value)
                {
                    _contactoSeleccionado = value;
                    MostrarDetallesCommand.Execute(value);
                    OnPropertyChanged(nameof(ContactoSeleccionado));
                }
            }
        }
        public ContactosViewModel() 
        {
            AgregarContactoCommand = new Command<DatosContacto>(AgregarContactos);
            MostrarDetallesCommand = new Command<DatosContacto>(MostrarDetalles);
        }
        //esto sirve para mostrar detalles del contacto
        private async void MostrarDetalles(DatosContacto ContactoSeleccionado)
        {
            if (ContactoSeleccionado != null)
            {
                await Shell.Current.GoToAsync($"///detalle?nombre={Uri.EscapeDataString(ContactoSeleccionado.Nombre)}" +
                    $"&telefono={Uri.EscapeDataString(ContactoSeleccionado.Telefono)}" +
                    $"&correo={Uri.EscapeDataString(ContactoSeleccionado.Correo)}" +
                    $"&direccion={Uri.EscapeDataString(ContactoSeleccionado.Direccion)}");
            }
        }

        private async void AgregarContactos(DatosContacto NuevoContacto)
        {
            if (Contactos.Any(c => c.Telefono == NuevoContacto.Telefono))//revisa si el numero que se esta guardando es igual a uno ya existente en Contactos
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
        
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
    }
}
