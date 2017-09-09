namespace Invoice_OTC
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.nomorTxt = new System.Windows.Forms.TextBox();
            this.bindingInvoice = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.namaInstitusiCmb = new System.Windows.Forms.ComboBox();
            this.customerListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.issuedDt = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuRotiList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseRotiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingItems = new System.Windows.Forms.BindingSource(this.components);
            this.namaInstitusiLbl = new System.Windows.Forms.Label();
            this.totalKotorTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ppnTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.totalBersihTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tambahBtn = new System.Windows.Forms.Button();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.batalBtn = new System.Windows.Forms.Button();
            this.cekInvoiceLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.invoiceIDTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.findStrip1 = new Invoice_OTC.Controller.FindStrip();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuRotiList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Invoice";
            // 
            // nomorTxt
            // 
            this.nomorTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingInvoice, "Nomor", true));
            this.nomorTxt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingInvoice, "Nomor", true));
            this.nomorTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomorTxt.Location = new System.Drawing.Point(112, 78);
            this.nomorTxt.Name = "nomorTxt";
            this.nomorTxt.Size = new System.Drawing.Size(262, 26);
            this.nomorTxt.TabIndex = 0;
            // 
            // bindingInvoice
            // 
            this.bindingInvoice.DataSource = typeof(Invoice_OTC.Model.InvoiceItem);
            this.bindingInvoice.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingInvoice_ListChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Periode Bulan";
            // 
            // namaInstitusiCmb
            // 
            this.namaInstitusiCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.namaInstitusiCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.namaInstitusiCmb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingInvoice, "SlsmFullName", true));
            this.namaInstitusiCmb.DataSource = this.customerListBindingSource;
            this.namaInstitusiCmb.DisplayMember = "FullName";
            this.namaInstitusiCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaInstitusiCmb.FormattingEnabled = true;
            this.namaInstitusiCmb.Location = new System.Drawing.Point(112, 146);
            this.namaInstitusiCmb.Name = "namaInstitusiCmb";
            this.namaInstitusiCmb.Size = new System.Drawing.Size(262, 28);
            this.namaInstitusiCmb.TabIndex = 5;
            this.namaInstitusiCmb.ValueMember = "SlsmCode";
            this.namaInstitusiCmb.SelectedIndexChanged += new System.EventHandler(this.namaInstitusiCmb_SelectedIndexChanged);
            // 
            // customerListBindingSource
            // 
            this.customerListBindingSource.DataSource = typeof(Invoice_OTC.Model.CustomerList);
            // 
            // bindingCustomer
            // 
            this.bindingCustomer.DataSource = typeof(Invoice_OTC.Model.CustomerList);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nama Institusi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dibuat Tanggal";
            // 
            // issuedDt
            // 
            this.issuedDt.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedDt.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingInvoice, "IssuedData", true));
            this.issuedDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedDt.Location = new System.Drawing.Point(112, 195);
            this.issuedDt.Name = "issuedDt";
            this.issuedDt.Size = new System.Drawing.Size(262, 26);
            this.issuedDt.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuRotiList;
            this.dataGridView1.DataSource = this.bindingItems;
            this.dataGridView1.Location = new System.Drawing.Point(23, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 188);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // contextMenuRotiList
            // 
            this.contextMenuRotiList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteItemToolStripMenuItem,
            this.browseRotiToolStripMenuItem});
            this.contextMenuRotiList.Name = "contextMenuStrip1";
            this.contextMenuRotiList.Size = new System.Drawing.Size(137, 48);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.deleteItemToolStripMenuItem.Text = "Delete Item";
            // 
            // browseRotiToolStripMenuItem
            // 
            this.browseRotiToolStripMenuItem.Name = "browseRotiToolStripMenuItem";
            this.browseRotiToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.browseRotiToolStripMenuItem.Text = "Browse Roti";
            this.browseRotiToolStripMenuItem.Click += new System.EventHandler(this.browseRotiToolStripMenuItem_Click);
            // 
            // bindingItems
            // 
            this.bindingItems.DataSource = typeof(Invoice_OTC.Model.rotiItem);
            this.bindingItems.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.bindingItems_AddingNew);
            this.bindingItems.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingItems_ListChanged);
            // 
            // namaInstitusiLbl
            // 
            this.namaInstitusiLbl.AutoSize = true;
            this.namaInstitusiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaInstitusiLbl.Location = new System.Drawing.Point(110, 175);
            this.namaInstitusiLbl.Name = "namaInstitusiLbl";
            this.namaInstitusiLbl.Size = new System.Drawing.Size(101, 16);
            this.namaInstitusiLbl.TabIndex = 6;
            this.namaInstitusiLbl.Text = "Dibuat Tanggal";
            // 
            // totalKotorTxt
            // 
            this.totalKotorTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingInvoice, "SubTotal", true));
            this.totalKotorTxt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingInvoice, "SubTotal", true));
            this.totalKotorTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalKotorTxt.Location = new System.Drawing.Point(495, 234);
            this.totalKotorTxt.Name = "totalKotorTxt";
            this.totalKotorTxt.ReadOnly = true;
            this.totalKotorTxt.Size = new System.Drawing.Size(268, 26);
            this.totalKotorTxt.TabIndex = 10;
            this.totalKotorTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(406, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total Kotor";
            // 
            // ppnTxt
            // 
            this.ppnTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingInvoice, "PPN", true));
            this.ppnTxt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingInvoice, "PPN", true));
            this.ppnTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppnTxt.Location = new System.Drawing.Point(495, 266);
            this.ppnTxt.Name = "ppnTxt";
            this.ppnTxt.ReadOnly = true;
            this.ppnTxt.Size = new System.Drawing.Size(268, 26);
            this.ppnTxt.TabIndex = 11;
            this.ppnTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(406, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "PPN";
            // 
            // totalBersihTxt
            // 
            this.totalBersihTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingInvoice, "Total", true));
            this.totalBersihTxt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingInvoice, "Total", true));
            this.totalBersihTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBersihTxt.Location = new System.Drawing.Point(495, 298);
            this.totalBersihTxt.Name = "totalBersihTxt";
            this.totalBersihTxt.ReadOnly = true;
            this.totalBersihTxt.Size = new System.Drawing.Size(268, 26);
            this.totalBersihTxt.TabIndex = 12;
            this.totalBersihTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(406, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Total Bersih";
            // 
            // tambahBtn
            // 
            this.tambahBtn.Image = global::Invoice_OTC.Properties.Resources.Add_50px;
            this.tambahBtn.Location = new System.Drawing.Point(457, 357);
            this.tambahBtn.Name = "tambahBtn";
            this.tambahBtn.Size = new System.Drawing.Size(72, 65);
            this.tambahBtn.TabIndex = 13;
            this.tambahBtn.UseVisualStyleBackColor = true;
            this.tambahBtn.Click += new System.EventHandler(this.tambahBtn_Click);
            // 
            // simpanBtn
            // 
            this.simpanBtn.Image = global::Invoice_OTC.Properties.Resources.Save_50px_1;
            this.simpanBtn.Location = new System.Drawing.Point(535, 357);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(72, 65);
            this.simpanBtn.TabIndex = 14;
            this.simpanBtn.UseVisualStyleBackColor = true;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Image = global::Invoice_OTC.Properties.Resources.Delete_50px;
            this.deleteBtn.Location = new System.Drawing.Point(613, 357);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(72, 65);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // batalBtn
            // 
            this.batalBtn.Image = global::Invoice_OTC.Properties.Resources.Close_Window_96px;
            this.batalBtn.Location = new System.Drawing.Point(691, 357);
            this.batalBtn.Name = "batalBtn";
            this.batalBtn.Size = new System.Drawing.Size(72, 65);
            this.batalBtn.TabIndex = 16;
            this.batalBtn.UseVisualStyleBackColor = true;
            this.batalBtn.Click += new System.EventHandler(this.batalBtn_Click);
            // 
            // cekInvoiceLbl
            // 
            this.cekInvoiceLbl.AutoSize = true;
            this.cekInvoiceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cekInvoiceLbl.Location = new System.Drawing.Point(391, 53);
            this.cekInvoiceLbl.Name = "cekInvoiceLbl";
            this.cekInvoiceLbl.Size = new System.Drawing.Size(91, 16);
            this.cekInvoiceLbl.TabIndex = 26;
            this.cekInvoiceLbl.Text = "Status Invoice";
            // 
            // button1
            // 
            this.button1.Image = global::Invoice_OTC.Properties.Resources.Receipt_96px;
            this.button1.Location = new System.Drawing.Point(592, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 92);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingInvoice, "PeriodeBulan", true));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 26);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // invoiceIDTxt
            // 
            this.invoiceIDTxt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingInvoice, "InvoiceID", true));
            this.invoiceIDTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingInvoice, "InvoiceID", true));
            this.invoiceIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceIDTxt.Location = new System.Drawing.Point(112, 46);
            this.invoiceIDTxt.Name = "invoiceIDTxt";
            this.invoiceIDTxt.Size = new System.Drawing.Size(262, 26);
            this.invoiceIDTxt.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "invoiceID";
            // 
            // findStrip1
            // 
            this.findStrip1.BackColor = System.Drawing.Color.Maroon;
            this.findStrip1.bindingSource = this.bindingInvoice;
            this.findStrip1.Location = new System.Drawing.Point(0, 0);
            this.findStrip1.Name = "findStrip1";
            this.findStrip1.Size = new System.Drawing.Size(784, 32);
            this.findStrip1.TabIndex = 2;
            this.findStrip1.Text = "findStrip1";
            this.findStrip1.ItemFound += new Invoice_OTC.Controller.ItemFoundEventHandler(this.findStrip1_ItemFound);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 442);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.findStrip1);
            this.Controls.Add(this.invoiceIDTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cekInvoiceLbl);
            this.Controls.Add(this.batalBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.simpanBtn);
            this.Controls.Add(this.tambahBtn);
            this.Controls.Add(this.totalBersihTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ppnTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalKotorTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.namaInstitusiLbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.issuedDt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.namaInstitusiCmb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nomorTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuRotiList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomorTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker issuedDt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label namaInstitusiLbl;
        private System.Windows.Forms.BindingSource bindingInvoice;
        private System.Windows.Forms.TextBox totalKotorTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ppnTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalBersihTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button tambahBtn;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button batalBtn;
        private System.Windows.Forms.Label cekInvoiceLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuRotiList;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorInvoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox invoiceIDTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem browseRotiToolStripMenuItem;
        private Controller.FindStrip findStrip1;
        private System.Windows.Forms.BindingSource customerListBindingSource;
        private System.Windows.Forms.BindingSource bindingCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox namaInstitusiCmb;
        private System.Windows.Forms.Label label3;
    }
}

