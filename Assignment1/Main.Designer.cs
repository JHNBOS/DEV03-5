namespace Assignment1
{
    partial class Main
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
            this.Title = new System.Windows.Forms.Label();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.ProjectsButton = new System.Windows.Forms.Button();
            this.createdbylable = new System.Windows.Forms.Label();
            this.HQButton = new System.Windows.Forms.Button();
            this.PositionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(126, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(201, 26);
            this.Title.TabIndex = 0;
            this.Title.Text = "Management Tool";
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeButton.Location = new System.Drawing.Point(65, 86);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(120, 90);
            this.EmployeeButton.TabIndex = 1;
            this.EmployeeButton.Text = "Employees";
            this.EmployeeButton.UseVisualStyleBackColor = true;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // ProjectsButton
            // 
            this.ProjectsButton.Location = new System.Drawing.Point(65, 198);
            this.ProjectsButton.Name = "ProjectsButton";
            this.ProjectsButton.Size = new System.Drawing.Size(120, 90);
            this.ProjectsButton.TabIndex = 2;
            this.ProjectsButton.Text = "Projects";
            this.ProjectsButton.UseVisualStyleBackColor = true;
            this.ProjectsButton.Click += new System.EventHandler(this.ProjectsButton_Click);
            // 
            // createdbylable
            // 
            this.createdbylable.AutoSize = true;
            this.createdbylable.Location = new System.Drawing.Point(171, 356);
            this.createdbylable.Name = "createdbylable";
            this.createdbylable.Size = new System.Drawing.Size(111, 13);
            this.createdbylable.TabIndex = 3;
            this.createdbylable.Text = "Created by Johan Bos";
            // 
            // HQButton
            // 
            this.HQButton.Location = new System.Drawing.Point(252, 86);
            this.HQButton.Name = "HQButton";
            this.HQButton.Size = new System.Drawing.Size(120, 90);
            this.HQButton.TabIndex = 4;
            this.HQButton.Text = "Headquarters";
            this.HQButton.UseVisualStyleBackColor = true;
            this.HQButton.Click += new System.EventHandler(this.HQButton_Click);
            // 
            // PositionButton
            // 
            this.PositionButton.Location = new System.Drawing.Point(252, 198);
            this.PositionButton.Name = "PositionButton";
            this.PositionButton.Size = new System.Drawing.Size(120, 90);
            this.PositionButton.TabIndex = 5;
            this.PositionButton.Text = "Positions";
            this.PositionButton.UseVisualStyleBackColor = true;
            this.PositionButton.Click += new System.EventHandler(this.PositionButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 378);
            this.Controls.Add(this.PositionButton);
            this.Controls.Add(this.HQButton);
            this.Controls.Add(this.createdbylable);
            this.Controls.Add(this.ProjectsButton);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.Title);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.Button ProjectsButton;
        private System.Windows.Forms.Label createdbylable;
        private System.Windows.Forms.Button HQButton;
        private System.Windows.Forms.Button PositionButton;
    }
}

