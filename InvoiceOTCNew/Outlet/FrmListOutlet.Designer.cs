namespace InvoiceOTCNew
{
    partial class FrmListOutlet
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
            this.outletDataGridView = new System.Windows.Forms.DataGridView();
            this.outletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outlCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outlNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outlAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outlSlsmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outlRouteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outlStatDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isppn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.outletDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // outletDataGridView
            // 
            this.outletDataGridView.AutoGenerateColumns = false;
            this.outletDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outletDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.outlCodeDataGridViewTextBoxColumn,
            this.outlNameDataGridViewTextBoxColumn,
            this.outlAddressDataGridViewTextBoxColumn,
            this.outlSlsmDataGridViewTextBoxColumn,
            this.outlRouteDataGridViewTextBoxColumn,
            this.outlStatDataGridViewCheckBoxColumn,
            this.isppn});
            this.outletDataGridView.DataSource = this.outletBindingSource;
            this.outletDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outletDataGridView.Location = new System.Drawing.Point(0, 93);
            this.outletDataGridView.Name = "outletDataGridView";
            this.outletDataGridView.Size = new System.Drawing.Size(711, 251);
            this.outletDataGridView.TabIndex = 3;
            this.outletDataGridView.SelectionChanged += new System.EventHandler(this.outletDataGridView_SelectionChanged);
            // 
            // outletBindingSource
            // 
            this.outletBindingSource.DataSource = typeof(InvoiceOTC.Model.Outlet);
            // 
            // outlCodeDataGridViewTextBoxColumn
            // 
            this.outlCodeDataGridViewTextBoxColumn.DataPropertyName = "outlCode";
            this.outlCodeDataGridViewTextBoxColumn.HeaderText = "outlCode";
            this.outlCodeDataGridViewTextBoxColumn.Name = "outlCodeDataGridViewTextBoxColumn";
            // 
            // outlNameDataGridViewTextBoxColumn
            // 
            this.outlNameDataGridViewTextBoxColumn.DataPropertyName = "outlName";
            this.outlNameDataGridViewTextBoxColumn.HeaderText = "outlName";
            this.outlNameDataGridViewTextBoxColumn.Name = "outlNameDataGridViewTextBoxColumn";
            // 
            // outlAddressDataGridViewTextBoxColumn
            // 
            this.outlAddressDataGridViewTextBoxColumn.DataPropertyName = "outlAddress";
            this.outlAddressDataGridViewTextBoxColumn.HeaderText = "outlAddress";
            this.outlAddressDataGridViewTextBoxColumn.Name = "outlAddressDataGridViewTextBoxColumn";
            // 
            // outlSlsmDataGridViewTextBoxColumn
            // 
            this.outlSlsmDataGridViewTextBoxColumn.DataPropertyName = "outlSlsm";
            this.outlSlsmDataGridViewTextBoxColumn.HeaderText = "outlSlsm";
            this.outlSlsmDataGridViewTextBoxColumn.Name = "outlSlsmDataGridViewTextBoxColumn";
            // 
            // outlRouteDataGridViewTextBoxColumn
            // 
            this.outlRouteDataGridViewTextBoxColumn.DataPropertyName = "outlRoute";
            this.outlRouteDataGridViewTextBoxColumn.HeaderText = "outlRoute";
            this.outlRouteDataGridViewTextBoxColumn.Name = "outlRouteDataGridViewTextBoxColumn";
            // 
            // outlStatDataGridViewCheckBoxColumn
            // 
            this.outlStatDataGridViewCheckBoxColumn.DataPropertyName = "outlStat";
            this.outlStatDataGridViewCheckBoxColumn.HeaderText = "outlStat";
            this.outlStatDataGridViewCheckBoxColumn.Name = "outlStatDataGridViewCheckBoxColumn";
            // 
            // isppn
            // 
            this.isppn.DataPropertyName = "isppn";
            this.isppn.HeaderText = "isppn";
            this.isppn.Name = "isppn";
            // 
            // FrmListOutlet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 416);
            this.Controls.Add(this.outletDataGridView);
            this.Name = "FrmListOutlet";
            this.Text = "j";
            this.Controls.SetChildIndex(this.outletDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.outletDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView outletDataGridView;        
        private System.Windows.Forms.BindingSource outletBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn outlCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outlNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outlAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outlSlsmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outlRouteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn outlStatDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isppn;
    }
}