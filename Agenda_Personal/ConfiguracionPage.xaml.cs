namespace Agenda_Personal;

public partial class ConfiguracionPage : ContentPage
{
	public ConfiguracionPage()
	{
		InitializeComponent();
	}
	private async void CambiarTema(object sender, EventArgs e)
	{
		bool TemaOscuro = Application.Current.Resources["FondoColor"].ToString() == "#1E1E1E";

		Application.Current.Resources["FondoColor"] = TemaOscuro ? Color.FromArgb("#e8e8e8") : Color.FromArgb("#1E1E1E");
        Application.Current.Resources["TextColor"] = TemaOscuro ? Color.FromArgb("#000000") : Color.FromArgb("#ffffff");

		//var paginaActual = Application.Current.MainPage;
		//Application.Current.MainPage = new ContentPage();

		//Application.Current.MainPage = paginaActual;

		Dispatcher.Dispatch(() =>
		{
			Application.Current.MainPage.BackgroundColor = (Color)Application.Current.Resources["FondoColor"];
		});

		await Task.Delay(50);
        //foreach (var pagina in Application.Current.MainPage.Navigation.NavigationStack)
        //{
        //    pagina.BackgroundColor = (Color)Application.Current.Resources["FondoColor"];
        //}
    }
}