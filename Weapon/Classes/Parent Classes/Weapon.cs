using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon.Classes.Parent_Classes
{
    abstract class Weapon
    {
        public string Manufacturer { get; set; }
        public string Owner { get; set; }
        public int Weight { get; set; }
        public string Material { get; set; }
    }
}
