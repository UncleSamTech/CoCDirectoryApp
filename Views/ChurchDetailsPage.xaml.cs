

using CoCDirectoryApp.Models;

namespace CoCDirectoryApp.Views;

public partial class ChurchDetailsPage : ContentPage
{
    public ChurchDetailsPage()
    {
        InitializeComponent(); 
    }

    private void OnToggleActivitiesClicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.CommandParameter is ChurchInfo church)
        {
            church.ShowActivities = !church.ShowActivities;
            button.Text = church.ShowActivities ? "Hide Activities" : "Show Activities";
        }
    }

}