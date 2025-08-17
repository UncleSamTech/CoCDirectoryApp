using CoCDirectoryApp.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CoCDirectoryApp.Views;

public partial class ChurchDetailsPage : ContentPage
{
    public ICommand DialPhoneCommand { get; }
    public ICommand OpenMapCommand { get; }
    public ICommand OpenActivityCommand { get; }
    public ObservableCollection<ChurchInfo> Churches { get; set; } = new();

    public ChurchDetailsPage()
    {
        InitializeComponent();
        BindingContext = this;

        Churches.Add(new ChurchInfo
        {
            Name = "Grace Church",
            Address = "7013 86 Avenue NW Edmonton",
            Phone = "+15879389791",
            Activities = new List<ActivityInfo> { new ActivityInfo { Name = "Bible Study" }, new ActivityInfo { Name = "Choir Practice" }, new ActivityInfo { Name = "Sunday Service" }},
            BuildingImage = "loggo.png"
        });

        

    }

    private void OnDialPhoneClicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.BindingContext is ChurchInfo church && !string.IsNullOrWhiteSpace(church.Phone))
        {
            try
            {
                if (PhoneDialer.Default.IsSupported)
                    PhoneDialer.Default.Open(church.Phone);
                else
                    Console.WriteLine("Phone dialer not supported.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }


    private async void OnOpenMapClicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.BindingContext is ChurchInfo church && !string.IsNullOrWhiteSpace(church.Address))
        {
            var encodedAddress = Uri.EscapeDataString(church.Address);
            var url = $"https://www.google.com/maps/search/?api=1&query={encodedAddress}";
            await Launcher.Default.OpenAsync(url);
        }
    }


}
