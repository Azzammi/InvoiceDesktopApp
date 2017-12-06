namespace Invoice_OTC.View
{
    partial class dgBindingFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgItem = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rotiToChooseItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingItem = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dgInvoice = new System.Windows.Forms.DataGridView();
            this.nomorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutletCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.outletItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outletCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPPNDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nomorPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPayedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingInvoice = new System.Windows.Forms.BindingSource(this.components);
            this.findStrip1 = new Invoice_OTC.Controller.FindStrip();
            this.customerListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotiToChooseItemBindingSource)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingItem)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // dgItem
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            this.dgItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgItem.AutoGenerateColumns = false;
            this.dgItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.qtyDataGridViewTextBoxColumn,
            this.Discount,
            this.priceDataGridViewTextBoxColumn,
            this.SubTotal});
            this.dgItem.ContextMenuStrip = this.contextMenuStrip2;
            this.dgItem.DataSource = this.bindingItem;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgItem.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgItem.Location = new System.Drawing.Point(0, 321);
            this.dgItem.Name = "dgItem";
            this.dgItem.Size = new System.Drawing.Size(870, 148);
            this.dgItem.TabIndex = 1;
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.DataSource = this.rotiToChooseItemBindingSource;
            this.ItemCode.DisplayMember = "ItemName";
            this.ItemCode.HeaderText = "ItemCode";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ItemCode.ValueMember = "ItemCode";
            this.ItemCode.Width = 300;
            // 
            // rotiToChooseItemBindingSource
            // 
            this.rotiToChooseItemBindingSource.DataSource = typeof(Invoice_OTC.Model.RotiToChooseItem);
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.qtyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            dataGridViewCellStyle4.NullValue = "0";
            this.Discount.DefaultCellStyle = dataGridViewCellStyle4;
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.Width = 50;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle5.Format = "C0";
            dataGridViewCellStyle5.NullValue = null;
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteBookToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(138, 26);
            // 
            // deleteBookToolStripMenuItem
            // 
            this.deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            this.deleteBookToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.deleteBookToolStripMenuItem.Text = "Delete Book";
            this.deleteBookToolStripMenuItem.Click += new System.EventHandler(this.deleteBookToolStripMenuItem_Click);
            // 
            // bindingItem
            // 
            this.bindingItem.DataSource = typeof(Invoice_OTC.Model.rotiItem);
            this.bindingItem.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.bindingItem_AddingNew);
            this.bindingItem.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingItem_ListChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(870, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Invoice_OTC.Properties.Resources.Print_96px;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(93, 22);
            this.toolStripButton1.Text = "Print Invoice";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(870, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 269);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(870, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel2.Text = "toolStripLabel2";
            // 
            // dgInvoice
            // 
            this.dgInvoice.AutoGenerateColumns = false;
            this.dgInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomorDataGridViewTextBoxColumn,
            this.OutletCode,
            this.dueDateDataGridViewTextBoxColumn,
            this.outletCodeDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn,
            this.pPNDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.issuedDataDataGridViewTextBoxColumn,
            this.isPPNDataGridViewCheckBoxColumn,
            this.nomorPODataGridViewTextBoxColumn,
            this.periodeDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn,
            this.isPayedDataGridViewCheckBoxColumn});
            this.dgInvoice.ContextMenuStrip = this.contextMenuStrip1;
            this.dgInvoice.DataSource = this.bindingInvoice;
            this.dgInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgInvoice.Location = new System.Drawing.Point(0, 57);
            this.dgInvoice.Name = "dgInvoice";
            this.dgInvoice.Size = new System.Drawing.Size(870, 212);
            this.dgInvoice.TabIndex = 6;
            // 
            // nomorDataGridViewTextBoxColumn
            // 
            this.nomorDataGridViewTextBoxColumn.DataPropertyName = "Nomor";
            this.nomorDataGridViewTextBoxColumn.HeaderText = "Nomor";
            this.nomorDataGridViewTextBoxColumn.Name = "nomorDataGridViewTextBoxColumn";
            // 
            // OutletCode
            // 
            this.OutletCode.DataPropertyName = "OutletCode";
            this.OutletCode.DataSource = this.outletItemBindingSource;
            this.OutletCode.DisplayMember = "OutletName";
            this.OutletCode.HeaderText = "OutletCode";
            this.OutletCode.Name = "OutletCode";
            this.OutletCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OutletCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OutletCode.ValueMember = "OutletCode";
            this.OutletCode.Width = 300;
            // 
            // outletItemBindingSource
            // 
            this.outletItemBindingSource.DataSource = typeof(Invoice_OTC.Model.outletItem);
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            // 
            // outletCodeDataGridViewTextBoxColumn
            // 
            this.outletCodeDataGridViewTextBoxColumn.DataPropertyName = "OutletCode";
            this.outletCodeDataGridViewTextBoxColumn.HeaderText = "OutletCode";
            this.outletCodeDataGridViewTextBoxColumn.Name = "outletCodeDataGridViewTextBoxColumn";
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            dataGridViewCellStyle7.Format = "C0";
            dataGridViewCellStyle7.NullValue = null;
            this.subTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            this.subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pPNDataGridViewTextBoxColumn
            // 
            this.pPNDataGridViewTextBoxColumn.DataPropertyName = "PPN";
            dataGridViewCellStyle8.Format = "C0";
            dataGridViewCellStyle8.NullValue = null;
            this.pPNDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.pPNDataGridViewTextBoxColumn.HeaderText = "PPN";
            this.pPNDataGridViewTextBoxColumn.Name = "pPNDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            dataGridViewCellStyle9.Format = "C0";
            dataGridViewCellStyle9.NullValue = null;
            this.totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // issuedDataDataGridViewTextBoxColumn
            // 
            this.issuedDataDataGridViewTextBoxColumn.DataPropertyName = "IssuedData";
            this.issuedDataDataGridViewTextBoxColumn.HeaderText = "IssuedData";
            this.issuedDataDataGridViewTextBoxColumn.Name = "issuedDataDataGridViewTextBoxColumn";
            // 
            // isPPNDataGridViewCheckBoxColumn
            // 
            this.isPPNDataGridViewCheckBoxColumn.DataPropertyName = "IsPPN";
            this.isPPNDataGridViewCheckBoxColumn.HeaderText = "IsPPN";
            this.isPPNDataGridViewCheckBoxColumn.Name = "isPPNDataGridViewCheckBoxColumn";
            // 
            // nomorPODataGridViewTextBoxColumn
            // 
            this.nomorPODataGridViewTextBoxColumn.DataPropertyName = "NomorPO";
            this.nomorPODataGridViewTextBoxColumn.HeaderText = "NomorPO";
            this.nomorPODataGridViewTextBoxColumn.Name = "nomorPODataGridViewTextBoxColumn";
            // 
            // periodeDataGridViewTextBoxColumn
            // 
            this.periodeDataGridViewTextBoxColumn.DataPropertyName = "Periode";
            this.periodeDataGridViewTextBoxColumn.HeaderText = "Periode";
            this.periodeDataGridViewTextBoxColumn.Name = "periodeDataGridViewTextBoxColumn";
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "Payment";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            // 
            // isPayedDataGridViewCheckBoxColumn
            // 
            this.isPayedDataGridViewCheckBoxColumn.DataPropertyName = "IsPayed";
            this.isPayedDataGridViewCheckBoxColumn.HeaderText = "IsPayed";
            this.isPayedDataGridViewCheckBoxColumn.Name = "isPayedDataGridViewCheckBoxColumn";
            // 
            // bindingInvoice
            // 
            this.bindingInvoice.DataSource = typeof(Invoice_OTC.Model.InvoiceItem);
            this.bindingInvoice.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.bindingInvoice_AddingNew);
            this.bindingInvoice.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingInvoice_ListChanged);
            // 
            // findStrip1
            // 
            this.findStrip1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.findStrip1.bindingSource = this.bindingInvoice;
            this.findStrip1.Location = new System.Drawing.Point(0, 0);
            this.findStrip1.Name = "findStrip1";
            this.findStrip1.Size = new System.Drawing.Size(870, 32);
            this.findStrip1.TabIndex = 2;
            this.findStrip1.Text = "findStrip1";
            this.findStrip1.ItemFound += new Invoice_OTC.Controller.ItemFoundEventHandler(this.findStrip1_ItemFound);
            // 
            // customerListBindingSource
            // 
            this.customerListBindingSource.DataSource = typeof(Invoice_OTC.Model.CustomerList);
            // 
            // dgBindingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 469);
            this.Controls.Add(this.dgInvoice);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.findStrip1);
            this.Controls.Add(this.dgItem);
            this.Name = "dgBindingFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dgBindingFrm";
            this.Load += new System.EventHandler(this.dgBindingFrm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotiToChooseItemBindingSource)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingItem)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingInvoice;
        private System.Windows.Forms.DataGridView dgItem;
        private System.Windows.Forms.BindingSource bindingItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem deleteBookToolStripMenuItem;        
        private Controller.FindStrip findStrip1;
        private System.Windows.Forms.BindingSource customerListBindingSource;
        private System.Windows.Forms.BindingSource rotiToChooseItemBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource outletItemBindingSource;
        private System.Windows.Forms.Label label1;                
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridView dgInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn OutletCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outletCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPPNDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPayedDataGridViewCheckBoxColumn;
    }
}