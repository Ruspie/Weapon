using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weapon.Classes;
using Weapon.Classes.Children_Classes;
using Weapon.Classes.Parent_Classes;

namespace Weapon
{
    public partial class Form1 : Form
    {
        public List<Classes.Parent_Classes.Weapon> listWeapons = new List<Classes.Parent_Classes.Weapon>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreatorWeapons creatorWeapons = new CreatorWeapons();
            listWeapons.Add(creatorWeapons.CreateWeapon(new Sword(), "lol", "kek", 10, "stale", 10, "default", "duble hand"));
            listWeapons[0].Name = "Sword";
            listWeapons.Add(creatorWeapons.CreateWeapon(new Dagger(), "lol", "kek", 10, "stale", 10, "exotic", "best boy"));
            listWeapons[1].Name = "Dagger";
            listWeapons.Add(creatorWeapons.CreateWeapon(new Bow(), "lol", "kek", 10, "tree", 10, "long"));
            listWeapons[2].Name = "Bow";
            listWeapons.Add(creatorWeapons.CreateWeapon(new Grenade(), "lol", "kek", 10, "tree", 10, "flash"));
            listWeapons[3].Name = "Grenade";
            listWeapons.Add(creatorWeapons.CreateWeapon(new Pistol(), "lol", "kek", 10, "tree", 10, "auto"));
            listWeapons[4].Name = "Pistol";
            listWeapons.Add(creatorWeapons.CreateWeapon(new Rifle(), "lol", "kek", 10, "tree", 10, "carabin"));
            listWeapons[5].Name = "Rifle";
        }

       /* private void Print()
        {
            textBox1.Clear();
            foreach (var weapon in listWeapons)
            {
                textBox1.Text += weapon.Name + "\t";
                textBox1.Text += weapon.Manufacturer + "\t";
                textBox1.Text += weapon.Owner + "\t";
                textBox1.Text += weapon.Weight + "\t";
                textBox1.Text += weapon.Material + "\r\n";
            }
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            BinaryFormatter serialization = new BinaryFormatter();

            using (FileStream fs = new FileStream("log.bin", FileMode.OpenOrCreate))
            {
                serialization.Serialize(fs, listWeapons);
                MessageBox.Show("Serialization Complete");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BinaryFormatter serialization = new BinaryFormatter();

            using (FileStream fs = new FileStream("log.bin", FileMode.Open))
            {
                listWeapons = (List<Classes.Parent_Classes.Weapon>)serialization.Deserialize(fs);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ClearComboBox(ComboBox comboBox)
        {
            while (comboBox.Items.Count > 0)
            {
                comboBox.Items.RemoveAt(0);
            }
        }

        private void comboBoxTypeWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTypeWeapon.SelectedIndex)
            {
                case 0:
                    ClearComboBox(comboBoxWeapon);
                    comboBoxWeapon.Items.Add("Dagger");
                    comboBoxWeapon.Items.Add("Sword");
                    break;
                case 1:
                    ClearComboBox(comboBoxWeapon);
                    comboBoxWeapon.Items.Add("Pistol");
                    comboBoxWeapon.Items.Add("Rifle");
                    break;
                case 2:
                    ClearComboBox(comboBoxWeapon);
                    comboBoxWeapon.Items.Add("Bow");
                    comboBoxWeapon.Items.Add("Grenade");
                    break;
                default:
                    ClearComboBox(comboBoxWeapon);
                    comboBoxWeapon.Items.Add("Dagger");
                    comboBoxWeapon.Items.Add("Sword");
                    break;
            }
            comboBoxWeapon.SelectedIndex = 0;
        }

        private void comboBoxWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearComboBox(comboBoxSetProperties);
            foreach (var key in new Bow().GetType().GetProperties())
            {
                comboBoxSetProperties.Items.Add(key);
            }
        }
    }
}
