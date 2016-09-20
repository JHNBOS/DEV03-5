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
    public partial class PositionsForm : Form
    {
        DBModel data = new DBModel();

        public PositionsForm()
        {
            InitializeComponent();

            this.FormClosing += PositionsForm_FormClosing;

            UpdateButton.Enabled = false;

            //Execute methods
            FillComboBox();
        }

        private void PositionsForm_FormClosing(object sender, FormClosingEventArgs e)
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
            //List of all positions
            List<positions> allPositions = null;

            try
            {
                allPositions = data.positions.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't load available positions!");
                Console.WriteLine(ex);
            }

            //Add positions to the comboboxes
            for (int i = 0; i < allPositions.Count; i++)
            {
                positions pos = allPositions[i];
                PositionsComboBox.Items.Add(pos.name);
            }
        }

        private void getSelectedPosition()
        {
            //Disable buttons
            SelectButton.Enabled = false;
            EditButton.Enabled = false;
            AddButton.Enabled = false;
            UpdateButton.Enabled = false;
            deleteButton.Enabled = false;

            //Read only
            pnameBox.ReadOnly = true;
            feeBox.ReadOnly = true;
            descriptionBox.ReadOnly = true;

            //Get selected position
            string position = PositionsComboBox.SelectedItem.ToString();

            positions pos = data.positions.Where(p => p.name == position).FirstOrDefault();

            pnameBox.Text = pos.name;
            feeBox.Text = "€" + pos.fee;
            descriptionBox.Text = pos.description;
        }

        private void ClearAll()
        {
            //Re-enable buttons
            SelectButton.Enabled = true;
            EditButton.Enabled = true;
            AddButton.Enabled = true;
            UpdateButton.Enabled = true;
            deleteButton.Enabled = true;

            //Read only
            pnameBox.ReadOnly = false;
            feeBox.ReadOnly = false;
            descriptionBox.ReadOnly = false;

            //Clear fields
            pnameBox.Clear();
            feeBox.Clear();
            descriptionBox.Clear();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            getSelectedPosition();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            getSelectedPosition();

            pnameBox.ReadOnly = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

      
        private void AddButton_Click(object sender, EventArgs e)
        { 
            //Position info
            string pName = pnameBox.Text;
            string fee = feeBox.Text;
            decimal Fee = Convert.ToDecimal(fee);
            string desc = descriptionBox.Text;


            try
            {
                positions pos = new positions();
                pos.name = pName;
                pos.fee = Fee;
                pos.description = desc;

                data.positions.Add(pos);
                data.SaveChanges();

                MessageBox.Show("New job position added!");

                //Clear fields
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Job Position couldn't be added!");

                //Clear fields
                ClearAll();

                Console.WriteLine(ex);
            }

            //Renew all comboboxes
            PositionsComboBox.Items.Clear();
            PositionsComboBox.ResetText();
            FillComboBox();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            decimal Fee = Convert.ToDecimal(feeBox.Text);

            positions newPos = new positions();
            newPos.name = pnameBox.Text;
            newPos.fee = Fee;
            newPos.description = descriptionBox.Text;

            string query = "UPDATE positions SET name=@P0, fee=@P1, description=@P2 WHERE name=@P3";

            List<object> parameterList = new List<object>();
            parameterList.Add(newPos.name);
            parameterList.Add(newPos.fee);
            parameterList.Add(newPos.description);
            parameterList.Add(newPos.name);

            object[] parameters = parameterList.ToArray();

            try
            {
                data.Database.ExecuteSqlCommand(query, parameters);
                data.SaveChanges();

                MessageBox.Show("Job Position information updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't update information!");
                Console.WriteLine(ex);
            }

            //Clear fields
            ClearAll();

            //Renew all comboboxes
            PositionsComboBox.Items.Clear();
            PositionsComboBox.ResetText();
            FillComboBox();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Get selected item
            string position = PositionsComboBox.SelectedItem.ToString();

            DialogResult delete = MessageBox.Show("Are you sure you want to remove this job position?",
                "Removing...",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            try
            {
                if (delete == DialogResult.Yes)
                {
                    positions deletePosition = data.positions.Where(p => p.name == position).FirstOrDefault();
                    List<employee_positions> deleteEmployeePositionsList = data.employee_positions.Where(ep => ep.name == deletePosition.name).ToList();
                    List<assigned> deleteAssignedPositionsList = data.assigned.Where(a => a.position_name == deletePosition.name).ToList();

                    data.employee_positions.RemoveRange(deleteEmployeePositionsList);
                    data.assigned.RemoveRange(deleteAssignedPositionsList);
                    data.positions.Remove(deletePosition);

                    data.SaveChanges();

                    MessageBox.Show("Job Position removed!");
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

            PositionsComboBox.Items.Clear();
            PositionsComboBox.ResetText();
            FillComboBox();
        }
    }
}
