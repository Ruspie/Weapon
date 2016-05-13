using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weapon.Classes;
using Weapon.Classes.Children_Classes;

namespace Weapon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreatorWeapons creatorWeapons = new CreatorWeapons();
            List<Classes.Parent_Classes.Weapon> listWeapons = new List<Classes.Parent_Classes.Weapon>();
            listWeapons.Add(creatorWeapons.CreateWeapon(new Sword(), "lol", "kek", 10, "stale", 10, "duble hand")); 
            listWeapons.Add(creatorWeapons.CreateWeapon(new Dagger(), "lol", "kek", 10, "stale", 10, "best boy"));
        }
    }
}
