using System;

namespace Weapon.Classes.Children_Classes
{
    [Serializable]
    internal class Rifle: Parent_Classes.Firearm
    {
        public string Engraving { get; set; }
        public Rifle(string manufactured, string owner, int weight, string material, float caliber, string engraving)
        {
            this.Manufacturer = manufactured;
            this.Owner = owner;
            this.Weight = weight;
            this.Material = material;
            this.Caliber = caliber;
            this.Engraving = engraving;
        }

        public Rifle() { }
    }
}
