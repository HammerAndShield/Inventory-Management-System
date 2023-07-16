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
                ModifyProductIDTextbox.Text = productToModify.ProductId.ToString();
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
            // Filter the AllParts BindingList based on the search query and update the DataGridView
            var searchQuery = ModifyProductSearchTextbox.Text.Trim().ToLower();

            // When the search box is empty, display all parts
            if (string.IsNullOrEmpty(searchQuery))
            {
                ModifyProductAllPartsDGV.DataSource = new BindingList<Part>(Inventory.AllParts);
            }
            else
            {
                ModifyProductAllPartsDGV.DataSource = new BindingList<Part>(
                Inventory.AllParts.Where(p => p.Name.ToLower().Contains(searchQuery)).ToList());
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
                // Test that Inventory, Price, Max and Min are numeric values
                if (!int.TryParse(ModifyProductInventoryTextbox.Text, out int inv) ||
                    !decimal.TryParse(ModifyProductPriceTextbox.Text, out decimal price) ||
                    !int.TryParse(ModifyProductMaxTextbox.Text, out int max) ||
                    !int.TryParse(ModifyProductMinTextbox.Text, out int min))
                {
                    throw new FormatException("Inventory, Price, Max, and Min must be numeric values.");
                }

                // Handle Min > Max and Inv not between Min and Max
                if (min > max)
                {
                    throw new InvalidOperationException("Min must be less than Max.");
                }
                if (inv < min || inv > max)
                {
                    throw new InvalidOperationException("Inv must be between Min and Max.");
                }

                // If no exceptions were thrown, update the product
                productToModify.Name = ModifyProductNameTextbox.Text;
                productToModify.Price = price;
                productToModify.InStock = inv;
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
