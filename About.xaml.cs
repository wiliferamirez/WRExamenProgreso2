namespace WRExamenProgreso2;

public partial class About : ContentPage
{
	public About()
	{
		InitializeComponent();
	}

    private async void BackToMain(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}