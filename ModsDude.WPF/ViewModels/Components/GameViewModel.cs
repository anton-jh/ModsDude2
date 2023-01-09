using ModsDude.WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsDude.WPF.ViewModels.Components;
public class GameViewModel
{
    public GameViewModel(Game game)
    {
        GameName = game.GameName;
        CustomName = game.CustomName;
        Profiles = new(game.Profiles.Select(profile => new ProfileViewModel(profile)));
        SelectedProfile = Profiles.First();
    }


    public string GameName { get; }
    public string? CustomName { get; }
    public string DisplayName => CustomName is null ? GameName : $"{CustomName} ({GameName})";
    public ObservableCollection<ProfileViewModel> Profiles { get; }
    public ProfileViewModel SelectedProfile { get; set; }
}
