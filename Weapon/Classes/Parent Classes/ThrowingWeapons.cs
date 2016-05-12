using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon.Classes.Parent_Classes
{
    class ThrowingWeapons: Weapon
    {
        private int Range { get; set; }

        public ThrowingWeapons(string manufactured, string owner, int weight, string material, int range)
            : base(manufactured, owner, weight, material)
        {
            this.Range = range;
        }
    }
}
