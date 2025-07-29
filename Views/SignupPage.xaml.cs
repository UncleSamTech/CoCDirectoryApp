namespace CoCDirectoryApp.Views;

public partial class SignupPage : ContentPage
{
	public SignupPage()
	{
		InitializeComponent();
	}

    private void OnPasswordTextChanged(object sender, TextChangedEventArgs e)
    {
        string password = e.NewTextValue;

        if (string.IsNullOrWhiteSpace(password))
        {
            ShowPasswordError("Password cannot be empty.");
        }
        else if (password.Length < 7 || password.Length > 20)
        {
            ShowPasswordError("Password must be 7–20 characters.");
        }
        else if (!password.Any(char.IsUpper))
        {
            ShowPasswordError("Include at least one uppercase letter.");
        }
        else if (!password.Any(char.IsLower))
        {
            ShowPasswordError("Include at least one lowercase letter.");
        }
        else if (!password.Any(char.IsDigit))
        {
            ShowPasswordError("Include at least one number.");
        }
        else
        {
            PasswordValidationLabel.IsVisible = false;
        }
    }

    private void ShowPasswordError(string message)
    {
        PasswordValidationLabel.Text = message;
        PasswordValidationLabel.IsVisible = true;
    }

    private void OnFacebookSignUpClicked(object sender, EventArgs e)
    {
        // Simulate or initiate Facebook login
        DisplayAlert("Sigup", "Facebook signup clicked", "OK");
    }

    private void OnGoogleSignUpClicked(object sender, EventArgs e)
    {
        // Simulate or initiate Google login
        DisplayAlert("Sigup", "Google signup clicked", "OK");
    }

    private void OnTwitterSignUpClicked(object sender, EventArgs e)
    {
        // Simulate or initiate Twitter login
        DisplayAlert("Sigup", "Twitter signup clicked", "OK");
    }

}