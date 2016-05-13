using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon.Classes.Parent_Classes
{
    [Serializable]
    internal abstract class Firearm: Weapon
    {
        public float Caliber { get; set; }
    }
}
