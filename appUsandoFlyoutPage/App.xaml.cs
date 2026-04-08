using appUsandoFlyoutPage.Views;

namespace appUsandoFlyoutPage;

public partial class App : Application
{
    public App()
    {
        try
        {
            Logger.Log("App: Constructor started");
            InitializeComponent();
            Logger.Log("App: InitializeComponent completed successfully");
        }
        catch (Exception ex)
        {
            Logger.LogException(ex);
            throw;
        }
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        try
        {
            Logger.Log("CreateWindow: Starting...");
            var mainPage = new NavigationPage(new Principal());
            Logger.Log("CreateWindow: MainPage created successfully");
            var window = new Window(mainPage);
            Logger.Log("CreateWindow: Window created successfully");
            return window;
        }
        catch (Exception ex)
        {
            Logger.LogException(ex);
            throw;
        }
    }
}
