namespace Invoice_OTC.View
{
    partial class detailedBindingForm
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
            System.Windows.Forms.Label issuedDataLabel;
            System.Windows.Forms.Label nomorLabel;
            System.Windows.Forms.Label periodeBulanLabel;
            System.Windows.Forms.Label pPNLabel;
            System.Windows.Forms.Label slsmCodeLabel;
            System.Windows.Forms.Label subTotalLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label outletAddressLabel;
            System.Windows.Forms.Label isPPNLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detailedBindingForm));
            this.issuedDataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.invoiceItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomorTextBox = new System.Windows.Forms.TextBox();
            this.periodeBulanDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pPNTextBox = new System.Windows.Forms.TextBox();
            this.slsmCodeComboBox = new System.Windows.Forms.ComboBox();
            this.outletItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rotiToChooseItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batalBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.tambahBtn = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.outletAddressTextBox = new System.Windows.Forms.TextBox();
            this.isPPNCheckBox = new System.Windows.Forms.CheckBox();
            this.findStrip1 = new Invoice_OTC.Controller.FindStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.cetakBtn = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            issuedDataLabel = new System.Windows.Forms.Label();
            nomorLabel = new System.Windows.Forms.Label();
            periodeBulanLabel = new System.Windows.Forms.Label();
            pPNLabel = new System.Windows.Forms.Label();
            slsmCodeLabel = new System.Windows.Forms.Label();
            subTotalLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            outletAddressLabel = new System.Windows.Forms.Label();
            isPPNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotiToChooseItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.findStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // issuedDataLabel
            // 
            issuedDataLabel.AutoSize = true;
            issuedDataLabel.Location = new System.Drawing.Point(23, 107);
            issuedDataLabel.Name = "issuedDataLabel";
            issuedDataLabel.Size = new System.Drawing.Size(67, 13);
            issuedDataLabel.TabIndex = 3;
            issuedDataLabel.Text = "Issued Data:";
            // 
            // nomorLabel
            // 
            nomorLabel.AutoSize = true;
            nomorLabel.Location = new System.Drawing.Point(23, 46);
            nomorLabel.Name = "nomorLabel";
            nomorLabel.Size = new System.Drawing.Size(41, 13);
            nomorLabel.TabIndex = 5;
            nomorLabel.Text = "Nomor:";
            // 
            // periodeBulanLabel
            // 
            periodeBulanLabel.AutoSize = true;
            periodeBulanLabel.Location = new System.Drawing.Point(23, 77);
            periodeBulanLabel.Name = "periodeBulanLabel";
            periodeBulanLabel.Size = new System.Drawing.Size(76, 13);
            periodeBulanLabel.TabIndex = 7;
            periodeBulanLabel.Text = "Periode Bulan:";
            // 
            // pPNLabel
            // 
            pPNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            pPNLabel.AutoSize = true;
            pPNLabel.Location = new System.Drawing.Point(643, 333);
            pPNLabel.Name = "pPNLabel";
            pPNLabel.Size = new System.Drawing.Size(32, 13);
            pPNLabel.TabIndex = 9;
            pPNLabel.Text = "PPN:";
            // 
            // slsmCodeLabel
            // 
            slsmCodeLabel.AutoSize = true;
            slsmCodeLabel.Location = new System.Drawing.Point(384, 46);
            slsmCodeLabel.Name = "slsmCodeLabel";
            slsmCodeLabel.Size = new System.Drawing.Size(64, 13);
            slsmCodeLabel.TabIndex = 11;
            slsmCodeLabel.Text = "Invoice To :";
            // 
            // subTotalLabel
            // 
            subTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            subTotalLabel.AutoSize = true;
            subTotalLabel.Location = new System.Drawing.Point(643, 307);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new System.Drawing.Size(56, 13);
            subTotalLabel.TabIndex = 17;
            subTotalLabel.Text = "Sub Total:";
            // 
            // totalLabel
            // 
            totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(643, 360);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 19;
            totalLabel.Text = "Total:";
            // 
            // outletAddressLabel
            // 
            outletAddressLabel.AutoSize = true;
            outletAddressLabel.Location = new System.Drawing.Point(384, 77);
            outletAddressLabel.Name = "outletAddressLabel";
            outletAddressLabel.Size = new System.Drawing.Size(48, 13);
            outletAddressLabel.TabIndex = 26;
            outletAddressLabel.Text = "Address:";
            // 
            // isPPNLabel
            // 
            isPPNLabel.AutoSize = true;
            isPPNLabel.Location = new System.Drawing.Point(761, 46);
            isPPNLabel.Name = "isPPNLabel";
            isPPNLabel.Size = new System.Drawing.Size(90, 13);
            isPPNLabel.TabIndex = 27;
            isPPNLabel.Text = "Include PPN 10%";
            // 
            // issuedDataDateTimePicker
            // 
            this.issuedDataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceItemBindingSource, "IssuedData", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.issuedDataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.issuedDataDateTimePicker.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.issuedDataDateTimePicker.Location = new System.Drawing.Point(111, 103);
            this.issuedDataDateTimePicker.Name = "issuedDataDateTimePicker";
            this.issuedDataDateTimePicker.Size = new System.Drawing.Size(267, 24);
            this.issuedDataDateTimePicker.TabIndex = 4;
            // 
            // invoiceItemBindingSource
            // 
            this.invoiceItemBindingSource.DataSource = typeof(Invoice_OTC.Model.InvoiceItem);
            // 
            // nomorTextBox
            // 
            this.nomorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceItemBindingSource, "Nomor", true));
            this.nomorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nomorTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.nomorTextBox.Location = new System.Drawing.Point(111, 43);
            this.nomorTextBox.Name = "nomorTextBox";
            this.nomorTextBox.Size = new System.Drawing.Size(89, 24);
            this.nomorTextBox.TabIndex = 6;
            // 
            // periodeBulanDateTimePicker
            // 
            this.periodeBulanDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceItemBindingSource, "PeriodeBulan", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.periodeBulanDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.periodeBulanDateTimePicker.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.periodeBulanDateTimePicker.Location = new System.Drawing.Point(111, 73);
            this.periodeBulanDateTimePicker.Name = "periodeBulanDateTimePicker";
            this.periodeBulanDateTimePicker.Size = new System.Drawing.Size(267, 24);
            this.periodeBulanDateTimePicker.TabIndex = 8;
            // 
            // pPNTextBox
            // 
            this.pPNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pPNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceItemBindingSource, "PPN", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"));
            this.pPNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pPNTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.pPNTextBox.Location = new System.Drawing.Point(731, 332);
            this.pPNTextBox.Name = "pPNTextBox";
            this.pPNTextBox.Size = new System.Drawing.Size(200, 24);
            this.pPNTextBox.TabIndex = 10;
            // 
            // slsmCodeComboBox
            // 
            this.slsmCodeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoiceItemBindingSource, "OutletCode", true));
            this.slsmCodeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.slsmCodeComboBox.DataSource = this.outletItemBindingSource;
            this.slsmCodeComboBox.DisplayMember = "OutletName";
            this.slsmCodeComboBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.slsmCodeComboBox.FormattingEnabled = true;
            this.slsmCodeComboBox.Location = new System.Drawing.Point(472, 43);
            this.slsmCodeComboBox.Name = "slsmCodeComboBox";
            this.slsmCodeComboBox.Size = new System.Drawing.Size(259, 26);
            this.slsmCodeComboBox.TabIndex = 12;
            this.slsmCodeComboBox.ValueMember = "OutletCode";
            // 
            // outletItemBindingSource
            // 
            this.outletItemBindingSource.DataSource = typeof(Invoice_OTC.Model.outletItem);
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.subTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceItemBindingSource, "SubTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"));
            this.subTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.subTotalTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.subTotalTextBox.Location = new System.Drawing.Point(731, 304);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.Size = new System.Drawing.Size(200, 24);
            this.subTotalTextBox.TabIndex = 18;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceItemBindingSource, "Total", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"));
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.totalTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.totalTextBox.Location = new System.Drawing.Point(731, 360);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 24);
            this.totalTextBox.TabIndex = 20;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.invoiceItemBindingSource;
            this.itemsBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.itemsBindingSource_AddingNew);
            this.itemsBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.itemsBindingSource_ListChanged);
            // 
            // itemsDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.itemsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.itemsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsDataGridView.AutoGenerateColumns = false;
            this.itemsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.itemsDataGridView.DataSource = this.itemsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemsDataGridView.Location = new System.Drawing.Point(23, 133);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.Size = new System.Drawing.Size(905, 165);
            this.itemsDataGridView.TabIndex = 21;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.DataSource = this.rotiToChooseItemBindingSource;
            this.codeDataGridViewTextBoxColumn.DisplayMember = "ItemName";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.codeDataGridViewTextBoxColumn.ValueMember = "ItemCode";
            // 
            // rotiToChooseItemBindingSource
            // 
            this.rotiToChooseItemBindingSource.DataSource = typeof(Invoice_OTC.Model.RotiToChooseItem);
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // batalBtn
            // 
            this.batalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.batalBtn.Image = global::Invoice_OTC.Properties.Resources.Close_Window_96px;
            this.batalBtn.Location = new System.Drawing.Point(264, 313);
            this.batalBtn.Name = "batalBtn";
            this.batalBtn.Size = new System.Drawing.Size(72, 65);
            this.batalBtn.TabIndex = 25;
            this.batalBtn.UseVisualStyleBackColor = true;
            this.batalBtn.Click += new System.EventHandler(this.batalBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteBtn.Image = global::Invoice_OTC.Properties.Resources.Delete_50px;
            this.deleteBtn.Location = new System.Drawing.Point(186, 313);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(72, 65);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // simpanBtn
            // 
            this.simpanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpanBtn.Image = global::Invoice_OTC.Properties.Resources.Pencil_Tip_50px;
            this.simpanBtn.Location = new System.Drawing.Point(108, 313);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(72, 65);
            this.simpanBtn.TabIndex = 23;
            this.simpanBtn.UseVisualStyleBackColor = true;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // tambahBtn
            // 
            this.tambahBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tambahBtn.Image = global::Invoice_OTC.Properties.Resources.Add_50px;
            this.tambahBtn.Location = new System.Drawing.Point(30, 313);
            this.tambahBtn.Name = "tambahBtn";
            this.tambahBtn.Size = new System.Drawing.Size(72, 65);
            this.tambahBtn.TabIndex = 22;
            this.tambahBtn.UseVisualStyleBackColor = true;
            this.tambahBtn.Click += new System.EventHandler(this.tambahBtn_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.invoiceItemBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 32);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(943, 25);
            this.bindingNavigator1.TabIndex = 26;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // outletAddressTextBox
            // 
            this.outletAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.outletAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outletItemBindingSource, "OutletAddress", true));
            this.outletAddressTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.outletAddressTextBox.Location = new System.Drawing.Point(472, 75);
            this.outletAddressTextBox.Multiline = true;
            this.outletAddressTextBox.Name = "outletAddressTextBox";
            this.outletAddressTextBox.Size = new System.Drawing.Size(259, 52);
            this.outletAddressTextBox.TabIndex = 27;
            // 
            // isPPNCheckBox
            // 
            this.isPPNCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.invoiceItemBindingSource, "IsPPN", true));
            this.isPPNCheckBox.Location = new System.Drawing.Point(851, 41);
            this.isPPNCheckBox.Name = "isPPNCheckBox";
            this.isPPNCheckBox.Size = new System.Drawing.Size(20, 24);
            this.isPPNCheckBox.TabIndex = 28;
            this.isPPNCheckBox.UseVisualStyleBackColor = true;
            // 
            // findStrip1
            // 
            this.findStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.findStrip1.bindingSource = this.invoiceItemBindingSource;
            this.findStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.cetakBtn});
            this.findStrip1.Location = new System.Drawing.Point(0, 0);
            this.findStrip1.Name = "findStrip1";
            this.findStrip1.Size = new System.Drawing.Size(943, 32);
            this.findStrip1.TabIndex = 2;
            this.findStrip1.Text = "findStrip1";
            this.findStrip1.ItemFound += new Invoice_OTC.Controller.ItemFoundEventHandler(this.findStrip1_ItemFound);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Invoice_OTC.Properties.Resources.Open_Folder_96px;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(111, 29);
            this.toolStripButton1.Text = "Show Navigator";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // cetakBtn
            // 
            this.cetakBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cetakBtn.Image = global::Invoice_OTC.Properties.Resources.Print_96px;
            this.cetakBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cetakBtn.Name = "cetakBtn";
            this.cetakBtn.Size = new System.Drawing.Size(57, 29);
            this.cetakBtn.Text = "Cetak";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(809, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // detailedBindingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 419);
            this.Controls.Add(this.button1);
            this.Controls.Add(isPPNLabel);
            this.Controls.Add(this.isPPNCheckBox);
            this.Controls.Add(outletAddressLabel);
            this.Controls.Add(this.outletAddressTextBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.batalBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.simpanBtn);
            this.Controls.Add(this.tambahBtn);
            this.Controls.Add(this.findStrip1);
            this.Controls.Add(this.itemsDataGridView);
            this.Controls.Add(issuedDataLabel);
            this.Controls.Add(this.issuedDataDateTimePicker);
            this.Controls.Add(nomorLabel);
            this.Controls.Add(this.nomorTextBox);
            this.Controls.Add(periodeBulanLabel);
            this.Controls.Add(this.periodeBulanDateTimePicker);
            this.Controls.Add(pPNLabel);
            this.Controls.Add(this.pPNTextBox);
            this.Controls.Add(slsmCodeLabel);
            this.Controls.Add(this.slsmCodeComboBox);
            this.Controls.Add(subTotalLabel);
            this.Controls.Add(this.subTotalTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "detailedBindingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "detailedBindingForm";
            this.Load += new System.EventHandler(this.detailedBindingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotiToChooseItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.findStrip1.ResumeLayout(false);
            this.findStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource invoiceItemBindingSource;
        private System.Windows.Forms.DateTimePicker issuedDataDateTimePicker;
        private System.Windows.Forms.TextBox nomorTextBox;
        private System.Windows.Forms.DateTimePicker periodeBulanDateTimePicker;
        private System.Windows.Forms.TextBox pPNTextBox;
        private System.Windows.Forms.ComboBox slsmCodeComboBox;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.BindingSource rotiToChooseItemBindingSource;
        private Controller.FindStrip findStrip1;
        private System.Windows.Forms.Button batalBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Button tambahBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource outletItemBindingSource;
        private System.Windows.Forms.ToolStripButton cetakBtn;
        private System.Windows.Forms.TextBox outletAddressTextBox;
        private System.Windows.Forms.CheckBox isPPNCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewComboBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}