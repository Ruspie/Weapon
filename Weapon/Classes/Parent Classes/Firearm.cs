using System;

namespace Weapon.Classes.Parent_Classes
{
    [Serializable]
    internal abstract class Firearm: Weapon
    {
        public float Caliber { get; set; }
    }
}
