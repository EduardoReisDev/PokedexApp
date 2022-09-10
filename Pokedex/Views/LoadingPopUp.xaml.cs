using CommunityToolkit.Maui.Views;

namespace Pokedex.Views;

public partial class LoadingPopUp : Popup
{
	public LoadingPopUp(string message)
	{
		InitializeComponent();

		LabelMessage.Text = message;
	}

	public void ClosePopUp()
	{
		Close();
	}
}
