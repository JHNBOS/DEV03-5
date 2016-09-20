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
    public partial class ProjectsForm : Form
    {
        DBModel data = new DBModel();

        public ProjectsForm()
        {
            InitializeComponent();

            this.FormClosing += ProjectsForm_FormClosing;

            AddPositionButton.Enabled = false;
            RemovePositionButton.Enabled = false;

            //Execute methods
            FillComboBox();
        }

        private void ProjectsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult quit = MessageBox.Show("Are you sure you want to leave this window?",
                "Leaving Window...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (quit == DialogResult.Yes)
            {
                Main main = new Main();
                main.Show();
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
            //List to store projects
            //List to store headquarters
            List<projects> allProjects = null;
            List<headquarters> allHeadQuarters = null;

            try
            {
                //Fill list with projects
                //Fill list with headquarters
                allProjects = data.projects.ToList();
                allHeadQuarters = data.headquarters.ToList();

                //Add name of projects to combobox
                for (int i = 0; i < allProjects.Count; i++)
                {
                    projects project = allProjects[i];
                    ProjectComboBox.Items.Add(project.name);
                }

                //Add name of headquarters to combobox
                for (int i = 0; i < allHeadQuarters.Count; i++)
                {
                    headquarters hq = allHeadQuarters[i];
                    hqComboBox.Items.Add(hq.name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void GetSelectedProject()
        {
            //Get selected project id
            string projectName = ProjectComboBox.SelectedItem.ToString();

            //Instance of selected project
            projects selectedProject = null;

            try
            {
                selectedProject = data.projects.Where(p => p.name == projectName).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem finding project or loading its information!");
                Console.WriteLine(ex);
            }

            //Set textboxes text to show project info
            idBox.Text = selectedProject.id.ToString();
            pnameBox.Text = selectedProject.name.ToString();
            budgetBox.Text = selectedProject.budget.ToString();
            hoursBox.Text = selectedProject.total_hours.ToString();
            hqComboBox.Text = selectedProject.headquarter.ToString();

            //string with id of selected project
            string pID = selectedProject.id.ToString();

            //Execute method to get positions
            GetPositions(pID);
            AbleToPayRent();

            //Readonly to true;
            idBox.ReadOnly = true;
            pnameBox.ReadOnly = true;
            budgetBox.ReadOnly = true;
            hoursBox.ReadOnly = true;
        }

        private void GetPositions(string projectID)
        {
            //1. List of assigned projects -> positions
            //2 List with type positions
            List<assigned> assignedProjects = null;
            List<positions> allPositions = new List<positions>();

            try
            {
                //Get assigned projects by project id
                assignedProjects = data.assigned.Where(a => a.project_id == projectID).ToList();

                //Find address by postal code and country and place this addresses object in the list
                foreach (var assigned in assignedProjects)
                {
                    positions pos = data.positions.Where(p => p.name == assigned.position_name).FirstOrDefault();
                    allPositions.Add(pos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Positions of this project cannot be shown!");
                Console.WriteLine(ex);
            }
            

            //Place all positions in position textbox
            foreach (var position in allPositions)
            {
                string positionNames = position.name;

                positionsListBox.Items.Add(positionNames);
            }

        }

        private void AbleToPayRent()
        {
            //Get selected project id
            string projectName = ProjectComboBox.SelectedItem.ToString();

            //Instance of selected project
            projects selectedProject = null;
            headquarters HQ = null;

            try
            {
                selectedProject = data.projects.Where(p => p.name == projectName).FirstOrDefault();

                string headquarter = selectedProject.headquarter;

                HQ = data.headquarters.Where(hq => hq.name == headquarter).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem finding project and/or headquarter!");
                Console.WriteLine(ex);
            }

            decimal budget = (decimal) selectedProject.budget;
            decimal rent = (decimal) HQ.rent;
            decimal percentage = (budget / 100) * 10;

            if (rent > percentage)
            {
                rentCheckBox.Checked = false;
            }
            else
            {
                rentCheckBox.Checked = true;
            }

        }

        private void ClearAll()
        {
            //Re-enable buttons
            SelectButton.Enabled = true;
            AddButton.Enabled = true;
            EditButton.Enabled = true;
            UpdateButton.Enabled = true;
            DeleteButton.Enabled = true;

            //Readonly to false;
            idBox.ReadOnly = false;
            pnameBox.ReadOnly = false;
            budgetBox.ReadOnly = false;
            hoursBox.ReadOnly = false;
            AddPositionButton.Enabled = false;
            RemovePositionButton.Enabled = false;


            //Clear fields
            idBox.Clear();
            pnameBox.Clear();
            budgetBox.Clear();
            hoursBox.Clear();
            hqComboBox.ResetText();
            hqComboBox.Items.Clear();
            positionsListBox.Items.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Project info
            string id = idBox.Text;
            string pName = pnameBox.Text;
            string budget = budgetBox.Text;
            string hours = hoursBox.Text;
            string hq = hqComboBox.SelectedItem.ToString();

            try
            {
                decimal Budget = Convert.ToDecimal(budget);
                int Hours = Convert.ToInt32(hours);

                //Create new instance of projects and fill in info
                projects newProject = new projects();
                newProject.id = id;
                newProject.name = pName;
                newProject.budget = Budget;
                newProject.total_hours = Hours;
                newProject.headquarter = hq;

                data.projects.Add(newProject);
                data.SaveChanges();

                MessageBox.Show("New project added!");

                //Clear fields
                ClearAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Project couldn't be added!");
                Console.WriteLine(ex);

                //Clear fields
                ClearAll();
            }

            //Renew all comboboxes
            ProjectComboBox.Items.Clear();
            ProjectComboBox.ResetText();

            //Clear fields
            ClearAll();

            FillComboBox();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            projects newProject = new projects();
            newProject.id = idBox.Text;
            newProject.name = pnameBox.Text;
            newProject.budget = Convert.ToInt32(budgetBox.Text);
            newProject.total_hours = Convert.ToInt32(hoursBox.Text);
            newProject.headquarter = hqComboBox.SelectedItem.ToString();

            string query = "UPDATE projects SET name=@P0, budget=@P1, total_hours=@P2, headquarter=@P3 WHERE id=@P4";

            List<object> parameterList = new List<object>();
            parameterList.Add(newProject.name);
            parameterList.Add(newProject.budget);
            parameterList.Add(newProject.total_hours);
            parameterList.Add(newProject.headquarter);
            parameterList.Add(newProject.id);

            object[] parameters = parameterList.ToArray();

            try
            {
                data.Database.ExecuteSqlCommand(query, parameters);
                data.SaveChanges();

                MessageBox.Show("Project information updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with updating information!");
                Console.WriteLine(ex);
            }

            //Renew all comboboxes
            ClearAll();

            ProjectComboBox.ResetText();
            ProjectComboBox.Items.Clear();

            FillComboBox();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            GetSelectedProject();

            //disable buttons
            SelectButton.Enabled = false;
            AddButton.Enabled = false;
            EditButton.Enabled = false;
            UpdateButton.Enabled = true;
            DeleteButton.Enabled = false;
            AddPositionButton.Enabled = true;
            RemovePositionButton.Enabled = true;

            //Readonly to false;
            idBox.ReadOnly = true;
            pnameBox.ReadOnly = false;
            budgetBox.ReadOnly = false;
            hoursBox.ReadOnly = false;

            //Reset text
            hqComboBox.ResetText();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //Get selected project id
            string projectName = ProjectComboBox.SelectedItem.ToString();

            DialogResult delete = MessageBox.Show("Are you sure you want to remove this project?",
                "Removing...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            try
            {
                if (delete == DialogResult.Yes)
                {
                    projects selectedProject = data.projects.Where(p => p.name == projectName).FirstOrDefault();
                    List<assigned> deleteAssignedList = data.assigned.Where(a => a.project_id == selectedProject.id).ToList();

                    data.assigned.RemoveRange(deleteAssignedList);
                    data.projects.Remove(selectedProject);

                    data.SaveChanges();

                    MessageBox.Show("Project removed!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with removing project!");
                Console.WriteLine(ex);
            }

            ProjectComboBox.ResetText();
            ProjectComboBox.Items.Clear();

            ClearAll();

            FillComboBox();
        }

        private void SelectButton_Click_1(object sender, EventArgs e)
        {
            SelectButton.Enabled = false;
            AddButton.Enabled = false;
            UpdateButton.Enabled = false;
            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
            AddPositionButton.Enabled = false;
            RemovePositionButton.Enabled = false;

            GetSelectedProject();
        }

        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void AddPositionButton_Click(object sender, EventArgs e)
        {
            //Get selected project id
            string projectName = ProjectComboBox.SelectedItem.ToString();

            //Instance of selected project
            projects selectedProject = null;

            try
            {
                selectedProject = data.projects.Where(p => p.name == projectName).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem finding project or loading its information!");
                Console.WriteLine(ex);
            }

            AssignJobForm aj = new AssignJobForm(selectedProject.id);
            aj.Show();
            this.Hide();
        }

        private void RemovePositionButton_Click(object sender, EventArgs e)
        {
            //Get selected item of listBox
            string job = positionsListBox.SelectedItem.ToString();

            //Get selected project name
            string projectName = ProjectComboBox.SelectedItem.ToString();

            DialogResult delete = MessageBox.Show("Are you sure you want to remove this job position?",
                "Removing...",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            projects selectedProject = null;

            try
            {
                if (delete == DialogResult.Yes)
                {
                    selectedProject = data.projects.Where(p => p.name == projectName).FirstOrDefault();
                    positions deletePosition = data.positions.Where(p => p.name == job).FirstOrDefault();
                    assigned deleteAssignedPosition = data.assigned.Where(a => a.position_name == job && a.project_id == selectedProject.id).FirstOrDefault();

                    data.assigned.Remove(deleteAssignedPosition);

                    data.SaveChanges();

                    MessageBox.Show("Job position removed!");
                }
                if (delete == DialogResult.No || delete == DialogResult.Cancel)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with removing job position!");
                Console.WriteLine(ex);
            }

            positionsListBox.Items.Clear();
            positionsListBox.ResetText();
            GetPositions(selectedProject.id);
        }
    }
}
