using CoCDirectoryApp.Views;

namespace CoCDirectoryApp;

public partial class AppShell : Shell
{
    private bool _hasNavigated = false;
    public AppShell()
	{
		InitializeComponent();
        // Register routes
        Routing.RegisterRoute("SplashPage", typeof(SplashPage));
        Routing.RegisterRoute("LoginPage", typeof(LoginPage));


    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (!_hasNavigated)
        {
            _hasNavigated = true;
            await Shell.Current.GoToAsync("//SplashPage");
        }
    }
}
