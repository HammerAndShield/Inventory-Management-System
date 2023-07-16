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
    public partial class ModifyProduct : Form
    {
        private Product productToModify;
        public ModifyProduct(Product product)
        {
            InitializeComponent();
            this.productToModify = product;
        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            if (productToModify != null)
            {
                ModifyProductIDTextbox.Text = productToModify.ProductID.ToString();
                ModifyProductNameTextbox.Text = productToModify.Name;
                ModifyProductInventoryTextbox.Text = productToModify.InStock.ToString();
                ModifyProductPriceTextbox.Text = productToModify.Price.ToString();
                ModifyProductMaxTextbox.Text = productToModify.Max.ToString();
                ModifyProductMinTextbox.Text = productToModify.Min.ToString();
                ModifyProductAssociatedPartsDGV.DataSource = productToModify.AssociatedParts;
            }

            ModifyProductAllPartsDGV.DataSource = Inventory.AllParts;
        }

        private void ModifyProductsCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyProductSearchButton_Click(object sender, EventArgs e)
        {
            // Save the search query as a variable to run the search algorithm.
            var searchQuery = ModifyProductSearchTextbox.Text.Trim().ToLower();

            // When the search box is empty, display all parts
            if (string.IsNullOrEmpty(searchQuery))
            {
                ModifyProductAllPartsDGV.DataSource = new BindingList<Part>(Inventory.AllParts);
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
                    ModifyProductAllPartsDGV.DataSource = new BindingList<Part>(matchingParts);
                }
            }
        }

        private void ModifyProductDeleteButton_Click(object sender, EventArgs e)
        {
            var selectedPart = (Part)ModifyProductAssociatedPartsDGV.CurrentRow.DataBoundItem;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ((BindingList<Part>)ModifyProductAssociatedPartsDGV.DataSource).Remove(selectedPart);
            }
        }

        private void ModifyProductAddButton_Click(object sender, EventArgs e)
        {
            var selectedPart = (Part)ModifyProductAllPartsDGV.CurrentRow.DataBoundItem;

            ((BindingList<Part>)ModifyProductAssociatedPartsDGV.DataSource).Add(selectedPart);
        }

        private void ModifyProductsSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check that all intended numeric values are numeric, and display an error if not
                if (!int.TryParse(ModifyProductInventoryTextbox.Text, out int inventory))
                    throw new ArgumentException("Inventory should be numeric.");

                if (!decimal.TryParse(ModifyProductPriceTextbox.Text, out decimal price))
                    throw new ArgumentException("Price should be numeric.");

                if (!int.TryParse(ModifyProductMaxTextbox.Text, out int max))
                    throw new ArgumentException("Max should be numeric.");

                if (!int.TryParse(ModifyProductMinTextbox.Text, out int min))
                    throw new ArgumentException("Min should be numeric.");

                // Min should be less than Max; and Inv should be between those two values
                if (min >= max)
                    throw new ArgumentException("Min should be less than Max.");

                if (inventory < min || inventory > max)
                    throw new ArgumentException("Inventory should be between Min and Max.");

                // If no exceptions were thrown, update the product
                productToModify.Name = ModifyProductNameTextbox.Text;
                productToModify.Price = price;
                productToModify.InStock = inventory;
                productToModify.Min = min;
                productToModify.Max = max;

                // Close the form and return to the main form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
