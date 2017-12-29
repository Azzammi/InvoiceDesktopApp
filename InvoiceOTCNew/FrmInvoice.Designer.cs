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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.penggunaTextBox = new System.Windows.Forms.TextBox();
            this.periodeTextBox = new System.Windows.Forms.TextBox();
            this.nomorInvoiceTextBox = new System.Windows.Forms.TextBox();
            this.issuedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nomorPOTextBox = new System.Windows.Forms.TextBox();
            this.isPPNCheckBox = new System.Windows.Forms.CheckBox();
            this.dueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idPaymentTextBox = new System.Windows.Forms.TextBox();
            this.isPayedCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.ppnTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.subTotalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxBase1 = new Syncfusion.Windows.Forms.Tools.ComboBoxBase();
            dueDateLabel = new System.Windows.Forms.Label();
            idPaymentLabel = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase1)).BeginInit();
            this.SuspendLayout();
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            dueDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dueDateLabel.ForeColor = System.Drawing.Color.White;
            dueDateLabel.Location = new System.Drawing.Point(3, 105);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new System.Drawing.Size(217, 26);
            dueDateLabel.TabIndex = 0;
            dueDateLabel.Text = "due Date:";
            // 
            // idPaymentLabel
            // 
            idPaymentLabel.AutoSize = true;
            idPaymentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            idPaymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idPaymentLabel.ForeColor = System.Drawing.Color.White;
            idPaymentLabel.Location = new System.Drawing.Point(3, 213);
            idPaymentLabel.Name = "idPaymentLabel";
            idPaymentLabel.Size = new System.Drawing.Size(217, 31);
            idPaymentLabel.TabIndex = 2;
            idPaymentLabel.Text = "id Payment:";
            // 
            // isPayedLabel
            // 
            isPayedLabel.AutoSize = true;
            isPayedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            isPayedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            isPayedLabel.ForeColor = System.Drawing.Color.White;
            isPayedLabel.Location = new System.Drawing.Point(3, 244);
            isPayedLabel.Name = "isPayedLabel";
            isPayedLabel.Size = new System.Drawing.Size(217, 41);
            isPayedLabel.TabIndex = 6;
            isPayedLabel.Text = "is Payed:";
            // 
            // isPPNLabel
            // 
            isPPNLabel.AutoSize = true;
            isPPNLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            isPPNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            isPPNLabel.ForeColor = System.Drawing.Color.White;
            isPPNLabel.Location = new System.Drawing.Point(3, 131);
            isPPNLabel.Name = "isPPNLabel";
            isPPNLabel.Size = new System.Drawing.Size(217, 30);
            isPPNLabel.TabIndex = 8;
            isPPNLabel.Text = "is PPN:";
            // 
            // issuedDateLabel
            // 
            issuedDateLabel.AutoSize = true;
            issuedDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            issuedDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            issuedDateLabel.ForeColor = System.Drawing.Color.White;
            issuedDateLabel.Location = new System.Drawing.Point(3, 26);
            issuedDateLabel.Name = "issuedDateLabel";
            issuedDateLabel.Size = new System.Drawing.Size(217, 26);
            issuedDateLabel.TabIndex = 10;
            issuedDateLabel.Text = "issued Date:";
            // 
            // nomorInvoiceLabel
            // 
            nomorInvoiceLabel.AutoSize = true;
            nomorInvoiceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            nomorInvoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomorInvoiceLabel.ForeColor = System.Drawing.Color.White;
            nomorInvoiceLabel.Location = new System.Drawing.Point(3, 0);
            nomorInvoiceLabel.Name = "nomorInvoiceLabel";
            nomorInvoiceLabel.Size = new System.Drawing.Size(217, 26);
            nomorInvoiceLabel.TabIndex = 12;
            nomorInvoiceLabel.Text = "nomor Invoice:";
            // 
            // nomorPOLabel
            // 
            nomorPOLabel.AutoSize = true;
            nomorPOLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            nomorPOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomorPOLabel.ForeColor = System.Drawing.Color.White;
            nomorPOLabel.Location = new System.Drawing.Point(3, 79);
            nomorPOLabel.Name = "nomorPOLabel";
            nomorPOLabel.Size = new System.Drawing.Size(217, 26);
            nomorPOLabel.TabIndex = 14;
            nomorPOLabel.Text = "nomor PO:";
            // 
            // outletCodeLabel
            // 
            outletCodeLabel.AutoSize = true;
            outletCodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            outletCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            outletCodeLabel.ForeColor = System.Drawing.Color.White;
            outletCodeLabel.Location = new System.Drawing.Point(3, 52);
            outletCodeLabel.Name = "outletCodeLabel";
            outletCodeLabel.Size = new System.Drawing.Size(217, 27);
            outletCodeLabel.TabIndex = 16;
            outletCodeLabel.Text = "Outlet:";
            // 
            // penggunaLabel
            // 
            penggunaLabel.AutoSize = true;
            penggunaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            penggunaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            penggunaLabel.ForeColor = System.Drawing.Color.White;
            penggunaLabel.Location = new System.Drawing.Point(3, 161);
            penggunaLabel.Name = "penggunaLabel";
            penggunaLabel.Size = new System.Drawing.Size(217, 26);
            penggunaLabel.TabIndex = 18;
            penggunaLabel.Text = "pengguna:";
            // 
            // periodeLabel
            // 
            periodeLabel.AutoSize = true;
            periodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            periodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            periodeLabel.ForeColor = System.Drawing.Color.White;
            periodeLabel.Location = new System.Drawing.Point(3, 187);
            periodeLabel.Name = "periodeLabel";
            periodeLabel.Size = new System.Drawing.Size(217, 26);
            periodeLabel.TabIndex = 20;
            periodeLabel.Text = "periode:";
            // 
            // ppnLabel
            // 
            ppnLabel.AutoSize = true;
            ppnLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            ppnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ppnLabel.ForeColor = System.Drawing.Color.White;
            ppnLabel.Location = new System.Drawing.Point(3, 26);
            ppnLabel.Name = "ppnLabel";
            ppnLabel.Size = new System.Drawing.Size(215, 29);
            ppnLabel.TabIndex = 22;
            ppnLabel.Text = "ppn:";
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            subTotalLabel.ForeColor = System.Drawing.Color.White;
            subTotalLabel.Location = new System.Drawing.Point(3, 0);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new System.Drawing.Size(215, 26);
            subTotalLabel.TabIndex = 24;
            subTotalLabel.Text = "sub Total:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalLabel.ForeColor = System.Drawing.Color.White;
            totalLabel.Location = new System.Drawing.Point(3, 55);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(215, 38);
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
            this.tableLayoutPanel4.Size = new System.Drawing.Size(907, 384);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(penggunaLabel, 0, 9);
            this.tableLayoutPanel5.Controls.Add(this.penggunaTextBox, 1, 9);
            this.tableLayoutPanel5.Controls.Add(periodeLabel, 0, 10);
            this.tableLayoutPanel5.Controls.Add(this.periodeTextBox, 1, 10);
            this.tableLayoutPanel5.Controls.Add(this.nomorInvoiceTextBox, 1, 0);
            this.tableLayoutPanel5.Controls.Add(nomorInvoiceLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(issuedDateLabel, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.issuedDateDateTimePicker, 1, 1);
            this.tableLayoutPanel5.Controls.Add(outletCodeLabel, 0, 3);
            this.tableLayoutPanel5.Controls.Add(nomorPOLabel, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.nomorPOTextBox, 1, 4);
            this.tableLayoutPanel5.Controls.Add(isPPNLabel, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.isPPNCheckBox, 1, 7);
            this.tableLayoutPanel5.Controls.Add(dueDateLabel, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.dueDateDateTimePicker, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.idPaymentTextBox, 1, 14);
            this.tableLayoutPanel5.Controls.Add(idPaymentLabel, 0, 14);
            this.tableLayoutPanel5.Controls.Add(isPayedLabel, 0, 15);
            this.tableLayoutPanel5.Controls.Add(this.isPayedCheckBox, 1, 15);
            this.tableLayoutPanel5.Controls.Add(this.comboBoxBase1, 1, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 17;
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
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(447, 378);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // penggunaTextBox
            // 
            this.penggunaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "pengguna", true));
            this.penggunaTextBox.Location = new System.Drawing.Point(226, 164);
            this.penggunaTextBox.Name = "penggunaTextBox";
            this.penggunaTextBox.Size = new System.Drawing.Size(200, 20);
            this.penggunaTextBox.TabIndex = 19;
            // 
            // periodeTextBox
            // 
            this.periodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "periode", true));
            this.periodeTextBox.Location = new System.Drawing.Point(226, 190);
            this.periodeTextBox.Name = "periodeTextBox";
            this.periodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.periodeTextBox.TabIndex = 21;
            // 
            // nomorInvoiceTextBox
            // 
            this.nomorInvoiceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "nomorInvoice", true));
            this.nomorInvoiceTextBox.Location = new System.Drawing.Point(226, 3);
            this.nomorInvoiceTextBox.Name = "nomorInvoiceTextBox";
            this.nomorInvoiceTextBox.Size = new System.Drawing.Size(172, 20);
            this.nomorInvoiceTextBox.TabIndex = 13;
            // 
            // issuedDateDateTimePicker
            // 
            this.issuedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "issuedDate", true));
            this.issuedDateDateTimePicker.Location = new System.Drawing.Point(226, 29);
            this.issuedDateDateTimePicker.Name = "issuedDateDateTimePicker";
            this.issuedDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.issuedDateDateTimePicker.TabIndex = 11;
            // 
            // nomorPOTextBox
            // 
            this.nomorPOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "nomorPO", true));
            this.nomorPOTextBox.Location = new System.Drawing.Point(226, 82);
            this.nomorPOTextBox.Name = "nomorPOTextBox";
            this.nomorPOTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomorPOTextBox.TabIndex = 15;
            // 
            // isPPNCheckBox
            // 
            this.isPPNCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.invoiceBindingSource, "isPPN", true));
            this.isPPNCheckBox.ForeColor = System.Drawing.Color.White;
            this.isPPNCheckBox.Location = new System.Drawing.Point(226, 134);
            this.isPPNCheckBox.Name = "isPPNCheckBox";
            this.isPPNCheckBox.Size = new System.Drawing.Size(200, 24);
            this.isPPNCheckBox.TabIndex = 9;
            this.isPPNCheckBox.Text = "checkBox1";
            this.isPPNCheckBox.UseVisualStyleBackColor = true;
            // 
            // dueDateDateTimePicker
            // 
            this.dueDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "dueDate", true));
            this.dueDateDateTimePicker.Location = new System.Drawing.Point(226, 108);
            this.dueDateDateTimePicker.Name = "dueDateDateTimePicker";
            this.dueDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dueDateDateTimePicker.TabIndex = 1;
            // 
            // idPaymentTextBox
            // 
            this.idPaymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "idPayment", true));
            this.idPaymentTextBox.Location = new System.Drawing.Point(226, 216);
            this.idPaymentTextBox.Name = "idPaymentTextBox";
            this.idPaymentTextBox.Size = new System.Drawing.Size(200, 20);
            this.idPaymentTextBox.TabIndex = 3;
            // 
            // isPayedCheckBox
            // 
            this.isPayedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.invoiceBindingSource, "isPayed", true));
            this.isPayedCheckBox.ForeColor = System.Drawing.Color.White;
            this.isPayedCheckBox.Location = new System.Drawing.Point(226, 247);
            this.isPayedCheckBox.Name = "isPayedCheckBox";
            this.isPayedCheckBox.Size = new System.Drawing.Size(200, 24);
            this.isPayedCheckBox.TabIndex = 7;
            this.isPayedCheckBox.Text = "checkBox1";
            this.isPayedCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(456, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(448, 378);
            this.tableLayoutPanel6.TabIndex = 1;
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
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 282);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.2973F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.7027F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(442, 93);
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
            this.ppnTextBox.Location = new System.Drawing.Point(224, 29);
            this.ppnTextBox.Name = "ppnTextBox";
            this.ppnTextBox.Size = new System.Drawing.Size(200, 20);
            this.ppnTextBox.TabIndex = 23;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(224, 58);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalTextBox.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subTotalDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.detailBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 273);
            this.dataGridView1.TabIndex = 2;
            // 
            // subTotalDataGridViewTextBoxColumn1
            // 
            this.subTotalDataGridViewTextBoxColumn1.DataPropertyName = "subTotal";
            this.subTotalDataGridViewTextBoxColumn1.HeaderText = "subTotal";
            this.subTotalDataGridViewTextBoxColumn1.Name = "subTotalDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "itemCode";
            this.dataGridViewTextBoxColumn1.DataSource = this.productBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "itemName";
            this.dataGridViewTextBoxColumn1.HeaderText = "itemCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "itemCode";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "itemQty";
            this.dataGridViewTextBoxColumn2.HeaderText = "itemQty";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "discount";
            this.dataGridViewTextBoxColumn3.HeaderText = "discount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "itemPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "itemPrice";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // detailBindingSource
            // 
            this.detailBindingSource.DataMember = "detail";
            this.detailBindingSource.DataSource = this.invoiceBindingSource;
            // 
            // itemCode
            // 
            this.itemCode.DataPropertyName = "itemCode";
            this.itemCode.DataSource = this.productBindingSource;
            this.itemCode.DisplayMember = "itemName";
            this.itemCode.HeaderText = "itemCode";
            this.itemCode.Name = "itemCode";
            this.itemCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemCode.ValueMember = "itemCode";
            // 
            // itemQty
            // 
            this.itemQty.DataPropertyName = "itemQty";
            this.itemQty.HeaderText = "itemQty";
            this.itemQty.Name = "itemQty";
            // 
            // discount
            // 
            this.discount.DataPropertyName = "discount";
            this.discount.HeaderText = "discount";
            this.discount.Name = "discount";
            // 
            // itemPrice
            // 
            this.itemPrice.DataPropertyName = "itemPrice";
            this.itemPrice.HeaderText = "itemPrice";
            this.itemPrice.Name = "itemPrice";
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "subTotal";
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "subTotal";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            // 
            // comboBoxBase1
            // 
            this.comboBoxBase1.BeforeTouchSize = new System.Drawing.Size(121, 21);
            this.comboBoxBase1.Location = new System.Drawing.Point(226, 55);
            this.comboBoxBase1.Name = "comboBoxBase1";
            this.comboBoxBase1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBase1.TabIndex = 22;
            this.comboBoxBase1.Text = "comboBoxBase1";
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 483);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "FrmInvoice";
            this.Text = "FrmInvoice";
            this.Controls.SetChildIndex(this.tableLayoutPanel4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.BindingSource outletBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DateTimePicker dueDateDateTimePicker;
        private System.Windows.Forms.TextBox idPaymentTextBox;
        private System.Windows.Forms.CheckBox isPayedCheckBox;
        private System.Windows.Forms.CheckBox isPPNCheckBox;
        private System.Windows.Forms.DateTimePicker issuedDateDateTimePicker;
        private System.Windows.Forms.TextBox nomorInvoiceTextBox;
        private System.Windows.Forms.TextBox nomorPOTextBox;
        private System.Windows.Forms.TextBox penggunaTextBox;
        private System.Windows.Forms.TextBox periodeTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;        
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.TextBox ppnTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource detailBindingSource;
        private Syncfusion.Windows.Forms.Tools.ComboBoxBase comboBoxBase1;
    }
}