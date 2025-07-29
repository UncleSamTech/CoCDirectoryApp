using CoCDirectoryApp.Models;

namespace CoCDirectoryApp.Views;

public partial class ChurchListPage : ContentPage
{
    public string State
    {
        set
        {
            // Do something with the selected state
            LoadChurches(value);
        }
    }
    public ChurchListPage()
	{
		InitializeComponent();
	}

    private void LoadChurches(string state)
    {
        // Load churches for the given state
    }

    private void OnStateSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection?.FirstOrDefault() is ChurchInfo selectedChurch && !string.IsNullOrEmpty(selectedChurch.Name))
        {
            // Example: navigate to a ChurchDetailsPage with the selected church info
            Shell.Current.GoToAsync($"ChurchDetailsPage?name={Uri.EscapeDataString(selectedChurch.Name)}");

            // Or handle selection however you prefer
        }

        // Optionally clear selection so they can tap the same item again
        ((CollectionView)sender).SelectedItem = null;
    }

}