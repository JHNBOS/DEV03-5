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
    public partial class AssignJobForm : Form
    {
        public string ProjectID { get; set; }
        DBModel data = new DBModel();

        public AssignJobForm(string PID)
        {
            InitializeComponent();

            ProjectID = PID;

            this.FormClosing += AssignJobForm_FormClosing;

            //Execute methods
            FillComboBox();
        }

        private void AssignJobForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult quit = MessageBox.Show("Are you sure you want to leave this window?",
                "Leaving Window...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (quit == DialogResult.Yes)
            {
                ProjectsForm pf = new ProjectsForm();
                pf.Show();
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
            List<positions> positionList = null;

            try
            {
                positionList = data.positions.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with retrieving job positions!");
                Console.WriteLine(ex);
            }

            foreach (var position in positionList)
            {
                string name = position.name;

                jobComboBox.Items.Add(name);
            }

        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            //Get selected job position
            string job = jobComboBox.SelectedItem.ToString();

            try
            {
                positions newPosition = data.positions.Where(np => np.name == job).FirstOrDefault();

                assigned newAssignPosition = new assigned();
                newAssignPosition.position_name = job;
                newAssignPosition.project_id = ProjectID;

                data.assigned.Add(newAssignPosition);

                data.SaveChanges();

                MessageBox.Show("Job Position assigned!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with assigning job position!");
                Console.WriteLine(ex);
            }


            ProjectsForm pf = new ProjectsForm();
            pf.Show();
            this.Hide();
        }
    }
}
