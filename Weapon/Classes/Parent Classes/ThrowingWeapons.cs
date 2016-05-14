using System;

namespace Weapon.Classes.Parent_Classes
{
    [Serializable]
    internal abstract class ThrowingWeapons: Weapon
    {
        public int Range { get; set; }
    }
}
