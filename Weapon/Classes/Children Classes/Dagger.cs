using System;

namespace Weapon.Classes.Children_Classes
{
    [Serializable]
    internal class Dagger: Parent_Classes.EdgedWeapons
    {
        public string Engraving { get; set; }
        public Dagger(string manufactured, string owner, int weight, string material, int length, string form, string engraving)
        {
            this.Manufacturer = manufactured;
            this.Owner = owner;
            this.Weight = weight;
            this.Material = material;
            this.Length = length;
            this.Form = form;
            this.Engraving = engraving;
        }

        public Dagger() { }
    }
}
