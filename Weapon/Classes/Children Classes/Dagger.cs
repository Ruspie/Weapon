using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon.Classes.Children_Classes
{
    class Dagger: Parent_Classes.Weapon
    {
        public Dagger(string manufactured, string owner, int weight, string material)
            : base(manufactured, owner, weight, material)
        {
        }
    }
}
