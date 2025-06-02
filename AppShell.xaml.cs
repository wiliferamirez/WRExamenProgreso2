namespace WRExamenProgreso2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Chistes", typeof(Chistes));
            Routing.RegisterRoute("MainPage", typeof(MainPage));
            Routing.RegisterRoute("About", typeof(About));
        }
    }
}
