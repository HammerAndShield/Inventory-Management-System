namespace C968_InventoryManagementSystem_AustinTownsend
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainScreenTitle = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            SearchPartsTextbox = new TextBox();
            SearchButtonParts = new Button();
            SearchButtonProducts = new Button();
            SearchProductsTextBox = new TextBox();
            AddPartsButton = new Button();
            ModifyPartsButton = new Button();
            DeletePartsButton = new Button();
            DeleteProductsButton = new Button();
            ModifyProductsButton = new Button();
            AddProductsButton = new Button();
            ExitButton = new Button();
            PartID = new DataGridViewTextBoxColumn();
            PartName = new DataGridViewTextBoxColumn();
            PartInventory = new DataGridViewTextBoxColumn();
            PartPrice = new DataGridViewTextBoxColumn();
            PartMin = new DataGridViewTextBoxColumn();
            PartMax = new DataGridViewTextBoxColumn();
            ProductId = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductInventory = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            ProductMinColumn = new DataGridViewTextBoxColumn();
            ProductMaxColumn = new DataGridViewTextBoxColumn();
            MainScreenPartLabel = new Label();
            MainScreenProductLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // MainScreenTitle
            // 
            MainScreenTitle.AutoSize = true;
            MainScreenTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            MainScreenTitle.Location = new Point(12, 9);
            MainScreenTitle.Name = "MainScreenTitle";
            MainScreenTitle.Size = new Size(458, 41);
            MainScreenTitle.TabIndex = 0;
            MainScreenTitle.Text = "Inventory Management System";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PartID, PartName, PartInventory, PartPrice, PartMin, PartMax });
            dataGridView1.Location = new Point(12, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1053, 516);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ProductId, ProductName, ProductInventory, ProductPrice, ProductMinColumn, ProductMaxColumn });
            dataGridView2.Location = new Point(1137, 139);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(1053, 516);
            dataGridView2.TabIndex = 2;
            // 
            // SearchPartsTextbox
            // 
            SearchPartsTextbox.Location = new Point(850, 106);
            SearchPartsTextbox.Name = "SearchPartsTextbox";
            SearchPartsTextbox.Size = new Size(215, 27);
            SearchPartsTextbox.TabIndex = 3;
            // 
            // SearchButtonParts
            // 
            SearchButtonParts.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButtonParts.Location = new Point(750, 104);
            SearchButtonParts.Name = "SearchButtonParts";
            SearchButtonParts.Size = new Size(94, 29);
            SearchButtonParts.TabIndex = 4;
            SearchButtonParts.Text = "Search";
            SearchButtonParts.UseVisualStyleBackColor = true;
            // 
            // SearchButtonProducts
            // 
            SearchButtonProducts.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButtonProducts.Location = new Point(1875, 103);
            SearchButtonProducts.Name = "SearchButtonProducts";
            SearchButtonProducts.Size = new Size(94, 29);
            SearchButtonProducts.TabIndex = 6;
            SearchButtonProducts.Text = "Search";
            SearchButtonProducts.UseVisualStyleBackColor = true;
            // 
            // SearchProductsTextBox
            // 
            SearchProductsTextBox.Location = new Point(1975, 105);
            SearchProductsTextBox.Name = "SearchProductsTextBox";
            SearchProductsTextBox.Size = new Size(215, 27);
            SearchProductsTextBox.TabIndex = 5;
            // 
            // AddPartsButton
            // 
            AddPartsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddPartsButton.Location = new Point(795, 661);
            AddPartsButton.Name = "AddPartsButton";
            AddPartsButton.Size = new Size(86, 40);
            AddPartsButton.TabIndex = 7;
            AddPartsButton.Text = "Add";
            AddPartsButton.UseVisualStyleBackColor = true;
            // 
            // ModifyPartsButton
            // 
            ModifyPartsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ModifyPartsButton.Location = new Point(887, 661);
            ModifyPartsButton.Name = "ModifyPartsButton";
            ModifyPartsButton.Size = new Size(86, 40);
            ModifyPartsButton.TabIndex = 8;
            ModifyPartsButton.Text = "Modify";
            ModifyPartsButton.UseVisualStyleBackColor = true;
            // 
            // DeletePartsButton
            // 
            DeletePartsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeletePartsButton.Location = new Point(979, 661);
            DeletePartsButton.Name = "DeletePartsButton";
            DeletePartsButton.Size = new Size(86, 40);
            DeletePartsButton.TabIndex = 9;
            DeletePartsButton.Text = "Delete";
            DeletePartsButton.UseVisualStyleBackColor = true;
            // 
            // DeleteProductsButton
            // 
            DeleteProductsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteProductsButton.Location = new Point(2102, 661);
            DeleteProductsButton.Name = "DeleteProductsButton";
            DeleteProductsButton.Size = new Size(86, 40);
            DeleteProductsButton.TabIndex = 12;
            DeleteProductsButton.Text = "Delete";
            DeleteProductsButton.UseVisualStyleBackColor = true;
            // 
            // ModifyProductsButton
            // 
            ModifyProductsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ModifyProductsButton.Location = new Point(2010, 661);
            ModifyProductsButton.Name = "ModifyProductsButton";
            ModifyProductsButton.Size = new Size(86, 40);
            ModifyProductsButton.TabIndex = 11;
            ModifyProductsButton.Text = "Modify";
            ModifyProductsButton.UseVisualStyleBackColor = true;
            // 
            // AddProductsButton
            // 
            AddProductsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddProductsButton.Location = new Point(1918, 661);
            AddProductsButton.Name = "AddProductsButton";
            AddProductsButton.Size = new Size(86, 40);
            AddProductsButton.TabIndex = 10;
            AddProductsButton.Text = "Add";
            AddProductsButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.Location = new Point(2094, 808);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 52);
            ExitButton.TabIndex = 13;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // PartID
            // 
            PartID.HeaderText = "Part ID";
            PartID.MinimumWidth = 6;
            PartID.Name = "PartID";
            // 
            // PartName
            // 
            PartName.HeaderText = "Part Name";
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
            // ProductId
            // 
            ProductId.HeaderText = "Product ID";
            ProductId.MinimumWidth = 6;
            ProductId.Name = "ProductId";
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            // 
            // ProductInventory
            // 
            ProductInventory.HeaderText = "Inventory";
            ProductInventory.MinimumWidth = 6;
            ProductInventory.Name = "ProductInventory";
            // 
            // ProductPrice
            // 
            ProductPrice.HeaderText = "Price";
            ProductPrice.MinimumWidth = 6;
            ProductPrice.Name = "ProductPrice";
            // 
            // ProductMinColumn
            // 
            ProductMinColumn.HeaderText = "Min";
            ProductMinColumn.MinimumWidth = 6;
            ProductMinColumn.Name = "ProductMinColumn";
            // 
            // ProductMaxColumn
            // 
            ProductMaxColumn.HeaderText = "Max";
            ProductMaxColumn.MinimumWidth = 6;
            ProductMaxColumn.Name = "ProductMaxColumn";
            // 
            // MainScreenPartLabel
            // 
            MainScreenPartLabel.AutoSize = true;
            MainScreenPartLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            MainScreenPartLabel.Location = new Point(12, 98);
            MainScreenPartLabel.Name = "MainScreenPartLabel";
            MainScreenPartLabel.Size = new Size(56, 31);
            MainScreenPartLabel.TabIndex = 14;
            MainScreenPartLabel.Text = "Part";
            // 
            // MainScreenProductLabel
            // 
            MainScreenProductLabel.AutoSize = true;
            MainScreenProductLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            MainScreenProductLabel.Location = new Point(1137, 98);
            MainScreenProductLabel.Name = "MainScreenProductLabel";
            MainScreenProductLabel.Size = new Size(106, 31);
            MainScreenProductLabel.TabIndex = 15;
            MainScreenProductLabel.Text = "Products";
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2202, 872);
            Controls.Add(MainScreenProductLabel);
            Controls.Add(MainScreenPartLabel);
            Controls.Add(ExitButton);
            Controls.Add(DeleteProductsButton);
            Controls.Add(ModifyProductsButton);
            Controls.Add(AddProductsButton);
            Controls.Add(DeletePartsButton);
            Controls.Add(ModifyPartsButton);
            Controls.Add(AddPartsButton);
            Controls.Add(SearchButtonProducts);
            Controls.Add(SearchProductsTextBox);
            Controls.Add(SearchButtonParts);
            Controls.Add(SearchPartsTextbox);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(MainScreenTitle);
            Name = "MainScreen";
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainScreenTitle;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox SearchPartsTextbox;
        private Button SearchButtonParts;
        private Button SearchButtonProducts;
        private TextBox SearchProductsTextBox;
        private Button AddPartsButton;
        private Button ModifyPartsButton;
        private Button DeletePartsButton;
        private Button DeleteProductsButton;
        private Button ModifyProductsButton;
        private Button AddProductsButton;
        private Button ExitButton;
        private DataGridViewTextBoxColumn PartID;
        private DataGridViewTextBoxColumn PartName;
        private DataGridViewTextBoxColumn PartInventory;
        private DataGridViewTextBoxColumn PartPrice;
        private DataGridViewTextBoxColumn PartMin;
        private DataGridViewTextBoxColumn PartMax;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductInventory;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn ProductMinColumn;
        private DataGridViewTextBoxColumn ProductMaxColumn;
        private Label MainScreenPartLabel;
        private Label MainScreenProductLabel;
    }
}