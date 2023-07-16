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
    }
}
