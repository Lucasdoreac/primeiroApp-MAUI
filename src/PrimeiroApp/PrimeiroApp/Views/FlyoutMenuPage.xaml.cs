using appUsandoEntry.Views;

namespace appUsandoEntry.Views;

public partial class FlyoutMenuPage : ContentPage
{
	public FlyoutMenuPage()
	{
		InitializeComponent();
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
			flyoutPage.Detail = new NavigationPage(new CadastroDeCarros());
			flyoutPage.IsPresented = false;
		}
	}
}
