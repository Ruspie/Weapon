using System;

namespace Weapon.Classes.Children_Classes
{
    [Serializable]
    internal class Grenade : Parent_Classes.ThrowingWeapons
    {
        public string Type { get; set; }

        public Grenade(string manufactured, string owner, int weight, string material, int range, string type)
        {
            this.Manufacturer = manufactured;
            this.Owner = owner;
            this.Weight = weight;
            this.Material = material;
            this.Range = range;
            this.Type = type;
        }

        public Grenade() { }
    }
}