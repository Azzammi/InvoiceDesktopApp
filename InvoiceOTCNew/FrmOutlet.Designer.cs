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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.outlAddressTextBox = new System.Windows.Forms.TextBox();
            this.outlCodeTextBox = new System.Windows.Forms.TextBox();
            this.outlNameTextBox = new System.Windows.Forms.TextBox();
            this.outlRouteTextBox = new System.Windows.Forms.TextBox();
            this.outlSlsmTextBox = new System.Windows.Forms.TextBox();
            this.outlStatusCheckBox = new System.Windows.Forms.CheckBox();
            outlAddressLabel = new System.Windows.Forms.Label();
            outlCodeLabel = new System.Windows.Forms.Label();
            outlNameLabel = new System.Windows.Forms.Label();
            outlRouteLabel = new System.Windows.Forms.Label();
            outlSlsmLabel = new System.Windows.Forms.Label();
            outlStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.outletBindingSource)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // outletBindingSource
            // 
            this.outletBindingSource.DataSource = typeof(InvoiceOTC.Model.Outlet);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.tableLayoutPanel4.Controls.Add(outlRouteLabel, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.outlRouteTextBox, 1, 3);
            this.tableLayoutPanel4.Controls.Add(outlSlsmLabel, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.outlSlsmTextBox, 1, 4);
            this.tableLayoutPanel4.Controls.Add(outlStatusLabel, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.outlStatusCheckBox, 1, 5);
            this.tableLayoutPanel4.Controls.Add(outlCodeLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.outlCodeTextBox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(outlNameLabel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.outlNameTextBox, 1, 1);
            this.tableLayoutPanel4.Controls.Add(outlAddressLabel, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.outlAddressTextBox, 1, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 58);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(375, 195);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // outlAddressLabel
            // 
            outlAddressLabel.AutoSize = true;
            outlAddressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            outlAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            outlAddressLabel.ForeColor = System.Drawing.Color.White;
            outlAddressLabel.Location = new System.Drawing.Point(3, 64);
            outlAddressLabel.Name = "outlAddressLabel";
            outlAddressLabel.Size = new System.Drawing.Size(131, 32);
            outlAddressLabel.TabIndex = 0;
            outlAddressLabel.Text = "outl Address:";
            outlAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outlAddressTextBox
            // 
            this.outlAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outletBindingSource, "outlAddress", true));
            this.outlAddressTextBox.Location = new System.Drawing.Point(140, 67);
            this.outlAddressTextBox.Name = "outlAddressTextBox";
            this.outlAddressTextBox.Size = new System.Drawing.Size(227, 20);
            this.outlAddressTextBox.TabIndex = 1;
            // 
            // outlCodeLabel
            // 
            outlCodeLabel.AutoSize = true;
            outlCodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            outlCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            outlCodeLabel.ForeColor = System.Drawing.Color.White;
            outlCodeLabel.Location = new System.Drawing.Point(3, 0);
            outlCodeLabel.Name = "outlCodeLabel";
            outlCodeLabel.Size = new System.Drawing.Size(131, 32);
            outlCodeLabel.TabIndex = 2;
            outlCodeLabel.Text = "outl Code:";
            outlCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outlCodeTextBox
            // 
            this.outlCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outletBindingSource, "outlCode", true));
            this.outlCodeTextBox.Location = new System.Drawing.Point(140, 3);
            this.outlCodeTextBox.Name = "outlCodeTextBox";
            this.outlCodeTextBox.Size = new System.Drawing.Size(227, 20);
            this.outlCodeTextBox.TabIndex = 3;
            // 
            // outlNameLabel
            // 
            outlNameLabel.AutoSize = true;
            outlNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            outlNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            outlNameLabel.ForeColor = System.Drawing.Color.White;
            outlNameLabel.Location = new System.Drawing.Point(3, 32);
            outlNameLabel.Name = "outlNameLabel";
            outlNameLabel.Size = new System.Drawing.Size(131, 32);
            outlNameLabel.TabIndex = 4;
            outlNameLabel.Text = "outl Name:";
            outlNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outlNameTextBox
            // 
            this.outlNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outletBindingSource, "outlName", true));
            this.outlNameTextBox.Location = new System.Drawing.Point(140, 35);
            this.outlNameTextBox.Name = "outlNameTextBox";
            this.outlNameTextBox.Size = new System.Drawing.Size(227, 20);
            this.outlNameTextBox.TabIndex = 5;
            // 
            // outlRouteLabel
            // 
            outlRouteLabel.AutoSize = true;
            outlRouteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            outlRouteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            outlRouteLabel.ForeColor = System.Drawing.Color.White;
            outlRouteLabel.Location = new System.Drawing.Point(3, 96);
            outlRouteLabel.Name = "outlRouteLabel";
            outlRouteLabel.Size = new System.Drawing.Size(131, 32);
            outlRouteLabel.TabIndex = 6;
            outlRouteLabel.Text = "outl Route:";
            outlRouteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outlRouteTextBox
            // 
            this.outlRouteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outletBindingSource, "outlRoute", true));
            this.outlRouteTextBox.Location = new System.Drawing.Point(140, 99);
            this.outlRouteTextBox.Name = "outlRouteTextBox";
            this.outlRouteTextBox.Size = new System.Drawing.Size(227, 20);
            this.outlRouteTextBox.TabIndex = 7;
            // 
            // outlSlsmLabel
            // 
            outlSlsmLabel.AutoSize = true;
            outlSlsmLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            outlSlsmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            outlSlsmLabel.ForeColor = System.Drawing.Color.White;
            outlSlsmLabel.Location = new System.Drawing.Point(3, 128);
            outlSlsmLabel.Name = "outlSlsmLabel";
            outlSlsmLabel.Size = new System.Drawing.Size(131, 32);
            outlSlsmLabel.TabIndex = 8;
            outlSlsmLabel.Text = "outl Slsm:";
            outlSlsmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outlSlsmTextBox
            // 
            this.outlSlsmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outletBindingSource, "outlSlsm", true));
            this.outlSlsmTextBox.Location = new System.Drawing.Point(140, 131);
            this.outlSlsmTextBox.Name = "outlSlsmTextBox";
            this.outlSlsmTextBox.Size = new System.Drawing.Size(227, 20);
            this.outlSlsmTextBox.TabIndex = 9;
            // 
            // outlStatusLabel
            // 
            outlStatusLabel.AutoSize = true;
            outlStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            outlStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            outlStatusLabel.ForeColor = System.Drawing.Color.White;
            outlStatusLabel.Location = new System.Drawing.Point(3, 160);
            outlStatusLabel.Name = "outlStatusLabel";
            outlStatusLabel.Size = new System.Drawing.Size(131, 35);
            outlStatusLabel.TabIndex = 10;
            outlStatusLabel.Text = "outl Status:";
            outlStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outlStatusCheckBox
            // 
            this.outlStatusCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.outletBindingSource, "outlStatus", true));
            this.outlStatusCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outlStatusCheckBox.ForeColor = System.Drawing.Color.White;
            this.outlStatusCheckBox.Location = new System.Drawing.Point(140, 163);
            this.outlStatusCheckBox.Name = "outlStatusCheckBox";
            this.outlStatusCheckBox.Size = new System.Drawing.Size(227, 24);
            this.outlStatusCheckBox.TabIndex = 11;
            this.outlStatusCheckBox.Text = "Active ?";
            this.outlStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // FrmOutlet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 300);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "FrmOutlet";
            this.Text = "FrmOutlet";
            this.Controls.SetChildIndex(this.tableLayoutPanel4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.outletBindingSource)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource outletBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox outlRouteTextBox;
        private System.Windows.Forms.TextBox outlSlsmTextBox;
        private System.Windows.Forms.CheckBox outlStatusCheckBox;
        private System.Windows.Forms.TextBox outlCodeTextBox;
        private System.Windows.Forms.TextBox outlNameTextBox;
        private System.Windows.Forms.TextBox outlAddressTextBox;
    }
}