using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapon.Classes.Children_Classes;
using Weapon.Classes.Parent_Classes;

namespace Weapon.Classes
{
    internal class CreatorWeapons
    {
        private Dagger Create(Dagger weapon, string manufactrured, string owner, int weight, string material, int length, string form, string engraving)
        {
            return new Dagger(manufactrured, owner, weight, material, length, form, engraving);
        }

        private Sword Create(Sword weapon, string manufactrured, string owner, int weight, string material, int length,
            string form, string type)
        {
            return new Sword(manufactrured, owner, weight, material, length, form, type);
        }

        public EdgedWeapons CreateWeapon(EdgedWeapons weapon, string manufactrured, string owner, int weight, string material, int length, string diffrentOption)
        {
            dynamic weaponToCreate = weapon;
            return Create(weaponToCreate, manufactrured, owner, weight, material, length, diffrentOption);
        }

        private Pistol Create(Pistol weapon, string manufactrured, string owner, int weight, string material, float caliber, string type)
        {
            return new Pistol(manufactrured, owner, weight, material, caliber, type);
        }

        private Rifle Create(Rifle weapon, string manufactrured, string owner, int weight, string material, float caliber, string engraving)
        {
            return new Rifle(manufactrured, owner, weight, material, caliber, engraving);
        }

        public Firearm CreateWeapon(Firearm weapon, string manufactrured, string owner, int weight, string material, int length, string diffrentOption)
        {
            dynamic weaponToCreate = weapon;
            return Create(weaponToCreate, manufactrured, owner, weight, material, length, diffrentOption);
        }


        public ThrowingWeapons CreateWeapon(ThrowingWeapons weapon, string manufactrured, string owner, int weight, string material, int length, string diffrentOption)
        {
            dynamic weaponToCreate = weapon;
            return Create(weaponToCreate, manufactrured, owner, weight, material, length, diffrentOption);
        }
    }
}
