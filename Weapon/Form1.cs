using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Weapon.Classes;
using Weapon.Classes.Children_Classes;

namespace Weapon
{
    public partial class Form1 : Form
    {
        private readonly LogWeapons _logWeapons = new LogWeapons();
        private Classes.Parent_Classes.Weapon _weapon;
        public Form1()
        {
            InitializeComponent();
        }

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
            Classes.Parent_Classes.Weapon weapon;
            switch (comboBoxWeapon.SelectedIndex)
            {
                case 0:
                    weapon = creatorWeapons.CreateWeapon(new Bow(), "", "", 0, "", 0, "");
                    break;
                case 1:
                    weapon = creatorWeapons.CreateWeapon(new Dagger(), "", "", 0, "", 0, "", "");
                    break;
                case 2:
                    weapon = creatorWeapons.CreateWeapon(new Grenade(), "", "", 0, "", 0, "");
                    break;
                case 3:
                    weapon = creatorWeapons.CreateWeapon(new Pistol(), "", "", 0, "", 0, "");
                    break;
                case 4:
                    weapon = creatorWeapons.CreateWeapon(new Rifle(), "", "", 0, "", 0, "");
                    break;
                case 5:
                    weapon = creatorWeapons.CreateWeapon(new Sword(), "", "", 0, "", 0, "", "");
                    break;
                default:
                    weapon = creatorWeapons.CreateWeapon(new Bow(), "", "", 0, "", 0, "");
                    break;
            }
            return weapon;
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
            _logWeapons.ListWeapons.Add(_weapon);
            comboBoxListWeapon.Items.Add(_weapon);
            comboBoxListWeapon.SelectedIndex = 0;
            _weapon = CreateWeapon();
            textBoxSetValue.Clear();
        }

        private string GetNameProperty(ComboBox comboBox)
        {
            string propertiesName = comboBox.Text;
            int ind = propertiesName.LastIndexOf(" ", StringComparison.Ordinal);
            propertiesName = propertiesName.Substring(ind + 1);
            return propertiesName;
        }

        private void textBoxSetValue_Leave(object sender, EventArgs e)
        {
            try
            {
                if (_weapon.GetType().GetProperty(GetNameProperty(comboBoxSetProperties)).PropertyType == typeof(float))
                {
                    _weapon.GetType().GetProperty(GetNameProperty(comboBoxSetProperties)).SetValue(_weapon, Convert.ToSingle(textBoxSetValue.Text));
                }
                else
                {
                    if (_weapon.GetType().GetProperty(GetNameProperty(comboBoxSetProperties)).PropertyType == typeof(int))
                    {
                        _weapon.GetType().GetProperty(GetNameProperty(comboBoxSetProperties)).SetValue(_weapon, Convert.ToInt32(textBoxSetValue.Text));
                    }
                    else
                    {
                        _weapon.GetType().GetProperty(GetNameProperty(comboBoxSetProperties)).SetValue(_weapon, textBoxSetValue.Text);
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
            textBoxSetValue.Text = Convert.ToString(_weapon.GetType().GetProperty(GetNameProperty(comboBoxSetProperties)).GetValue(_weapon));
        }

        private void comboBoxListWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearComboBox(comboBoxSelectProperty);
            foreach (PropertyInfo key in _logWeapons.ListWeapons[comboBoxListWeapon.SelectedIndex].GetType().GetProperties())
            {
                comboBoxSelectProperty.Items.Add(key);
            }
            comboBoxSelectProperty.SelectedIndex = 0;
        }

        private void comboBoxSelectProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxGetValue.Text = Convert.ToString(
                _logWeapons.ListWeapons[comboBoxListWeapon.SelectedIndex].GetType()
                    .GetProperty(GetNameProperty(comboBoxSelectProperty))
                    .GetValue(_logWeapons.ListWeapons[comboBoxListWeapon.SelectedIndex]));
        }

        private void buttonSerialize_Click(object sender, EventArgs e)
        {
            BinaryFormatter serialization = new BinaryFormatter();

            using (FileStream fs = new FileStream("log.bin", FileMode.OpenOrCreate))
            {
                serialization.Serialize(fs, _logWeapons.ListWeapons);
                MessageBox.Show("Serialization Complete");
            }
        }

        private void CreateListComboBox(ComboBox comboBox)
        {
            foreach (var weapon in _logWeapons.ListWeapons)
            {
                //comboBox.Items.Add(weapon.GetType().GetProperties());
                comboBox.Items.Add((weapon).GetType());
            }
            comboBox.SelectedIndex = 0;
        }

        private void buttonDeserialize_Click(object sender, EventArgs e)
        {
            BinaryFormatter serialization = new BinaryFormatter();

            using (FileStream fs = new FileStream("log.bin", FileMode.Open))
            {
                _logWeapons.ListWeapons = (List<Classes.Parent_Classes.Weapon>)serialization.Deserialize(fs);
            }
            ClearComboBox(comboBoxListWeapon);
            CreateListComboBox(comboBoxListWeapon);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    _logWeapons.ListWeapons[comboBoxListWeapon.SelectedIndex].GetType()
                        .GetProperty(GetNameProperty(comboBoxSelectProperty))
                        .PropertyType == typeof (float))
                {
                    _logWeapons.ListWeapons[comboBoxListWeapon.SelectedIndex].GetType()
                        .GetProperty(GetNameProperty(comboBoxSelectProperty))
                        .SetValue(_logWeapons.ListWeapons[comboBoxListWeapon.SelectedIndex],
                            Convert.ToSingle(textBoxGetValue.Text));
                }
                else
                {
                    if (
                        _logWeapons.ListWeapons[comboBoxListWeapon.SelectedIndex].GetType()
                            .GetProperty(GetNameProperty(comboBoxSelectProperty))
                            .PropertyType == typeof (int))
                    {
                        _logWeapons.ListWeapons[comboBoxListWeapon.SelectedIndex].GetType()
                            .GetProperty(GetNameProperty(comboBoxSelectProperty))
                            .SetValue(_logWeapons.ListWeapons[comboBoxListWeapon.SelectedIndex],
                                Convert.ToInt32(textBoxGetValue.Text));
                    }
                    else
                    {
                        _logWeapons.ListWeapons[comboBoxListWeapon.SelectedIndex].GetType()
                            .GetProperty(GetNameProperty(comboBoxSelectProperty))
                            .SetValue(_logWeapons.ListWeapons[comboBoxListWeapon.SelectedIndex], textBoxGetValue.Text);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Failed to write data");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            _logWeapons.ListWeapons.RemoveAt(comboBoxListWeapon.SelectedIndex);
            comboBoxListWeapon.Items.RemoveAt(comboBoxListWeapon.SelectedIndex);            
        }
    }
}
