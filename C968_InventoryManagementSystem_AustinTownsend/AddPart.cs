using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_InventoryManagementSystem_AustinTownsend
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();

            AddPartInHouseRadio.Checked = true;
        }

        private void AddPartInHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (AddPartInHouseRadio.Checked)
            {
                AddPartMachineIDLabel.Text = "Machine ID";
            }
        }

        private void AddPartOutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (AddPartOutsourcedRadio.Checked)
            {
                AddPartMachineIDLabel.Text = "Company Name";
            }
        }

        private void AddPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPartSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather data from the form controls.
                string name = AddPartNameTextbox.Text;

                // Detect non-numeric values in textboxes that expect numeric values
                if (!decimal.TryParse(AddPartPriceTextbox.Text, out decimal price))
                    throw new ArgumentException("Please enter a numeric value for the price.");

                if (!int.TryParse(AddPartInventoryTextbox.Text, out int inStock))
                    throw new ArgumentException("Please enter a numeric value for the inventory level.");

                if (!int.TryParse(AddPartMinTextbox.Text, out int min))
                    throw new ArgumentException("Please enter a numeric value for the minimum value.");

                if (!int.TryParse(AddPartMaxTextbox.Text, out int max))
                    throw new ArgumentException("Please enter a numeric value for the maximum value.");

                // Min should be less than Max; and Inv should be between those two values
                if (min >= max)
                    throw new ArgumentException("Minimum value should be less than maximum value.");

                if (inStock < min || inStock > max)
                    throw new ArgumentException("Inventory level should be between minimum and maximum values.");

                // If "In-House" is selected, create an Inhouse part.
                // Otherwise, create an Outsourced part.
                if (AddPartInHouseRadio.Checked)
                {
                    if (!int.TryParse(AddPartMachineIDTextbox.Text, out int machineID))
                        throw new ArgumentException("Please enter a numeric value for the machine ID.");

                    var part = new Inhouse { Name = name, Price = price, InStock = inStock, Min = min, Max = max, MachineID = machineID };
                    Inventory.AddPart(part);
                }
                else
                {
                    string companyName = AddPartMachineIDTextbox.Text;
                    var part = new Outsourced { Name = name, Price = price, InStock = inStock, Min = min, Max = max, CompanyName = companyName };
                    Inventory.AddPart(part);
                }

                // Close this form and go back to the main form.
                this.Close();
            }
            catch (ArgumentException ex)
            {
                // Display an error message if a validation fails.
                MessageBox.Show(ex.Message);
            }
        }
    }
}
