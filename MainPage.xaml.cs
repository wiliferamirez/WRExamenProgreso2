namespace WRExamenProgreso2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void NavigateToChistes(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///Chistes");
        }

        private async void NavigateToAbout(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///About");
        }
    }

}
