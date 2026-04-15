using appUsandoEntry.Views;

namespace appUsandoEntry.Views;

public partial class FlyoutPageMenu : ContentPage
{
    public FlyoutPageMenu()
    {
        InitializeComponent();
    }

    private void IrParaPrincipal(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Principal());
    }

    private void IrParaCadastroCarros(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new CadastroDeCarros());
    }
}
