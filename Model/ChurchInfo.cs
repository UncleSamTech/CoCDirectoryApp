using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CoCDirectoryApp.Models
{
    public class ChurchInfo : INotifyPropertyChanged
    {
        private string name = string.Empty;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private string address = string.Empty;
        public string Address
        {
            get => address;
            set => SetProperty(ref address, value);
        }

        private string phone = string.Empty;
        public string Phone
        {
            get => phone;
            set => SetProperty(ref phone, value);
        }

        private List<ActivityInfo> activities = new();
        public List<ActivityInfo> Activities
        {
            get => activities;
            set
            {
                if (SetProperty(ref activities, value))
                    OnPropertyChanged(nameof(ActivitiesDisplay));
            }
        }

        public string ActivitiesDisplay => Activities != null ? string.Join("\n", Activities) : string.Empty;

        private string buildingImage = string.Empty;
        public string BuildingImage
        {
            get => buildingImage;
            set => SetProperty(ref buildingImage, value);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T backingField, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(backingField, value))
                return false;

            backingField = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
