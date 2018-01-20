namespace InvoiceOTCNew
{
    partial class FrmMiniMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMiniMenu));
            this.tabbedMDIManager1 = new Syncfusion.Windows.Forms.Tools.TabbedMDIManager(this.components);
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rekapInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.softwareLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.sumLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.timeLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.timerCtl = new System.Windows.Forms.Timer(this.components);
            this.invoiceBtn = new System.Windows.Forms.ToolStripButton();
            this.outletBtn = new System.Windows.Forms.ToolStripButton();
            this.productBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEx1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabbedMDIManager1
            // 
            this.tabbedMDIManager1.AttachedTo = this;
            this.tabbedMDIManager1.CloseButtonBackColor = System.Drawing.Color.White;
            this.tabbedMDIManager1.CloseButtonToolTip = "";
            this.tabbedMDIManager1.CloseButtonVisible = false;
            this.tabbedMDIManager1.DropDownButtonToolTip = "";
            this.tabbedMDIManager1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabbedMDIManager1.NeedUpdateHostedForm = false;
            this.tabbedMDIManager1.ShowCloseButton = true;
            this.tabbedMDIManager1.ShowCloseButtonBackColor = true;
            this.tabbedMDIManager1.ShowCloseButtonForActiveTabOnly = true;
            this.tabbedMDIManager1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererBlendDark);
            this.tabbedMDIManager1.ThemesEnabled = true;
            this.tabbedMDIManager1.UseIconsInTabs = false;
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.AutoSize = false;
            this.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Size = new System.Drawing.Size(486, 31);
            this.toolStripEx1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.masterToolStripMenuItem,
            this.invoiceToolStripMenuItem,
            this.logsToolStripMenuItem,
            this.laporanToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.logsToolStripMenuItem.Text = "Logs";
            this.logsToolStripMenuItem.Click += new System.EventHandler(this.logsToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rekapInvoiceToolStripMenuItem});
            this.laporanToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // rekapInvoiceToolStripMenuItem
            // 
            this.rekapInvoiceToolStripMenuItem.Name = "rekapInvoiceToolStripMenuItem";
            this.rekapInvoiceToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.rekapInvoiceToolStripMenuItem.Text = "Rekap Invoice";
            this.rekapInvoiceToolStripMenuItem.Click += new System.EventHandler(this.rekapInvoiceToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softwareLbl,
            this.sumLbl,
            this.timeLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 275);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(851, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // softwareLbl
            // 
            this.softwareLbl.ForeColor = System.Drawing.Color.White;
            this.softwareLbl.Name = "softwareLbl";
            this.softwareLbl.Size = new System.Drawing.Size(600, 17);
            this.softwareLbl.Spring = true;
            this.softwareLbl.Text = "toolStripStatusLabel1";
            // 
            // sumLbl
            // 
            this.sumLbl.ForeColor = System.Drawing.Color.White;
            this.sumLbl.Name = "sumLbl";
            this.sumLbl.Size = new System.Drawing.Size(118, 17);
            this.sumLbl.Text = "toolStripStatusLabel1";
            // 
            // timeLbl
            // 
            this.timeLbl.ForeColor = System.Drawing.Color.White;
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(118, 17);
            this.timeLbl.Text = "toolStripStatusLabel1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceBtn,
            this.outletBtn,
            this.productBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(851, 39);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // timerCtl
            // 
            this.timerCtl.Enabled = true;
            this.timerCtl.Tick += new System.EventHandler(this.timerCtl_Tick);
            // 
            // invoiceBtn
            // 
            this.invoiceBtn.Image = global::InvoiceOTCNew.Properties.Resources.Invoice;
            this.invoiceBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.invoiceBtn.Name = "invoiceBtn";
            this.invoiceBtn.Size = new System.Drawing.Size(81, 36);
            this.invoiceBtn.Text = "Invoice";
            this.invoiceBtn.Click += new System.EventHandler(this.listInvoiceShow);
            // 
            // outletBtn
            // 
            this.outletBtn.Image = global::InvoiceOTCNew.Properties.Resources.Shop_WF;
            this.outletBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.outletBtn.Name = "outletBtn";
            this.outletBtn.Size = new System.Drawing.Size(76, 36);
            this.outletBtn.Text = "Outlet";
            this.outletBtn.Click += new System.EventHandler(this.listOutletShow);
            // 
            // productBtn
            // 
            this.productBtn.Image = global::InvoiceOTCNew.Properties.Resources.Product_Box_02_WF;
            this.productBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(85, 36);
            this.productBtn.Text = "Product";
            this.productBtn.Click += new System.EventHandler(this.listProductShow);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(98, 14);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 14);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FrmMiniMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 297);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMiniMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMiniMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.TabbedMDIManager tabbedMDIManager1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton invoiceBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton outletBtn;
        private System.Windows.Forms.ToolStripButton productBtn;
        private System.Windows.Forms.ToolStripStatusLabel softwareLbl;
        private System.Windows.Forms.ToolStripStatusLabel sumLbl;
        private System.Windows.Forms.ToolStripStatusLabel timeLbl;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rekapInvoiceToolStripMenuItem;
        private System.Windows.Forms.Timer timerCtl;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}