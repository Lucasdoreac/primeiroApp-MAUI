using appUsandoEntry.Views;

namespace appUsandoEntry.Views;

public partial class Menu : ContentPage
{
    public Menu()
    {
        InitializeComponent();
    }

    private void irPaginaPrincipal(object sender, EventArgs e)
    {
        var flyoutPage = Application.Current.Windows[0].Page as FlyoutPage;
        if (flyoutPage != null)
        {
            flyoutPage.Detail = new NavigationPage(new Principal());
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