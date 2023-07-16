using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C968_InventoryManagementSystem_AustinTownsend
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();

            //Initialize the "All Associated Parts" table with the AllParts binding list
            AddProductAllPartsDGV.DataSource = Inventory.AllParts;

            //Initialize a new associated parts binding list for the second table
            AddProductAssociatedPartsDGV.DataSource = new BindingList<Part>();
        }

        private void AddProductIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddProductsCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProductSearchButton_Click(object sender, EventArgs e)
        {
            // Save the query as a variable to run the search algorithm
            var searchQuery = AddProductSearchTextbox.Text.Trim().ToLower();

            // When the search box is empty, display all parts
            if (string.IsNullOrEmpty(searchQuery))
            {
                AddProductAllPartsDGV.DataSource = new BindingList<Part>(Inventory.AllParts);
            }
            else
            {
                var matchingParts = Inventory.AllParts.Where(p => p.Name.ToLower().Contains(searchQuery) || p.PartID.ToString().Contains(searchQuery)).ToList();

                if (!matchingParts.Any()) 
                {
                    MessageBox.Show("Part matching search could not be found.");
                }
                else
                {
                    AddProductAllPartsDGV.DataSource = new BindingList<Part>(matchingParts);
                }
            }
        }

        private void AddProductAddButton_Click(object sender, EventArgs e)
        {
            var selectedPart = (Part)AddProductAllPartsDGV.CurrentRow.DataBoundItem;

            ((BindingList<Part>)AddProductAssociatedPartsDGV.DataSource).Add(selectedPart);
        }

        private void AddProductDeleteButton_Click(object sender, EventArgs e)
        {
            var selectedPart = (Part)AddProductAssociatedPartsDGV.CurrentRow.DataBoundItem;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ((BindingList<Part>)AddProductAssociatedPartsDGV.DataSource).Remove(selectedPart);
            }
        }

        private void AddProductsSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Detect non-numeric values in textboxes that expect numeric values
                if (!int.TryParse(AddProductInventoryTextbox.Text, out int inventory))
                    throw new ArgumentException("Inventory should be numeric.");

                if (!decimal.TryParse(AddProductPriceTextbox.Text, out decimal price))
                    throw new ArgumentException("Price should be numeric.");

                if (!int.TryParse(AddProductMaxTextbox.Text, out int max))
                    throw new ArgumentException("Max should be numeric.");

                if (!int.TryParse(AddProductMinTextbox.Text, out int min))
                    throw new ArgumentException("Min should be numeric.");

                // Min should be less than Max; and Inv should be between those two values
                if (min >= max)
                    throw new ArgumentException("Min should be less than Max.");

                if (inventory < min || inventory > max)
                    throw new ArgumentException("Inventory should be between Min and Max.");

                // Creating a new Product and adding the associated parts
                var newProduct = new Product()
                {
                    Name = AddProductNameTextbox.Text,
                    Price = price,
                    InStock = inventory,
                    Min = min,
                    Max = max,
                };

                foreach (DataGridViewRow row in AddProductAssociatedPartsDGV.Rows)
                {
                    newProduct.AddAssociatedPart((Part)row.DataBoundItem);
                }

                // Adding the new Product to the Inventory
                Inventory.AddProduct(newProduct);

                // Closing the AddProduct form and returning to the main form
                this.Close();
            }
            catch (Exception ex)
            {
                // Display an error message if an exception is thrown.
                MessageBox.Show(ex.Message);
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            AddProductIDTextbox.Text = Inventory.nextProductID.ToString();
        }
    }
}
