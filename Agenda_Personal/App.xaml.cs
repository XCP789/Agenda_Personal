using Agenda_Personal.InformacionContacto;

namespace Agenda_Personal
{
    public partial class App : Application
    {
        public static ContactosViewModel ContactosVM { get; private set; } = new ContactosViewModel();
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}