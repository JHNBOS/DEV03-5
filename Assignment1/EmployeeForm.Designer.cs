namespace Assignment1
{
    partial class EmployeeForm
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
            this.EmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bsnBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.residenceBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.degreeListBox = new System.Windows.Forms.ListBox();
            this.AddDegreeButton = new System.Windows.Forms.Button();
            this.RemoveDegreeButton = new System.Windows.Forms.Button();
            this.removeJobbutton = new System.Windows.Forms.Button();
            this.addJobButton = new System.Windows.Forms.Button();
            this.jobListBox = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.projectListBox = new System.Windows.Forms.ListBox();
            this.RemoveAssignButton = new System.Windows.Forms.Button();
            this.AssignProjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeComboBox
            // 
            this.EmployeeComboBox.FormattingEnabled = true;
            this.EmployeeComboBox.Location = new System.Drawing.Point(199, 95);
            this.EmployeeComboBox.Name = "EmployeeComboBox";
            this.EmployeeComboBox.Size = new System.Drawing.Size(175, 21);
            this.EmployeeComboBox.Sorted = true;
            this.EmployeeComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select an employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name";
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(54, 243);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(142, 20);
            this.fnameBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Surname";
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(57, 315);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(142, 20);
            this.surnameBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "BSN";
            // 
            // bsnBox
            // 
            this.bsnBox.Location = new System.Drawing.Point(54, 168);
            this.bsnBox.Name = "bsnBox";
            this.bsnBox.Size = new System.Drawing.Size(142, 20);
            this.bsnBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Addresses";
            // 
            // addressBox
            // 
            this.addressBox.AcceptsReturn = true;
            this.addressBox.Location = new System.Drawing.Point(238, 168);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.addressBox.Size = new System.Drawing.Size(298, 96);
            this.addressBox.TabIndex = 13;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(322, 472);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(129, 23);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(235, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ex:Beukenlaan 12A,1234AB Rotterdam,Netherlands";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(457, 472);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(129, 23);
            this.UpdateButton.TabIndex = 17;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Postal Code Residence";
            // 
            // residenceBox
            // 
            this.residenceBox.Location = new System.Drawing.Point(54, 390);
            this.residenceBox.Name = "residenceBox";
            this.residenceBox.Size = new System.Drawing.Size(142, 20);
            this.residenceBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Job Position(s)";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(486, 95);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(47, 23);
            this.DeleteButton.TabIndex = 50;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(433, 95);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(47, 23);
            this.EditButton.TabIndex = 49;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(539, 95);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(47, 23);
            this.ClearButton.TabIndex = 48;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(380, 95);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(47, 23);
            this.SelectButton.TabIndex = 47;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(564, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Education";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(23, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(846, 2);
            this.label11.TabIndex = 64;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(23, 467);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(846, 2);
            this.label12.TabIndex = 65;
            // 
            // degreeListBox
            // 
            this.degreeListBox.FormattingEnabled = true;
            this.degreeListBox.HorizontalScrollbar = true;
            this.degreeListBox.Location = new System.Drawing.Point(567, 168);
            this.degreeListBox.Name = "degreeListBox";
            this.degreeListBox.ScrollAlwaysVisible = true;
            this.degreeListBox.Size = new System.Drawing.Size(249, 95);
            this.degreeListBox.Sorted = true;
            this.degreeListBox.TabIndex = 66;
            // 
            // AddDegreeButton
            // 
            this.AddDegreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDegreeButton.Location = new System.Drawing.Point(676, 269);
            this.AddDegreeButton.Name = "AddDegreeButton";
            this.AddDegreeButton.Size = new System.Drawing.Size(67, 23);
            this.AddDegreeButton.TabIndex = 67;
            this.AddDegreeButton.Text = "Add";
            this.AddDegreeButton.UseVisualStyleBackColor = true;
            this.AddDegreeButton.Click += new System.EventHandler(this.AddDegreeButton_Click);
            // 
            // RemoveDegreeButton
            // 
            this.RemoveDegreeButton.Location = new System.Drawing.Point(749, 269);
            this.RemoveDegreeButton.Name = "RemoveDegreeButton";
            this.RemoveDegreeButton.Size = new System.Drawing.Size(67, 23);
            this.RemoveDegreeButton.TabIndex = 68;
            this.RemoveDegreeButton.Text = "Remove";
            this.RemoveDegreeButton.UseVisualStyleBackColor = true;
            this.RemoveDegreeButton.Click += new System.EventHandler(this.RemoveDegreeButton_Click);
            // 
            // removeJobbutton
            // 
            this.removeJobbutton.Location = new System.Drawing.Point(466, 416);
            this.removeJobbutton.Name = "removeJobbutton";
            this.removeJobbutton.Size = new System.Drawing.Size(67, 23);
            this.removeJobbutton.TabIndex = 70;
            this.removeJobbutton.Text = "Remove";
            this.removeJobbutton.UseVisualStyleBackColor = true;
            this.removeJobbutton.Click += new System.EventHandler(this.removeJobbutton_Click);
            // 
            // addJobButton
            // 
            this.addJobButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addJobButton.Location = new System.Drawing.Point(393, 416);
            this.addJobButton.Name = "addJobButton";
            this.addJobButton.Size = new System.Drawing.Size(67, 23);
            this.addJobButton.TabIndex = 69;
            this.addJobButton.Text = "Assign";
            this.addJobButton.UseVisualStyleBackColor = true;
            this.addJobButton.Click += new System.EventHandler(this.addJobButton_Click);
            // 
            // jobListBox
            // 
            this.jobListBox.FormattingEnabled = true;
            this.jobListBox.HorizontalScrollbar = true;
            this.jobListBox.Location = new System.Drawing.Point(238, 315);
            this.jobListBox.Name = "jobListBox";
            this.jobListBox.ScrollAlwaysVisible = true;
            this.jobListBox.Size = new System.Drawing.Size(295, 95);
            this.jobListBox.Sorted = true;
            this.jobListBox.TabIndex = 71;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(219, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(2, 330);
            this.label13.TabIndex = 72;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(567, 298);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 73;
            this.label14.Text = "Projects";
            // 
            // projectListBox
            // 
            this.projectListBox.FormattingEnabled = true;
            this.projectListBox.Location = new System.Drawing.Point(567, 315);
            this.projectListBox.Name = "projectListBox";
            this.projectListBox.ScrollAlwaysVisible = true;
            this.projectListBox.Size = new System.Drawing.Size(249, 95);
            this.projectListBox.TabIndex = 74;
            // 
            // RemoveAssignButton
            // 
            this.RemoveAssignButton.Location = new System.Drawing.Point(749, 416);
            this.RemoveAssignButton.Name = "RemoveAssignButton";
            this.RemoveAssignButton.Size = new System.Drawing.Size(67, 23);
            this.RemoveAssignButton.TabIndex = 76;
            this.RemoveAssignButton.Text = "Remove";
            this.RemoveAssignButton.UseVisualStyleBackColor = true;
            this.RemoveAssignButton.Click += new System.EventHandler(this.RemoveAssignButton_Click);
            // 
            // AssignProjectButton
            // 
            this.AssignProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignProjectButton.Location = new System.Drawing.Point(676, 416);
            this.AssignProjectButton.Name = "AssignProjectButton";
            this.AssignProjectButton.Size = new System.Drawing.Size(67, 23);
            this.AssignProjectButton.TabIndex = 75;
            this.AssignProjectButton.Text = "Assign";
            this.AssignProjectButton.UseVisualStyleBackColor = true;
            this.AssignProjectButton.Click += new System.EventHandler(this.AssignProjectButton_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 507);
            this.Controls.Add(this.RemoveAssignButton);
            this.Controls.Add(this.AssignProjectButton);
            this.Controls.Add(this.projectListBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.jobListBox);
            this.Controls.Add(this.removeJobbutton);
            this.Controls.Add(this.addJobButton);
            this.Controls.Add(this.RemoveDegreeButton);
            this.Controls.Add(this.AddDegreeButton);
            this.Controls.Add(this.degreeListBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.residenceBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bsnBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeComboBox);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EmployeeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bsnBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox residenceBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox degreeListBox;
        private System.Windows.Forms.Button AddDegreeButton;
        private System.Windows.Forms.Button RemoveDegreeButton;
        private System.Windows.Forms.Button removeJobbutton;
        private System.Windows.Forms.Button addJobButton;
        private System.Windows.Forms.ListBox jobListBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox projectListBox;
        private System.Windows.Forms.Button RemoveAssignButton;
        private System.Windows.Forms.Button AssignProjectButton;
    }
}