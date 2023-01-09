using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsDude.WPF.Models;
public class Game
{
    public Game(string gameName, string? customName, IEnumerable<Profile> profiles)
    {
        GameName = gameName;
        CustomName = customName;
        Profiles = new(profiles);
    }


    public string GameName { get; }
    public string? CustomName { get; }
    public ObservableCollection<Profile> Profiles { get; }
}
