namespace Assignment1
{
    partial class HeadQuarterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClearButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.HQComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bnameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roomsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.rentBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.postalBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(394, 94);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(47, 23);
            this.ClearButton.TabIndex = 26;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(235, 94);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(47, 23);
            this.SelectButton.TabIndex = 25;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Select a headquarter";
            // 
            // HQComboBox
            // 
            this.HQComboBox.FormattingEnabled = true;
            this.HQComboBox.Location = new System.Drawing.Point(53, 94);
            this.HQComboBox.Name = "HQComboBox";
            this.HQComboBox.Size = new System.Drawing.Size(175, 21);
            this.HQComboBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "HQ Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Building Name";
            // 
            // bnameBox
            // 
            this.bnameBox.Location = new System.Drawing.Point(53, 180);
            this.bnameBox.Name = "bnameBox";
            this.bnameBox.Size = new System.Drawing.Size(146, 20);
            this.bnameBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "No. of rooms";
            // 
            // roomsUpDown
            // 
            this.roomsUpDown.Location = new System.Drawing.Point(53, 239);
            this.roomsUpDown.Name = "roomsUpDown";
            this.roomsUpDown.Size = new System.Drawing.Size(106, 20);
            this.roomsUpDown.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Rent";
            // 
            // rentBox
            // 
            this.rentBox.Location = new System.Drawing.Point(53, 299);
            this.rentBox.Name = "rentBox";
            this.rentBox.Size = new System.Drawing.Size(106, 20);
            this.rentBox.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Street";
            // 
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(278, 180);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(198, 20);
            this.streetBox.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(496, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Number";
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(499, 180);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(88, 20);
            this.numberBox.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Postal Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "City";
            // 
            // postalBox
            // 
            this.postalBox.Location = new System.Drawing.Point(278, 239);
            this.postalBox.Name = "postalBox";
            this.postalBox.Size = new System.Drawing.Size(136, 20);
            this.postalBox.TabIndex = 39;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(436, 239);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(151, 20);
            this.cityBox.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(275, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Country";
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(278, 299);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(309, 20);
            this.countryBox.TabIndex = 42;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(288, 94);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(47, 23);
            this.EditButton.TabIndex = 43;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(301, 378);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(129, 23);
            this.UpdateButton.TabIndex = 45;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(166, 378);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(129, 23);
            this.AddButton.TabIndex = 44;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(341, 94);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(47, 23);
            this.DeleteButton.TabIndex = 46;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // HeadQuarterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 440);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.postalBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.streetBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rentBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roomsUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HQComboBox);
            this.Controls.Add(this.label1);
            this.Name = "HeadQuarterForm";
            this.Text = "Headquarter Management";
            ((System.ComponentModel.ISupportInitialize)(this.roomsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox HQComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bnameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown roomsUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rentBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox postalBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}