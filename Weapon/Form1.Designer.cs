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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxListWeapon = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxValueSet.SuspendLayout();
            this.groupBoxSelectedPropertySet.SuspendLayout();
            this.groupBoxSelectedWeaponSet.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBoxListWeapon);
            this.groupBox2.Location = new System.Drawing.Point(12, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 201);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 3;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(21, 72);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(153, 21);
            this.comboBox5.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxListWeapon
            // 
            this.comboBoxListWeapon.FormattingEnabled = true;
            this.comboBoxListWeapon.Location = new System.Drawing.Point(21, 35);
            this.comboBoxListWeapon.Name = "comboBoxListWeapon";
            this.comboBoxListWeapon.Size = new System.Drawing.Size(153, 21);
            this.comboBoxListWeapon.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 533);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxValueSet.ResumeLayout(false);
            this.groupBoxValueSet.PerformLayout();
            this.groupBoxSelectedPropertySet.ResumeLayout(false);
            this.groupBoxSelectedWeaponSet.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSetValue;
        private System.Windows.Forms.ComboBox comboBoxSetProperties;
        private System.Windows.Forms.ComboBox comboBoxWeapon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxListWeapon;
        private System.Windows.Forms.GroupBox groupBoxSelectedWeaponSet;
        private System.Windows.Forms.GroupBox groupBoxSelectedPropertySet;
        private System.Windows.Forms.GroupBox groupBoxValueSet;
        private System.Windows.Forms.Button buttonCreate;
    }
}

