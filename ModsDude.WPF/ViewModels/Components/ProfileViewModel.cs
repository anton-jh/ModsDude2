using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsDude.WPF.ViewModels.Components
{
    class ProfileViewModel
    {
        public ProfileViewModel(string name)
        {
            Name = name;
        }


        public string Name { get; set; }
    }
}
