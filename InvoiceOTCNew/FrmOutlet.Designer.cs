namespace InvoiceOTCNew
{
    partial class FrmOutlet
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
            System.Windows.Forms.Label outlAddressLabel;
            System.Windows.Forms.Label outlCodeLabel;
            System.Windows.Forms.Label outlNameLabel;
            System.Windows.Forms.Label outlRouteLabel;
            System.Windows.Forms.Label outlSlsmLabel;
            System.Windows.Forms.Label outlStatusLabel;
            this.outletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.outlCodeTextBox = new System.Windows.Forms.TextBox();
            this.outlNameTextBox = new System.Windows.Forms.TextBox();
            this.outlAddressTextBox = new System.Windows.Forms.TextBox();
            this.outlRouteTextBox = new System.Windows.Forms.TextBox();
            this.outlSlsmTextBox = new System.Windows.Forms.TextBox();
            this.outlStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            outlAddressLabel = new System.Windows.Forms.Label();
            outlCodeLabel = new System.Windows.Forms.Label();
            outlNameLabel = new System.Windows.Forms.Label();
            outlRouteLabel = new System.Windows.Forms.Label();
            outlSlsmLabel = new System.Windows.Forms.Label();
            outlStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.outletBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // outlAddressLabel
            // 
            outlAddressLabel.AutoSize = true;
            outlAddressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            outlAddressLabel.ForeColor = System.Drawing.Color.White;
            outlAddressLabel.Location = new System.Drawing.Point(3, 57);
            outlAddressLabel.Name = "outlAddressLabel";
            outlAddressLabel.Size = new System.Drawing.Size(75, 124);
            outlAddressLabel.TabIndex = 0;
            outlAddressLabel.Text = "outl Address:";
            outlAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outlCodeLabel
            // 
            outlCodeLabel.AutoSize = true;
            outlCodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            outlCodeLabel.ForeColor = System.Drawing.Color.White;
            outlCodeLabel.Location = new System.Drawing.Point(3, 0);
            outlCodeLabel.Name = "outlCodeLabel";
            outlCodeLabel.Size = new System.Drawing.Size(75, 28);
            outlCodeLabel.TabIndex = 2;
            outlCodeLabel.Text = "outl Code:";
            outlCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outlNameLabel
            // 
            outlNameLabel.AutoSize = true;
            outlNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            outlNameLabel.ForeColor = System.Drawing.Color.White;
            outlNameLabel.Location = new System.Drawing.Point(3, 28);
            outlNameLabel.Name = "outlNameLabel";
            outlNameLabel.Size = new System.Drawing.Size(75, 29);
            outlNameLabel.TabIndex = 4;
            outlNameLabel.Text = "outl Name:";
            outlNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outlRouteLabel
            // 
            outlRouteLabel.AutoSize = true;
            outlRouteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            outlRouteLabel.ForeColor = System.Drawing.Color.White;
            outlRouteLabel.Location = new System.Drawing.Point(3, 181);
            outlRouteLabel.Name = "outlRouteLabel";
            outlRouteLabel.Size = new System.Drawing.Size(75, 27);
            outlRouteLabel.TabIndex = 6;
            outlRouteLabel.Text = "outl Route:";
            outlRouteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outlSlsmLabel
            // 
            outlSlsmLabel.AutoSize = true;
            outlSlsmLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            outlSlsmLabel.ForeColor = System.Drawing.Color.White;
            outlSlsmLabel.Location = new System.Drawing.Point(3, 208);
            outlSlsmLabel.Name = "outlSlsmLabel";
            outlSlsmLabel.Size = new System.Drawing.Size(75, 26);
            outlSlsmLabel.TabIndex = 8;
            outlSlsmLabel.Text = "outl Slsm:";
            outlSlsmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outlStatusLabel
            // 
            outlStatusLabel.AutoSize = true;
            outlStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            outlStatusLabel.ForeColor = System.Drawing.Color.White;
            outlStatusLabel.Location = new System.Drawing.Point(3, 234);
            outlStatusLabel.Name = "outlStatusLabel";
            outlStatusLabel.Size = new System.Drawing.Size(75, 21);
            outlStatusLabel.TabIndex = 10;
            outlStatusLabel.Text = "outl Status:";
            outlStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outletBindingSource
            // 
            this.outletBindingSource.DataSource = typeof(InvoiceOTC.Model.Outlet);
            this.outletBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.BindingSource_AddingNew);
            this.outletBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.BindingSource_ListChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.04739F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.14286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 367);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 50);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entry Outlet";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.69942F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.30058F));
            this.tableLayoutPanel2.Controls.Add(outlCodeLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.outlCodeTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(outlNameLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.outlNameTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(outlAddressLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.outlAddressTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.outlRouteTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(outlRouteLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(outlSlsmLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.outlSlsmTextBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(outlStatusLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.outlStatusCheckBox, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 59);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.48485F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.51515F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(346, 255);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // outlCodeTextBox
            // 
            this.outlCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outletBindingSource, "outlCode", true));
            this.outlCodeTextBox.Location = new System.Drawing.Point(84, 3);
            this.outlCodeTextBox.Name = "outlCodeTextBox";
            this.outlCodeTextBox.Size = new System.Drawing.Size(104, 20);
            this.outlCodeTextBox.TabIndex = 0;
            // 
            // outlNameTextBox
            // 
            this.outlNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outletBindingSource, "outlName", true));
            this.outlNameTextBox.Location = new System.Drawing.Point(84, 31);
            this.outlNameTextBox.Name = "outlNameTextBox";
            this.outlNameTextBox.Size = new System.Drawing.Size(104, 20);
            this.outlNameTextBox.TabIndex = 1;
            // 
            // outlAddressTextBox
            // 
            this.outlAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outletBindingSource, "outlAddress", true));
            this.outlAddressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outlAddressTextBox.Location = new System.Drawing.Point(84, 60);
            this.outlAddressTextBox.Multiline = true;
            this.outlAddressTextBox.Name = "outlAddressTextBox";
            this.outlAddressTextBox.Size = new System.Drawing.Size(259, 118);
            this.outlAddressTextBox.TabIndex = 2;
            // 
            // outlRouteTextBox
            // 
            this.outlRouteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outletBindingSource, "outlRoute", true));
            this.outlRouteTextBox.Location = new System.Drawing.Point(84, 184);
            this.outlRouteTextBox.Name = "outlRouteTextBox";
            this.outlRouteTextBox.Size = new System.Drawing.Size(104, 20);
            this.outlRouteTextBox.TabIndex = 3;
            // 
            // outlSlsmTextBox
            // 
            this.outlSlsmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outletBindingSource, "outlSlsm", true));
            this.outlSlsmTextBox.Location = new System.Drawing.Point(84, 211);
            this.outlSlsmTextBox.Name = "outlSlsmTextBox";
            this.outlSlsmTextBox.Size = new System.Drawing.Size(104, 20);
            this.outlSlsmTextBox.TabIndex = 4;
            // 
            // outlStatusCheckBox
            // 
            this.outlStatusCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.outletBindingSource, "outlStatus", true));
            this.outlStatusCheckBox.ForeColor = System.Drawing.Color.White;
            this.outlStatusCheckBox.Location = new System.Drawing.Point(84, 237);
            this.outlStatusCheckBox.Name = "outlStatusCheckBox";
            this.outlStatusCheckBox.Size = new System.Drawing.Size(104, 15);
            this.outlStatusCheckBox.TabIndex = 5;
            this.outlStatusCheckBox.Text = "Aktif";
            this.outlStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 320);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(346, 44);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(176, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmOutlet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(352, 367);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmOutlet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOutlet";
            this.Load += new System.EventHandler(this.FrmOutlet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outletBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource outletBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox outlCodeTextBox;
        private System.Windows.Forms.TextBox outlNameTextBox;
        private System.Windows.Forms.TextBox outlAddressTextBox;
        private System.Windows.Forms.TextBox outlRouteTextBox;
        private System.Windows.Forms.TextBox outlSlsmTextBox;
        private System.Windows.Forms.CheckBox outlStatusCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}