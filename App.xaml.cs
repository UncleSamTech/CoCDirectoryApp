using CoCDirectoryApp.Views;

namespace CoCDirectoryApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        AppDomain.CurrentDomain.UnhandledException += (s, e) =>
        {
            LogCrash(e.ExceptionObject?.ToString() ?? "Unknown exception");
        };

        TaskScheduler.UnobservedTaskException += (s, e) =>
        {
            LogCrash(e.Exception?.ToString() ?? "Unknown exception");
        };
    }

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}

    void LogCrash(string message)
    {
        try
        {
            var path = Path.Combine(FileSystem.AppDataDirectory, "crashlog.txt");
            File.AppendAllText(path, DateTime.Now + ": " + message + Environment.NewLine);
        }
        catch { }
    }
}