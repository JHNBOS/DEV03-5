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
    public partial class AssignProjectForm : Form
    {
        public string EmpBSN { get; set; }
        DBModel data = new DBModel();

        public AssignProjectForm(string bsn)
        {
            InitializeComponent();

            EmpBSN = bsn;

            this.FormClosing += AssignProjectForm_FormClosing;

            //Execute methods
            FillComboBox();
        }

        private void AssignProjectForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FillComboBox()
        {
            //List for filling items for combobox
            List<projects> projectsList = null;

            try
            {
                projectsList = data.projects.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with retrieving projects!");
                Console.WriteLine(ex);
            }

            foreach (var project in projectsList)
            {
                string name = project.name;

                projectComboBox.Items.Add(name);
            }

        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            //Get selected project
            string project = projectComboBox.SelectedItem.ToString();

            try
            {
                projects newProject = data.projects.Where(p => p.name == project).FirstOrDefault();

                working_on newWorkingOn = new working_on();
                newWorkingOn.emp_bsn = EmpBSN;
                newWorkingOn.project_id = newProject.id;

                data.working_on.Add(newWorkingOn);
                data.SaveChanges();

                MessageBox.Show("Project assigned!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with assigning project!");
                Console.WriteLine(ex);
            }


            EmployeeForm ef = new EmployeeForm();
            ef.Show();
            this.Hide();
        }
    }
}
