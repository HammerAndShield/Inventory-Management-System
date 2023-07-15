namespace C968_InventoryManagementSystem_AustinTownsend
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddProductLabel = new Label();
            AddProductIDLabel = new Label();
            AddProductIDTextbox = new TextBox();
            AddProductNameTextbox = new TextBox();
            AddProductNameLabel = new Label();
            AddProductInventoryTextbox = new TextBox();
            AddProductInventoryLabel = new Label();
            AddProductPriceTextbox = new TextBox();
            AddProductPriceLabel = new Label();
            AddProductMaxLabel = new Label();
            AddProductMaxTextbox = new TextBox();
            AddProductMinTextbox = new TextBox();
            AddProductMinLabel = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            AddProductAllPartsLabel = new Label();
            AddProductsAssociatedPartsLabel = new Label();
            AddProductAddButton = new Button();
            AddProductDeleteButton = new Button();
            AddProductsSaveButton = new Button();
            AddProductsCancelButton = new Button();
            AddProductSearchButton = new Button();
            AddProductSearchTextbox = new TextBox();
            PartID = new DataGridViewTextBoxColumn();
            PartName = new DataGridViewTextBoxColumn();
            PartInventory = new DataGridViewTextBoxColumn();
            PartPrice = new DataGridViewTextBoxColumn();
            PartMin = new DataGridViewTextBoxColumn();
            PartMax = new DataGridViewTextBoxColumn();
            PartID2 = new DataGridViewTextBoxColumn();
            PartName2 = new DataGridViewTextBoxColumn();
            PartInventory2 = new DataGridViewTextBoxColumn();
            PartPrice2 = new DataGridViewTextBoxColumn();
            PartMin2 = new DataGridViewTextBoxColumn();
            PartMax2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // AddProductLabel
            // 
            AddProductLabel.AutoSize = true;
            AddProductLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddProductLabel.Location = new Point(12, 9);
            AddProductLabel.Name = "AddProductLabel";
            AddProductLabel.Size = new Size(182, 38);
            AddProductLabel.TabIndex = 0;
            AddProductLabel.Text = "Add Product";
            // 
            // AddProductIDLabel
            // 
            AddProductIDLabel.AutoSize = true;
            AddProductIDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddProductIDLabel.Location = new Point(54, 213);
            AddProductIDLabel.Name = "AddProductIDLabel";
            AddProductIDLabel.Size = new Size(31, 28);
            AddProductIDLabel.TabIndex = 1;
            AddProductIDLabel.Text = "ID";
            AddProductIDLabel.Click += AddProductIDLabel_Click;
            // 
            // AddProductIDTextbox
            // 
            AddProductIDTextbox.Location = new Point(167, 213);
            AddProductIDTextbox.Name = "AddProductIDTextbox";
            AddProductIDTextbox.Size = new Size(173, 27);
            AddProductIDTextbox.TabIndex = 2;
            // 
            // AddProductNameTextbox
            // 
            AddProductNameTextbox.Location = new Point(167, 259);
            AddProductNameTextbox.Name = "AddProductNameTextbox";
            AddProductNameTextbox.Size = new Size(173, 27);
            AddProductNameTextbox.TabIndex = 4;
            // 
            // AddProductNameLabel
            // 
            AddProductNameLabel.AutoSize = true;
            AddProductNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddProductNameLabel.Location = new Point(54, 258);
            AddProductNameLabel.Name = "AddProductNameLabel";
            AddProductNameLabel.Size = new Size(64, 28);
            AddProductNameLabel.TabIndex = 3;
            AddProductNameLabel.Text = "Name";
            // 
            // AddProductInventoryTextbox
            // 
            AddProductInventoryTextbox.Location = new Point(167, 305);
            AddProductInventoryTextbox.Name = "AddProductInventoryTextbox";
            AddProductInventoryTextbox.Size = new Size(173, 27);
            AddProductInventoryTextbox.TabIndex = 6;
            // 
            // AddProductInventoryLabel
            // 
            AddProductInventoryLabel.AutoSize = true;
            AddProductInventoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddProductInventoryLabel.Location = new Point(54, 304);
            AddProductInventoryLabel.Name = "AddProductInventoryLabel";
            AddProductInventoryLabel.Size = new Size(95, 28);
            AddProductInventoryLabel.TabIndex = 5;
            AddProductInventoryLabel.Text = "Inventory";
            // 
            // AddProductPriceTextbox
            // 
            AddProductPriceTextbox.Location = new Point(167, 354);
            AddProductPriceTextbox.Name = "AddProductPriceTextbox";
            AddProductPriceTextbox.Size = new Size(173, 27);
            AddProductPriceTextbox.TabIndex = 8;
            // 
            // AddProductPriceLabel
            // 
            AddProductPriceLabel.AutoSize = true;
            AddProductPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddProductPriceLabel.Location = new Point(54, 353);
            AddProductPriceLabel.Name = "AddProductPriceLabel";
            AddProductPriceLabel.Size = new Size(54, 28);
            AddProductPriceLabel.TabIndex = 7;
            AddProductPriceLabel.Text = "Price";
            // 
            // AddProductMaxLabel
            // 
            AddProductMaxLabel.AutoSize = true;
            AddProductMaxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddProductMaxLabel.Location = new Point(54, 401);
            AddProductMaxLabel.Name = "AddProductMaxLabel";
            AddProductMaxLabel.Size = new Size(49, 28);
            AddProductMaxLabel.TabIndex = 9;
            AddProductMaxLabel.Text = "Max";
            // 
            // AddProductMaxTextbox
            // 
            AddProductMaxTextbox.Location = new Point(167, 401);
            AddProductMaxTextbox.Name = "AddProductMaxTextbox";
            AddProductMaxTextbox.Size = new Size(82, 27);
            AddProductMaxTextbox.TabIndex = 10;
            // 
            // AddProductMinTextbox
            // 
            AddProductMinTextbox.Location = new Point(362, 401);
            AddProductMinTextbox.Name = "AddProductMinTextbox";
            AddProductMinTextbox.Size = new Size(82, 27);
            AddProductMinTextbox.TabIndex = 12;
            // 
            // AddProductMinLabel
            // 
            AddProductMinLabel.AutoSize = true;
            AddProductMinLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddProductMinLabel.Location = new Point(278, 401);
            AddProductMinLabel.Name = "AddProductMinLabel";
            AddProductMinLabel.Size = new Size(46, 28);
            AddProductMinLabel.TabIndex = 11;
            AddProductMinLabel.Text = "Min";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PartID, PartName, PartInventory, PartPrice, PartMin, PartMax });
            dataGridView1.Location = new Point(545, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(613, 219);
            dataGridView1.TabIndex = 13;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { PartID2, PartName2, PartInventory2, PartPrice2, PartMin2, PartMax2 });
            dataGridView2.Location = new Point(545, 401);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(613, 219);
            dataGridView2.TabIndex = 14;
            // 
            // AddProductAllPartsLabel
            // 
            AddProductAllPartsLabel.AutoSize = true;
            AddProductAllPartsLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            AddProductAllPartsLabel.Location = new Point(545, 60);
            AddProductAllPartsLabel.Name = "AddProductAllPartsLabel";
            AddProductAllPartsLabel.Size = new Size(160, 25);
            AddProductAllPartsLabel.TabIndex = 15;
            AddProductAllPartsLabel.Text = "All Candidate Parts";
            // 
            // AddProductsAssociatedPartsLabel
            // 
            AddProductsAssociatedPartsLabel.AutoSize = true;
            AddProductsAssociatedPartsLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            AddProductsAssociatedPartsLabel.Location = new Point(545, 356);
            AddProductsAssociatedPartsLabel.Name = "AddProductsAssociatedPartsLabel";
            AddProductsAssociatedPartsLabel.Size = new Size(279, 25);
            AddProductsAssociatedPartsLabel.TabIndex = 16;
            AddProductsAssociatedPartsLabel.Text = "Parts Associated with this Product";
            // 
            // AddProductAddButton
            // 
            AddProductAddButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddProductAddButton.Location = new Point(1064, 323);
            AddProductAddButton.Name = "AddProductAddButton";
            AddProductAddButton.Size = new Size(94, 39);
            AddProductAddButton.TabIndex = 17;
            AddProductAddButton.Text = "Add";
            AddProductAddButton.UseVisualStyleBackColor = true;
            // 
            // AddProductDeleteButton
            // 
            AddProductDeleteButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddProductDeleteButton.Location = new Point(1064, 636);
            AddProductDeleteButton.Name = "AddProductDeleteButton";
            AddProductDeleteButton.Size = new Size(94, 39);
            AddProductDeleteButton.TabIndex = 18;
            AddProductDeleteButton.Text = "Delete";
            AddProductDeleteButton.UseVisualStyleBackColor = true;
            // 
            // AddProductsSaveButton
            // 
            AddProductsSaveButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddProductsSaveButton.Location = new Point(940, 692);
            AddProductsSaveButton.Name = "AddProductsSaveButton";
            AddProductsSaveButton.Size = new Size(94, 39);
            AddProductsSaveButton.TabIndex = 19;
            AddProductsSaveButton.Text = "Save";
            AddProductsSaveButton.UseVisualStyleBackColor = true;
            // 
            // AddProductsCancelButton
            // 
            AddProductsCancelButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddProductsCancelButton.Location = new Point(1064, 692);
            AddProductsCancelButton.Name = "AddProductsCancelButton";
            AddProductsCancelButton.Size = new Size(94, 39);
            AddProductsCancelButton.TabIndex = 20;
            AddProductsCancelButton.Text = "Cancel";
            AddProductsCancelButton.UseVisualStyleBackColor = true;
            // 
            // AddProductSearchButton
            // 
            AddProductSearchButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddProductSearchButton.Location = new Point(853, 35);
            AddProductSearchButton.Name = "AddProductSearchButton";
            AddProductSearchButton.Size = new Size(94, 29);
            AddProductSearchButton.TabIndex = 21;
            AddProductSearchButton.Text = "Search";
            AddProductSearchButton.UseVisualStyleBackColor = true;
            // 
            // AddProductSearchTextbox
            // 
            AddProductSearchTextbox.Location = new Point(953, 36);
            AddProductSearchTextbox.Name = "AddProductSearchTextbox";
            AddProductSearchTextbox.Size = new Size(205, 27);
            AddProductSearchTextbox.TabIndex = 22;
            // 
            // PartID
            // 
            PartID.HeaderText = "Part ID";
            PartID.MinimumWidth = 6;
            PartID.Name = "PartID";
            // 
            // PartName
            // 
            PartName.HeaderText = "Name";
            PartName.MinimumWidth = 6;
            PartName.Name = "PartName";
            // 
            // PartInventory
            // 
            PartInventory.HeaderText = "Inventory";
            PartInventory.MinimumWidth = 6;
            PartInventory.Name = "PartInventory";
            // 
            // PartPrice
            // 
            PartPrice.HeaderText = "Price";
            PartPrice.MinimumWidth = 6;
            PartPrice.Name = "PartPrice";
            // 
            // PartMin
            // 
            PartMin.HeaderText = "Min";
            PartMin.MinimumWidth = 6;
            PartMin.Name = "PartMin";
            // 
            // PartMax
            // 
            PartMax.HeaderText = "Max";
            PartMax.MinimumWidth = 6;
            PartMax.Name = "PartMax";
            // 
            // PartID2
            // 
            PartID2.HeaderText = "Part ID";
            PartID2.MinimumWidth = 6;
            PartID2.Name = "PartID2";
            // 
            // PartName2
            // 
            PartName2.HeaderText = "Name";
            PartName2.MinimumWidth = 6;
            PartName2.Name = "PartName2";
            // 
            // PartInventory2
            // 
            PartInventory2.HeaderText = "Inventory";
            PartInventory2.MinimumWidth = 6;
            PartInventory2.Name = "PartInventory2";
            // 
            // PartPrice2
            // 
            PartPrice2.HeaderText = "Price";
            PartPrice2.MinimumWidth = 6;
            PartPrice2.Name = "PartPrice2";
            // 
            // PartMin2
            // 
            PartMin2.HeaderText = "Min";
            PartMin2.MinimumWidth = 6;
            PartMin2.Name = "PartMin2";
            // 
            // PartMax2
            // 
            PartMax2.HeaderText = "Max";
            PartMax2.MinimumWidth = 6;
            PartMax2.Name = "PartMax2";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 753);
            Controls.Add(AddProductSearchTextbox);
            Controls.Add(AddProductSearchButton);
            Controls.Add(AddProductsCancelButton);
            Controls.Add(AddProductsSaveButton);
            Controls.Add(AddProductDeleteButton);
            Controls.Add(AddProductAddButton);
            Controls.Add(AddProductsAssociatedPartsLabel);
            Controls.Add(AddProductAllPartsLabel);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(AddProductMinTextbox);
            Controls.Add(AddProductMinLabel);
            Controls.Add(AddProductMaxTextbox);
            Controls.Add(AddProductMaxLabel);
            Controls.Add(AddProductPriceTextbox);
            Controls.Add(AddProductPriceLabel);
            Controls.Add(AddProductInventoryTextbox);
            Controls.Add(AddProductInventoryLabel);
            Controls.Add(AddProductNameTextbox);
            Controls.Add(AddProductNameLabel);
            Controls.Add(AddProductIDTextbox);
            Controls.Add(AddProductIDLabel);
            Controls.Add(AddProductLabel);
            Name = "AddProduct";
            Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddProductLabel;
        private Label AddProductIDLabel;
        private TextBox AddProductIDTextbox;
        private TextBox AddProductNameTextbox;
        private Label AddProductNameLabel;
        private TextBox AddProductInventoryTextbox;
        private Label AddProductInventoryLabel;
        private TextBox AddProductPriceTextbox;
        private Label AddProductPriceLabel;
        private Label AddProductMaxLabel;
        private TextBox AddProductMaxTextbox;
        private TextBox AddProductMinTextbox;
        private Label AddProductMinLabel;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label AddProductAllPartsLabel;
        private Label AddProductsAssociatedPartsLabel;
        private Button AddProductAddButton;
        private Button AddProductDeleteButton;
        private Button AddProductsSaveButton;
        private Button AddProductsCancelButton;
        private Button AddProductSearchButton;
        private TextBox AddProductSearchTextbox;
        private DataGridViewTextBoxColumn PartID;
        private DataGridViewTextBoxColumn PartName;
        private DataGridViewTextBoxColumn PartInventory;
        private DataGridViewTextBoxColumn PartPrice;
        private DataGridViewTextBoxColumn PartMin;
        private DataGridViewTextBoxColumn PartMax;
        private DataGridViewTextBoxColumn PartID2;
        private DataGridViewTextBoxColumn PartName2;
        private DataGridViewTextBoxColumn PartInventory2;
        private DataGridViewTextBoxColumn PartPrice2;
        private DataGridViewTextBoxColumn PartMin2;
        private DataGridViewTextBoxColumn PartMax2;
    }
}