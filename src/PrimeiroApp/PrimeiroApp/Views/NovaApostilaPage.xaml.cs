using appUsandoEntry.Views;

namespace appUsandoEntry.Views;

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
