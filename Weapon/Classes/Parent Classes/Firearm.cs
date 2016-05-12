using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon.Classes.Parent_Classes
{
    class Firearm: Weapon
    {
        public Firearm(string manufactured, string owner, int weight, string material)
            : base(manufactured, owner, weight, material)
        {
        }
    }
}
