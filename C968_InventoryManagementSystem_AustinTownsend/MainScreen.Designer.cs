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
            components = new System.ComponentModel.Container();
            MainScreenTitle = new Label();
            PartDataGrid = new DataGridView();
            outsourcedBindingSource = new BindingSource(components);
            ProductDataGrid = new DataGridView();
            SearchPartsTextbox = new TextBox();
            SearchButtonParts = new Button();
            SearchButtonProducts = new Button();
            SearchProductsTextbox = new TextBox();
            AddPartsButton = new Button();
            ModifyPartsButton = new Button();
            DeletePartsButton = new Button();
            DeleteProductsButton = new Button();
            ModifyProductsButton = new Button();
            AddProductsButton = new Button();
            ExitButton = new Button();
            MainScreenPartLabel = new Label();
            MainScreenProductLabel = new Label();
            inhouseBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)PartDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)outsourcedBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inhouseBindingSource).BeginInit();
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
            // PartDataGrid
            // 
            PartDataGrid.AllowUserToAddRows = false;
            PartDataGrid.AllowUserToDeleteRows = false;
            PartDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PartDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            PartDataGrid.Location = new Point(12, 139);
            PartDataGrid.Name = "PartDataGrid";
            PartDataGrid.ReadOnly = true;
            PartDataGrid.RowHeadersVisible = false;
            PartDataGrid.RowHeadersWidth = 51;
            PartDataGrid.RowTemplate.Height = 29;
            PartDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PartDataGrid.Size = new Size(1053, 516);
            PartDataGrid.TabIndex = 1;
            // 
            // outsourcedBindingSource
            // 
            outsourcedBindingSource.DataSource = typeof(Outsourced);
            // 
            // ProductDataGrid
            // 
            ProductDataGrid.AllowUserToAddRows = false;
            ProductDataGrid.AllowUserToDeleteRows = false;
            ProductDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            ProductDataGrid.Location = new Point(1137, 139);
            ProductDataGrid.Name = "ProductDataGrid";
            ProductDataGrid.ReadOnly = true;
            ProductDataGrid.RowHeadersVisible = false;
            ProductDataGrid.RowHeadersWidth = 51;
            ProductDataGrid.RowTemplate.Height = 29;
            ProductDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductDataGrid.Size = new Size(1053, 516);
            ProductDataGrid.TabIndex = 2;
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
            SearchButtonParts.Click += SearchButtonParts_Click;
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
            SearchButtonProducts.Click += SearchButtonProducts_Click;
            // 
            // SearchProductsTextbox
            // 
            SearchProductsTextbox.Location = new Point(1975, 105);
            SearchProductsTextbox.Name = "SearchProductsTextbox";
            SearchProductsTextbox.Size = new Size(215, 27);
            SearchProductsTextbox.TabIndex = 5;
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
            AddPartsButton.Click += AddPartsButton_Click;
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
            ModifyPartsButton.Click += ModifyPartsButton_Click;
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
            DeletePartsButton.Click += DeletePartsButton_Click;
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
            DeleteProductsButton.Click += DeleteProductsButton_Click;
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
            ModifyProductsButton.Click += ModifyProductsButton_Click;
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
            AddProductsButton.Click += AddProductsButton_Click;
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
            ExitButton.Click += ExitButton_Click;
            // 
            // MainScreenPartLabel
            // 
            MainScreenPartLabel.AutoSize = true;
            MainScreenPartLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            MainScreenPartLabel.Location = new Point(12, 98);
            MainScreenPartLabel.Name = "MainScreenPartLabel";
            MainScreenPartLabel.Size = new Size(66, 31);
            MainScreenPartLabel.TabIndex = 14;
            MainScreenPartLabel.Text = "Parts";
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
            // inhouseBindingSource
            // 
            inhouseBindingSource.DataSource = typeof(Inhouse);
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
            Controls.Add(SearchProductsTextbox);
            Controls.Add(SearchButtonParts);
            Controls.Add(SearchPartsTextbox);
            Controls.Add(ProductDataGrid);
            Controls.Add(PartDataGrid);
            Controls.Add(MainScreenTitle);
            Name = "MainScreen";
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)PartDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)outsourcedBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)inhouseBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainScreenTitle;
        private DataGridView PartDataGrid;
        private DataGridView ProductDataGrid;
        private TextBox SearchPartsTextbox;
        private Button SearchButtonParts;
        private Button SearchButtonProducts;
        private TextBox SearchProductsTextbox;
        private Button AddPartsButton;
        private Button ModifyPartsButton;
        private Button DeletePartsButton;
        private Button DeleteProductsButton;
        private Button ModifyProductsButton;
        private Button AddProductsButton;
        private Button ExitButton;
        private Label MainScreenPartLabel;
        private Label MainScreenProductLabel;
        private BindingSource outsourcedBindingSource;
        private BindingSource inhouseBindingSource;
    }
}