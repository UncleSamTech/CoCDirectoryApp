using System.Collections.ObjectModel;

namespace CoCDirectoryApp.Views;

public partial class StateListPage : ContentPage
{
	public StateListPage()
	{
		InitializeComponent();
	}
    public ObservableCollection<StateInfo> States { get; set; } = new ObservableCollection<StateInfo>
{
    new StateInfo { StateName = "Abia", StateImage = "abia_capital.jpg" },
    new StateInfo { StateName = "Adamawa", StateImage = "adamawa_capital.jpg" },
    new StateInfo { StateName = "Akwa Ibom", StateImage = "akwa_ibom_capital.jpg" },
    new StateInfo { StateName = "Anambra", StateImage = "anambra_capital.jpg" },
    new StateInfo { StateName = "Bauchi", StateImage = "bauchi_capital.jpg" },
    new StateInfo { StateName = "Bayelsa", StateImage = "bayelsa_capital.jpg" },
    new StateInfo { StateName = "Benue", StateImage = "benue_capital.jpg" },
    new StateInfo { StateName = "Borno", StateImage = "borno_capital.jpg" },
    new StateInfo { StateName = "Cross River", StateImage = "cross_river_capital.jpg" },
    new StateInfo { StateName = "Delta", StateImage = "delta_capital.jpg" },
    new StateInfo { StateName = "Ebonyi", StateImage = "ebonyi_capital.jpg" },
    new StateInfo { StateName = "Edo", StateImage = "edo_capital.jpg" },
    new StateInfo { StateName = "Ekiti", StateImage = "ekiti_capital.jpg" },
    new StateInfo { StateName = "Enugu", StateImage = "enugu_capital.jpg" },
    new StateInfo { StateName = "Gombe", StateImage = "gombe_capital.jpg" },
    new StateInfo { StateName = "Imo", StateImage = "imo_capital.jpeg" },
    new StateInfo { StateName = "Jigawa", StateImage = "jigawa_capital.jpg" },
    new StateInfo { StateName = "Kaduna", StateImage = "kaduna_capital.jpg" },
    new StateInfo { StateName = "Kano", StateImage = "kano_capital.jpg" },
    new StateInfo { StateName = "Katsina", StateImage = "katsina_capital.jpg" },
    new StateInfo { StateName = "Kebbi", StateImage = "kebbi_capital.jpg" },
    new StateInfo { StateName = "Kogi", StateImage = "kogi_capital.jpg" },
    new StateInfo { StateName = "Kwara", StateImage = "kwara_capital.jpg" },
    new StateInfo { StateName = "Lagos", StateImage = "lagos_capital.jpg" },
    new StateInfo { StateName = "Nasarawa", StateImage = "nasarawa_capital.jpg" },
    new StateInfo { StateName = "Niger", StateImage = "niger_capital.jpg" },
    new StateInfo { StateName = "Ogun", StateImage = "ogun_capital.jpg" },
    new StateInfo { StateName = "Ondo", StateImage = "ondo_capital.jpg" },
    new StateInfo { StateName = "Osun", StateImage = "osun_capital.jpg" },
    new StateInfo { StateName = "Oyo", StateImage = "oyo_capital.jpg" },
    new StateInfo { StateName = "Plateau", StateImage = "plateau_capital.jpg" },
    new StateInfo { StateName = "Rivers", StateImage = "rivers_capital.jpg" },
    new StateInfo { StateName = "Sokoto", StateImage = "sokoto_capital.jpg" },
    new StateInfo { StateName = "Taraba", StateImage = "taraba_capital.jpg" },
    new StateInfo { StateName = "Yobe", StateImage = "yobe_capital.jpg" },
    new StateInfo { StateName = "Zamfara", StateImage = "zamfara_capital.jpg" },
    new StateInfo { StateName = "Federal Capital Territory", StateImage = "fct_capital.jpg" }
};

    private async void OnStateSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection?.FirstOrDefault() is StateInfo selectedState && selectedState.StateName != null)
        {
            string stateName = selectedState.StateName;

            // Clear the selection so user can re-select the same item
            ((CollectionView)sender).SelectedItem = null;

            // Navigate to ChurchListPage with query parameter
            await Shell.Current.GoToAsync($"ChurchListPage?state={Uri.EscapeDataString(stateName)}");
        }
    }




}