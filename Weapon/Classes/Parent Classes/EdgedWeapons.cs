using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon.Classes.Parent_Classes
{
    internal abstract class EdgedWeapons: Weapon
    {
        public int Length { get; set; }
        public string Form { get; set; }
    }
}
