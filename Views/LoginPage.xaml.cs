namespace CoCDirectoryApp.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
        Shell.SetFlyoutBehavior(this, FlyoutBehavior.Disabled);
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

    private async void OnSignUpClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignupPage");
    }

    public async void OnLoginClicked(object sender, EventArgs e)
    {
        // Simulate login process
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            await DisplayAlert("Error", "Username and password cannot be empty.", "OK");
            return;
        }
        // Here you would typically validate the credentials with a backend service
        await DisplayAlert("Login", "Login successful!", "OK");
        
        // Navigate to the main application page after successful login
        await Shell.Current.GoToAsync("//StateListPage");
    }

}