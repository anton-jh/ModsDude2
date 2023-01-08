using ModsDude.WPF.ViewModels.Components;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsDude.WPF.ViewModels
{
    class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            SelectedTab = new("Farming Simulator 22");
            Tabs = new()
            {
                SelectedTab,
                new("BeamNG.Drive", "BeamMP Client"),
                new("BeamNG.Drive", "BeamMP Server")
            };
        }


        public MainTabContentViewModel SelectedTab { get; set; }
        public ObservableCollection<MainTabContentViewModel> Tabs { get; set; }
    }
}
