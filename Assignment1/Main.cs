using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            this.FormClosing += Main_FormClosing;                                                                                                                                                                          
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult quit = MessageBox.Show("Are you sure you want to quit this program?",
                "Quiting Program...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if(quit == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            if (quit == DialogResult.No || quit == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            this.Hide();
            employeeForm.Show();
        }

        private void ProjectsButton_Click(object sender, EventArgs e)
        {
            ProjectsForm projetcsForm = new ProjectsForm();
            this.Hide();
            projetcsForm.Show();
        }

        private void HQButton_Click(object sender, EventArgs e)
        {
            HeadQuarterForm headquartersForm = new HeadQuarterForm();
            this.Hide();
            headquartersForm.Show();
        }

        private void PositionButton_Click(object sender, EventArgs e)
        {
            PositionsForm positionsForm = new PositionsForm();
            this.Hide();
            positionsForm.Show();
        }
    }
}
