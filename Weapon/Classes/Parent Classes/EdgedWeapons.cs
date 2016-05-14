using System;

namespace Weapon.Classes.Parent_Classes
{
    [Serializable]
    internal abstract class EdgedWeapons: Weapon
    {
        public int Length { get; set; }
        public string Form { get; set; }
    }
}
