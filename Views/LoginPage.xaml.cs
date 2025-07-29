namespace CoCDirectoryApp.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void OnFacebookLoginClicked(object sender, EventArgs e)
    {
        // Simulate or initiate Facebook login
        DisplayAlert("Login", "Facebook login clicked", "OK");
    }

    private void OnGoogleLoginClicked(object sender, EventArgs e)
    {
        // Simulate or initiate Google login
        DisplayAlert("Login", "Google login clicked", "OK");
    }

    private void OnTwitterLoginClicked(object sender, EventArgs e)
    {
        // Simulate or initiate Twitter login
        DisplayAlert("Login", "Twitter login clicked", "OK");
    }

}