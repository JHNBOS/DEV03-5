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
    public partial class AddDegreeForm : Form
    {
        public string EmpBSN { get; set; }
        DBModel data = new DBModel();

        public AddDegreeForm(string bsn)
        {
            InitializeComponent();

            EmpBSN = bsn;

            this.FormClosing += AddDegree_FormClosing;
        }

        private void AddDegree_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult quit = MessageBox.Show("Are you sure you want to leave this window?",
                "Leaving Window...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (quit == DialogResult.Yes)
            {
                EmployeeForm ef = new EmployeeForm();
                ef.Show();
                this.Hide();
            }
            if (quit == DialogResult.No || quit == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Get information filled in by user
            string school = schoolBox.Text;
            string course = courseBox.Text;
            string level = levelBox.Text;

            try
            {
                degrees newDegree = new degrees();
                newDegree.course = course;
                newDegree.level = level;
                newDegree.school = school;
                newDegree.emp_bsn = EmpBSN;

                data.degrees.Add(newDegree);
                data.SaveChanges();

                MessageBox.Show("Degree added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with adding added!");
                Console.WriteLine(ex);
            }

            EmployeeForm ef = new EmployeeForm();
            ef.Show();
            this.Hide();

        }
    }
}
