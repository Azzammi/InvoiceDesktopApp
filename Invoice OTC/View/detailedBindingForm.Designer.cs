namespace Invoice_OTC.View
{
    partial class detailedBindingForm
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
            System.Windows.Forms.Label invoiceIDLabel;
            System.Windows.Forms.Label issuedDataLabel;
            System.Windows.Forms.Label nomorLabel;
            System.Windows.Forms.Label periodeBulanLabel;
            System.Windows.Forms.Label pPNLabel;
            System.Windows.Forms.Label slsmCodeLabel;
            System.Windows.Forms.Label subTotalLabel;
            System.Windows.Forms.Label totalLabel;
            this.invoiceItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceIDTextBox = new System.Windows.Forms.TextBox();
            this.issuedDataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nomorTextBox = new System.Windows.Forms.TextBox();
            this.periodeBulanDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pPNTextBox = new System.Windows.Forms.TextBox();
            this.slsmCodeComboBox = new System.Windows.Forms.ComboBox();
            this.customerListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rotiToChooseItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findStrip1 = new Invoice_OTC.Controller.FindStrip();
            this.batalBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.tambahBtn = new System.Windows.Forms.Button();
            invoiceIDLabel = new System.Windows.Forms.Label();
            issuedDataLabel = new System.Windows.Forms.Label();
            nomorLabel = new System.Windows.Forms.Label();
            periodeBulanLabel = new System.Windows.Forms.Label();
            pPNLabel = new System.Windows.Forms.Label();
            slsmCodeLabel = new System.Windows.Forms.Label();
            subTotalLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotiToChooseItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceIDLabel
            // 
            invoiceIDLabel.AutoSize = true;
            invoiceIDLabel.Location = new System.Drawing.Point(23, 46);
            invoiceIDLabel.Name = "invoiceIDLabel";
            invoiceIDLabel.Size = new System.Drawing.Size(59, 13);
            invoiceIDLabel.TabIndex = 1;
            invoiceIDLabel.Text = "Invoice ID:";
            // 
            // issuedDataLabel
            // 
            issuedDataLabel.AutoSize = true;
            issuedDataLabel.Location = new System.Drawing.Point(23, 73);
            issuedDataLabel.Name = "issuedDataLabel";
            issuedDataLabel.Size = new System.Drawing.Size(67, 13);
            issuedDataLabel.TabIndex = 3;
            issuedDataLabel.Text = "Issued Data:";
            // 
            // nomorLabel
            // 
            nomorLabel.AutoSize = true;
            nomorLabel.Location = new System.Drawing.Point(23, 98);
            nomorLabel.Name = "nomorLabel";
            nomorLabel.Size = new System.Drawing.Size(41, 13);
            nomorLabel.TabIndex = 5;
            nomorLabel.Text = "Nomor:";
            // 
            // periodeBulanLabel
            // 
            periodeBulanLabel.AutoSize = true;
            periodeBulanLabel.Location = new System.Drawing.Point(342, 47);
            periodeBulanLabel.Name = "periodeBulanLabel";
            periodeBulanLabel.Size = new System.Drawing.Size(76, 13);
            periodeBulanLabel.TabIndex = 7;
            periodeBulanLabel.Text = "Periode Bulan:";
            // 
            // pPNLabel
            // 
            pPNLabel.AutoSize = true;
            pPNLabel.Location = new System.Drawing.Point(342, 342);
            pPNLabel.Name = "pPNLabel";
            pPNLabel.Size = new System.Drawing.Size(32, 13);
            pPNLabel.TabIndex = 9;
            pPNLabel.Text = "PPN:";
            // 
            // slsmCodeLabel
            // 
            slsmCodeLabel.AutoSize = true;
            slsmCodeLabel.Location = new System.Drawing.Point(342, 98);
            slsmCodeLabel.Name = "slsmCodeLabel";
            slsmCodeLabel.Size = new System.Drawing.Size(64, 13);
            slsmCodeLabel.TabIndex = 11;
            slsmCodeLabel.Text = "Invoice To :";
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Location = new System.Drawing.Point(342, 316);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new System.Drawing.Size(56, 13);
            subTotalLabel.TabIndex = 17;
            subTotalLabel.Text = "Sub Total:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(342, 369);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 19;
            totalLabel.Text = "Total:";
            // 
            // invoiceItemBindingSource
            // 
            this.invoiceItemBindingSource.DataSource = typeof(Invoice_OTC.Model.InvoiceItem);
            // 
            // invoiceIDTextBox
            // 
            this.invoiceIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceItemBindingSource, "InvoiceID", true));
            this.invoiceIDTextBox.Location = new System.Drawing.Point(111, 43);
            this.invoiceIDTextBox.Name = "invoiceIDTextBox";
            this.invoiceIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.invoiceIDTextBox.TabIndex = 2;
            // 
            // issuedDataDateTimePicker
            // 
            this.issuedDataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceItemBindingSource, "IssuedData", true));
            this.issuedDataDateTimePicker.Location = new System.Drawing.Point(111, 69);
            this.issuedDataDateTimePicker.Name = "issuedDataDateTimePicker";
            this.issuedDataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.issuedDataDateTimePicker.TabIndex = 4;
            // 
            // nomorTextBox
            // 
            this.nomorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceItemBindingSource, "Nomor", true));
            this.nomorTextBox.Location = new System.Drawing.Point(111, 95);
            this.nomorTextBox.Name = "nomorTextBox";
            this.nomorTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomorTextBox.TabIndex = 6;
            // 
            // periodeBulanDateTimePicker
            // 
            this.periodeBulanDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceItemBindingSource, "PeriodeBulan", true));
            this.periodeBulanDateTimePicker.Location = new System.Drawing.Point(430, 43);
            this.periodeBulanDateTimePicker.Name = "periodeBulanDateTimePicker";
            this.periodeBulanDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.periodeBulanDateTimePicker.TabIndex = 8;
            // 
            // pPNTextBox
            // 
            this.pPNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceItemBindingSource, "PPN", true));
            this.pPNTextBox.Location = new System.Drawing.Point(430, 339);
            this.pPNTextBox.Name = "pPNTextBox";
            this.pPNTextBox.Size = new System.Drawing.Size(200, 20);
            this.pPNTextBox.TabIndex = 10;
            // 
            // slsmCodeComboBox
            // 
            this.slsmCodeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoiceItemBindingSource, "SlsmCode", true));
            this.slsmCodeComboBox.DataSource = this.customerListBindingSource;
            this.slsmCodeComboBox.DisplayMember = "SlsmName";
            this.slsmCodeComboBox.FormattingEnabled = true;
            this.slsmCodeComboBox.Location = new System.Drawing.Point(430, 95);
            this.slsmCodeComboBox.Name = "slsmCodeComboBox";
            this.slsmCodeComboBox.Size = new System.Drawing.Size(200, 21);
            this.slsmCodeComboBox.TabIndex = 12;
            this.slsmCodeComboBox.ValueMember = "SlsmCode";
            // 
            // customerListBindingSource
            // 
            this.customerListBindingSource.DataSource = typeof(Invoice_OTC.Model.CustomerList);
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceItemBindingSource, "SubTotal", true));
            this.subTotalTextBox.Location = new System.Drawing.Point(430, 313);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.Size = new System.Drawing.Size(200, 20);
            this.subTotalTextBox.TabIndex = 18;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceItemBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(430, 366);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalTextBox.TabIndex = 20;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.invoiceItemBindingSource;
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.AutoGenerateColumns = false;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.itemsDataGridView.DataSource = this.itemsBindingSource;
            this.itemsDataGridView.Location = new System.Drawing.Point(26, 122);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.Size = new System.Drawing.Size(604, 176);
            this.itemsDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn2.DataSource = this.rotiToChooseItemBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "ItemName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ROTI";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ItemCode";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // rotiToChooseItemBindingSource
            // 
            this.rotiToChooseItemBindingSource.DataSource = typeof(Invoice_OTC.Model.RotiToChooseItem);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn4.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // findStrip1
            // 
            this.findStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.findStrip1.bindingSource = this.invoiceItemBindingSource;
            this.findStrip1.Location = new System.Drawing.Point(0, 0);
            this.findStrip1.Name = "findStrip1";
            this.findStrip1.Size = new System.Drawing.Size(655, 32);
            this.findStrip1.TabIndex = 2;
            this.findStrip1.Text = "findStrip1";
            this.findStrip1.ItemFound += new Invoice_OTC.Controller.ItemFoundEventHandler(this.findStrip1_ItemFound);
            // 
            // batalBtn
            // 
            this.batalBtn.Image = global::Invoice_OTC.Properties.Resources.Close_Window_96px;
            this.batalBtn.Location = new System.Drawing.Point(259, 317);
            this.batalBtn.Name = "batalBtn";
            this.batalBtn.Size = new System.Drawing.Size(72, 65);
            this.batalBtn.TabIndex = 25;
            this.batalBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Image = global::Invoice_OTC.Properties.Resources.Delete_50px;
            this.deleteBtn.Location = new System.Drawing.Point(181, 317);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(72, 65);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // simpanBtn
            // 
            this.simpanBtn.Image = global::Invoice_OTC.Properties.Resources.Save_50px_1;
            this.simpanBtn.Location = new System.Drawing.Point(103, 317);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(72, 65);
            this.simpanBtn.TabIndex = 23;
            this.simpanBtn.UseVisualStyleBackColor = true;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // tambahBtn
            // 
            this.tambahBtn.Image = global::Invoice_OTC.Properties.Resources.Add_50px;
            this.tambahBtn.Location = new System.Drawing.Point(25, 317);
            this.tambahBtn.Name = "tambahBtn";
            this.tambahBtn.Size = new System.Drawing.Size(72, 65);
            this.tambahBtn.TabIndex = 22;
            this.tambahBtn.UseVisualStyleBackColor = true;
            this.tambahBtn.Click += new System.EventHandler(this.tambahBtn_Click);
            // 
            // detailedBindingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 398);
            this.Controls.Add(this.batalBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.simpanBtn);
            this.Controls.Add(this.tambahBtn);
            Controls.Add(this.findStrip1);
            this.Controls.Add(this.itemsDataGridView);
            this.Controls.Add(invoiceIDLabel);
            this.Controls.Add(this.invoiceIDTextBox);
            this.Controls.Add(issuedDataLabel);
            this.Controls.Add(this.issuedDataDateTimePicker);
            this.Controls.Add(nomorLabel);
            this.Controls.Add(this.nomorTextBox);
            this.Controls.Add(periodeBulanLabel);
            this.Controls.Add(this.periodeBulanDateTimePicker);
            this.Controls.Add(pPNLabel);
            this.Controls.Add(this.pPNTextBox);
            this.Controls.Add(slsmCodeLabel);
            this.Controls.Add(this.slsmCodeComboBox);
            this.Controls.Add(subTotalLabel);
            this.Controls.Add(this.subTotalTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "detailedBindingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "detailedBindingForm";
            this.Load += new System.EventHandler(this.detailedBindingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotiToChooseItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource invoiceItemBindingSource;
        private System.Windows.Forms.TextBox invoiceIDTextBox;
        private System.Windows.Forms.DateTimePicker issuedDataDateTimePicker;
        private System.Windows.Forms.TextBox nomorTextBox;
        private System.Windows.Forms.DateTimePicker periodeBulanDateTimePicker;
        private System.Windows.Forms.TextBox pPNTextBox;
        private System.Windows.Forms.ComboBox slsmCodeComboBox;
        private System.Windows.Forms.BindingSource customerListBindingSource;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource rotiToChooseItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Controller.FindStrip findStrip1;
        private System.Windows.Forms.Button batalBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Button tambahBtn;
    }
}