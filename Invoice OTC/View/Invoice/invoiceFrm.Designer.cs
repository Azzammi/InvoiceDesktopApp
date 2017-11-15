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
            System.Windows.Forms.Label pPNLabel;
            System.Windows.Forms.Label subTotalLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label dueDateLabel;
            System.Windows.Forms.Label paymentLabel;
            System.Windows.Forms.Label isPayedLabel;
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
            this.dueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paymentComboBox = new System.Windows.Forms.ComboBox();
            this.isPayedCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            isPPNLabel = new System.Windows.Forms.Label();
            issuedDataLabel = new System.Windows.Forms.Label();
            nomorLabel = new System.Windows.Forms.Label();
            nomorPOLabel = new System.Windows.Forms.Label();
            outletCodeLabel = new System.Windows.Forms.Label();
            pPNLabel = new System.Windows.Forms.Label();
            subTotalLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            dueDateLabel = new System.Windows.Forms.Label();
            paymentLabel = new System.Windows.Forms.Label();
            isPayedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemBindingNavigator)).BeginInit();
            this.invoiceItemBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotiToChooseItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletItemBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // isPPNLabel
            // 
            isPPNLabel.AutoSize = true;
            isPPNLabel.Location = new System.Drawing.Point(522, 38);
            isPPNLabel.Name = "isPPNLabel";
            isPPNLabel.Size = new System.Drawing.Size(43, 13);
            isPPNLabel.TabIndex = 4;
            isPPNLabel.Text = "Is PPN:";
            // 
            // issuedDataLabel
            // 
            issuedDataLabel.AutoSize = true;
            issuedDataLabel.Location = new System.Drawing.Point(522, 0);
            issuedDataLabel.Name = "issuedDataLabel";
            issuedDataLabel.Size = new System.Drawing.Size(67, 13);
            issuedDataLabel.TabIndex = 6;
            issuedDataLabel.Text = "Issued Data:";
            // 
            // nomorLabel
            // 
            nomorLabel.AutoSize = true;
            nomorLabel.Location = new System.Drawing.Point(3, 0);
            nomorLabel.Name = "nomorLabel";
            nomorLabel.Size = new System.Drawing.Size(76, 13);
            nomorLabel.TabIndex = 8;
            nomorLabel.Text = "Nomor Invoice";
            // 
            // nomorPOLabel
            // 
            nomorPOLabel.AutoSize = true;
            nomorPOLabel.Location = new System.Drawing.Point(3, 38);
            nomorPOLabel.Name = "nomorPOLabel";
            nomorPOLabel.Size = new System.Drawing.Size(59, 13);
            nomorPOLabel.TabIndex = 10;
            nomorPOLabel.Text = "Nomor PO:";
            // 
            // outletCodeLabel
            // 
            outletCodeLabel.AutoSize = true;
            outletCodeLabel.Location = new System.Drawing.Point(3, 76);
            outletCodeLabel.Name = "outletCodeLabel";
            outletCodeLabel.Size = new System.Drawing.Size(35, 13);
            outletCodeLabel.TabIndex = 12;
            outletCodeLabel.Text = "Outlet";
            // 
            // pPNLabel
            // 
            pPNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            pPNLabel.AutoSize = true;
            pPNLabel.Location = new System.Drawing.Point(43, 47);
            pPNLabel.Name = "pPNLabel";
            pPNLabel.Size = new System.Drawing.Size(32, 13);
            pPNLabel.TabIndex = 18;
            pPNLabel.Text = "PPN:";
            // 
            // subTotalLabel
            // 
            subTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            subTotalLabel.AutoSize = true;
            subTotalLabel.Location = new System.Drawing.Point(19, 17);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new System.Drawing.Size(56, 13);
            subTotalLabel.TabIndex = 20;
            subTotalLabel.Text = "Sub Total:";
            // 
            // totalLabel
            // 
            totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(41, 82);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 22;
            totalLabel.Text = "Total:";
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new System.Drawing.Point(3, 114);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new System.Drawing.Size(56, 13);
            dueDateLabel.TabIndex = 22;
            dueDateLabel.Text = "Due Date:";
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Location = new System.Drawing.Point(522, 76);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new System.Drawing.Size(51, 13);
            paymentLabel.TabIndex = 23;
            paymentLabel.Text = "Payment:";
            // 
            // isPayedLabel
            // 
            isPayedLabel.AutoSize = true;
            isPayedLabel.Location = new System.Drawing.Point(522, 114);
            isPayedLabel.Name = "isPayedLabel";
            isPayedLabel.Size = new System.Drawing.Size(51, 13);
            isPayedLabel.TabIndex = 24;
            isPayedLabel.Text = "Is Payed:";
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            this.isPPNCheckBox.Location = new System.Drawing.Point(670, 41);
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
            this.issuedDataDateTimePicker.Location = new System.Drawing.Point(670, 3);
            this.issuedDataDateTimePicker.Name = "issuedDataDateTimePicker";
            this.issuedDataDateTimePicker.Size = new System.Drawing.Size(247, 24);
            this.issuedDataDateTimePicker.TabIndex = 4;
            // 
            // nomorTextBox
            // 
            this.nomorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceItemBindingSource, "Nomor", true));
            this.nomorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nomorTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.nomorTextBox.Location = new System.Drawing.Point(151, 3);
            this.nomorTextBox.Name = "nomorTextBox";
            this.nomorTextBox.Size = new System.Drawing.Size(200, 24);
            this.nomorTextBox.TabIndex = 0;
            // 
            // nomorPOTextBox
            // 
            this.nomorPOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceItemBindingSource, "NomorPO", true));
            this.nomorPOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nomorPOTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.nomorPOTextBox.Location = new System.Drawing.Point(151, 41);
            this.nomorPOTextBox.Name = "nomorPOTextBox";
            this.nomorPOTextBox.Size = new System.Drawing.Size(200, 24);
            this.nomorPOTextBox.TabIndex = 1;
            // 
            // pPNTextBox
            // 
            this.pPNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pPNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceItemBindingSource, "PPN", true));
            this.pPNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pPNTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.pPNTextBox.Location = new System.Drawing.Point(201, 33);
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
            this.subTotalTextBox.Location = new System.Drawing.Point(201, 3);
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
            this.totalTextBox.Location = new System.Drawing.Point(201, 68);
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
            this.itemsDataGridView.AutoGenerateColumns = false;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.itemsDataGridView.DataSource = this.itemsBindingSource;
            this.itemsDataGridView.Location = new System.Drawing.Point(0, 186);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.Size = new System.Drawing.Size(1039, 140);
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
            this.comboBoxAdv1.Location = new System.Drawing.Point(151, 79);
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
            // dueDateDateTimePicker
            // 
            this.dueDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceItemBindingSource, "DueDate", true));
            this.dueDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dueDateDateTimePicker.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.dueDateDateTimePicker.Location = new System.Drawing.Point(151, 117);
            this.dueDateDateTimePicker.Name = "dueDateDateTimePicker";
            this.dueDateDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.dueDateDateTimePicker.TabIndex = 23;
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceItemBindingSource, "Payment", true));
            this.paymentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.paymentComboBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.Location = new System.Drawing.Point(670, 79);
            this.paymentComboBox.Name = "paymentComboBox";
            this.paymentComboBox.Size = new System.Drawing.Size(247, 26);
            this.paymentComboBox.TabIndex = 24;
            // 
            // isPayedCheckBox
            // 
            this.isPayedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.invoiceItemBindingSource, "IsPayed", true));
            this.isPayedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.isPayedCheckBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.isPayedCheckBox.Location = new System.Drawing.Point(670, 117);
            this.isPayedCheckBox.Name = "isPayedCheckBox";
            this.isPayedCheckBox.Size = new System.Drawing.Size(255, 24);
            this.isPayedCheckBox.TabIndex = 25;
            this.isPayedCheckBox.Text = "checkBox1";
            this.isPayedCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
            this.tableLayoutPanel1.Controls.Add(nomorLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.isPayedCheckBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(isPayedLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.paymentComboBox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.nomorTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(nomorPOLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(paymentLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.nomorPOTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(outletCodeLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dueDateDateTimePicker, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.isPPNCheckBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(isPPNLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(dueDateLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxAdv1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.issuedDataDateTimePicker, 3, 0);
            this.tableLayoutPanel1.Controls.Add(issuedDataLabel, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1039, 152);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.55445F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.44554F));
            this.tableLayoutPanel2.Controls.Add(subTotalLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(pPNLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(totalLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.totalTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.pPNTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.subTotalTextBox, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(612, 329);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(404, 95);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // invoiceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 436);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.itemsDataGridView);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dueDateDateTimePicker;
        private System.Windows.Forms.ComboBox paymentComboBox;
        private System.Windows.Forms.CheckBox isPayedCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}