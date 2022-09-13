using Pokedex.Models;

namespace Pokedex.Views;

public partial class PokemonDetailsView : ContentPage
{
    private Pokemon pokemon;

    public PokemonDetailsView()
	{
		InitializeComponent();
	}

    public PokemonDetailsView(Pokemon pokemon)
    {
        this.pokemon = pokemon;
    }
}
