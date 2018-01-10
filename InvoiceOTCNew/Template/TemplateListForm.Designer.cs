namespace InvoiceOTCNew
{
    partial class TemplateListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateListForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.findStrip2 = new InvoiceOTC.Controller.FindStrip();
            this.advancedSearchBtn = new System.Windows.Forms.ToolStripButton();
            this.importBtn = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.headerLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tambahBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.totalDGCellBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.countDGCellBtn = new System.Windows.Forms.ToolStripButton();
            this.printBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1.SuspendLayout();
            this.findStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.findStrip2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(875, 93);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // findStrip2
            // 
            this.findStrip2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.findStrip2.bindingSource = null;
            this.findStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.findStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedSearchBtn,
            this.toolStripSeparator2,
            this.importBtn,
            this.printBtn});
            this.findStrip2.Location = new System.Drawing.Point(0, 54);
            this.findStrip2.Name = "findStrip2";
            this.findStrip2.Padding = new System.Windows.Forms.Padding(5);
            this.findStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.findStrip2.Size = new System.Drawing.Size(875, 39);
            this.findStrip2.TabIndex = 2;
            this.findStrip2.Text = "findStrip2";
            this.findStrip2.ItemFound += new InvoiceOTC.Controller.ItemFoundEventHandler(this.findStrip1_ItemFound);
            // 
            // advancedSearchBtn
            // 
            this.advancedSearchBtn.ForeColor = System.Drawing.Color.White;
            this.advancedSearchBtn.Image = global::InvoiceOTCNew.Properties.Resources.Google_Web_Search_50px;
            this.advancedSearchBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.advancedSearchBtn.Name = "advancedSearchBtn";
            this.advancedSearchBtn.Size = new System.Drawing.Size(68, 26);
            this.advancedSearchBtn.Text = "Search !";
            this.advancedSearchBtn.Click += new System.EventHandler(this.advancedSearchBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.importBtn.ForeColor = System.Drawing.Color.White;
            this.importBtn.Image = global::InvoiceOTCNew.Properties.Resources.import_excel32;
            this.importBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(63, 26);
            this.importBtn.Text = "Import";
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.headerLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 48);
            this.panel2.TabIndex = 0;
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.ForeColor = System.Drawing.Color.White;
            this.headerLbl.Location = new System.Drawing.Point(19, 15);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(68, 20);
            this.headerLbl.TabIndex = 0;
            this.headerLbl.Text = "Header";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.88572F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.11428F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 315);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(875, 47);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.tambahBtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.editBtn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.DeleteBtn, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.ExitBtn, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(422, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(450, 41);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tambahBtn
            // 
            this.tambahBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tambahBtn.Location = new System.Drawing.Point(3, 3);
            this.tambahBtn.Name = "tambahBtn";
            this.tambahBtn.Size = new System.Drawing.Size(106, 35);
            this.tambahBtn.TabIndex = 0;
            this.tambahBtn.Text = "Tambah";
            this.tambahBtn.UseVisualStyleBackColor = true;
            this.tambahBtn.Click += new System.EventHandler(this.tambahBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editBtn.Location = new System.Drawing.Point(115, 3);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(106, 35);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Edit ";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteBtn.Location = new System.Drawing.Point(227, 3);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(106, 35);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitBtn.Location = new System.Drawing.Point(339, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(108, 35);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Cancel / Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 41);
            this.panel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalDGCellBtn,
            this.toolStripSeparator1,
            this.countDGCellBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 362);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(875, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // totalDGCellBtn
            // 
            this.totalDGCellBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.totalDGCellBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.totalDGCellBtn.Image = ((System.Drawing.Image)(resources.GetObject("totalDGCellBtn.Image")));
            this.totalDGCellBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.totalDGCellBtn.Name = "totalDGCellBtn";
            this.totalDGCellBtn.Size = new System.Drawing.Size(44, 22);
            this.totalDGCellBtn.Text = "Total :";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // countDGCellBtn
            // 
            this.countDGCellBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.countDGCellBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.countDGCellBtn.Image = ((System.Drawing.Image)(resources.GetObject("countDGCellBtn.Image")));
            this.countDGCellBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.countDGCellBtn.Name = "countDGCellBtn";
            this.countDGCellBtn.Size = new System.Drawing.Size(50, 22);
            this.countDGCellBtn.Text = "Count :";
            // 
            // printBtn
            // 
            this.printBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.Image = global::InvoiceOTCNew.Properties.Resources.Print_96px;
            this.printBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(52, 26);
            this.printBtn.Text = "Print";
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // TemplateListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(875, 387);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TemplateListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TemplateListForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.findStrip2.ResumeLayout(false);
            this.findStrip2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button tambahBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.ToolStripButton advancedSearchBtn;
        protected InvoiceOTC.Controller.FindStrip findStrip2;
        private System.Windows.Forms.ToolStripButton importBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripButton totalDGCellBtn;
        protected System.Windows.Forms.ToolStripButton countDGCellBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton printBtn;
    }
}