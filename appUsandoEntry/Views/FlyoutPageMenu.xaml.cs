using appUsandoEntry.Views;

namespace appUsandoEntry.Views;

public partial class FlyoutPageMenu : ContentPage
{
    public FlyoutPageMenu()
    {
        InitializeComponent();
    }

    private void IrParaDandara(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Dandara());
    }

    private void IrParaOprah(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Oprah());
    }
}
