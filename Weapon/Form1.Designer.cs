namespace Weapon
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.groupBoxValueSet = new System.Windows.Forms.GroupBox();
            this.textBoxSetValue = new System.Windows.Forms.TextBox();
            this.groupBoxSelectedPropertySet = new System.Windows.Forms.GroupBox();
            this.comboBoxSetProperties = new System.Windows.Forms.ComboBox();
            this.groupBoxSelectedWeaponSet = new System.Windows.Forms.GroupBox();
            this.comboBoxWeapon = new System.Windows.Forms.ComboBox();
            this.groupBoxListWeapons = new System.Windows.Forms.GroupBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.textBoxGetValue = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxListWeapon = new System.Windows.Forms.ComboBox();
            this.groupBoxSelectWeaponInList = new System.Windows.Forms.GroupBox();
            this.groupBoxSelectProperty = new System.Windows.Forms.GroupBox();
            this.comboBoxSelectProperty = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSerialize = new System.Windows.Forms.Button();
            this.buttonDeserialize = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxValueSet.SuspendLayout();
            this.groupBoxSelectedPropertySet.SuspendLayout();
            this.groupBoxSelectedWeaponSet.SuspendLayout();
            this.groupBoxListWeapons.SuspendLayout();
            this.groupBoxSelectWeaponInList.SuspendLayout();
            this.groupBoxSelectProperty.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCreate);
            this.groupBox1.Controls.Add(this.groupBoxValueSet);
            this.groupBox1.Controls.Add(this.groupBoxSelectedPropertySet);
            this.groupBox1.Controls.Add(this.groupBoxSelectedWeaponSet);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Weapon :";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(198, 191);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 7;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.button_Click);
            // 
            // groupBoxValueSet
            // 
            this.groupBoxValueSet.Controls.Add(this.textBoxSetValue);
            this.groupBoxValueSet.Location = new System.Drawing.Point(6, 134);
            this.groupBoxValueSet.Name = "groupBoxValueSet";
            this.groupBoxValueSet.Size = new System.Drawing.Size(457, 51);
            this.groupBoxValueSet.TabIndex = 6;
            this.groupBoxValueSet.TabStop = false;
            this.groupBoxValueSet.Text = "Set Value :";
            // 
            // textBoxSetValue
            // 
            this.textBoxSetValue.Location = new System.Drawing.Point(6, 19);
            this.textBoxSetValue.Name = "textBoxSetValue";
            this.textBoxSetValue.Size = new System.Drawing.Size(441, 20);
            this.textBoxSetValue.TabIndex = 3;
            this.textBoxSetValue.Leave += new System.EventHandler(this.textBoxSetValue_Leave);
            // 
            // groupBoxSelectedPropertySet
            // 
            this.groupBoxSelectedPropertySet.Controls.Add(this.comboBoxSetProperties);
            this.groupBoxSelectedPropertySet.Location = new System.Drawing.Point(6, 77);
            this.groupBoxSelectedPropertySet.Name = "groupBoxSelectedPropertySet";
            this.groupBoxSelectedPropertySet.Size = new System.Drawing.Size(457, 51);
            this.groupBoxSelectedPropertySet.TabIndex = 5;
            this.groupBoxSelectedPropertySet.TabStop = false;
            this.groupBoxSelectedPropertySet.Text = "Select Property :";
            // 
            // comboBoxSetProperties
            // 
            this.comboBoxSetProperties.FormattingEnabled = true;
            this.comboBoxSetProperties.Location = new System.Drawing.Point(6, 19);
            this.comboBoxSetProperties.Name = "comboBoxSetProperties";
            this.comboBoxSetProperties.Size = new System.Drawing.Size(441, 21);
            this.comboBoxSetProperties.TabIndex = 2;
            this.comboBoxSetProperties.SelectedIndexChanged += new System.EventHandler(this.comboBoxSetProperties_SelectedIndexChanged);
            // 
            // groupBoxSelectedWeaponSet
            // 
            this.groupBoxSelectedWeaponSet.Controls.Add(this.comboBoxWeapon);
            this.groupBoxSelectedWeaponSet.Location = new System.Drawing.Point(6, 19);
            this.groupBoxSelectedWeaponSet.Name = "groupBoxSelectedWeaponSet";
            this.groupBoxSelectedWeaponSet.Size = new System.Drawing.Size(457, 52);
            this.groupBoxSelectedWeaponSet.TabIndex = 4;
            this.groupBoxSelectedWeaponSet.TabStop = false;
            this.groupBoxSelectedWeaponSet.Text = "Select Weapon :";
            // 
            // comboBoxWeapon
            // 
            this.comboBoxWeapon.FormattingEnabled = true;
            this.comboBoxWeapon.Location = new System.Drawing.Point(6, 19);
            this.comboBoxWeapon.Name = "comboBoxWeapon";
            this.comboBoxWeapon.Size = new System.Drawing.Size(441, 21);
            this.comboBoxWeapon.TabIndex = 1;
            this.comboBoxWeapon.SelectedIndexChanged += new System.EventHandler(this.comboBoxWeapon_SelectedIndexChanged);
            // 
            // groupBoxListWeapons
            // 
            this.groupBoxListWeapons.Controls.Add(this.groupBox3);
            this.groupBoxListWeapons.Controls.Add(this.groupBoxSelectProperty);
            this.groupBoxListWeapons.Controls.Add(this.groupBoxSelectWeaponInList);
            this.groupBoxListWeapons.Controls.Add(this.buttonChange);
            this.groupBoxListWeapons.Controls.Add(this.buttonDelete);
            this.groupBoxListWeapons.Location = new System.Drawing.Point(12, 238);
            this.groupBoxListWeapons.Name = "groupBoxListWeapons";
            this.groupBoxListWeapons.Size = new System.Drawing.Size(474, 223);
            this.groupBoxListWeapons.TabIndex = 1;
            this.groupBoxListWeapons.TabStop = false;
            this.groupBoxListWeapons.Text = "List Weapons :";
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(328, 192);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 4;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBoxGetValue
            // 
            this.textBoxGetValue.Location = new System.Drawing.Point(6, 19);
            this.textBoxGetValue.Name = "textBoxGetValue";
            this.textBoxGetValue.Size = new System.Drawing.Size(441, 20);
            this.textBoxGetValue.TabIndex = 3;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(48, 192);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxListWeapon
            // 
            this.comboBoxListWeapon.FormattingEnabled = true;
            this.comboBoxListWeapon.Location = new System.Drawing.Point(6, 19);
            this.comboBoxListWeapon.Name = "comboBoxListWeapon";
            this.comboBoxListWeapon.Size = new System.Drawing.Size(441, 21);
            this.comboBoxListWeapon.TabIndex = 0;
            this.comboBoxListWeapon.SelectedIndexChanged += new System.EventHandler(this.comboBoxListWeapon_SelectedIndexChanged);
            // 
            // groupBoxSelectWeaponInList
            // 
            this.groupBoxSelectWeaponInList.Controls.Add(this.comboBoxListWeapon);
            this.groupBoxSelectWeaponInList.Location = new System.Drawing.Point(6, 19);
            this.groupBoxSelectWeaponInList.Name = "groupBoxSelectWeaponInList";
            this.groupBoxSelectWeaponInList.Size = new System.Drawing.Size(457, 52);
            this.groupBoxSelectWeaponInList.TabIndex = 5;
            this.groupBoxSelectWeaponInList.TabStop = false;
            this.groupBoxSelectWeaponInList.Text = "Select Weapon in List :";
            // 
            // groupBoxSelectProperty
            // 
            this.groupBoxSelectProperty.Controls.Add(this.comboBoxSelectProperty);
            this.groupBoxSelectProperty.Location = new System.Drawing.Point(6, 77);
            this.groupBoxSelectProperty.Name = "groupBoxSelectProperty";
            this.groupBoxSelectProperty.Size = new System.Drawing.Size(457, 52);
            this.groupBoxSelectProperty.TabIndex = 5;
            this.groupBoxSelectProperty.TabStop = false;
            this.groupBoxSelectProperty.Text = "Select Property :";
            // 
            // comboBoxSelectProperty
            // 
            this.comboBoxSelectProperty.FormattingEnabled = true;
            this.comboBoxSelectProperty.Location = new System.Drawing.Point(6, 19);
            this.comboBoxSelectProperty.Name = "comboBoxSelectProperty";
            this.comboBoxSelectProperty.Size = new System.Drawing.Size(441, 21);
            this.comboBoxSelectProperty.TabIndex = 1;
            this.comboBoxSelectProperty.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectProperty_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxGetValue);
            this.groupBox3.Location = new System.Drawing.Point(6, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 51);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Set Value :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDeserialize);
            this.groupBox2.Controls.Add(this.buttonSerialize);
            this.groupBox2.Location = new System.Drawing.Point(12, 467);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 52);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sere";
            // 
            // buttonSerialize
            // 
            this.buttonSerialize.Location = new System.Drawing.Point(48, 19);
            this.buttonSerialize.Name = "buttonSerialize";
            this.buttonSerialize.Size = new System.Drawing.Size(75, 23);
            this.buttonSerialize.TabIndex = 8;
            this.buttonSerialize.Text = "Serialize";
            this.buttonSerialize.UseVisualStyleBackColor = true;
            this.buttonSerialize.Click += new System.EventHandler(this.buttonSerialize_Click);
            // 
            // buttonDeserialize
            // 
            this.buttonDeserialize.Location = new System.Drawing.Point(328, 19);
            this.buttonDeserialize.Name = "buttonDeserialize";
            this.buttonDeserialize.Size = new System.Drawing.Size(75, 23);
            this.buttonDeserialize.TabIndex = 8;
            this.buttonDeserialize.Text = "Deserialize";
            this.buttonDeserialize.UseVisualStyleBackColor = true;
            this.buttonDeserialize.Click += new System.EventHandler(this.buttonDeserialize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 525);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxListWeapons);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxValueSet.ResumeLayout(false);
            this.groupBoxValueSet.PerformLayout();
            this.groupBoxSelectedPropertySet.ResumeLayout(false);
            this.groupBoxSelectedWeaponSet.ResumeLayout(false);
            this.groupBoxListWeapons.ResumeLayout(false);
            this.groupBoxSelectWeaponInList.ResumeLayout(false);
            this.groupBoxSelectProperty.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSetValue;
        private System.Windows.Forms.ComboBox comboBoxSetProperties;
        private System.Windows.Forms.ComboBox comboBoxWeapon;
        private System.Windows.Forms.GroupBox groupBoxListWeapons;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.TextBox textBoxGetValue;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxListWeapon;
        private System.Windows.Forms.GroupBox groupBoxSelectedWeaponSet;
        private System.Windows.Forms.GroupBox groupBoxSelectedPropertySet;
        private System.Windows.Forms.GroupBox groupBoxValueSet;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.GroupBox groupBoxSelectProperty;
        private System.Windows.Forms.ComboBox comboBoxSelectProperty;
        private System.Windows.Forms.GroupBox groupBoxSelectWeaponInList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDeserialize;
        private System.Windows.Forms.Button buttonSerialize;
    }
}

