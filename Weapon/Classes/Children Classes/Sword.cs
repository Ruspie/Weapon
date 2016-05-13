using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon.Classes.Children_Classes
{
    internal class Sword: Parent_Classes.EdgedWeapons
    {
        public string Type { get; set; }
        public Sword(string manufactured, string owner, int weight, string material, int length, string form, string type)
        {
            this.Manufacturer = manufactured;
            this.Owner = owner;
            this.Weight = weight;
            this.Material = material;
            this.Length = length;
            this.Form = form;
            this.Type = type;
        }

        public Sword() { }
    }
}
