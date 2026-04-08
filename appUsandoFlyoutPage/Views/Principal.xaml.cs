using appUsandoFlyoutPage.Views;

namespace appUsandoFlyoutPage.Views;

public partial class Principal : ContentPage
{
    public Principal()
    {
        try
        {
            Logger.Log("Principal: Constructor started");
            InitializeComponent();
            Logger.Log("Principal: InitializeComponent completed");
        }
        catch (Exception ex)
        {
            Logger.LogException(ex);
            throw;
        }
    }

    private void IrParaDandara(object sender, EventArgs e)
    {
        try
        {
            Logger.Log("Principal: Navegando para Dandara");
            Navigation.PushAsync(new Dandara());
        }
        catch (Exception ex)
        {
            Logger.LogException(ex);
        }
    }

    private void IrParaOprah(object sender, EventArgs e)
    {
        try
        {
            Logger.Log("Principal: Navegando para Oprah");
            Navigation.PushAsync(new Oprah());
        }
        catch (Exception ex)
        {
            Logger.LogException(ex);
        }
    }
}
