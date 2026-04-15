using appUsandoEntry.Views;

namespace appUsandoEntry;

public partial class App : Application
{
    public App()
    {
        try
        {
            ConsoleLogger.Log("App: Constructor started");
            InitializeComponent();
            ConsoleLogger.Log("App: InitializeComponent completed successfully");
        }
        catch (Exception ex)
        {
            ConsoleLogger.LogException(ex);
            throw;
        }
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        try
        {
            ConsoleLogger.Log("CreateWindow: Starting...");
            var flyoutPage = new MinhaFlyoutPage();
            ConsoleLogger.Log("CreateWindow: MinhaFlyoutPage created successfully");
            var window = new Window(flyoutPage);
            ConsoleLogger.Log("CreateWindow: Window created successfully");
            return window;
        }
        catch (Exception ex)
        {
            ConsoleLogger.LogException(ex);
            throw;
        }
    }
}
