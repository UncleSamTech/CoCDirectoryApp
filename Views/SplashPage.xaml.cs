namespace CoCDirectoryApp.Views;

public partial class SplashPage : ContentPage
{
	public SplashPage()
	{
		InitializeComponent();
        Shell.SetFlyoutBehavior(this, FlyoutBehavior.Disabled);
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await Task.Delay(3000); // wait 3 sec
        await Shell.Current.GoToAsync("//LoginPage");
       // Application.Current.MainPage = new NavigationPage(new LoginPage());

    }

}