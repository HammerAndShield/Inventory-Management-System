namespace C968_InventoryManagementSystem_AustinTownsend
{
    partial class ModifyProduct
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
            ModifyProductSearchTextbox = new TextBox();
            ModifyProductSearchButton = new Button();
            ModifyProductsCancelButton = new Button();
            ModifyProductsSaveButton = new Button();
            ModifyProductDeleteButton = new Button();
            ModifyProductAddButton = new Button();
            ModifyProductsAssociatedPartsLabel = new Label();
            ModifyProductAllPartsLabel = new Label();
            ModifyProductAssociatedPartsDGV = new DataGridView();
            ModifyProductAllPartsDGV = new DataGridView();
            ModifyProductMinTextbox = new TextBox();
            ModifyProductMinLabel = new Label();
            ModifyProductMaxTextbox = new TextBox();
            ModifyProductMaxLabel = new Label();
            ModifyProductPriceTextbox = new TextBox();
            ModifyProductPriceLabel = new Label();
            ModifyProductInventoryTextbox = new TextBox();
            ModifyProductInventoryLabel = new Label();
            ModifyProductNameTextbox = new TextBox();
            ModifyProductNameLabel = new Label();
            ModifyProductIDTextbox = new TextBox();
            ModifyProductIDLabel = new Label();
            ModifyProductLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ModifyProductAssociatedPartsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ModifyProductAllPartsDGV).BeginInit();
            SuspendLayout();
            // 
            // ModifyProductSearchTextbox
            // 
            ModifyProductSearchTextbox.Location = new Point(953, 40);
            ModifyProductSearchTextbox.Name = "ModifyProductSearchTextbox";
            ModifyProductSearchTextbox.Size = new Size(205, 27);
            ModifyProductSearchTextbox.TabIndex = 45;
            // 
            // ModifyProductSearchButton
            // 
            ModifyProductSearchButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ModifyProductSearchButton.Location = new Point(853, 39);
            ModifyProductSearchButton.Name = "ModifyProductSearchButton";
            ModifyProductSearchButton.Size = new Size(94, 29);
            ModifyProductSearchButton.TabIndex = 44;
            ModifyProductSearchButton.Text = "Search";
            ModifyProductSearchButton.UseVisualStyleBackColor = true;
            ModifyProductSearchButton.Click += ModifyProductSearchButton_Click;
            // 
            // ModifyProductsCancelButton
            // 
            ModifyProductsCancelButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ModifyProductsCancelButton.Location = new Point(1064, 696);
            ModifyProductsCancelButton.Name = "ModifyProductsCancelButton";
            ModifyProductsCancelButton.Size = new Size(94, 39);
            ModifyProductsCancelButton.TabIndex = 43;
            ModifyProductsCancelButton.Text = "Cancel";
            ModifyProductsCancelButton.UseVisualStyleBackColor = true;
            ModifyProductsCancelButton.Click += ModifyProductsCancelButton_Click;
            // 
            // ModifyProductsSaveButton
            // 
            ModifyProductsSaveButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ModifyProductsSaveButton.Location = new Point(940, 696);
            ModifyProductsSaveButton.Name = "ModifyProductsSaveButton";
            ModifyProductsSaveButton.Size = new Size(94, 39);
            ModifyProductsSaveButton.TabIndex = 42;
            ModifyProductsSaveButton.Text = "Save";
            ModifyProductsSaveButton.UseVisualStyleBackColor = true;
            ModifyProductsSaveButton.Click += ModifyProductsSaveButton_Click;
            // 
            // ModifyProductDeleteButton
            // 
            ModifyProductDeleteButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ModifyProductDeleteButton.Location = new Point(1064, 640);
            ModifyProductDeleteButton.Name = "ModifyProductDeleteButton";
            ModifyProductDeleteButton.Size = new Size(94, 39);
            ModifyProductDeleteButton.TabIndex = 41;
            ModifyProductDeleteButton.Text = "Delete";
            ModifyProductDeleteButton.UseVisualStyleBackColor = true;
            ModifyProductDeleteButton.Click += ModifyProductDeleteButton_Click;
            // 
            // ModifyProductAddButton
            // 
            ModifyProductAddButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ModifyProductAddButton.Location = new Point(1064, 327);
            ModifyProductAddButton.Name = "ModifyProductAddButton";
            ModifyProductAddButton.Size = new Size(94, 39);
            ModifyProductAddButton.TabIndex = 40;
            ModifyProductAddButton.Text = "Add";
            ModifyProductAddButton.UseVisualStyleBackColor = true;
            ModifyProductAddButton.Click += ModifyProductAddButton_Click;
            // 
            // ModifyProductsAssociatedPartsLabel
            // 
            ModifyProductsAssociatedPartsLabel.AutoSize = true;
            ModifyProductsAssociatedPartsLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ModifyProductsAssociatedPartsLabel.Location = new Point(545, 360);
            ModifyProductsAssociatedPartsLabel.Name = "ModifyProductsAssociatedPartsLabel";
            ModifyProductsAssociatedPartsLabel.Size = new Size(279, 25);
            ModifyProductsAssociatedPartsLabel.TabIndex = 39;
            ModifyProductsAssociatedPartsLabel.Text = "Parts Associated with this Product";
            // 
            // ModifyProductAllPartsLabel
            // 
            ModifyProductAllPartsLabel.AutoSize = true;
            ModifyProductAllPartsLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ModifyProductAllPartsLabel.Location = new Point(545, 64);
            ModifyProductAllPartsLabel.Name = "ModifyProductAllPartsLabel";
            ModifyProductAllPartsLabel.Size = new Size(160, 25);
            ModifyProductAllPartsLabel.TabIndex = 38;
            ModifyProductAllPartsLabel.Text = "All Candidate Parts";
            // 
            // ModifyProductAssociatedPartsDGV
            // 
            ModifyProductAssociatedPartsDGV.AllowUserToAddRows = false;
            ModifyProductAssociatedPartsDGV.AllowUserToDeleteRows = false;
            ModifyProductAssociatedPartsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ModifyProductAssociatedPartsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ModifyProductAssociatedPartsDGV.Location = new Point(545, 405);
            ModifyProductAssociatedPartsDGV.Name = "ModifyProductAssociatedPartsDGV";
            ModifyProductAssociatedPartsDGV.ReadOnly = true;
            ModifyProductAssociatedPartsDGV.RowHeadersVisible = false;
            ModifyProductAssociatedPartsDGV.RowHeadersWidth = 51;
            ModifyProductAssociatedPartsDGV.RowTemplate.Height = 29;
            ModifyProductAssociatedPartsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ModifyProductAssociatedPartsDGV.Size = new Size(613, 219);
            ModifyProductAssociatedPartsDGV.TabIndex = 37;
            // 
            // ModifyProductAllPartsDGV
            // 
            ModifyProductAllPartsDGV.AllowUserToAddRows = false;
            ModifyProductAllPartsDGV.AllowUserToDeleteRows = false;
            ModifyProductAllPartsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ModifyProductAllPartsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ModifyProductAllPartsDGV.Location = new Point(545, 102);
            ModifyProductAllPartsDGV.Name = "ModifyProductAllPartsDGV";
            ModifyProductAllPartsDGV.ReadOnly = true;
            ModifyProductAllPartsDGV.RowHeadersVisible = false;
            ModifyProductAllPartsDGV.RowHeadersWidth = 51;
            ModifyProductAllPartsDGV.RowTemplate.Height = 29;
            ModifyProductAllPartsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ModifyProductAllPartsDGV.Size = new Size(613, 219);
            ModifyProductAllPartsDGV.TabIndex = 36;
            // 
            // ModifyProductMinTextbox
            // 
            ModifyProductMinTextbox.Location = new Point(362, 405);
            ModifyProductMinTextbox.Name = "ModifyProductMinTextbox";
            ModifyProductMinTextbox.Size = new Size(82, 27);
            ModifyProductMinTextbox.TabIndex = 35;
            // 
            // ModifyProductMinLabel
            // 
            ModifyProductMinLabel.AutoSize = true;
            ModifyProductMinLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModifyProductMinLabel.Location = new Point(278, 405);
            ModifyProductMinLabel.Name = "ModifyProductMinLabel";
            ModifyProductMinLabel.Size = new Size(46, 28);
            ModifyProductMinLabel.TabIndex = 34;
            ModifyProductMinLabel.Text = "Min";
            // 
            // ModifyProductMaxTextbox
            // 
            ModifyProductMaxTextbox.Location = new Point(167, 405);
            ModifyProductMaxTextbox.Name = "ModifyProductMaxTextbox";
            ModifyProductMaxTextbox.Size = new Size(82, 27);
            ModifyProductMaxTextbox.TabIndex = 33;
            // 
            // ModifyProductMaxLabel
            // 
            ModifyProductMaxLabel.AutoSize = true;
            ModifyProductMaxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModifyProductMaxLabel.Location = new Point(54, 405);
            ModifyProductMaxLabel.Name = "ModifyProductMaxLabel";
            ModifyProductMaxLabel.Size = new Size(49, 28);
            ModifyProductMaxLabel.TabIndex = 32;
            ModifyProductMaxLabel.Text = "Max";
            // 
            // ModifyProductPriceTextbox
            // 
            ModifyProductPriceTextbox.Location = new Point(167, 358);
            ModifyProductPriceTextbox.Name = "ModifyProductPriceTextbox";
            ModifyProductPriceTextbox.Size = new Size(173, 27);
            ModifyProductPriceTextbox.TabIndex = 31;
            // 
            // ModifyProductPriceLabel
            // 
            ModifyProductPriceLabel.AutoSize = true;
            ModifyProductPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModifyProductPriceLabel.Location = new Point(54, 357);
            ModifyProductPriceLabel.Name = "ModifyProductPriceLabel";
            ModifyProductPriceLabel.Size = new Size(54, 28);
            ModifyProductPriceLabel.TabIndex = 30;
            ModifyProductPriceLabel.Text = "Price";
            // 
            // ModifyProductInventoryTextbox
            // 
            ModifyProductInventoryTextbox.Location = new Point(167, 309);
            ModifyProductInventoryTextbox.Name = "ModifyProductInventoryTextbox";
            ModifyProductInventoryTextbox.Size = new Size(173, 27);
            ModifyProductInventoryTextbox.TabIndex = 29;
            // 
            // ModifyProductInventoryLabel
            // 
            ModifyProductInventoryLabel.AutoSize = true;
            ModifyProductInventoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModifyProductInventoryLabel.Location = new Point(54, 308);
            ModifyProductInventoryLabel.Name = "ModifyProductInventoryLabel";
            ModifyProductInventoryLabel.Size = new Size(95, 28);
            ModifyProductInventoryLabel.TabIndex = 28;
            ModifyProductInventoryLabel.Text = "Inventory";
            // 
            // ModifyProductNameTextbox
            // 
            ModifyProductNameTextbox.Location = new Point(167, 263);
            ModifyProductNameTextbox.Name = "ModifyProductNameTextbox";
            ModifyProductNameTextbox.Size = new Size(173, 27);
            ModifyProductNameTextbox.TabIndex = 27;
            // 
            // ModifyProductNameLabel
            // 
            ModifyProductNameLabel.AutoSize = true;
            ModifyProductNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModifyProductNameLabel.Location = new Point(54, 262);
            ModifyProductNameLabel.Name = "ModifyProductNameLabel";
            ModifyProductNameLabel.Size = new Size(64, 28);
            ModifyProductNameLabel.TabIndex = 26;
            ModifyProductNameLabel.Text = "Name";
            // 
            // ModifyProductIDTextbox
            // 
            ModifyProductIDTextbox.Location = new Point(167, 217);
            ModifyProductIDTextbox.Name = "ModifyProductIDTextbox";
            ModifyProductIDTextbox.ReadOnly = true;
            ModifyProductIDTextbox.Size = new Size(173, 27);
            ModifyProductIDTextbox.TabIndex = 25;
            // 
            // ModifyProductIDLabel
            // 
            ModifyProductIDLabel.AutoSize = true;
            ModifyProductIDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModifyProductIDLabel.Location = new Point(54, 217);
            ModifyProductIDLabel.Name = "ModifyProductIDLabel";
            ModifyProductIDLabel.Size = new Size(31, 28);
            ModifyProductIDLabel.TabIndex = 24;
            ModifyProductIDLabel.Text = "ID";
            // 
            // ModifyProductLabel
            // 
            ModifyProductLabel.AutoSize = true;
            ModifyProductLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            ModifyProductLabel.Location = new Point(12, 13);
            ModifyProductLabel.Name = "ModifyProductLabel";
            ModifyProductLabel.Size = new Size(224, 38);
            ModifyProductLabel.TabIndex = 23;
            ModifyProductLabel.Text = "Modify Product";
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 748);
            Controls.Add(ModifyProductSearchTextbox);
            Controls.Add(ModifyProductSearchButton);
            Controls.Add(ModifyProductsCancelButton);
            Controls.Add(ModifyProductsSaveButton);
            Controls.Add(ModifyProductDeleteButton);
            Controls.Add(ModifyProductAddButton);
            Controls.Add(ModifyProductsAssociatedPartsLabel);
            Controls.Add(ModifyProductAllPartsLabel);
            Controls.Add(ModifyProductAssociatedPartsDGV);
            Controls.Add(ModifyProductAllPartsDGV);
            Controls.Add(ModifyProductMinTextbox);
            Controls.Add(ModifyProductMinLabel);
            Controls.Add(ModifyProductMaxTextbox);
            Controls.Add(ModifyProductMaxLabel);
            Controls.Add(ModifyProductPriceTextbox);
            Controls.Add(ModifyProductPriceLabel);
            Controls.Add(ModifyProductInventoryTextbox);
            Controls.Add(ModifyProductInventoryLabel);
            Controls.Add(ModifyProductNameTextbox);
            Controls.Add(ModifyProductNameLabel);
            Controls.Add(ModifyProductIDTextbox);
            Controls.Add(ModifyProductIDLabel);
            Controls.Add(ModifyProductLabel);
            Name = "ModifyProduct";
            Text = "Modify Product";
            Load += ModifyProduct_Load;
            ((System.ComponentModel.ISupportInitialize)ModifyProductAssociatedPartsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ModifyProductAllPartsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ModifyProductSearchTextbox;
        private Button ModifyProductSearchButton;
        private Button ModifyProductsCancelButton;
        private Button ModifyProductsSaveButton;
        private Button ModifyProductDeleteButton;
        private Button ModifyProductAddButton;
        private Label ModifyProductsAssociatedPartsLabel;
        private Label ModifyProductAllPartsLabel;
        private DataGridView ModifyProductAssociatedPartsDGV;
        private DataGridView ModifyProductAllPartsDGV;
        private TextBox ModifyProductMinTextbox;
        private Label ModifyProductMinLabel;
        private TextBox ModifyProductMaxTextbox;
        private Label ModifyProductMaxLabel;
        private TextBox ModifyProductPriceTextbox;
        private Label ModifyProductPriceLabel;
        private TextBox ModifyProductInventoryTextbox;
        private Label ModifyProductInventoryLabel;
        private TextBox ModifyProductNameTextbox;
        private Label ModifyProductNameLabel;
        private TextBox ModifyProductIDTextbox;
        private Label ModifyProductIDLabel;
        private Label ModifyProductLabel;
    }
}