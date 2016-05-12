using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon.Classes.Parent_Classes
{
    public abstract class Weapon
    {
        public string Manufacturer { get; set; }
        public string Owner { get; set; }
        public int Weight { get; set; }
        public string Material { get; set; }

        public Weapon(string manufacturer, string owner, int weight, string material)
        {
            this.Manufacturer = manufacturer;
            this.Owner = owner;
            this.Weight = weight;
            this.Material = material;
        }
    }
}
