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
        Routing.RegisterRoute("SignupPage", typeof(SignupPage));
        Routing.RegisterRoute("ChurchListPage", typeof(ChurchListPage));
        Routing.RegisterRoute("ChurchDetailsPage", typeof(ChurchDetailsPage));
        Routing.RegisterRoute("AddCongregation", typeof(AddCongregation));



    }
    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        // TODO: clear any saved authentication/session data here
        // For example:
        // Preferences.Remove("UserToken");

        // Navigate to login page
        await Shell.Current.GoToAsync("//LoginPage");
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
