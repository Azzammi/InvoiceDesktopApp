namespace InvoiceOTCNew
{
    partial class FrmInvoiceNew
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.invoiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(545, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 155);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(15, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 155);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(545, 412);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(457, 120);
            this.panel4.TabIndex = 5;
            // 
            // invoiceDetailBindingSource
            // 
            this.invoiceDetailBindingSource.DataSource = typeof(InvoiceOTC.Model.InvoiceDetail);
            // 
            // invoiceDetailDataGridView
            // 
            this.invoiceDetailDataGridView.AutoGenerateColumns = false;
            this.invoiceDetailDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.invoiceDetailDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.invoiceDetailDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.invoiceDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.invoiceDetailDataGridView.DataSource = this.invoiceDetailBindingSource;
            this.invoiceDetailDataGridView.Location = new System.Drawing.Point(12, 236);
            this.invoiceDetailDataGridView.Name = "invoiceDetailDataGridView";
            this.invoiceDetailDataGridView.Size = new System.Drawing.Size(990, 170);
            this.invoiceDetailDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "invoiceID";
            this.dataGridViewTextBoxColumn1.HeaderText = "invoiceID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "itemCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "itemCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "itemQty";
            this.dataGridViewTextBoxColumn3.HeaderText = "itemQty";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "discount";
            this.dataGridViewTextBoxColumn4.HeaderText = "discount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "itemPrice";
            this.dataGridViewTextBoxColumn5.HeaderText = "itemPrice";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "subTotal";
            this.dataGridViewTextBoxColumn6.HeaderText = "subTotal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // FrmInvoiceNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 593);
            this.Controls.Add(this.invoiceDetailDataGridView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmInvoiceNew";
            this.Text = "FrmInvoiceNew";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.invoiceDetailDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource invoiceDetailBindingSource;
        private System.Windows.Forms.DataGridView invoiceDetailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}