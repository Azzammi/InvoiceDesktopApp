#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Invoice_OTC.View
{
    partial class FrmViewInvoice
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
            Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor gridRelationDescriptor1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.invoiceItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.gridDataBoundGrid1 = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.DataSource = this.invoiceItemBindingSource;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridGroupingControl1.Location = new System.Drawing.Point(0, 43);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridGroupingControl1.Size = new System.Drawing.Size(426, 224);
            this.gridGroupingControl1.TabIndex = 0;
            gridRelationDescriptor1.ChildTableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ID"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("Invoiceid"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ItemCode"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("Qty"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("Price"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("Discount"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("SubTotal")});
            gridRelationDescriptor1.ChildTableDescriptor.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ID"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Invoiceid"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ItemCode"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Qty"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Price"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Discount"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("SubTotal")});
            gridRelationDescriptor1.MappingName = "Items";
            this.gridGroupingControl1.TableDescriptor.Relations.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor[] {
            gridRelationDescriptor1});
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.UseRightToLeftCompatibleTextBox = true;
            this.gridGroupingControl1.VersionInfo = "15.3460.0.26";
            // 
            // invoiceItemBindingSource
            // 
            this.invoiceItemBindingSource.DataSource = typeof(Invoice_OTC.Model.InvoiceItem);
            this.invoiceItemBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.invoiceItemBindingSource_AddingNew);
            this.invoiceItemBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.invoiceItemBindingSource_ListChanged);
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Location = new System.Drawing.Point(0, 0);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Size = new System.Drawing.Size(870, 40);
            this.toolStripEx1.TabIndex = 1;
            this.toolStripEx1.Text = "toolStripEx1";
            // 
            // gridDataBoundGrid1
            // 
            this.gridDataBoundGrid1.AllowDragSelectedCols = true;
            this.gridDataBoundGrid1.DataSource = this.invoiceItemBindingSource;
            this.gridDataBoundGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDataBoundGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Black;
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(0, 40);
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.OptimizeInsertRemoveCells = true;
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(870, 224);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid1.TabIndex = 2;
            this.gridDataBoundGrid1.Text = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.UseListChangedEvent = true;
            this.gridDataBoundGrid1.UseRightToLeftCompatibleTextBox = true;
            // 
            // FrmViewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 264);
            this.Controls.Add(this.gridDataBoundGrid1);
            this.Controls.Add(this.gridGroupingControl1);
            this.Controls.Add(this.toolStripEx1);
            this.Name = "FrmViewInvoice";
            this.Text = "MetroForm1";
            this.Load += new System.EventHandler(this.FrmViewInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private System.Windows.Forms.BindingSource invoiceItemBindingSource;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid1;
    }
}