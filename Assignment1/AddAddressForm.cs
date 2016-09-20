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
    public partial class AddAddressForm : Form
    {
        public string EmpBSN { get; set; }
        DBModel data = new DBModel();

        public AddAddressForm(string bsn)
        {
            InitializeComponent();

            EmpBSN = bsn;

            this.FormClosing += AddAddressForm_FormClosing;
        }

        private void AddAddressForm_FormClosing(object sender, FormClosingEventArgs e)
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
            //Get info from textboxes
            string street = streetBox.Text;
            string number = numberBox.Text;
            string postal = postalBox.Text;
            string city = cityBox.Text;
            string country = countryBox.Text;

            try
            {
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

                //Create new employee_addresses object and insert in db
                employee_addresses employee_address = new employee_addresses();
                employee_address.addr_postal = postal;
                employee_address.addr_country = country;
                employee_address.emp_bsn = EmpBSN;

                data.employee_addresses.Add(employee_address);
                data.SaveChanges();

                MessageBox.Show("Address added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with adding address!");
                Console.WriteLine(ex);
            }


            EmployeeForm ef = new EmployeeForm();
            ef.Show();
            this.Hide();
        }
    }
}
