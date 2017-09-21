namespace Invoice_OTC.View
{
    partial class FrmImportExcelRoti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImportExcelRoti));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.sourceTxt = new System.Windows.Forms.ToolStripTextBox();
            this.browseBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.sheetTxt = new System.Windows.Forms.ToolStripTextBox();
            this.prosesBtn = new System.Windows.Forms.ToolStripButton();
            this.importBtn = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 310);
            this.dataGridView1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.sourceTxt,
            this.browseBtn,
            this.toolStripLabel2,
            this.sheetTxt,
            this.prosesBtn,
            this.importBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel1.Text = "Source :";
            // 
            // sourceTxt
            // 
            this.sourceTxt.Name = "sourceTxt";
            this.sourceTxt.Size = new System.Drawing.Size(100, 25);
            // 
            // browseBtn
            // 
            this.browseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.browseBtn.Image = ((System.Drawing.Image)(resources.GetObject("browseBtn.Image")));
            this.browseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(49, 22);
            this.browseBtn.Text = "Browse";
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel2.Text = "Sheet Name :";
            // 
            // sheetTxt
            // 
            this.sheetTxt.Name = "sheetTxt";
            this.sheetTxt.Size = new System.Drawing.Size(100, 25);
            this.sheetTxt.Text = "sheet1";
            // 
            // prosesBtn
            // 
            this.prosesBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.prosesBtn.Image = ((System.Drawing.Image)(resources.GetObject("prosesBtn.Image")));
            this.prosesBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prosesBtn.Name = "prosesBtn";
            this.prosesBtn.Size = new System.Drawing.Size(45, 22);
            this.prosesBtn.Text = "Proses";
            this.prosesBtn.Click += new System.EventHandler(this.prosesBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.importBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.importBtn.Image = ((System.Drawing.Image)(resources.GetObject("importBtn.Image")));
            this.importBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(53, 22);
            this.importBtn.Text = "Import !";
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // FrmImportExcelRoti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 335);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmImportExcelRoti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmImportExcelRoti";
            this.Load += new System.EventHandler(this.FrmImportExcelRoti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox sourceTxt;
        private System.Windows.Forms.ToolStripButton browseBtn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox sheetTxt;
        private System.Windows.Forms.ToolStripButton prosesBtn;
        private System.Windows.Forms.ToolStripButton importBtn;
    }
}