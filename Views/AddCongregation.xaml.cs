using CoCDirectoryApp.Models;
using Microsoft.Maui.Controls.Maps;
using System.Collections.ObjectModel;
using Microsoft.Maui.Maps;

namespace CoCDirectoryApp.Views;

public partial class AddCongregation : ContentPage
{
    private ObservableCollection<ActivityInfo> ActivityList { get; set; } = new();

    public ObservableCollection<ChurchInfo> Churches { get; set; }
    public AddCongregation(ObservableCollection<ChurchInfo> churches)
	{
		InitializeComponent();
        Churches = churches;
        BindingContext = this;
    }

    private void OnAddActivityClicked(object sender, EventArgs e)
    {
        var activityName = NewActivityEntry.Text?.Trim();
        if (!string.IsNullOrWhiteSpace(activityName))
        {
            ActivityList.Add(new ActivityInfo { Name = activityName });
            NewActivityEntry.Text = string.Empty;
        }
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        string name = NameEntry.Text.Trim();
        string phone = PhoneEntry.Text.Trim();
        string address = AddressEntry.Text.Trim();

        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address))
        {
            await DisplayAlert("Missing Info", "Name and address are required.", "OK");
            return;
        }

        var newChurch = new ChurchInfo
        {
            Name = name,
            Phone = phone,
            Address = address,
            BuildingImage = "loggo.png",
            Activities = ActivityList.ToList()
        };

        Churches.Add(newChurch);

        await DisplayAlert("Success", "Church added successfully.", "OK");
        await Navigation.PopAsync(); // Go back to list
    }

    private async void OnPickLocationClicked(object sender, EventArgs e)
    {
        try
        {
            // Get current location
            var location = await Geolocation.Default.GetLocationAsync();

            if (location != null)
            {
                await UpdateAddressFromLocation(location);

                // Center map at current location
                LocationMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                    new Location(location.Latitude, location.Longitude),
                    Distance.FromKilometers(1)));

                // Drop a pin
                LocationMap.Pins.Clear();
                LocationMap.Pins.Add(new Pin
                {
                    Label = "Selected Location",
                    Location = new Location(location.Latitude, location.Longitude)
                });
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Unable to pick location: {ex.Message}", "OK");
        }
    }

    public async void OnMapClicked(object sender, MapClickedEventArgs e)
    {
        var clickedLocation = e.Location;

        // Drop pin where user clicked
        LocationMap.Pins.Clear();
        LocationMap.Pins.Add(new Pin
        {
            Label = "Selected Location",
            Location = clickedLocation
        });

        // Reverse geocode and update address
        await UpdateAddressFromLocation(clickedLocation);
    }
    private async Task UpdateAddressFromLocation(Location location)
    {
        var placemarks = await Geocoding.Default.GetPlacemarksAsync(location);
        var placemark = placemarks?.FirstOrDefault();

        if (placemark != null)
        {
            AddressEntry.Text = $"{placemark.Thoroughfare} {placemark.Locality}, {placemark.CountryName}";
        }
        else
        {
            AddressEntry.Text = $"{location.Latitude}, {location.Longitude}";
        }
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

#if WINDOWS
        DisplayAlert("Notice", "Map control is not supported on Windows.", "OK");
#endif
    }

}