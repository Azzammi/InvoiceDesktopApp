namespace InvoiceOTCNew
{
    partial class FrmInvoice
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
            System.Windows.Forms.Label dueDateLabel;
            System.Windows.Forms.Label idPaymentLabel;
            System.Windows.Forms.Label invoiceIDLabel;
            System.Windows.Forms.Label isPayedLabel;
            System.Windows.Forms.Label isPPNLabel;
            System.Windows.Forms.Label issuedDateLabel;
            System.Windows.Forms.Label nomorInvoiceLabel;
            System.Windows.Forms.Label nomorPOLabel;
            System.Windows.Forms.Label outletCodeLabel;
            System.Windows.Forms.Label penggunaLabel;
            System.Windows.Forms.Label periodeLabel;
            System.Windows.Forms.Label ppnLabel;
            System.Windows.Forms.Label subTotalLabel;
            System.Windows.Forms.Label totalLabel;
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idPaymentTextBox = new System.Windows.Forms.TextBox();
            this.invoiceIDTextBox = new System.Windows.Forms.TextBox();
            this.isPayedCheckBox = new System.Windows.Forms.CheckBox();
            this.isPPNCheckBox = new System.Windows.Forms.CheckBox();
            this.issuedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nomorInvoiceTextBox = new System.Windows.Forms.TextBox();
            this.nomorPOTextBox = new System.Windows.Forms.TextBox();
            this.penggunaTextBox = new System.Windows.Forms.TextBox();
            this.periodeTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.p_ItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.ppnTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.outletCodeComboBox = new System.Windows.Forms.ComboBox();
            dueDateLabel = new System.Windows.Forms.Label();
            idPaymentLabel = new System.Windows.Forms.Label();
            invoiceIDLabel = new System.Windows.Forms.Label();
            isPayedLabel = new System.Windows.Forms.Label();
            isPPNLabel = new System.Windows.Forms.Label();
            issuedDateLabel = new System.Windows.Forms.Label();
            nomorInvoiceLabel = new System.Windows.Forms.Label();
            nomorPOLabel = new System.Windows.Forms.Label();
            outletCodeLabel = new System.Windows.Forms.Label();
            penggunaLabel = new System.Windows.Forms.Label();
            periodeLabel = new System.Windows.Forms.Label();
            ppnLabel = new System.Windows.Forms.Label();
            subTotalLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pItemsBindingSource)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_ItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new System.Drawing.Point(3, 0);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new System.Drawing.Size(54, 13);
            dueDateLabel.TabIndex = 0;
            dueDateLabel.Text = "due Date:";
            // 
            // idPaymentLabel
            // 
            idPaymentLabel.AutoSize = true;
            idPaymentLabel.Location = new System.Drawing.Point(3, 26);
            idPaymentLabel.Name = "idPaymentLabel";
            idPaymentLabel.Size = new System.Drawing.Size(62, 13);
            idPaymentLabel.TabIndex = 2;
            idPaymentLabel.Text = "id Payment:";
            // 
            // invoiceIDLabel
            // 
            invoiceIDLabel.AutoSize = true;
            invoiceIDLabel.Location = new System.Drawing.Point(3, 52);
            invoiceIDLabel.Name = "invoiceIDLabel";
            invoiceIDLabel.Size = new System.Drawing.Size(58, 13);
            invoiceIDLabel.TabIndex = 4;
            invoiceIDLabel.Text = "invoice ID:";
            // 
            // isPayedLabel
            // 
            isPayedLabel.AutoSize = true;
            isPayedLabel.Location = new System.Drawing.Point(3, 78);
            isPayedLabel.Name = "isPayedLabel";
            isPayedLabel.Size = new System.Drawing.Size(50, 13);
            isPayedLabel.TabIndex = 6;
            isPayedLabel.Text = "is Payed:";
            // 
            // isPPNLabel
            // 
            isPPNLabel.AutoSize = true;
            isPPNLabel.Location = new System.Drawing.Point(3, 108);
            isPPNLabel.Name = "isPPNLabel";
            isPPNLabel.Size = new System.Drawing.Size(42, 13);
            isPPNLabel.TabIndex = 8;
            isPPNLabel.Text = "is PPN:";
            // 
            // issuedDateLabel
            // 
            issuedDateLabel.AutoSize = true;
            issuedDateLabel.Location = new System.Drawing.Point(3, 138);
            issuedDateLabel.Name = "issuedDateLabel";
            issuedDateLabel.Size = new System.Drawing.Size(66, 13);
            issuedDateLabel.TabIndex = 10;
            issuedDateLabel.Text = "issued Date:";
            // 
            // nomorInvoiceLabel
            // 
            nomorInvoiceLabel.AutoSize = true;
            nomorInvoiceLabel.Location = new System.Drawing.Point(3, 164);
            nomorInvoiceLabel.Name = "nomorInvoiceLabel";
            nomorInvoiceLabel.Size = new System.Drawing.Size(77, 13);
            nomorInvoiceLabel.TabIndex = 12;
            nomorInvoiceLabel.Text = "nomor Invoice:";
            // 
            // nomorPOLabel
            // 
            nomorPOLabel.AutoSize = true;
            nomorPOLabel.Location = new System.Drawing.Point(3, 190);
            nomorPOLabel.Name = "nomorPOLabel";
            nomorPOLabel.Size = new System.Drawing.Size(57, 13);
            nomorPOLabel.TabIndex = 14;
            nomorPOLabel.Text = "nomor PO:";
            // 
            // outletCodeLabel
            // 
            outletCodeLabel.AutoSize = true;
            outletCodeLabel.Location = new System.Drawing.Point(3, 216);
            outletCodeLabel.Name = "outletCodeLabel";
            outletCodeLabel.Size = new System.Drawing.Size(64, 13);
            outletCodeLabel.TabIndex = 16;
            outletCodeLabel.Text = "outlet Code:";
            // 
            // penggunaLabel
            // 
            penggunaLabel.AutoSize = true;
            penggunaLabel.Location = new System.Drawing.Point(3, 243);
            penggunaLabel.Name = "penggunaLabel";
            penggunaLabel.Size = new System.Drawing.Size(58, 13);
            penggunaLabel.TabIndex = 18;
            penggunaLabel.Text = "pengguna:";
            // 
            // periodeLabel
            // 
            periodeLabel.AutoSize = true;
            periodeLabel.Location = new System.Drawing.Point(3, 269);
            periodeLabel.Name = "periodeLabel";
            periodeLabel.Size = new System.Drawing.Size(45, 13);
            periodeLabel.TabIndex = 20;
            periodeLabel.Text = "periode:";
            // 
            // ppnLabel
            // 
            ppnLabel.AutoSize = true;
            ppnLabel.Location = new System.Drawing.Point(3, 35);
            ppnLabel.Name = "ppnLabel";
            ppnLabel.Size = new System.Drawing.Size(28, 13);
            ppnLabel.TabIndex = 22;
            ppnLabel.Text = "ppn:";
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Location = new System.Drawing.Point(3, 0);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new System.Drawing.Size(54, 13);
            subTotalLabel.TabIndex = 24;
            subTotalLabel.Text = "sub Total:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(3, 73);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(30, 13);
            totalLabel.TabIndex = 26;
            totalLabel.Text = "total:";
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(InvoiceOTC.Model.Invoice);
            // 
            // outletBindingSource
            // 
            this.outletBindingSource.DataSource = typeof(InvoiceOTC.Model.Outlet);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(InvoiceOTC.Model.Product);
            // 
            // pItemsBindingSource
            // 
            this.pItemsBindingSource.DataMember = "p_Items";
            this.pItemsBindingSource.DataSource = this.invoiceBindingSource;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 58);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(907, 456);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(dueDateLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dueDateDateTimePicker, 1, 0);
            this.tableLayoutPanel5.Controls.Add(idPaymentLabel, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.idPaymentTextBox, 1, 1);
            this.tableLayoutPanel5.Controls.Add(invoiceIDLabel, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.invoiceIDTextBox, 1, 2);
            this.tableLayoutPanel5.Controls.Add(isPayedLabel, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.isPayedCheckBox, 1, 3);
            this.tableLayoutPanel5.Controls.Add(isPPNLabel, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.isPPNCheckBox, 1, 4);
            this.tableLayoutPanel5.Controls.Add(issuedDateLabel, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.issuedDateDateTimePicker, 1, 5);
            this.tableLayoutPanel5.Controls.Add(nomorInvoiceLabel, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.nomorInvoiceTextBox, 1, 6);
            this.tableLayoutPanel5.Controls.Add(nomorPOLabel, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.nomorPOTextBox, 1, 7);
            this.tableLayoutPanel5.Controls.Add(outletCodeLabel, 0, 8);
            this.tableLayoutPanel5.Controls.Add(penggunaLabel, 0, 9);
            this.tableLayoutPanel5.Controls.Add(this.penggunaTextBox, 1, 9);
            this.tableLayoutPanel5.Controls.Add(periodeLabel, 0, 10);
            this.tableLayoutPanel5.Controls.Add(this.periodeTextBox, 1, 10);
            this.tableLayoutPanel5.Controls.Add(this.outletCodeComboBox, 1, 8);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 15;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(447, 450);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // dueDateDateTimePicker
            // 
            this.dueDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "dueDate", true));
            this.dueDateDateTimePicker.Location = new System.Drawing.Point(226, 3);
            this.dueDateDateTimePicker.Name = "dueDateDateTimePicker";
            this.dueDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dueDateDateTimePicker.TabIndex = 1;
            // 
            // idPaymentTextBox
            // 
            this.idPaymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "idPayment", true));
            this.idPaymentTextBox.Location = new System.Drawing.Point(226, 29);
            this.idPaymentTextBox.Name = "idPaymentTextBox";
            this.idPaymentTextBox.Size = new System.Drawing.Size(200, 20);
            this.idPaymentTextBox.TabIndex = 3;
            // 
            // invoiceIDTextBox
            // 
            this.invoiceIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "invoiceID", true));
            this.invoiceIDTextBox.Location = new System.Drawing.Point(226, 55);
            this.invoiceIDTextBox.Name = "invoiceIDTextBox";
            this.invoiceIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.invoiceIDTextBox.TabIndex = 5;
            // 
            // isPayedCheckBox
            // 
            this.isPayedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.invoiceBindingSource, "isPayed", true));
            this.isPayedCheckBox.Location = new System.Drawing.Point(226, 81);
            this.isPayedCheckBox.Name = "isPayedCheckBox";
            this.isPayedCheckBox.Size = new System.Drawing.Size(200, 24);
            this.isPayedCheckBox.TabIndex = 7;
            this.isPayedCheckBox.Text = "checkBox1";
            this.isPayedCheckBox.UseVisualStyleBackColor = true;
            // 
            // isPPNCheckBox
            // 
            this.isPPNCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.invoiceBindingSource, "isPPN", true));
            this.isPPNCheckBox.Location = new System.Drawing.Point(226, 111);
            this.isPPNCheckBox.Name = "isPPNCheckBox";
            this.isPPNCheckBox.Size = new System.Drawing.Size(200, 24);
            this.isPPNCheckBox.TabIndex = 9;
            this.isPPNCheckBox.Text = "checkBox1";
            this.isPPNCheckBox.UseVisualStyleBackColor = true;
            // 
            // issuedDateDateTimePicker
            // 
            this.issuedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "issuedDate", true));
            this.issuedDateDateTimePicker.Location = new System.Drawing.Point(226, 141);
            this.issuedDateDateTimePicker.Name = "issuedDateDateTimePicker";
            this.issuedDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.issuedDateDateTimePicker.TabIndex = 11;
            // 
            // nomorInvoiceTextBox
            // 
            this.nomorInvoiceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "nomorInvoice", true));
            this.nomorInvoiceTextBox.Location = new System.Drawing.Point(226, 167);
            this.nomorInvoiceTextBox.Name = "nomorInvoiceTextBox";
            this.nomorInvoiceTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomorInvoiceTextBox.TabIndex = 13;
            // 
            // nomorPOTextBox
            // 
            this.nomorPOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "nomorPO", true));
            this.nomorPOTextBox.Location = new System.Drawing.Point(226, 193);
            this.nomorPOTextBox.Name = "nomorPOTextBox";
            this.nomorPOTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomorPOTextBox.TabIndex = 15;
            // 
            // penggunaTextBox
            // 
            this.penggunaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "pengguna", true));
            this.penggunaTextBox.Location = new System.Drawing.Point(226, 246);
            this.penggunaTextBox.Name = "penggunaTextBox";
            this.penggunaTextBox.Size = new System.Drawing.Size(200, 20);
            this.penggunaTextBox.TabIndex = 19;
            // 
            // periodeTextBox
            // 
            this.periodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "periode", true));
            this.periodeTextBox.Location = new System.Drawing.Point(226, 272);
            this.periodeTextBox.Name = "periodeTextBox";
            this.periodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.periodeTextBox.TabIndex = 21;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.p_ItemsDataGridView, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(456, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(448, 450);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // p_ItemsDataGridView
            // 
            this.p_ItemsDataGridView.AutoGenerateColumns = false;
            this.p_ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.p_ItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.p_ItemsDataGridView.DataSource = this.detailBindingSource;
            this.p_ItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_ItemsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.p_ItemsDataGridView.Name = "p_ItemsDataGridView";
            this.p_ItemsDataGridView.Size = new System.Drawing.Size(442, 327);
            this.p_ItemsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "itemCode";
            this.dataGridViewTextBoxColumn3.DataSource = this.productBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "itemName";
            this.dataGridViewTextBoxColumn3.HeaderText = "itemCode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "itemCode";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "itemQty";
            this.dataGridViewTextBoxColumn4.HeaderText = "itemQty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "discount";
            this.dataGridViewTextBoxColumn5.HeaderText = "discount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "itemPrice";
            this.dataGridViewTextBoxColumn6.HeaderText = "itemPrice";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "subTotal";
            this.dataGridViewTextBoxColumn7.HeaderText = "subTotal";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // detailBindingSource
            // 
            this.detailBindingSource.DataMember = "detail";
            this.detailBindingSource.DataSource = this.invoiceBindingSource;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(subTotalLabel, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.subTotalTextBox, 1, 0);
            this.tableLayoutPanel7.Controls.Add(ppnLabel, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.ppnTextBox, 1, 1);
            this.tableLayoutPanel7.Controls.Add(totalLabel, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.totalTextBox, 1, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 336);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.2973F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.7027F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(442, 111);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "subTotal", true));
            this.subTotalTextBox.Location = new System.Drawing.Point(224, 3);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.Size = new System.Drawing.Size(200, 20);
            this.subTotalTextBox.TabIndex = 25;
            // 
            // ppnTextBox
            // 
            this.ppnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "ppn", true));
            this.ppnTextBox.Location = new System.Drawing.Point(224, 38);
            this.ppnTextBox.Name = "ppnTextBox";
            this.ppnTextBox.Size = new System.Drawing.Size(200, 20);
            this.ppnTextBox.TabIndex = 23;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(224, 76);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalTextBox.TabIndex = 27;
            // 
            // outletCodeComboBox
            // 
            this.outletCodeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoiceBindingSource, "outletCode", true));
            this.outletCodeComboBox.DataSource = this.outletBindingSource;
            this.outletCodeComboBox.DisplayMember = "outlName";
            this.outletCodeComboBox.FormattingEnabled = true;
            this.outletCodeComboBox.Location = new System.Drawing.Point(226, 219);
            this.outletCodeComboBox.Name = "outletCodeComboBox";
            this.outletCodeComboBox.Size = new System.Drawing.Size(200, 21);
            this.outletCodeComboBox.TabIndex = 22;
            this.outletCodeComboBox.ValueMember = "outlCode";
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 561);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "FrmInvoice";
            this.Text = "FrmInvoice";
            this.Load += new System.EventHandler(this.FrmInvoice_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pItemsBindingSource)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p_ItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.BindingSource pItemsBindingSource;
        private System.Windows.Forms.BindingSource outletBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DateTimePicker dueDateDateTimePicker;
        private System.Windows.Forms.TextBox idPaymentTextBox;
        private System.Windows.Forms.TextBox invoiceIDTextBox;
        private System.Windows.Forms.CheckBox isPayedCheckBox;
        private System.Windows.Forms.CheckBox isPPNCheckBox;
        private System.Windows.Forms.DateTimePicker issuedDateDateTimePicker;
        private System.Windows.Forms.TextBox nomorInvoiceTextBox;
        private System.Windows.Forms.TextBox nomorPOTextBox;
        private System.Windows.Forms.TextBox penggunaTextBox;
        private System.Windows.Forms.TextBox periodeTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.DataGridView p_ItemsDataGridView;
        private System.Windows.Forms.BindingSource detailBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.TextBox ppnTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ComboBox outletCodeComboBox;
    }
}