using PrimeiroApp.Views;

namespace PrimeiroApp.Views;

public partial class FlyoutMenuPage : ContentPage
{
	public FlyoutMenuPage()
	{
		InitializeComponent();
	}

	private void GoToHome(object sender, EventArgs e)
	{
		var flyoutPage = Parent as FlyoutPage;
		if (flyoutPage != null)
		{
			flyoutPage.Detail = new NavigationPage(new MainPage());
			flyoutPage.IsPresented = false;
		}
	}

	private void GoToProfile(object sender, EventArgs e)
	{
		var flyoutPage = Parent as FlyoutPage;
		if (flyoutPage != null)
		{
			flyoutPage.Detail = new NavigationPage(new ProfilePage());
			flyoutPage.IsPresented = false;
		}
	}

	private void GoToSettings(object sender, EventArgs e)
	{
		var flyoutPage = Parent as FlyoutPage;
		if (flyoutPage != null)
		{
			flyoutPage.Detail = new NavigationPage(new SettingsPage());
			flyoutPage.IsPresented = false;
		}
	}

	private void GoToMulheres(object sender, EventArgs e)
	{
		var flyoutPage = Parent as FlyoutPage;
		if (flyoutPage != null)
		{
			flyoutPage.Detail = new NavigationPage(new MulheresTabbedPage());
			flyoutPage.IsPresented = false;
		}
	}

	private void GoToNovaApostila(object sender, EventArgs e)
	{
		var flyoutPage = Parent as FlyoutPage;
		if (flyoutPage != null)
		{
			flyoutPage.Detail = new NavigationPage(new NovaApostilaPage());
			flyoutPage.IsPresented = false;
		}
	}

	private void GoToApostila07(object sender, EventArgs e)
	{
		var flyoutPage = Parent as FlyoutPage;
		if (flyoutPage != null)
		{
			flyoutPage.Detail = new NavigationPage(new Apostila07Page());
			flyoutPage.IsPresented = false;
		}
	}

	private void GoToCadastroCarros(object sender, EventArgs e)
	{
		var flyoutPage = Parent as FlyoutPage;
		if (flyoutPage != null)
		{
			flyoutPage.Detail = new NavigationPage(new CadastroDeCarrosPage());
			flyoutPage.IsPresented = false;
		}
	}
}
