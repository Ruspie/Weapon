using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
        private LogWeapons logWeapons = new LogWeapons();
        private Classes.Parent_Classes.Weapon _weapon;
        public Form1()
        {
            InitializeComponent();
        }

       /* private void button2_Click(object sender, EventArgs e)
        {
            BinaryFormatter serialization = new BinaryFormatter();

            using (FileStream fs = new FileStream("log.bin", FileMode.OpenOrCreate))
            {
                serialization.Serialize(fs, logWeapons);
                MessageBox.Show("Serialization Complete");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BinaryFormatter serialization = new BinaryFormatter();

            using (FileStream fs = new FileStream("log.bin", FileMode.Open))
            {
                logWeapons = (List<Classes.Parent_Classes.Weapon>)serialization.Deserialize(fs);
            }
        }*/

        private void ClearComboBox(ComboBox comboBox)
        {
            while (comboBox.Items.Count > 0)
            {
                comboBox.Items.RemoveAt(0);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxWeapon.Items.Add(typeof (Bow));
            comboBoxWeapon.Items.Add(typeof (Dagger));
            comboBoxWeapon.Items.Add(typeof (Grenade));
            comboBoxWeapon.Items.Add(typeof (Pistol));
            comboBoxWeapon.Items.Add(typeof (Rifle));
            comboBoxWeapon.Items.Add(typeof (Sword));
            comboBoxWeapon.SelectedIndex = 0;
        }

        private Classes.Parent_Classes.Weapon CreateWeapon()
        {
            CreatorWeapons creatorWeapons = new CreatorWeapons();
            switch (comboBoxWeapon.SelectedIndex)
            {
                case 0:
                    _weapon = creatorWeapons.CreateWeapon(new Bow(), "", "", 0, "", 0, "");
                    break;
                case 1:
                    _weapon = creatorWeapons.CreateWeapon(new Dagger(), "", "", 0, "", 0, "", "");
                    break;
                case 2:
                    _weapon = creatorWeapons.CreateWeapon(new Grenade(), "", "", 0, "", 0, "");
                    break;
                case 3:
                    _weapon = creatorWeapons.CreateWeapon(new Pistol(), "", "", 0, "", 0, "");
                    break;
                case 4:
                    _weapon = creatorWeapons.CreateWeapon(new Rifle(), "", "", 0, "", 0, "");
                    break;
                case 5:
                    _weapon = creatorWeapons.CreateWeapon(new Sword(), "", "", 0, "", 0, "", "");
                    break;
                default:
                    _weapon = creatorWeapons.CreateWeapon(new Bow(), "", "", 0, "", 0, "");
                    break;
            }
            return _weapon;
        }

       private void comboBoxWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearComboBox(comboBoxSetProperties);
            _weapon = CreateWeapon();
            foreach (PropertyInfo key in _weapon.GetType().GetProperties())
            {
                comboBoxSetProperties.Items.Add(key);
            }
            comboBoxSetProperties.SelectedIndex = 0;
        }

        private void button_Click(object sender, EventArgs e)
        {
            logWeapons.ListWeapons.Add(_weapon);
            comboBoxListWeapon.Items.Add(_weapon);
            comboBoxListWeapon.SelectedIndex = 1;
            comboBoxWeapon.SelectedIndex = 0;
        }

        private string GetNameProperty()
        {
            string propertiesName = comboBoxSetProperties.Text;
            int ind = propertiesName.LastIndexOf(" ", StringComparison.Ordinal);
            propertiesName = propertiesName.Substring(ind + 1);
            return propertiesName;
        }

        private void textBoxSetValue_Leave(object sender, EventArgs e)
        {
            try
            {
                if (_weapon.GetType().GetProperty(GetNameProperty()).PropertyType == typeof(float))
                {
                    _weapon.GetType().GetProperty(GetNameProperty()).SetValue(_weapon, Convert.ToSingle(textBoxSetValue.Text));
                }
                else
                {
                    if (_weapon.GetType().GetProperty(GetNameProperty()).PropertyType == typeof(int))
                    {
                        _weapon.GetType().GetProperty(GetNameProperty()).SetValue(_weapon, Convert.ToInt32(textBoxSetValue.Text));
                    }
                    else
                    {
                        _weapon.GetType().GetProperty(GetNameProperty()).SetValue(_weapon, textBoxSetValue.Text);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Failed to write data");
            }
        }

        private void comboBoxSetProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSetValue.Text = Convert.ToString(_weapon.GetType().GetProperty(GetNameProperty()).GetValue(_weapon));
        }
    }
}
