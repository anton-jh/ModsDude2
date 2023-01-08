using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsDude.WPF.ViewModels.Components
{
    class MainTabContentViewModel
    {
        public MainTabContentViewModel(string gameName, string? customName = null)
        {
            SelectedProfile = new("Profile 1");
            Profiles = new()
            {
                SelectedProfile,
                new("Profile 2"),
                new("Profile 3")
            };
            GameName = gameName;
            CustomName = customName;
        }


        public ObservableCollection<ProfileViewModel> Profiles { get; set; }
        public ProfileViewModel SelectedProfile { get; set; }
        
        public string GameName { get; }
        public string? CustomName { get; }

        public string DisplayString => CustomName is null ? GameName : $"{CustomName} ({GameName})";
    }
}
