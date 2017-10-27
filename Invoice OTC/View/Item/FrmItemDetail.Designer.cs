namespace Invoice_OTC.View
{
    partial class FrmItemDetail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItemDetail));
            System.Windows.Forms.Label brandLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label itemCodeLabel;
            System.Windows.Forms.Label itemNameLabel;
            System.Windows.Forms.Label itemSortLabel;
            System.Windows.Forms.Label jenisLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label statLabel;
            System.Windows.Forms.Label subCategoryLabel;
            this.rotiToChooseItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rotiToChooseItemBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.rotiToChooseItemBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.itemCodeTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemSortTextBox = new System.Windows.Forms.TextBox();
            this.jenisTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.statCheckBox = new System.Windows.Forms.CheckBox();
            this.subCategoryTextBox = new System.Windows.Forms.TextBox();
            brandLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            itemCodeLabel = new System.Windows.Forms.Label();
            itemNameLabel = new System.Windows.Forms.Label();
            itemSortLabel = new System.Windows.Forms.Label();
            jenisLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            statLabel = new System.Windows.Forms.Label();
            subCategoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rotiToChooseItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotiToChooseItemBindingNavigator)).BeginInit();
            this.rotiToChooseItemBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // rotiToChooseItemBindingSource
            // 
            this.rotiToChooseItemBindingSource.DataSource = typeof(Invoice_OTC.Model.RotiToChooseItem);
            // 
            // rotiToChooseItemBindingNavigator
            // 
            this.rotiToChooseItemBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rotiToChooseItemBindingNavigator.BindingSource = this.rotiToChooseItemBindingSource;
            this.rotiToChooseItemBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rotiToChooseItemBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rotiToChooseItemBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.rotiToChooseItemBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.rotiToChooseItemBindingNavigatorSaveItem});
            this.rotiToChooseItemBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.rotiToChooseItemBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rotiToChooseItemBindingNavigator.MoveFirstItem = this.bindingNavigatorMovePreviousItem;
            this.rotiToChooseItemBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rotiToChooseItemBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rotiToChooseItemBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rotiToChooseItemBindingNavigator.Name = "rotiToChooseItemBindingNavigator";
            this.rotiToChooseItemBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rotiToChooseItemBindingNavigator.Size = new System.Drawing.Size(626, 31);
            this.rotiToChooseItemBindingNavigator.TabIndex = 0;
            this.rotiToChooseItemBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // rotiToChooseItemBindingNavigatorSaveItem
            // 
            this.rotiToChooseItemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rotiToChooseItemBindingNavigatorSaveItem.Enabled = false;
            this.rotiToChooseItemBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rotiToChooseItemBindingNavigatorSaveItem.Image")));
            this.rotiToChooseItemBindingNavigatorSaveItem.Name = "rotiToChooseItemBindingNavigatorSaveItem";
            this.rotiToChooseItemBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.rotiToChooseItemBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new System.Drawing.Point(21, 44);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(38, 13);
            brandLabel.TabIndex = 1;
            brandLabel.Text = "Brand:";
            // 
            // brandTextBox
            // 
            this.brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rotiToChooseItemBindingSource, "Brand", true));
            this.brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.brandTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.brandTextBox.Location = new System.Drawing.Point(101, 41);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(199, 24);
            this.brandTextBox.TabIndex = 2;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(21, 70);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(52, 13);
            categoryLabel.TabIndex = 3;
            categoryLabel.Text = "Category:";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rotiToChooseItemBindingSource, "Category", true));
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.categoryTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.categoryTextBox.Location = new System.Drawing.Point(101, 67);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(199, 24);
            this.categoryTextBox.TabIndex = 4;
            // 
            // itemCodeLabel
            // 
            itemCodeLabel.AutoSize = true;
            itemCodeLabel.Location = new System.Drawing.Point(21, 96);
            itemCodeLabel.Name = "itemCodeLabel";
            itemCodeLabel.Size = new System.Drawing.Size(58, 13);
            itemCodeLabel.TabIndex = 5;
            itemCodeLabel.Text = "Item Code:";
            // 
            // itemCodeTextBox
            // 
            this.itemCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rotiToChooseItemBindingSource, "ItemCode", true));
            this.itemCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.itemCodeTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.itemCodeTextBox.Location = new System.Drawing.Point(101, 93);
            this.itemCodeTextBox.Name = "itemCodeTextBox";
            this.itemCodeTextBox.Size = new System.Drawing.Size(199, 24);
            this.itemCodeTextBox.TabIndex = 6;
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new System.Drawing.Point(21, 122);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(61, 13);
            itemNameLabel.TabIndex = 7;
            itemNameLabel.Text = "Item Name:";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rotiToChooseItemBindingSource, "ItemName", true));
            this.itemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.itemNameTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.itemNameTextBox.Location = new System.Drawing.Point(101, 119);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(199, 24);
            this.itemNameTextBox.TabIndex = 8;
            // 
            // itemSortLabel
            // 
            itemSortLabel.AutoSize = true;
            itemSortLabel.Location = new System.Drawing.Point(21, 148);
            itemSortLabel.Name = "itemSortLabel";
            itemSortLabel.Size = new System.Drawing.Size(52, 13);
            itemSortLabel.TabIndex = 9;
            itemSortLabel.Text = "Item Sort:";
            // 
            // itemSortTextBox
            // 
            this.itemSortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rotiToChooseItemBindingSource, "ItemSort", true));
            this.itemSortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.itemSortTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.itemSortTextBox.Location = new System.Drawing.Point(101, 145);
            this.itemSortTextBox.Name = "itemSortTextBox";
            this.itemSortTextBox.Size = new System.Drawing.Size(199, 24);
            this.itemSortTextBox.TabIndex = 10;
            // 
            // jenisLabel
            // 
            jenisLabel.AutoSize = true;
            jenisLabel.Location = new System.Drawing.Point(21, 174);
            jenisLabel.Name = "jenisLabel";
            jenisLabel.Size = new System.Drawing.Size(34, 13);
            jenisLabel.TabIndex = 11;
            jenisLabel.Text = "Jenis:";
            // 
            // jenisTextBox
            // 
            this.jenisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rotiToChooseItemBindingSource, "Jenis", true));
            this.jenisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.jenisTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.jenisTextBox.Location = new System.Drawing.Point(101, 171);
            this.jenisTextBox.Name = "jenisTextBox";
            this.jenisTextBox.Size = new System.Drawing.Size(199, 24);
            this.jenisTextBox.TabIndex = 12;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(21, 200);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 13;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rotiToChooseItemBindingSource, "Price", true));
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.priceTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.priceTextBox.Location = new System.Drawing.Point(101, 197);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(199, 24);
            this.priceTextBox.TabIndex = 14;
            // 
            // statLabel
            // 
            statLabel.AutoSize = true;
            statLabel.Location = new System.Drawing.Point(21, 228);
            statLabel.Name = "statLabel";
            statLabel.Size = new System.Drawing.Size(29, 13);
            statLabel.TabIndex = 15;
            statLabel.Text = "Stat:";
            // 
            // statCheckBox
            // 
            this.statCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.rotiToChooseItemBindingSource, "Stat", true));
            this.statCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.statCheckBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.statCheckBox.Location = new System.Drawing.Point(101, 223);
            this.statCheckBox.Name = "statCheckBox";
            this.statCheckBox.Size = new System.Drawing.Size(199, 24);
            this.statCheckBox.TabIndex = 16;
            this.statCheckBox.Text = "checkBox1";
            this.statCheckBox.UseVisualStyleBackColor = true;
            // 
            // subCategoryLabel
            // 
            subCategoryLabel.AutoSize = true;
            subCategoryLabel.Location = new System.Drawing.Point(21, 256);
            subCategoryLabel.Name = "subCategoryLabel";
            subCategoryLabel.Size = new System.Drawing.Size(74, 13);
            subCategoryLabel.TabIndex = 17;
            subCategoryLabel.Text = "Sub Category:";
            // 
            // subCategoryTextBox
            // 
            this.subCategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rotiToChooseItemBindingSource, "SubCategory", true));
            this.subCategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.subCategoryTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.subCategoryTextBox.Location = new System.Drawing.Point(101, 253);
            this.subCategoryTextBox.Name = "subCategoryTextBox";
            this.subCategoryTextBox.Size = new System.Drawing.Size(199, 24);
            this.subCategoryTextBox.TabIndex = 18;
            // 
            // FrmItemDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 350);
            this.Controls.Add(brandLabel);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(itemCodeLabel);
            this.Controls.Add(this.itemCodeTextBox);
            this.Controls.Add(itemNameLabel);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(itemSortLabel);
            this.Controls.Add(this.itemSortTextBox);
            this.Controls.Add(jenisLabel);
            this.Controls.Add(this.jenisTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(statLabel);
            this.Controls.Add(this.statCheckBox);
            this.Controls.Add(subCategoryLabel);
            this.Controls.Add(this.subCategoryTextBox);
            this.Controls.Add(this.rotiToChooseItemBindingNavigator);
            this.Name = "FrmItemDetail";
            this.Text = "FrmItemDetail";
            this.Load += new System.EventHandler(this.FrmItemDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rotiToChooseItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotiToChooseItemBindingNavigator)).EndInit();
            this.rotiToChooseItemBindingNavigator.ResumeLayout(false);
            this.rotiToChooseItemBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource rotiToChooseItemBindingSource;
        private System.Windows.Forms.BindingNavigator rotiToChooseItemBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton rotiToChooseItemBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox itemCodeTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox itemSortTextBox;
        private System.Windows.Forms.TextBox jenisTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.CheckBox statCheckBox;
        private System.Windows.Forms.TextBox subCategoryTextBox;
    }
}