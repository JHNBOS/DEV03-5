namespace Assignment1
{
    partial class AddAddressForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.postalBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "Add address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Street";
            // 
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(31, 66);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(184, 20);
            this.streetBox.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Number";
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(221, 66);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(115, 20);
            this.numberBox.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Postal Code";
            // 
            // postalBox
            // 
            this.postalBox.Location = new System.Drawing.Point(31, 135);
            this.postalBox.Name = "postalBox";
            this.postalBox.Size = new System.Drawing.Size(147, 20);
            this.postalBox.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "City";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(184, 135);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(152, 20);
            this.cityBox.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Country";
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(31, 201);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(305, 20);
            this.countryBox.TabIndex = 76;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(135, 250);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(87, 23);
            this.AddButton.TabIndex = 77;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 276);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.postalBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.streetBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "AddAddressForm";
            this.Text = "Add Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox postalBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.Button AddButton;
    }
}