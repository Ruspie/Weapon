using Weapon.Classes.Children_Classes;
using Weapon.Classes.Parent_Classes;

namespace Weapon.Classes
{
    internal class CreatorWeapons
    {

        /*-------------------------------------------------------------Create Edged Weapons ----------------------------------------------------*/
                                             
        private Dagger Create(Dagger weapon, string manufactured, string owner, int weight, string material, int length, string form, string type)
        {
            return new Dagger(manufactured, owner, weight, material, length, form, type);
        }

        private Sword Create(Sword weapon, string manufactured, string owner, int weight, string material, int length, string form, string type)
        {
            return new Sword(manufactured, owner, weight, material, length, form, type);
        }

        public EdgedWeapons CreateWeapon(EdgedWeapons weapon, string manufactured, string owner, int weight, string material, int length, string form, string diffrentOption)
        {
            dynamic weaponToCreate = weapon;
            return Create(weaponToCreate, manufactured, owner, weight, material, length, form, diffrentOption);
        }

        /*-------------------------------------------------------------Create Firearm Weapons ----------------------------------------------------*/

        private Pistol Create(Pistol weapon, string manufactured, string owner, int weight, string material, float caliber, string type)
        {
            return new Pistol(manufactured, owner, weight, material, caliber, type);
        }

        private Rifle Create(Rifle weapon, string manufactured, string owner, int weight, string material, float caliber, string engraving)
        {
            return new Rifle(manufactured, owner, weight, material, caliber, engraving);
        }

        public Firearm CreateWeapon(Firearm weapon, string manufactured, string owner, int weight, string material, float caliber, string diffrentOption)
        {
            dynamic weaponToCreate = weapon;
            return Create(weaponToCreate, manufactured, owner, weight, material, caliber, diffrentOption);
        }

        /*-------------------------------------------------------------Create Throwing Weapons ----------------------------------------------------*/

        private Bow Create(Bow weapon, string manufactured, string owner, int weight, string material, int range, string type)
        {
            return new Bow(manufactured, owner, weight, material, range, type);
        }

        private Grenade Create(Grenade weapon, string manufactured, string owner, int weight, string material, int range, string type)
        {
            return new Grenade(manufactured, owner, weight, material, range, type);
        }

        public ThrowingWeapons CreateWeapon(ThrowingWeapons weapon, string manufactured, string owner, int weight, string material, int range, string diffrentOption)
        {
            dynamic weaponToCreate = weapon;
            return Create(weaponToCreate, manufactured, owner, weight, material, range, diffrentOption);
        }
    }
}
