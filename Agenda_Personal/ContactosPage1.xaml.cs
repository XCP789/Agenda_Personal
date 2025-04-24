using Agenda_Personal.InformacionContacto;

namespace Agenda_Personal;

public partial class ContactosPage1 : ContentPage
{
	public ContactosPage1(ContactosViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;		
	}
}