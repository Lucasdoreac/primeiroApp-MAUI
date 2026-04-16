using Microsoft.Maui.Controls;

namespace appUsandoEntry.Views;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private void irPaginaDandara(object sender, EventArgs e)
    {
        var flyoutPage = Parent as FlyoutPage;
        if (flyoutPage != null)
        {
            flyoutPage.Detail = new NavigationPage(new Dandara());
            flyoutPage.IsPresented = false;
        }
    }

    private void irPaginaOprah(object sender, EventArgs e)
    {
        var flyoutPage = Parent as FlyoutPage;
        if (flyoutPage != null)
        {
            flyoutPage.Detail = new NavigationPage(new Oprah());
            flyoutPage.IsPresented = false;
        }
    }

    private void irPaginaCadastro(object sender, EventArgs e)
    {
        var flyoutPage = Parent as FlyoutPage;
        if (flyoutPage != null)
        {
            flyoutPage.Detail = new NavigationPage(new CadastroDeCarros());
            flyoutPage.IsPresented = false;
        }
    }
}