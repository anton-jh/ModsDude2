using ModsDude.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsDude.WPF.ViewModels.Components
{
    public class ProfileViewModel
    {
        public ProfileViewModel(Profile profile)
        {
            Name = profile.Name;
        }

        public string Name { get; }
    }
}
