using PrimeiroApp.Views;

namespace PrimeiroApp.Views;

public partial class NovaApostilaPage : ContentPage
{
	public NovaApostilaPage()
	{
		InitializeComponent();
	}

	private async void GoToMenu(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}
