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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoice));
            this.invoiceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.invoiceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.invoiceDataGridView = new System.Windows.Forms.DataGridView();
            this.invoiceDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.pItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outletCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPPNDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nomorPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penggunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPayedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).BeginInit();
            this.invoiceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceBindingNavigator
            // 
            this.invoiceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.invoiceBindingNavigator.BindingSource = this.invoiceBindingSource;
            this.invoiceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.invoiceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.invoiceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.invoiceBindingNavigatorSaveItem});
            this.invoiceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.invoiceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.invoiceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.invoiceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.invoiceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.invoiceBindingNavigator.Name = "invoiceBindingNavigator";
            this.invoiceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.invoiceBindingNavigator.Size = new System.Drawing.Size(916, 25);
            this.invoiceBindingNavigator.TabIndex = 0;
            this.invoiceBindingNavigator.Text = "bindingNavigator1";
            this.invoiceBindingNavigator.RefreshItems += new System.EventHandler(this.invoiceBindingNavigator_RefreshItems);
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
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(InvoiceOTC.Model.Invoice);
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
            // invoiceBindingNavigatorSaveItem
            // 
            this.invoiceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.invoiceBindingNavigatorSaveItem.Enabled = false;
            this.invoiceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("invoiceBindingNavigatorSaveItem.Image")));
            this.invoiceBindingNavigatorSaveItem.Name = "invoiceBindingNavigatorSaveItem";
            this.invoiceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.invoiceBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // invoiceDataGridView
            // 
            this.invoiceDataGridView.AutoGenerateColumns = false;
            this.invoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceIDDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.outletCodeDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn,
            this.ppnDataGridViewTextBoxColumn,
            this.issuedDateDataGridViewTextBoxColumn,
            this.isPPNDataGridViewCheckBoxColumn,
            this.nomorPODataGridViewTextBoxColumn,
            this.penggunaDataGridViewTextBoxColumn,
            this.periodeDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn,
            this.isPayedDataGridViewCheckBoxColumn});
            this.invoiceDataGridView.DataSource = this.invoiceBindingSource;
            this.invoiceDataGridView.Location = new System.Drawing.Point(12, 28);
            this.invoiceDataGridView.Name = "invoiceDataGridView";
            this.invoiceDataGridView.Size = new System.Drawing.Size(892, 157);
            this.invoiceDataGridView.TabIndex = 1;
            // 
            // invoiceDetailDataGridView
            // 
            this.invoiceDetailDataGridView.AutoGenerateColumns = false;
            this.invoiceDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCodeDataGridViewTextBoxColumn,
            this.itemQtyDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.itemPriceDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn1});
            this.invoiceDetailDataGridView.DataSource = this.pItemsBindingSource;
            this.invoiceDetailDataGridView.Location = new System.Drawing.Point(12, 191);
            this.invoiceDetailDataGridView.Name = "invoiceDetailDataGridView";
            this.invoiceDetailDataGridView.Size = new System.Drawing.Size(892, 203);
            this.invoiceDetailDataGridView.TabIndex = 2;
            // 
            // pItemsBindingSource
            // 
            this.pItemsBindingSource.DataMember = "p_Items";
            this.pItemsBindingSource.DataSource = this.invoiceBindingSource;
            // 
            // outletBindingSource
            // 
            this.outletBindingSource.DataSource = typeof(InvoiceOTC.Model.Outlet);
            // 
            // invoiceIDDataGridViewTextBoxColumn
            // 
            this.invoiceIDDataGridViewTextBoxColumn.DataPropertyName = "invoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.HeaderText = "invoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
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
            this.outletCodeDataGridViewTextBoxColumn.DataSource = this.outletBindingSource;
            this.outletCodeDataGridViewTextBoxColumn.DisplayMember = "outlName";
            this.outletCodeDataGridViewTextBoxColumn.HeaderText = "outletCode";
            this.outletCodeDataGridViewTextBoxColumn.Name = "outletCodeDataGridViewTextBoxColumn";
            this.outletCodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.outletCodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.outletCodeDataGridViewTextBoxColumn.ValueMember = "outlCode";
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
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "paymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "paymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            // 
            // isPayedDataGridViewCheckBoxColumn
            // 
            this.isPayedDataGridViewCheckBoxColumn.DataPropertyName = "isPayed";
            this.isPayedDataGridViewCheckBoxColumn.HeaderText = "isPayed";
            this.isPayedDataGridViewCheckBoxColumn.Name = "isPayedDataGridViewCheckBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(InvoiceOTC.Model.Product);
            // 
            // itemCodeDataGridViewTextBoxColumn
            // 
            this.itemCodeDataGridViewTextBoxColumn.DataPropertyName = "itemCode";
            this.itemCodeDataGridViewTextBoxColumn.DataSource = this.productBindingSource;
            this.itemCodeDataGridViewTextBoxColumn.DisplayMember = "itemName";
            this.itemCodeDataGridViewTextBoxColumn.HeaderText = "itemCode";
            this.itemCodeDataGridViewTextBoxColumn.Name = "itemCodeDataGridViewTextBoxColumn";
            this.itemCodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemCodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemCodeDataGridViewTextBoxColumn.ValueMember = "itemCode";
            // 
            // itemQtyDataGridViewTextBoxColumn
            // 
            this.itemQtyDataGridViewTextBoxColumn.DataPropertyName = "itemQty";
            this.itemQtyDataGridViewTextBoxColumn.HeaderText = "itemQty";
            this.itemQtyDataGridViewTextBoxColumn.Name = "itemQtyDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // itemPriceDataGridViewTextBoxColumn
            // 
            this.itemPriceDataGridViewTextBoxColumn.DataPropertyName = "itemPrice";
            this.itemPriceDataGridViewTextBoxColumn.HeaderText = "itemPrice";
            this.itemPriceDataGridViewTextBoxColumn.Name = "itemPriceDataGridViewTextBoxColumn";
            // 
            // subTotalDataGridViewTextBoxColumn1
            // 
            this.subTotalDataGridViewTextBoxColumn1.DataPropertyName = "subTotal";
            this.subTotalDataGridViewTextBoxColumn1.HeaderText = "subTotal";
            this.subTotalDataGridViewTextBoxColumn1.Name = "subTotalDataGridViewTextBoxColumn1";
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 406);
            this.Controls.Add(this.invoiceDetailDataGridView);
            this.Controls.Add(this.invoiceDataGridView);
            this.Controls.Add(this.invoiceBindingNavigator);
            this.Name = "FrmInvoice";
            this.Text = "FrmInvoice";
            this.Load += new System.EventHandler(this.FrmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).EndInit();
            this.invoiceBindingNavigator.ResumeLayout(false);
            this.invoiceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.BindingNavigator invoiceBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton invoiceBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView invoiceDataGridView;
        private System.Windows.Forms.DataGridView invoiceDetailDataGridView;                
        private System.Windows.Forms.BindingSource pItemsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn outletCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource outletBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPPNDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penggunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPayedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn1;
    }
}