using System.Net;
using System.Text.Json;
using CommunityToolkit.Maui.Views;
using Pokedex.Models;
using Pokedex.Views;

namespace Pokedex;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	public void OnTextCompleted(object sender, EventArgs args)
	{
        var popup = new LoadingPopUp("Looking for pokemon...");
        this.ShowPopup(popup);

        string text = ((Entry)sender).Text;

		string url = "https://pokeapi.co/api/v2/pokemon/" + text.ToLower();

		using (HttpClient client = new())
		{
            try
            {
                string pokemonSerialized = client.GetStringAsync(url).Result;

                if (pokemonSerialized != null)
                {
                    Pokemon pokemon = JsonSerializer.Deserialize<Pokemon>(pokemonSerialized);
                    //popup.ClosePopUp();
                }
                else
                {
                    //popup.ClosePopUp();
                    ShowPokemonNotFoundAlert();
                }

            }
            catch (Exception)
            {
                //popup.ClosePopUp();
                ShowPokemonNotFoundAlert();
            }
        }
    }

	private async void ShowPokemonNotFoundAlert()
	{
        await DisplayAlert("Pokémon not found", "Are you sure you spelled the name correctly?", "I will check");
    }
}
