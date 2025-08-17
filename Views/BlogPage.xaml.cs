namespace CoCDirectoryApp.Views;

public partial class BlogPage : ContentPage
{
	public BlogPage()
	{
		InitializeComponent();
	}

    private async void OnAddBlogClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddBlog());
    }
}