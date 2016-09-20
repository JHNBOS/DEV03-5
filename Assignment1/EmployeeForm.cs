using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class EmployeeForm : Form
    {
        //1. Instance of DBModel
        DBModel data = new DBModel();

        public EmployeeForm()
        {
            InitializeComponent();

            this.FormClosing += EmployeeForm_FormClosing;

            AddDegreeButton.Enabled = false;
            RemoveDegreeButton.Enabled = false;
            addJobButton.Enabled = false;
            removeJobbutton.Enabled = false;

            //Execute methods
            FillComboBox();
        }

        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
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
            //List of all employees
            List<employees> allEmployeesList = data.employees.ToList();

            //Add first and lastnames of employees to combobox
            for (int i = 0; i < allEmployeesList.Count; i++)
            {
                employees employee = allEmployeesList[i];
                EmployeeComboBox.Items.Add(employee.surname + "," + employee.name);
            }
        }

        private void GetSelectedEmployee()
        {
            //Get first and last name and split in two variables
            string fullName = EmployeeComboBox.SelectedItem.ToString();
            string[] tmp = fullName.Split(',');
            string firstName = tmp[1];
            string lastName = tmp[0];

            employees selectedEmployee = null;

            try
            {
                //Instance of employee object of selected employee
                selectedEmployee = data.employees.Where(em => em.name == firstName && em.surname == lastName).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with finding employee!");
                Console.WriteLine(ex);
            }
            
            //employee info
            string bsn = selectedEmployee.bsn;
            string residence = selectedEmployee.postal_code;

            //Set text of TextBoxes in form
            bsnBox.Text = bsn;
            fnameBox.Text = firstName;
            surnameBox.Text = lastName;
            residenceBox.Text = residence;

            //Get Address(es) from other method
            //Get Position(s) from other method
            //Get Degree(s) from other method
            GetAddress(bsn);
            GetEmployeePositions(firstName, lastName, bsn);
            GetDegrees(bsn);
            GetProjects(bsn);
        }

        private void GetEmployeePositions(string firstname, string surname, string bsn)
        {
            employees selectedEmployee = null;
            List<employee_positions> employeePositionsList = null;
            List<positions> selectedPositionsList = new List<positions>();

            try
            {
                //Instance of employee object of selected employee
                selectedEmployee = data.employees.Where(em => em.name == firstname && em.surname == surname).FirstOrDefault();
                employeePositionsList = data.employee_positions.Where(ep => ep.emp_bsn == bsn).ToList();

                foreach (var ep in employeePositionsList)
                {
                    positions position = data.positions.Where(p => p.name == ep.name).FirstOrDefault();
                    selectedPositionsList.Add(position);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with finding job positions!");
                Console.WriteLine(ex);
            }

            //Set text of TextBox to show positions
            foreach (var positions in selectedPositionsList)
            {
                string pName = positions.name;
                string pFee = positions.fee.ToString();

                string PositionLine = pName + " earning " + pFee;

                jobListBox.Items.Add(PositionLine);
            }
        }

        private void GetProjects(string bsn)
        {
            //List of junction table between employees and working_on
            //List of projects
            List<working_on> workingOnList = null;
            List<projects> projectsList = new List<projects>();

            try
            {
                workingOnList = data.working_on.Where(w => w.emp_bsn == bsn).ToList();


                foreach (var working in workingOnList)
                {
                    projects project = data.projects.Where(pr => pr.id == working.project_id).FirstOrDefault();
                    projectsList.Add(project);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with finding any projects!");
                Console.WriteLine(ex);
            }

            //Set text of TextBox to the address(es)
            foreach (var project in projectsList)
            {
                string projectName = project.name;

                projectListBox.Items.Add(projectName);
            }
        }

        private void GetAddress(string bsn)
        {
            //1. List of junction table rows between employees and addresses
            //2. List of addresses
            List<employee_addresses> addressJunction = null;
            List<addresses> addressList = new List<addresses>();

            try
            {
                addressJunction = data.employee_addresses.Where(em => em.emp_bsn == bsn).ToList();

                //Find address by postal code and country and place this addresses object in the list
                foreach (var emp_addr in addressJunction)
                {
                    addresses address = data.addresses.Where(l => l.postal_code == emp_addr.addr_postal && l.country == emp_addr.addr_country).FirstOrDefault();
                    addressList.Add(address);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with finding any addresses");
                Console.WriteLine(ex);
            }

            //Set text of TextBox to the address(es)
            foreach (var addresses in addressList)
            {
                string street = addresses.street;
                string number = addresses.number;
                string postal = addresses.postal_code;
                string city = addresses.city;
                string country = addresses.country;

                string address = street + " " + number + ", " + postal + " " + city + ", " + country + Environment.NewLine;

                if (addressBox.TextLength == 0)
                {
                    addressBox.Text = address;
                }
                else
                {
                    addressBox.Text += address;
                }

            }
        }

        private void GetDegrees(string bsn)
        {
            //Lists
            employees selectedEmployee = null;
            List<employee_degrees> employeeDegreesList = null;
            List<degrees> selectedDegreesList = new List<degrees>();

            try
            {
                //Instance of employee object of selected employee
                //employee_degrees junction list
                selectedEmployee = data.employees.Where(em => em.bsn == bsn).FirstOrDefault();
                employeeDegreesList = data.employee_degrees.Where(ed => ed.emp_bsn == bsn).ToList();

                foreach (var ed in employeeDegreesList)
                {
                    degrees degree = data.degrees.Where(d => d.id == ed.degree_id).FirstOrDefault();
                    selectedDegreesList.Add(degree);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with finding degrees!");
                Console.WriteLine(ex);
            }

            //Set text of TextBox to show degrees
            foreach (var degree in selectedDegreesList)
            {
                string course = degree.course;
                string school = degree.school;
                string level = degree.level;

                string DegreeLine = school + "," + " " + course + "," + " " + level;

                degreeListBox.Items.Add(DegreeLine);
            }
        }

        private void ClearAll()
        {
            //Re-enable buttons
            AddButton.Enabled = true;
            SelectButton.Enabled = true;
            EditButton.Enabled = true;
            UpdateButton.Enabled = true;
            DeleteButton.Enabled = true;
            AddDegreeButton.Enabled = false;
            RemoveDegreeButton.Enabled = false;
            addJobButton.Enabled = false;
            removeJobbutton.Enabled = false;

            //Readonly to false;
            bsnBox.ReadOnly = false;
            fnameBox.ReadOnly = false;
            surnameBox.ReadOnly = false;
            addressBox.ReadOnly = false;
            residenceBox.ReadOnly = false;

            //Clear fields
            bsnBox.Clear();
            fnameBox.Clear();
            surnameBox.Clear();
            addressBox.Clear();
            residenceBox.Clear();
            jobListBox.Items.Clear();
            degreeListBox.Items.Clear();
        }


        /* START OF BUTTON HANDLERS */
        private void SelectButton_Click(object sender, EventArgs e)
        {
            GetSelectedEmployee();

            EditButton.Enabled = false;
            AddButton.Enabled = false;
            SelectButton.Enabled = false;
            UpdateButton.Enabled = false;
            DeleteButton.Enabled = false;
            AddDegreeButton.Enabled = false;
            RemoveDegreeButton.Enabled = false;
            addJobButton.Enabled = false;
            removeJobbutton.Enabled = false;

            //Readonly to false;
            bsnBox.ReadOnly = true;
            fnameBox.ReadOnly = true;
            surnameBox.ReadOnly = true;
            addressBox.ReadOnly = true;
            residenceBox.ReadOnly = true;
        }

        //Method to clear all the textboxes
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        //Method to add new employee
        private void AddButton_Click(object sender, EventArgs e)
        {
            //Full address
            string fullAddress = addressBox.ToString();
            string[] tmp = fullAddress.Split(new char[] {' ', ',', '\n'}, StringSplitOptions.RemoveEmptyEntries);

            //Address info
            string street = tmp[2];
            string number = tmp[3];
            string postal = tmp[4];
            string city = tmp[5];
            string country = tmp[6];

            //Employee info
            string firstName = fnameBox.Text;
            string surName = surnameBox.Text;
            string bsn = bsnBox.Text;
            string residence = residenceBox.Text;


            try
            {
                employees employee = new employees();
                employee.bsn = bsn;
                employee.name = firstName;
                employee.surname = surName;
                employee.postal_code = residence;

                data.employees.Add(employee);
                data.SaveChanges();

                addresses address = new addresses();
                address.street = street;
                address.number = number;
                address.postal_code = postal;
                address.city = city;
                address.country = country;

                data.addresses.Add(address);
                data.SaveChanges();

                employee_addresses ea = new employee_addresses();
                ea.emp_bsn = bsn;
                ea.addr_postal = postal;
                ea.addr_country = country;

                data.employee_addresses.Add(ea);
                data.SaveChanges();

                MessageBox.Show("New employee added!");

                //Clear
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Employee couldn't be added!");

                //Clear
                ClearAll();

                Console.WriteLine(ex);
            }

            //Renew all comboboxes
            FillComboBox();
        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            GetSelectedEmployee();

            //disenable buttons
            AddButton.Enabled = false;
            SelectButton.Enabled = false;
            EditButton.Enabled = false;
            UpdateButton.Enabled = true;
            DeleteButton.Enabled = false;
            AddDegreeButton.Enabled = true;
            RemoveDegreeButton.Enabled = true;
            addJobButton.Enabled = true;
            removeJobbutton.Enabled = true;

            //Readonly to false;
            bsnBox.ReadOnly = true;
            fnameBox.ReadOnly = false;
            surnameBox.ReadOnly = false;
            addressBox.ReadOnly = false;
            residenceBox.ReadOnly = false;
        }



        private void UpdateButton_Click(object sender, EventArgs e)
        {
            employees newEmployee = new employees();

            newEmployee.bsn = bsnBox.Text;
            newEmployee.name = fnameBox.Text;
            newEmployee.surname = surnameBox.Text;
            newEmployee.postal_code = residenceBox.Text;

            string query = "UPDATE employees SET name=@P0, surname=@P1, postal_code=@P2 WHERE bsn=@P3";

            List<object> parameterList = new List<object>();
            parameterList.Add(newEmployee.name);
            parameterList.Add(newEmployee.surname);
            parameterList.Add(newEmployee.postal_code);
            parameterList.Add(newEmployee.bsn);

            object[] parameters = parameterList.ToArray();

            try
            {
                data.Database.ExecuteSqlCommand(query, parameters);
                data.SaveChanges();

                MessageBox.Show("Employee information updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with updating information!");
                Console.WriteLine(ex);
            }

            //Renew all comboboxes
            FillComboBox();
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //Get selected employee to delete
            //Get first and last name and split in two variables
            string fullName = EmployeeComboBox.SelectedItem.ToString();
            string[] tmp = fullName.Split(',');
            string firstName = tmp[1];
            string lastName = tmp[0];

            DialogResult delete = MessageBox.Show("Are you sure you want to remove this employee?",
                "Removing...",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            try
            {
                if (delete == DialogResult.Yes)
                {
                    employees deleteEmployee = data.employees.Where(emp => emp.name == firstName && emp.surname == lastName).FirstOrDefault();
                    List<employee_addresses> deleteEAList = data.employee_addresses.Where(ea => ea.emp_bsn == deleteEmployee.bsn).ToList();
                    List<employee_positions> deletePositionsList = data.employee_positions.Where(ep => ep.emp_bsn == deleteEmployee.bsn).ToList();
                    List<employee_degrees> deleteDegreeList = data.employee_degrees.Where(ep => ep.emp_bsn == deleteEmployee.bsn).ToList();

                    data.employee_addresses.RemoveRange(deleteEAList);
                    data.employee_positions.RemoveRange(deletePositionsList);
                    data.employee_degrees.RemoveRange(deleteDegreeList);
                    data.employees.Remove(deleteEmployee);

                    data.SaveChanges();

                    MessageBox.Show("Employee removed!");
                }
                if (delete == DialogResult.No || delete == DialogResult.Cancel)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with removing employee!");
                Console.WriteLine(ex);
            }

            EmployeeComboBox.Items.Clear();
            EmployeeComboBox.ResetText();
            FillComboBox();
        }


        private void AddDegreeButton_Click(object sender, EventArgs e)
        {
            //Get selected employee to delete
            //Get first and last name and split in two variables
            string fullName = EmployeeComboBox.SelectedItem.ToString();
            string[] tmp = fullName.Split(',');
            string firstName = tmp[1];
            string lastName = tmp[0];

            employees selectedEmployee = null;

            try
            {
                selectedEmployee = data.employees.Where(emp => emp.name == firstName && emp.surname == lastName).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            AddDegreeForm ad = new AddDegreeForm(selectedEmployee.bsn);
            ad.Show();
        }


        private void RemoveDegreeButton_Click(object sender, EventArgs e)
        {
            //Get selected item of listBox
            string degree = degreeListBox.SelectedItem.ToString();
            string[] tmp = degree.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string school = tmp[0];
            string course = tmp[1];
            string level = tmp[2];

            //Get selected employee to delete
            //Get first and last name and split in two variables
            string fullName = EmployeeComboBox.SelectedItem.ToString();
            string[] tmp1 = fullName.Split(',');
            string firstName = tmp1[1];
            string lastName = tmp1[0];

            Console.WriteLine("School: " + school);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("Level: " + level);

            DialogResult delete = MessageBox.Show("Are you sure you want to remove this degree?",
                "Removing...",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            employees selectedEmployee = null;

            try
            {
                if (delete == DialogResult.Yes)
                {
                    selectedEmployee = data.employees.Where(emp => emp.name == firstName && emp.surname == lastName).FirstOrDefault();

                    degrees deleteDegree = data.degrees.Where(d => d.school == school && d.course == course
                    && d.level == level).FirstOrDefault();
                    employee_degrees deleteEmployeeDegree = data.employee_degrees.Where(ed => ed.degree_id == deleteDegree.id).FirstOrDefault();

                    data.employee_degrees.Remove(deleteEmployeeDegree);
                    data.degrees.Remove(deleteDegree);
                    data.SaveChanges();

                    MessageBox.Show("Degree removed!");
                }
                if (delete == DialogResult.No || delete == DialogResult.Cancel)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with removing degree!");
                Console.WriteLine(ex);
            }

            degreeListBox.Items.Clear();
            degreeListBox.ResetText();
            GetDegrees(selectedEmployee.bsn);
        }


        private void addJobButton_Click(object sender, EventArgs e)
        {
            //Get selected employee to delete
            //Get first and last name and split in two variables
            string fullName = EmployeeComboBox.SelectedItem.ToString();
            string[] tmp = fullName.Split(',');
            string firstName = tmp[1];
            string lastName = tmp[0];

            employees selectedEmployee = null;

            try
            {
                selectedEmployee = data.employees.Where(emp => emp.name == firstName && emp.surname == lastName).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            AddJobForm jf = new AddJobForm(selectedEmployee.bsn);
            jf.Show();
            this.Hide();
        }


        private void removeJobbutton_Click(object sender, EventArgs e)
        {
            //Get selected item of listBox
            string job = jobListBox.SelectedItem.ToString();
            string[] tmp = job.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string position = tmp[0];
            string earning = tmp[1];
            string fee = tmp[2];

            //Get selected employee to delete
            //Get first and last name and split in two variables
            string fullName = EmployeeComboBox.SelectedItem.ToString();
            string[] tmp1 = fullName.Split(',');
            string firstName = tmp1[1];
            string lastName = tmp1[0];

            Console.WriteLine("Position: " + position);
            Console.WriteLine("Fee: " + fee);

            DialogResult delete = MessageBox.Show("Are you sure you want to remove this job position?",
                "Removing...",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            employees selectedEmployee = null;

            try
            {
                if (delete == DialogResult.Yes)
                {
                    selectedEmployee = data.employees.Where(emp => emp.name == firstName && emp.surname == lastName).FirstOrDefault();

                    positions deletePosition = data.positions.Where(p => p.name == position).FirstOrDefault();
                    employee_positions employeePositions = data.employee_positions.Where(ep => ep.emp_bsn == selectedEmployee.bsn
                    && ep.name == deletePosition.name).FirstOrDefault();

                    data.employee_positions.Remove(employeePositions);
                    data.positions.Remove(deletePosition);
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

            jobListBox.Items.Clear();
            jobListBox.ResetText();
            GetEmployeePositions(selectedEmployee.name, selectedEmployee.surname, selectedEmployee.bsn);
        }

        private void AssignProjectButton_Click(object sender, EventArgs e)
        {
            //Get selected employee to delete
            //Get first and last name and split in two variables
            string fullName = EmployeeComboBox.SelectedItem.ToString();
            string[] tmp = fullName.Split(',');
            string firstName = tmp[1];
            string lastName = tmp[0];

            employees selectedEmployee = null;

            try
            {
                selectedEmployee = data.employees.Where(emp => emp.name == firstName && emp.surname == lastName).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            AssignProjectForm ap = new AssignProjectForm(selectedEmployee.bsn);
            ap.Show();
            this.Hide();
        }

        private void RemoveAssignButton_Click(object sender, EventArgs e)
        {
            //Get selected item
            string project = projectListBox.SelectedItem.ToString();

            //Get first and last name and split in two variables
            string fullName = EmployeeComboBox.SelectedItem.ToString();
            string[] tmp1 = fullName.Split(',');
            string firstName = tmp1[1];
            string lastName = tmp1[0];

            employees selectedEmployee = null;
            projects selectedProject = null;

            try
            {
                selectedProject = data.projects.Where(p => p.name == project).FirstOrDefault();
                selectedEmployee = data.employees.Where(emp => emp.name == firstName && emp.surname == lastName).FirstOrDefault();
                working_on deleteWorkingOn = data.working_on.Where(w => w.project_id == selectedProject.id && w.emp_bsn == selectedEmployee.bsn).FirstOrDefault();

                data.working_on.Remove(deleteWorkingOn);
                data.SaveChanges();

                MessageBox.Show("Assigned project removed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with removing assigned project!");
                Console.WriteLine(ex);
            }

            projectListBox.Items.Clear();
            projectListBox.ResetText();
            GetProjects(selectedEmployee.bsn);
        }

        /* END OF BUTTON HANDLERS */

    }
}
