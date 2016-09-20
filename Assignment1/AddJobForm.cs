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
    public partial class AddJobForm : Form
    {
        public string EmpBSN { get; set; }
        DBModel data = new DBModel();

        public AddJobForm(string bsn)
        {
            InitializeComponent();

            EmpBSN = bsn;

            this.FormClosing += AddJobForm_FormClosing;

            //Execute methods
            FillComboBox();
        }

        private void AddJobForm_FormClosing(object sender, FormClosingEventArgs e)
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

                employee_positions newEmployeePosition = new employee_positions();
                newEmployeePosition.emp_bsn = EmpBSN;
                newEmployeePosition.name = newPosition.name;

                data.employee_positions.Add(newEmployeePosition);

                data.SaveChanges();

                MessageBox.Show("Job Position assigned!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with assigning job position!");
                Console.WriteLine(ex);
            }


            EmployeeForm ef = new EmployeeForm();
            ef.Show();
            this.Hide();
        }
    }
}
