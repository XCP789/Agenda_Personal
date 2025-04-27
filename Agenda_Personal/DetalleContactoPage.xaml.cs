namespace Agenda_Personal;

[QueryProperty(nameof(Nombre), "nombre")]
[QueryProperty(nameof(Telefono), "telefono")]
[QueryProperty(nameof(Correo), "correo")]
[QueryProperty(nameof(Direccion), "direccion")]
public partial class DetalleContactoPage : ContentPage
{
    public string Nombre { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;
    public string Direccion { get; set; } = string.Empty;
    public DetalleContactoPage()
	{
		InitializeComponent();
	    	
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        BindingContext = null;
        BindingContext = this;
    }

}