namespace InvoiceOTCNew
{
    partial class FrmListBoundGrid
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
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorInvoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outletCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPPNDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nomorPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penggunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPayedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.itemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(InvoiceOTC.Model.Invoice);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.78899F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.21101F));
            this.tableLayoutPanel4.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dataGridView2, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 58);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(545, 157);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceIDDataGridViewTextBoxColumn,
            this.nomorInvoiceDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.outletCodeDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn,
            this.ppnDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.issuedDateDataGridViewTextBoxColumn,
            this.isPPNDataGridViewCheckBoxColumn,
            this.nomorPODataGridViewTextBoxColumn,
            this.penggunaDataGridViewTextBoxColumn,
            this.periodeDataGridViewTextBoxColumn,
            this.idPaymentDataGridViewTextBoxColumn,
            this.isPayedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.invoiceBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 151);
            this.dataGridView1.TabIndex = 0;
            // 
            // invoiceIDDataGridViewTextBoxColumn
            // 
            this.invoiceIDDataGridViewTextBoxColumn.DataPropertyName = "invoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.HeaderText = "invoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
            // 
            // nomorInvoiceDataGridViewTextBoxColumn
            // 
            this.nomorInvoiceDataGridViewTextBoxColumn.DataPropertyName = "nomorInvoice";
            this.nomorInvoiceDataGridViewTextBoxColumn.HeaderText = "nomorInvoice";
            this.nomorInvoiceDataGridViewTextBoxColumn.Name = "nomorInvoiceDataGridViewTextBoxColumn";
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "dueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "dueDate";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            // 
            // outletCodeDataGridViewTextBoxColumn
            // 
            this.outletCodeDataGridViewTextBoxColumn.DataPropertyName = "outletCode";
            this.outletCodeDataGridViewTextBoxColumn.HeaderText = "outletCode";
            this.outletCodeDataGridViewTextBoxColumn.Name = "outletCodeDataGridViewTextBoxColumn";
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "subTotal";
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "subTotal";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            // 
            // ppnDataGridViewTextBoxColumn
            // 
            this.ppnDataGridViewTextBoxColumn.DataPropertyName = "ppn";
            this.ppnDataGridViewTextBoxColumn.HeaderText = "ppn";
            this.ppnDataGridViewTextBoxColumn.Name = "ppnDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // issuedDateDataGridViewTextBoxColumn
            // 
            this.issuedDateDataGridViewTextBoxColumn.DataPropertyName = "issuedDate";
            this.issuedDateDataGridViewTextBoxColumn.HeaderText = "issuedDate";
            this.issuedDateDataGridViewTextBoxColumn.Name = "issuedDateDataGridViewTextBoxColumn";
            // 
            // isPPNDataGridViewCheckBoxColumn
            // 
            this.isPPNDataGridViewCheckBoxColumn.DataPropertyName = "isPPN";
            this.isPPNDataGridViewCheckBoxColumn.HeaderText = "isPPN";
            this.isPPNDataGridViewCheckBoxColumn.Name = "isPPNDataGridViewCheckBoxColumn";
            // 
            // nomorPODataGridViewTextBoxColumn
            // 
            this.nomorPODataGridViewTextBoxColumn.DataPropertyName = "nomorPO";
            this.nomorPODataGridViewTextBoxColumn.HeaderText = "nomorPO";
            this.nomorPODataGridViewTextBoxColumn.Name = "nomorPODataGridViewTextBoxColumn";
            // 
            // penggunaDataGridViewTextBoxColumn
            // 
            this.penggunaDataGridViewTextBoxColumn.DataPropertyName = "pengguna";
            this.penggunaDataGridViewTextBoxColumn.HeaderText = "pengguna";
            this.penggunaDataGridViewTextBoxColumn.Name = "penggunaDataGridViewTextBoxColumn";
            // 
            // periodeDataGridViewTextBoxColumn
            // 
            this.periodeDataGridViewTextBoxColumn.DataPropertyName = "periode";
            this.periodeDataGridViewTextBoxColumn.HeaderText = "periode";
            this.periodeDataGridViewTextBoxColumn.Name = "periodeDataGridViewTextBoxColumn";
            // 
            // idPaymentDataGridViewTextBoxColumn
            // 
            this.idPaymentDataGridViewTextBoxColumn.DataPropertyName = "idPayment";
            this.idPaymentDataGridViewTextBoxColumn.HeaderText = "idPayment";
            this.idPaymentDataGridViewTextBoxColumn.Name = "idPaymentDataGridViewTextBoxColumn";
            // 
            // isPayedDataGridViewCheckBoxColumn
            // 
            this.isPayedDataGridViewCheckBoxColumn.DataPropertyName = "isPayed";
            this.isPayedDataGridViewCheckBoxColumn.HeaderText = "isPayed";
            this.isPayedDataGridViewCheckBoxColumn.Name = "isPayedDataGridViewCheckBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCode,
            this.itemQty,
            this.discount,
            this.itemPrice,
            this.subTotalDataGridViewTextBoxColumn1});
            this.dataGridView2.DataMember = "detail";
            this.dataGridView2.DataSource = this.invoiceBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(366, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(176, 151);
            this.dataGridView2.TabIndex = 1;
            // 
            // itemCode
            // 
            this.itemCode.DataPropertyName = "itemCode";
            this.itemCode.HeaderText = "itemCode";
            this.itemCode.Name = "itemCode";
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
            // subTotalDataGridViewTextBoxColumn1
            // 
            this.subTotalDataGridViewTextBoxColumn1.DataPropertyName = "subTotal";
            this.subTotalDataGridViewTextBoxColumn1.HeaderText = "subTotal";
            this.subTotalDataGridViewTextBoxColumn1.Name = "subTotalDataGridViewTextBoxColumn1";
            // 
            // FrmListBoundGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 262);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "FrmListBoundGrid";
            this.Text = "FrmListBoundGrid";
            this.Load += new System.EventHandler(this.FrmListBoundGrid_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorInvoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outletCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPPNDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penggunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPayedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn1;
    }
}