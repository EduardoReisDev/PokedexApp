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

	public async void OnTextCompleted(object sender, EventArgs args)
	{
        string url = "https://pokeapi.co/api/v2/pokemon/" + EntryPokemonName?.Text?.ToLower();

        try
        {
            HttpClient client = new();
            string pokemonSerialized = client.GetStringAsync(url).Result;

            if (pokemonSerialized != null)
            {
                Pokemon pokemon = JsonSerializer.Deserialize<Pokemon>(pokemonSerialized);
                await Navigation.PushAsync(new PokemonDetailsView(pokemon));
            }
            else
            {
                ShowPokemonNotFoundAlert();
            }

        }
        catch (Exception)
        {
            ShowPokemonNotFoundAlert();
        }
    }

	private async void ShowPokemonNotFoundAlert()
	{
        await DisplayAlert("Pokémon not found", "Are you sure you spelled the name correctly?", "I will check");
    }
}
