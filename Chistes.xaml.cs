using System.Net.Http.Json;
using System.Text.Json;

namespace WRExamenProgreso2;

public partial class Chistes : ContentPage
{
    public Chistes()
    {
        InitializeComponent();
        _ = LoadChisteAsync();
    }

    private async void NewChiste(object sender, EventArgs e)
    {
        await LoadChisteAsync();
    }

    private async Task LoadChisteAsync()
    {
        try
        {
            ChisteLabel.Text = "Cargando chiste...";
            using var client = new HttpClient();
            var response = await client.GetAsync("https://official-joke-api.appspot.com/random_joke");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var joke = JsonSerializer.Deserialize<Joke>(json);
                if (joke != null)
                {
                    ChisteLabel.Text = $"{joke.setup}\n\n{joke.punchline}";
                }
                else
                {
                    ChisteLabel.Text = "No se pudo cargar el chiste :c";
                }
            }
            else
            {
                ChisteLabel.Text = "Error al obtener el chiste :/";
            }
        }
        catch
        {
            ChisteLabel.Text = "No se pudo establcer una conexion :3";
        }
    }

    private class Joke
    {
        public string setup { get; set; }
        public string punchline { get; set; }
    }

    private async void BackToMain(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}