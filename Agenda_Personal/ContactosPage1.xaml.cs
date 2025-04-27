using Agenda_Personal.InformacionContacto;

namespace Agenda_Personal;

public partial class ContactosPage1 : ContentPage
{
	private readonly ContactosViewModel ViewModel;
	public ContactosPage1(ContactosViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;	
		ViewModel = vm;
	}
}