namespace CoCDirectoryApp.Views;

public partial class AddBlog : ContentPage
{
    public AddBlog()
    {
        InitializeComponent();
    }

    private async void OnAddImageClicked(object sender, EventArgs e)
    {

        await DisplayAlert("Add Image", "This feature is not implemented yet.", "OK");

    }

    private async void OnAddAudioClicked(object sender, EventArgs e)
    {

        await DisplayAlert("Add Audio", "This feature is not implemented yet.", "OK");

    }

    private async void OnAddVideoClicked(object sender, EventArgs e)
    {

        await DisplayAlert("Add Video", "This feature is not implemented yet.", "OK");

    }

    private async void OnPublishClicked(object sender, EventArgs e)
    {

        await DisplayAlert("Blog Publish", "This feature is not implemented yet.", "OK");

    }
}