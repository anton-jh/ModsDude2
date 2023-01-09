using ModsDude.WPF.Models;
using ModsDude.WPF.ViewModels.Components;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsDude.WPF.ViewModels
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            Game selectedGame = new("Farming Simulator 22", null, new Profile[]
            {
                new("Elmcreek 5"),
                new("Calm lands 2022Q1")
            });

            SelectedGame = new(selectedGame);

            Games = new()
            {
                SelectedGame,
                new(new("BeamNG.Drive", "Client", new Profile[]
                {
                    new("Everything"),
                    new("Old school")
                })),
                new(new("BeamNG.Drive", "Server", new Profile[]
                {
                    new("Everything"),
                    new("Old school")
                }))
            };
        }


        public ObservableCollection<GameViewModel> Games { get; }
        public GameViewModel SelectedGame { get; set; }
    }
}
