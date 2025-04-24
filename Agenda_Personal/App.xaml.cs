using Agenda_Personal.InformacionContacto;

namespace Agenda_Personal
{
    public partial class App : Application
    {
        public static ContactosViewModel ContactosVM { get; private set; }
        public App()
        {
            InitializeComponent();
            ContactosVM = new ContactosViewModel();
            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}