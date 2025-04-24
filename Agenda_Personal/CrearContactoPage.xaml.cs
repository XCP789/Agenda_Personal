using Agenda_Personal.InformacionContacto;

namespace Agenda_Personal;

public partial class CrearContactoPage : ContentPage
{
	private ContactosViewModel ViewModel;
	public CrearContactoPage(ContactosViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		ViewModel = vm;
	}

	private void GuardarContacto(object sender, EventArgs e)
	{
		var nuevoContacto = new DatosContacto
		{
			Nombre = nombreEntry.Text,
			Telefono = telefonoEntry.Text,
			Correo = correoEntry.Text,
			Direccion = direccionEntry.Text
		};
		ViewModel.AgregarContactoCommand.Execute(nuevoContacto);
		Shell.Current.GoToAsync("//ContantosPage1");
	}
}