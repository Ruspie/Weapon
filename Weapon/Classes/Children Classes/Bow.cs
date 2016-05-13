using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon.Classes.Children_Classes
{
    [Serializable]
    internal class Bow: Parent_Classes.ThrowingWeapons
    {
        public string Type { get; set; }
        public Bow(string manufactured, string owner, int weight, string material, int range, string type)

        {
            this.Manufacturer = manufactured;
            this.Owner = owner;
            this.Weight = weight;
            this.Material = material;
            this.Range = range;
            this.Type = type;
        }

        public Bow() { }
    }
}
