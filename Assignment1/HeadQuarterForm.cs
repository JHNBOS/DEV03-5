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
    public partial class HeadQuarterForm : Form
    {
        DBModel data = new DBModel();

        public HeadQuarterForm()
        {
            InitializeComponent();

            this.FormClosing += HeadQuarterForm_FormClosing;

            //Methods to execute
            FillComboBox();
        }

        private void HeadQuarterForm_FormClosing(object sender, FormClosingEventArgs e)
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
            //List of all headquarters
            List<headquarters> allHeadquartersList = data.headquarters.ToList();

            //Add name of headquarters to combobox
            for (int i = 0; i < allHeadquartersList.Count; i++)
            {
                headquarters headquarter = allHeadquartersList[i];
                HQComboBox.Items.Add(headquarter.name);
            }
        }

        private void GetSelectedHQ()
        {
            //get name selected headquarter
            string name = HQComboBox.SelectedItem.ToString();

            //Instance of selected headquarter
            headquarters selectedHeadQuarter = data.headquarters.Where(hq => hq.name == name).FirstOrDefault();

            //Headquarter info
            int? numberRooms = selectedHeadQuarter.rooms;
            decimal? rent = selectedHeadQuarter.rent;

            bnameBox.Text = name;
            roomsUpDown.Value = Convert.ToDecimal(numberRooms);
            rentBox.Text = rent.ToString();

            //Run method(s) to get other information
            GetAddress(name);
        }

        private void GetAddress(string headquarterName)
        {
            //1. List of junction table rows between headquarters and addresses
            //2. List of addresses
            List<headquarter_addresses> addressJunction = null;
            List<addresses> addressList = new List<addresses>();

            try
            {
                addressJunction = data.headquarter_addresses.Where(e => e.hq_name == headquarterName).ToList();

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

            //Set text of TextBoxes to the address of headquarter
            foreach (var addresses in addressList)
            {
                string street = addresses.street;
                string number = addresses.number;
                string postal = addresses.postal_code;
                string city = addresses.city;
                string country = addresses.country;

                streetBox.Text = street;
                numberBox.Text = number;
                postalBox.Text = postal;
                cityBox.Text = city;
                countryBox.Text = country;
            }
        }

        private void ClearAll()
        {
            //Re-enable buttons
            AddButton.Enabled = true;
            SelectButton.Enabled = true;
            EditButton.Enabled = true;
            UpdateButton.Enabled = true;

            //Readonly to false;
            bnameBox.ReadOnly = false;
            roomsUpDown.ReadOnly = false;
            rentBox.ReadOnly = false;
            streetBox.ReadOnly = false;
            numberBox.ReadOnly = false;
            postalBox.ReadOnly = false;
            cityBox.ReadOnly = false;
            countryBox.ReadOnly = false;

            //Clear fields
            bnameBox.Clear();
            roomsUpDown.Value = 0;
            rentBox.Clear();
            streetBox.Clear();
            numberBox.Clear();
            postalBox.Clear();
            cityBox.Clear();
            countryBox.Clear();
        }


        private void SelectButton_Click(object sender, EventArgs e)
        {
            GetSelectedHQ();

            EditButton.Enabled = false;
            AddButton.Enabled = false;
            SelectButton.Enabled = false;
            UpdateButton.Enabled = false;

            //Readonly to false;
            bnameBox.ReadOnly = true;
            rentBox.ReadOnly = false;
            roomsUpDown.ReadOnly = false;
            streetBox.ReadOnly = false;
            numberBox.ReadOnly = false;
            postalBox.ReadOnly = false;
            cityBox.ReadOnly = false;
            countryBox.ReadOnly = false;

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            GetSelectedHQ();

            EditButton.Enabled = false;
            AddButton.Enabled = false;
            SelectButton.Enabled = false;
            UpdateButton.Enabled = true;

            //Readonly to false;
            bnameBox.ReadOnly = true;
            rentBox.ReadOnly = false;
            roomsUpDown.ReadOnly = false;
            streetBox.ReadOnly = false;
            numberBox.ReadOnly = false;
            postalBox.ReadOnly = false;
            cityBox.ReadOnly = false;
            countryBox.ReadOnly = false;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Headquarter info
            string name = bnameBox.Text;
            int roomNumber = Convert.ToInt32(roomsUpDown.Value);
            int rent = int.Parse(rentBox.Text);

            //Address info
            string street = streetBox.Text;
            string number = numberBox.Text;
            string postal = postalBox.Text;
            string city = cityBox.Text;
            string country = countryBox.Text;

            try
            {
                //Create new headquarter object and insert into db
                headquarters headquarter = new headquarters();
                headquarter.name = name;
                headquarter.rooms = roomNumber;
                headquarter.rent = rent;

                data.headquarters.Add(headquarter);
                data.SaveChanges();


                //Create new address object and insert into db after checking for duplicates
                addresses address = new addresses();
                address.street = street;
                address.number = number;
                address.postal_code = postal;
                address.city = city;
                address.country = country;

                bool copyFound = false;

                List<addresses> compareList = data.addresses.ToList();

                Console.WriteLine("compareList count: " + compareList.Count);

                foreach (addresses addr in compareList)
                {
                    if (address.street == addr.street && address.number == addr.number 
                        && address.postal_code == addr.postal_code && address.city == addr.city
                        && address.country == addr.country)
                    {
                        copyFound = true;
                        Console.WriteLine("Copy found!");
                    }
                }

                if (!copyFound)
                {
                    data.addresses.Add(address);
                    data.SaveChanges();
                    Console.WriteLine("Inserted address to DB!");
                }

                //Create new headquarter_addresses object and insert into db
                headquarter_addresses headquarter_address = new headquarter_addresses();
                headquarter_address.hq_name = headquarter.name;
                headquarter_address.addr_postal = address.postal_code;
                headquarter_address.addr_country = address.country;

                data.headquarter_addresses.Add(headquarter_address);
                data.SaveChanges();

                MessageBox.Show("New headquarter added!");

                //Clear fields
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Employee couldn't be added!");

                //Clear fields
                ClearAll();

                Console.WriteLine(ex);
            }

            //Renew all comboboxes
            FillComboBox();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            headquarters oldHeadQuarter = data.headquarters.Where(h => h.name == bnameBox.Text).FirstOrDefault();

            headquarters newHeadQuarter = new headquarters();
            newHeadQuarter.name = bnameBox.Text;
            newHeadQuarter.rent = Convert.ToInt32(rentBox.Text);
            newHeadQuarter.rooms = Convert.ToInt32(roomsUpDown.Value);

            string query = "UPDATE headquarters SET name=@P0, rent=@P1, rooms=@P2 WHERE name=@P3";

            List<object> parameterList = new List<object>();
            parameterList.Add(newHeadQuarter.name);
            parameterList.Add(newHeadQuarter.rent);
            parameterList.Add(newHeadQuarter.rooms);
            parameterList.Add(oldHeadQuarter.name);

            object[] parameters = parameterList.ToArray();

            /*-----------------------------------------------*/

            addresses oldAddress = data.addresses.Where(a => a.postal_code == postalBox.Text && a.street == streetBox.Text
            && a.number == numberBox.Text).FirstOrDefault();

            addresses newAddress = new addresses();
            newAddress.street = streetBox.Text;
            newAddress.number = numberBox.Text;
            newAddress.postal_code = postalBox.Text;
            newAddress.city = cityBox.Text;
            newAddress.country = countryBox.Text;

            string query1 = "UPDATE addresses SET street=@P0, number=@P1, postal_code=@P2, city=@P3, country=@P4" 
                + " WHERE street=@P5 AND number=@P6 AND postal_code=@P7 AND country=@P8";

            List<object> parameterList1 = new List<object>();
            parameterList1.Add(newAddress.street);
            parameterList1.Add(newAddress.number);
            parameterList1.Add(newAddress.postal_code);
            parameterList1.Add(newAddress.city);
            parameterList1.Add(newAddress.country);
            parameterList1.Add(oldAddress.street);
            parameterList1.Add(oldAddress.number);
            parameterList1.Add(oldAddress.postal_code);
            parameterList1.Add(oldAddress.country);

            object[] parameters1 = parameterList1.ToArray();

            /*-----------------------------------------------*/

            headquarter_addresses oldHeadquarterAddress = data.headquarter_addresses.Where(ha => ha.hq_name == bnameBox.Text).FirstOrDefault();

            headquarter_addresses newHeadquarterAddress = new headquarter_addresses();
            newHeadquarterAddress.hq_name = newHeadQuarter.name;
            newHeadquarterAddress.addr_postal = newAddress.postal_code;
            newHeadquarterAddress.addr_country = newAddress.country;

            string query2 = "UPDATE headquarter_addresses SET hq_name=@P0, addr_postal=@P1, addr_country=@P2 WHERE "
                + "hq_name=@P3 AND addr_postal=@P4 AND addr_country=@P5";

            List<object> parameterList2 = new List<object>();
            parameterList1.Add(newHeadquarterAddress.hq_name);
            parameterList1.Add(newHeadquarterAddress.addr_postal);
            parameterList1.Add(newHeadquarterAddress.addr_country);
            parameterList1.Add(oldHeadquarterAddress.hq_name);
            parameterList1.Add(oldHeadquarterAddress.addr_postal);
            parameterList1.Add(oldHeadquarterAddress.addr_country);

            object[] parameters2 = parameterList2.ToArray();

            try
            {
                data.Database.ExecuteSqlCommand(query2, parameters2);
                data.Database.ExecuteSqlCommand(query, parameters);
                data.Database.ExecuteSqlCommand(query1, parameters1);
                data.SaveChanges();

                MessageBox.Show("Headquarter information updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't update information!");
                Console.WriteLine(ex);
            }

            //Clear fields
            ClearAll();

            //Renew all comboboxes
            HQComboBox.Items.Clear();
            HQComboBox.ResetText();
            FillComboBox();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //Get selected headquarter to delete
            string name = bnameBox.Text;

            DialogResult delete = MessageBox.Show("Are you sure you want to remove this headquarter?",
                "Removing...",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            try
            {
                if (delete == DialogResult.Yes)
                {
                    headquarters deleteHQ = data.headquarters.Where(h => h.name == name).FirstOrDefault();
                    headquarter_addresses deleteHA = data.headquarter_addresses.Where(ha => ha.hq_name == name).FirstOrDefault();

                    data.headquarter_addresses.Remove(deleteHA);
                    data.SaveChanges();

                    data.headquarters.Remove(deleteHQ);
                    data.SaveChanges();

                    MessageBox.Show("Headquarter removed!");
                }
                if (delete == DialogResult.No || delete == DialogResult.Cancel) { }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with removing headquarter!");
                Console.WriteLine(ex);
            }

            //Renew all comboboxes
            HQComboBox.Items.Clear();
            HQComboBox.ResetText();
            FillComboBox();
        }



    }
}
