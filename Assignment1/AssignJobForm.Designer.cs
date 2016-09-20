namespace Assignment1
{
    partial class AssignJobForm
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
            this.assignButton = new System.Windows.Forms.Button();
            this.jobComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // assignButton
            // 
            this.assignButton.Location = new System.Drawing.Point(65, 174);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(142, 23);
            this.assignButton.TabIndex = 74;
            this.assignButton.Text = "Assign Job Position";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // jobComboBox
            // 
            this.jobComboBox.FormattingEnabled = true;
            this.jobComboBox.Location = new System.Drawing.Point(37, 102);
            this.jobComboBox.Name = "jobComboBox";
            this.jobComboBox.Size = new System.Drawing.Size(210, 21);
            this.jobComboBox.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Select a job position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "Assign job position";
            // 
            // AssignJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 209);
            this.Controls.Add(this.assignButton);
            this.Controls.Add(this.jobComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Name = "AssignJobForm";
            this.Text = "Assigning Job";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.ComboBox jobComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
    }
}