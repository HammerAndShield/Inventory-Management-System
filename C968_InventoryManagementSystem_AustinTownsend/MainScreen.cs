using System.ComponentModel;
using System.Linq;

namespace C968_InventoryManagementSystem_AustinTownsend
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            PartDataGrid.DataSource = Inventory.AllParts;
            ProductDataGrid.DataSource = Inventory.Products;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddPartsButton_Click(object sender, EventArgs e)
        {
            var addPartForm = new AddPart();
            addPartForm.FormClosed += new FormClosedEventHandler(FormClosedShow);
            addPartForm.Show();
            this.Hide();
        }


        private void FormClosedShow(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void AddProductsButton_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProduct();
            addProductForm.FormClosed += new FormClosedEventHandler(FormClosedShow);
            addProductForm.Show();
            this.Hide();
        }

        private void ModifyPartsButton_Click(object sender, EventArgs e)
        {
            if (PartDataGrid.CurrentRow != null)
            {
                var selectedPart = (Part)PartDataGrid.CurrentRow.DataBoundItem;
                var modifyPartForm = new ModifyPart(selectedPart);
                modifyPartForm.FormClosed += new FormClosedEventHandler(FormClosedShow);
                modifyPartForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No part selected.");
            }
        }

        private void ModifyProductsButton_Click(object sender, EventArgs e)
        {
            if (ProductDataGrid.CurrentRow != null)
            {
                var selectedProduct = (Product)ProductDataGrid.CurrentRow.DataBoundItem;
                var modifyProductForm = new ModifyProduct(selectedProduct);
                modifyProductForm.FormClosed += new FormClosedEventHandler(FormClosedShow);
                modifyProductForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No product selected.");
            }
        }

        private void DeletePartsButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected.
                if (PartDataGrid.CurrentRow == null)
                    throw new InvalidOperationException("No part selected.");

                // Get the selected part from the DataGrid       
                Part selectedPart = (Part)PartDataGrid.CurrentRow.DataBoundItem;

                // Prevent the user from deleting a part that has a product associated with it.
                foreach (Product product in Inventory.Products)
                {
                    if (product.AssociatedParts.Contains(selectedPart))
                    {
                        throw new InvalidOperationException("Cannot delete a part that has a product associated with it.");
                    }
                }

                // Confirm "Delete" actions
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (!Inventory.DeletePart(selectedPart))
                    {
                        throw new InvalidOperationException("Failed to delete the part.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Display an error message if an exception is thrown.
                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteProductsButton_Click(object sender, EventArgs e)
        {
            if (ProductDataGrid.SelectedCells.Count > 0)
            {
                int selectedRowIndex = ProductDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = ProductDataGrid.Rows[selectedRowIndex];

                Product selectedProduct = (Product)selectedRow.DataBoundItem;

                if (selectedProduct.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete a product that has associated parts.", "Error");
                }
                else
                {
                    DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this product?",
                                                                 "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        bool success = Inventory.RemoveProduct(selectedProduct.ProductId);
                        if (success)
                        {
                            MessageBox.Show("Product Deleted");
                        }
                        else
                        {
                            MessageBox.Show("Product not found, and not deleted.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No product selected", "Error");
            }
        }

        private void SearchButtonParts_Click(object sender, EventArgs e)
        {
            // Filter the AllParts BindingList based on the search query and update the DataGridView
            var searchQuery = SearchPartsTextbox.Text.Trim().ToLower();

            // When the search box is empty, display all parts
            if (string.IsNullOrEmpty(searchQuery))
            {
                PartDataGrid.DataSource = new BindingList<Part>(Inventory.AllParts);
            }
            else
            {
                PartDataGrid.DataSource = new BindingList<Part>(
                Inventory.AllParts.Where(p => p.Name.ToLower().Contains(searchQuery)).ToList());
            }
        }

        private void SearchButtonProducts_Click(object sender, EventArgs e)
        {
            // Filter the AllParts BindingList based on the search query and update the DataGridView
            var searchQuery = SearchProductsTextbox.Text.Trim().ToLower();

            // When the search box is empty, display all parts
            if (string.IsNullOrEmpty(searchQuery))
            {
                ProductDataGrid.DataSource = new BindingList<Product>(Inventory.Products);
            }
            else
            {
                ProductDataGrid.DataSource = new BindingList<Product>(
                Inventory.Products.Where(p => p.Name.ToLower().Contains(searchQuery)).ToList());
            }
        }

    }
}