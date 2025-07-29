using System.ComponentModel;

namespace CoCDirectoryApp.Models;

public class ChurchInfo : INotifyPropertyChanged
{
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public List<string>? Activities { get; set; } // Can be multi-line string
    public string? BuildingImage { get; set; } // image filename from Resources/Images

    private bool showActivities;
    public bool ShowActivities
    {
        get => showActivities;
        set
        {
            if (showActivities != value)
            {
                showActivities = value;
                OnPropertyChanged(nameof(ShowActivities));
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
