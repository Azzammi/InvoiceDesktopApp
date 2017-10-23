#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Invoice_OTC.View
{
    partial class invoiceFrm
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
            System.Windows.Forms.Label isPPNLabel;
            System.Windows.Forms.Label issuedDataLabel;
            System.Windows.Forms.Label nomorLabel;
            System.Windows.Forms.Label nomorPOLabel;
            System.Windows.Forms.Label outletCodeLabel;
            System.Windows.Forms.Label periodeBulanLabel;
            System.Windows.Forms.Label pPNLabel;
            System.Windows.Forms.Label subTotalLabel;
            System.Windows.Forms.Label totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoiceFrm));
            this.invoiceItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceItemBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.invoiceItemBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.isPPNCheckBox = new System.Windows.Forms.CheckBox();
            this.issuedDataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nomorTextBox = new System.Windows.Forms.TextBox();
            this.nomorPOTextBox = new System.Windows.Forms.TextBox();
            this.periodeBulanDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pPNTextBox = new System.Windows.Forms.TextBox();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rotiToChooseItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.outletItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            isPPNLabel = new System.Windows.Forms.Label();
            issuedDataLabel = new System.Windows.Forms.Label();
            nomorLabel = new System.Windows.Forms.Label();
            nomorPOLabel = new System.Windows.Forms.Label();
            outletCodeLabel = new System.Windows.Forms.Label();
            periodeBulanLabel = new System.Windows.Forms.Label();
            pPNLabel = new System.Windows.Forms.Label();
            subTotalLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemBindingNavigator)).BeginInit();
            this.invoiceItemBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotiToChooseItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // isPPNLabel
            // 
            isPPNLabel.AutoSize = true;
            isPPNLabel.Location = new System.Drawing.Point(371, 83);
            isPPNLabel.Name = "isPPNLabel";
            isPPNLabel.Size = new System.Drawing.Size(43, 13);
            isPPNLabel.TabIndex = 4;
            isPPNLabel.Text = "Is PPN:";
            // 
            // issuedDataLabel
            // 
            issuedDataLabel.AutoSize = true;
            issuedDataLabel.Location = new System.Drawing.Point(371, 51);
            issuedDataLabel.Name = "issuedDataLabel";
            issuedDataLabel.Size = new System.Drawing.Size(67, 13);
            issuedDataLabel.TabIndex = 6;
            issuedDataLabel.Text = "Issued Data:";
            // 
            // nomorLabel
            // 
            nomorLabel.AutoSize = true;
            nomorLabel.Location = new System.Drawing.Point(23, 53);
            nomorLabel.Name = "nomorLabel";
            nomorLabel.Size = new System.Drawing.Size(76, 13);
            nomorLabel.TabIndex = 8;
            nomorLabel.Text = "Nomor Invoice";
            // 
            // nomorPOLabel
            // 
            nomorPOLabel.AutoSize = true;
            nomorPOLabel.Location = new System.Drawing.Point(23, 79);
            nomorPOLabel.Name = "nomorPOLabel";
            nomorPOLabel.Size = new System.Drawing.Size(59, 13);
            nomorPOLabel.TabIndex = 10;
            nomorPOLabel.Text = "Nomor PO:";
            // 
            // outletCodeLabel
            // 
            outletCodeLabel.AutoSize = true;
            outletCodeLabel.Location = new System.Drawing.Point(23, 115);
            outletCodeLabel.Name = "outletCodeLabel";
            outletCodeLabel.Size = new System.Drawing.Size(35, 13);
            outletCodeLabel.TabIndex = 12;
            outletCodeLabel.Text = "Outlet";
            // 
            // periodeBulanLabel
            // 
            periodeBulanLabel.AutoSize = true;
            periodeBulanLabel.Location = new System.Drawing.Point(23, 150);
            periodeBulanLabel.Name = "periodeBulanLabel";
            periodeBulanLabel.Size = new System.Drawing.Size(76, 13);
            periodeBulanLabel.TabIndex = 16;
            periodeBulanLabel.Text = "Periode Bulan:";
            // 
            // pPNLabel
            // 
            pPNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            pPNLabel.AutoSize = true;
            pPNLabel.Location = new System.Drawing.Point(734, 400);
            pPNLabel.Name = "pPNLabel";
            pPNLabel.Size = new System.Drawing.Size(32, 13);
            pPNLabel.TabIndex = 18;
            pPNLabel.Text = "PPN:";
            // 
            // subTotalLabel
            // 
            subTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            subTotalLabel.AutoSize = true;
            subTotalLabel.Location = new System.Drawing.Point(734, 370);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new System.Drawing.Size(56, 13);
            subTotalLabel.TabIndex = 20;
            subTotalLabel.Text = "Sub Total:";
            // 
            // totalLabel
            // 
            totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(734, 431);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 22;
            totalLabel.Text = "Total:";
            // 
            // invoiceItemBindingSource
            // 
            this.invoiceItemBindingSource.DataSource = typeof(Invoice_OTC.Model.InvoiceItem);
            // 
            // invoiceItemBindingNavigator
            // 
            this.invoiceItemBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.invoiceItemBindingNavigator.BindingSource = this.invoiceItemBindingSource;
            this.invoiceItemBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.invoiceItemBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.invoiceItemBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.invoiceItemBindingNavigatorSaveItem});
            this.invoiceItemBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.invoiceItemBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.invoiceItemBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.invoiceItemBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.invoiceItemBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.invoiceItemBindingNavigator.Name = "invoiceItemBindingNavigator";
            this.invoiceItemBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.invoiceItemBindingNavigator.Size = new System.Drawing.Size(1039, 25);
            this.invoiceItemBindingNavigator.TabIndex = 0;
            this.invoiceItemBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // invoiceItemBindingNavigatorSaveItem
            // 
            this.invoiceItemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.invoiceItemBindingNavigatorSaveItem.Enabled = false;
            this.invoiceItemBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("invoiceItemBindingNavigatorSaveItem.Image")));
            this.invoiceItemBindingNavigatorSaveItem.Name = "invoiceItemBindingNavigatorSaveItem";
            this.invoiceItemBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.invoiceItemBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // isPPNCheckBox
            // 
            this.isPPNCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.invoiceItemBindingSource, "IsPPN", true));
            this.isPPNCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.isPPNCheckBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.isPPNCheckBox.Location = new System.Drawing.Point(453, 78);
            this.isPPNCheckBox.Name = "isPPNCheckBox";
            this.isPPNCheckBox.Size = new System.Drawing.Size(200, 24);
            this.isPPNCheckBox.TabIndex = 5;
            this.isPPNCheckBox.Text = "PPN 10% ";
            this.isPPNCheckBox.UseVisualStyleBackColor = true;
            // 
            // issuedDataDateTimePicker
            // 
            this.issuedDataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceItemBindingSource, "IssuedData", true));
            this.issuedDataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.issuedDataDateTimePicker.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.issuedDataDateTimePicker.Location = new System.Drawing.Point(453, 47);
            this.issuedDataDateTimePicker.Name = "issuedDataDateTimePicker";
            this.issuedDataDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.issuedDataDateTimePicker.TabIndex = 4;
            // 
            // nomorTextBox
            // 
            this.nomorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceItemBindingSource, "Nomor", true));
            this.nomorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nomorTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.nomorTextBox.Location = new System.Drawing.Point(105, 50);
            this.nomorTextBox.Name = "nomorTextBox";
            this.nomorTextBox.Size = new System.Drawing.Size(200, 24);
            this.nomorTextBox.TabIndex = 0;
            // 
            // nomorPOTextBox
            // 
            this.nomorPOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceItemBindingSource, "NomorPO", true));
            this.nomorPOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nomorPOTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.nomorPOTextBox.Location = new System.Drawing.Point(105, 80);
            this.nomorPOTextBox.Name = "nomorPOTextBox";
            this.nomorPOTextBox.Size = new System.Drawing.Size(200, 24);
            this.nomorPOTextBox.TabIndex = 1;
            // 
            // periodeBulanDateTimePicker
            // 
            this.periodeBulanDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceItemBindingSource, "PeriodeBulan", true));
            this.periodeBulanDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.periodeBulanDateTimePicker.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.periodeBulanDateTimePicker.Location = new System.Drawing.Point(105, 146);
            this.periodeBulanDateTimePicker.Name = "periodeBulanDateTimePicker";
            this.periodeBulanDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.periodeBulanDateTimePicker.TabIndex = 3;
            // 
            // pPNTextBox
            // 
            this.pPNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pPNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceItemBindingSource, "PPN", true));
            this.pPNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pPNTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.pPNTextBox.Location = new System.Drawing.Point(816, 397);
            this.pPNTextBox.Name = "pPNTextBox";
            this.pPNTextBox.Size = new System.Drawing.Size(200, 24);
            this.pPNTextBox.TabIndex = 8;
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.subTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceItemBindingSource, "SubTotal", true));
            this.subTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.subTotalTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.subTotalTextBox.Location = new System.Drawing.Point(816, 367);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.Size = new System.Drawing.Size(200, 24);
            this.subTotalTextBox.TabIndex = 7;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceItemBindingSource, "Total", true));
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.totalTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.totalTextBox.Location = new System.Drawing.Point(816, 428);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 24);
            this.totalTextBox.TabIndex = 9;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.invoiceItemBindingSource;
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsDataGridView.AutoGenerateColumns = false;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.itemsDataGridView.DataSource = this.itemsBindingSource;
            this.itemsDataGridView.Location = new System.Drawing.Point(26, 186);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.Size = new System.Drawing.Size(990, 175);
            this.itemsDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ItemCode";
            this.dataGridViewTextBoxColumn3.DataSource = this.rotiToChooseItemBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "ItemName";
            this.dataGridViewTextBoxColumn3.HeaderText = "ItemCode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ItemCode";
            // 
            // rotiToChooseItemBindingSource
            // 
            this.rotiToChooseItemBindingSource.DataSource = typeof(Invoice_OTC.Model.RotiToChooseItem);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn4.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn6.HeaderText = "Discount";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SubTotal";
            this.dataGridViewTextBoxColumn7.HeaderText = "SubTotal";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(200, 26);
            this.comboBoxAdv1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxAdv1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoiceItemBindingSource, "OutletCode", true));
            this.comboBoxAdv1.DataSource = this.outletItemBindingSource;
            this.comboBoxAdv1.DisplayMember = "OutletName";
            this.comboBoxAdv1.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.comboBoxAdv1.Location = new System.Drawing.Point(105, 110);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(200, 26);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
            this.comboBoxAdv1.TabIndex = 2;
            this.comboBoxAdv1.ValueMember = "OutletCode";
            // 
            // outletItemBindingSource
            // 
            this.outletItemBindingSource.DataSource = typeof(Invoice_OTC.Model.outletItem);
            // 
            // invoiceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 489);
            this.Controls.Add(this.comboBoxAdv1);
            this.Controls.Add(this.itemsDataGridView);
            this.Controls.Add(isPPNLabel);
            this.Controls.Add(this.isPPNCheckBox);
            this.Controls.Add(issuedDataLabel);
            this.Controls.Add(this.issuedDataDateTimePicker);
            this.Controls.Add(nomorLabel);
            this.Controls.Add(this.nomorTextBox);
            this.Controls.Add(nomorPOLabel);
            this.Controls.Add(this.nomorPOTextBox);
            this.Controls.Add(outletCodeLabel);
            this.Controls.Add(periodeBulanLabel);
            this.Controls.Add(this.periodeBulanDateTimePicker);
            this.Controls.Add(pPNLabel);
            this.Controls.Add(this.pPNTextBox);
            this.Controls.Add(subTotalLabel);
            this.Controls.Add(this.subTotalTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.invoiceItemBindingNavigator);
            this.Name = "invoiceFrm";
            this.Text = "e4 ";
            this.Load += new System.EventHandler(this.invoiceFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemBindingNavigator)).EndInit();
            this.invoiceItemBindingNavigator.ResumeLayout(false);
            this.invoiceItemBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotiToChooseItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource invoiceItemBindingSource;
        private System.Windows.Forms.BindingNavigator invoiceItemBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton invoiceItemBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox isPPNCheckBox;
        private System.Windows.Forms.DateTimePicker issuedDataDateTimePicker;
        private System.Windows.Forms.TextBox nomorTextBox;
        private System.Windows.Forms.TextBox nomorPOTextBox;
        private System.Windows.Forms.DateTimePicker periodeBulanDateTimePicker;
        private System.Windows.Forms.TextBox pPNTextBox;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource rotiToChooseItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private System.Windows.Forms.BindingSource outletItemBindingSource;
    }
}