namespace Agenda_Personal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //conexion entre paginas
        private async void IrListaContactos (object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//ListaContactos");
        }
        private async void IrCrearContacto(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//CrearContacto");
        }
        private async void IrConfiguracion(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Configuracion");
        }

    }

}
