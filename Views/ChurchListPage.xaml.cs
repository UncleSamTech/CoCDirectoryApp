using CoCDirectoryApp.Model;
using CoCDirectoryApp.Models;
using System.Collections.ObjectModel;

namespace CoCDirectoryApp.Views;

[QueryProperty(nameof(State), "state")]
public partial class ChurchListPage : ContentPage
{
    public ObservableCollection<ChurchListInfo> ChurchesList { get; set; } = new();
    public ObservableCollection<ChurchListInfo> FilteredChurchesList { get; set; } = new();

    public string State
    {
        set
        {
            Title = $"Churches in {value}";
            LoadChurches(value);
        }
    }

    public ChurchListPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private void LoadChurches(string state)
    {
        ChurchesList.Clear();

        if (state == "Abia")
        {
            ChurchesList.Add(new ChurchListInfo { ChurchName = "First Church", ChurchPhone = "123-456-7890", ChurchLoggo = "loggo.png" });
            ChurchesList.Add(new ChurchListInfo { ChurchName = "Grace Church", ChurchPhone = "987-654-3210", ChurchLoggo = "loggo.png" });
        }

        FilteredChurchesList.Clear();
        foreach (var church in ChurchesList)
            FilteredChurchesList.Add(church);
    }

    private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    {
        var query = e.NewTextValue?.ToLower() ?? "";

        var results = string.IsNullOrWhiteSpace(query)
            ? ChurchesList
            : new ObservableCollection<ChurchListInfo>(
                ChurchesList.Where(c =>
                    !string.IsNullOrWhiteSpace(c.ChurchName) &&
                    c.ChurchName.ToLower().Contains(query)
                )
              );

        FilteredChurchesList.Clear();
        foreach (var church in results)
            FilteredChurchesList.Add(church);
    }
    private async void OnAddCongregationClicked(object sender, EventArgs e)
    {
        // Pass an ObservableCollection<ChurchInfo> to the AddCongregation constructor as required
        await Navigation.PushAsync(new AddCongregation(new ObservableCollection<ChurchInfo>()));
    }
    private async void OnChurchSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection?.FirstOrDefault() is ChurchListInfo selectedChurchList && !string.IsNullOrEmpty(selectedChurchList.ChurchName))
        {
            var navParams = new Dictionary<string, object>
            {
                { "name", selectedChurchList.ChurchName ?? string.Empty },
                { "phone", selectedChurchList.ChurchPhone ?? string.Empty },
                { "logo", selectedChurchList.ChurchLoggo ?? string.Empty },
                { "address", "123 Church Street" },
                { "activities", string.Join(",", new List<string> { "Bible Study", "Songs practice" }) }
            };

            await Shell.Current.GoToAsync(nameof(ChurchDetailsPage), navParams);
        }

        ((CollectionView)sender).SelectedItem = null;
    }
}
