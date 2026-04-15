using appUsandoEntry.Views;

namespace appUsandoEntry.Views;

public partial class Menu : ContentPage
{
    public Menu()
    {
        InitializeComponent();
    }

    private void irPaginaDandara(object sender, EventArgs e)
    {
        var flyoutPage = Application.Current.Windows[0].Page as FlyoutPage;
        if (flyoutPage != null)
        {
            flyoutPage.Detail = new NavigationPage(new Dandara());
        }
    }

    private void irPaginaOprah(object sender, EventArgs e)
    {
        var flyoutPage = Application.Current.Windows[0].Page as FlyoutPage;
        if (flyoutPage != null)
        {
            flyoutPage.Detail = new NavigationPage(new Oprah());
        }
    }

    private void irPaginaCadastroCarros(object sender, EventArgs e)
    {
        var flyoutPage = Application.Current.Windows[0].Page as FlyoutPage;
        if (flyoutPage != null)
        {
            flyoutPage.Detail = new NavigationPage(new CadastroDeCarros());
        }
    }
}