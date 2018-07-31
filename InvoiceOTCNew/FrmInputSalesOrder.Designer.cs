namespace InvoiceOTCNew
{
    partial class FrmInputSalesOrder
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
            System.Windows.Forms.Label accountRefLabel;
            System.Windows.Forms.Label manualRefLabel;
            System.Windows.Forms.Label nomorSOLabel;
            System.Windows.Forms.Label otherRefLabel;
            System.Windows.Forms.Label outlCodeLabel;
            System.Windows.Forms.Label outlNameLabel;
            System.Windows.Forms.Label qtyOrderLabel;
            System.Windows.Forms.Label soCreatedLabel;
            System.Windows.Forms.Label soDateLabel;
            System.Windows.Forms.Label totalAmountLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInputSalesOrder));
            this.salesOrderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.salesOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.salesOrderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.p_ItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabSalesOrder = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.accountRefTextBox = new System.Windows.Forms.TextBox();
            this.manualRefTextBox = new System.Windows.Forms.TextBox();
            this.nomorSOTextBox = new System.Windows.Forms.TextBox();
            this.otherRefTextBox = new System.Windows.Forms.TextBox();
            this.outlCodeTextBox = new System.Windows.Forms.TextBox();
            this.outlNameTextBox = new System.Windows.Forms.TextBox();
            this.qtyOrderTextBox = new System.Windows.Forms.TextBox();
            this.soCreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.soDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.detailDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            accountRefLabel = new System.Windows.Forms.Label();
            manualRefLabel = new System.Windows.Forms.Label();
            nomorSOLabel = new System.Windows.Forms.Label();
            otherRefLabel = new System.Windows.Forms.Label();
            outlCodeLabel = new System.Windows.Forms.Label();
            outlNameLabel = new System.Windows.Forms.Label();
            qtyOrderLabel = new System.Windows.Forms.Label();
            soCreatedLabel = new System.Windows.Forms.Label();
            soDateLabel = new System.Windows.Forms.Label();
            totalAmountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderBindingNavigator)).BeginInit();
            this.salesOrderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_ItemsBindingSource)).BeginInit();
            this.tabSalesOrder.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // accountRefLabel
            // 
            accountRefLabel.AutoSize = true;
            accountRefLabel.Location = new System.Drawing.Point(3, 0);
            accountRefLabel.Name = "accountRefLabel";
            accountRefLabel.Size = new System.Drawing.Size(69, 13);
            accountRefLabel.TabIndex = 0;
            accountRefLabel.Text = "account Ref:";
            // 
            // manualRefLabel
            // 
            manualRefLabel.AutoSize = true;
            manualRefLabel.Location = new System.Drawing.Point(3, 20);
            manualRefLabel.Name = "manualRefLabel";
            manualRefLabel.Size = new System.Drawing.Size(64, 13);
            manualRefLabel.TabIndex = 2;
            manualRefLabel.Text = "manual Ref:";
            // 
            // nomorSOLabel
            // 
            nomorSOLabel.AutoSize = true;
            nomorSOLabel.Location = new System.Drawing.Point(3, 40);
            nomorSOLabel.Name = "nomorSOLabel";
            nomorSOLabel.Size = new System.Drawing.Size(57, 13);
            nomorSOLabel.TabIndex = 4;
            nomorSOLabel.Text = "nomor SO:";
            // 
            // otherRefLabel
            // 
            otherRefLabel.AutoSize = true;
            otherRefLabel.Location = new System.Drawing.Point(3, 60);
            otherRefLabel.Name = "otherRefLabel";
            otherRefLabel.Size = new System.Drawing.Size(54, 13);
            otherRefLabel.TabIndex = 6;
            otherRefLabel.Text = "other Ref:";
            // 
            // outlCodeLabel
            // 
            outlCodeLabel.AutoSize = true;
            outlCodeLabel.Location = new System.Drawing.Point(3, 80);
            outlCodeLabel.Name = "outlCodeLabel";
            outlCodeLabel.Size = new System.Drawing.Size(55, 13);
            outlCodeLabel.TabIndex = 8;
            outlCodeLabel.Text = "outl Code:";
            // 
            // outlNameLabel
            // 
            outlNameLabel.AutoSize = true;
            outlNameLabel.Location = new System.Drawing.Point(3, 100);
            outlNameLabel.Name = "outlNameLabel";
            outlNameLabel.Size = new System.Drawing.Size(58, 13);
            outlNameLabel.TabIndex = 10;
            outlNameLabel.Text = "outl Name:";
            // 
            // qtyOrderLabel
            // 
            qtyOrderLabel.AutoSize = true;
            qtyOrderLabel.Location = new System.Drawing.Point(3, 120);
            qtyOrderLabel.Name = "qtyOrderLabel";
            qtyOrderLabel.Size = new System.Drawing.Size(53, 13);
            qtyOrderLabel.TabIndex = 12;
            qtyOrderLabel.Text = "qty Order:";
            // 
            // soCreatedLabel
            // 
            soCreatedLabel.AutoSize = true;
            soCreatedLabel.Location = new System.Drawing.Point(3, 160);
            soCreatedLabel.Name = "soCreatedLabel";
            soCreatedLabel.Size = new System.Drawing.Size(61, 13);
            soCreatedLabel.TabIndex = 16;
            soCreatedLabel.Text = "so Created:";
            // 
            // soDateLabel
            // 
            soDateLabel.AutoSize = true;
            soDateLabel.Location = new System.Drawing.Point(3, 180);
            soDateLabel.Name = "soDateLabel";
            soDateLabel.Size = new System.Drawing.Size(47, 13);
            soDateLabel.TabIndex = 18;
            soDateLabel.Text = "so Date:";
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Location = new System.Drawing.Point(3, 200);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new System.Drawing.Size(69, 13);
            totalAmountLabel.TabIndex = 20;
            totalAmountLabel.Text = "total Amount:";
            // 
            // salesOrderBindingNavigator
            // 
            this.salesOrderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.salesOrderBindingNavigator.BindingSource = this.salesOrderBindingSource;
            this.salesOrderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.salesOrderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.salesOrderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.salesOrderBindingNavigatorSaveItem});
            this.salesOrderBindingNavigator.Location = new System.Drawing.Point(0, 58);
            this.salesOrderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.salesOrderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.salesOrderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.salesOrderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.salesOrderBindingNavigator.Name = "salesOrderBindingNavigator";
            this.salesOrderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.salesOrderBindingNavigator.Size = new System.Drawing.Size(630, 25);
            this.salesOrderBindingNavigator.TabIndex = 0;
            this.salesOrderBindingNavigator.Text = "bindingNavigator1";
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
            // salesOrderBindingSource
            // 
            this.salesOrderBindingSource.DataSource = typeof(InvoiceOTC.Model.SalesOrder);
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
            // salesOrderBindingNavigatorSaveItem
            // 
            this.salesOrderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salesOrderBindingNavigatorSaveItem.Enabled = false;
            this.salesOrderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("salesOrderBindingNavigatorSaveItem.Image")));
            this.salesOrderBindingNavigatorSaveItem.Name = "salesOrderBindingNavigatorSaveItem";
            this.salesOrderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.salesOrderBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // p_ItemsBindingSource
            // 
            this.p_ItemsBindingSource.DataMember = "p_Items";
            this.p_ItemsBindingSource.DataSource = this.salesOrderBindingSource;
            // 
            // tabSalesOrder
            // 
            this.tabSalesOrder.Controls.Add(this.tabPage1);
            this.tabSalesOrder.Controls.Add(this.tabPage2);
            this.tabSalesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSalesOrder.Location = new System.Drawing.Point(0, 83);
            this.tabSalesOrder.Name = "tabSalesOrder";
            this.tabSalesOrder.SelectedIndex = 0;
            this.tabSalesOrder.Size = new System.Drawing.Size(630, 373);
            this.tabSalesOrder.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(622, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detail";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.69481F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.30519F));
            this.tableLayoutPanel2.Controls.Add(accountRefLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.accountRefTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(manualRefLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.manualRefTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(nomorSOLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.nomorSOTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(otherRefLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.otherRefTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(outlCodeLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.outlCodeTextBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(outlNameLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.outlNameTextBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(qtyOrderLabel, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.qtyOrderTextBox, 1, 6);
            this.tableLayoutPanel2.Controls.Add(soCreatedLabel, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.soCreatedDateTimePicker, 1, 8);
            this.tableLayoutPanel2.Controls.Add(soDateLabel, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.soDateDateTimePicker, 1, 9);
            this.tableLayoutPanel2.Controls.Add(totalAmountLabel, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.totalAmountTextBox, 1, 10);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(616, 341);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // accountRefTextBox
            // 
            this.accountRefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesOrderBindingSource, "accountRef", true));
            this.accountRefTextBox.Location = new System.Drawing.Point(111, 3);
            this.accountRefTextBox.Name = "accountRefTextBox";
            this.accountRefTextBox.Size = new System.Drawing.Size(200, 20);
            this.accountRefTextBox.TabIndex = 1;
            // 
            // manualRefTextBox
            // 
            this.manualRefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesOrderBindingSource, "manualRef", true));
            this.manualRefTextBox.Location = new System.Drawing.Point(111, 23);
            this.manualRefTextBox.Name = "manualRefTextBox";
            this.manualRefTextBox.Size = new System.Drawing.Size(200, 20);
            this.manualRefTextBox.TabIndex = 3;
            // 
            // nomorSOTextBox
            // 
            this.nomorSOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesOrderBindingSource, "nomorSO", true));
            this.nomorSOTextBox.Location = new System.Drawing.Point(111, 43);
            this.nomorSOTextBox.Name = "nomorSOTextBox";
            this.nomorSOTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomorSOTextBox.TabIndex = 5;
            // 
            // otherRefTextBox
            // 
            this.otherRefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesOrderBindingSource, "otherRef", true));
            this.otherRefTextBox.Location = new System.Drawing.Point(111, 63);
            this.otherRefTextBox.Name = "otherRefTextBox";
            this.otherRefTextBox.Size = new System.Drawing.Size(200, 20);
            this.otherRefTextBox.TabIndex = 7;
            // 
            // outlCodeTextBox
            // 
            this.outlCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesOrderBindingSource, "outlCode", true));
            this.outlCodeTextBox.Location = new System.Drawing.Point(111, 83);
            this.outlCodeTextBox.Name = "outlCodeTextBox";
            this.outlCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.outlCodeTextBox.TabIndex = 9;
            // 
            // outlNameTextBox
            // 
            this.outlNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesOrderBindingSource, "outlName", true));
            this.outlNameTextBox.Location = new System.Drawing.Point(111, 103);
            this.outlNameTextBox.Name = "outlNameTextBox";
            this.outlNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.outlNameTextBox.TabIndex = 11;
            // 
            // qtyOrderTextBox
            // 
            this.qtyOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesOrderBindingSource, "qtyOrder", true));
            this.qtyOrderTextBox.Location = new System.Drawing.Point(111, 123);
            this.qtyOrderTextBox.Name = "qtyOrderTextBox";
            this.qtyOrderTextBox.Size = new System.Drawing.Size(200, 20);
            this.qtyOrderTextBox.TabIndex = 13;
            // 
            // soCreatedDateTimePicker
            // 
            this.soCreatedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.salesOrderBindingSource, "soCreated", true));
            this.soCreatedDateTimePicker.Location = new System.Drawing.Point(111, 163);
            this.soCreatedDateTimePicker.Name = "soCreatedDateTimePicker";
            this.soCreatedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.soCreatedDateTimePicker.TabIndex = 17;
            // 
            // soDateDateTimePicker
            // 
            this.soDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.salesOrderBindingSource, "soDate", true));
            this.soDateDateTimePicker.Location = new System.Drawing.Point(111, 183);
            this.soDateDateTimePicker.Name = "soDateDateTimePicker";
            this.soDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.soDateDateTimePicker.TabIndex = 19;
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesOrderBindingSource, "totalAmount", true));
            this.totalAmountTextBox.Location = new System.Drawing.Point(111, 203);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalAmountTextBox.TabIndex = 21;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.detailDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(622, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Item";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // detailDataGridView
            // 
            this.detailDataGridView.AutoGenerateColumns = false;
            this.detailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.detailDataGridView.DataSource = this.p_ItemsBindingSource;
            this.detailDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailDataGridView.Location = new System.Drawing.Point(3, 3);
            this.detailDataGridView.Name = "detailDataGridView";
            this.detailDataGridView.Size = new System.Drawing.Size(616, 341);
            this.detailDataGridView.TabIndex = 0;
            this.detailDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.detailDataGridView_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "itemCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "itemCode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "itemName";
            this.dataGridViewTextBoxColumn4.HeaderText = "itemName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "itemPrice";
            this.dataGridViewTextBoxColumn8.HeaderText = "itemPrice";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "qtyOrder";
            this.dataGridViewTextBoxColumn5.HeaderText = "qtyOrder";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn6.HeaderText = "amount";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // FrmInputSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 497);
            this.Controls.Add(this.tabSalesOrder);
            this.Controls.Add(this.salesOrderBindingNavigator);
            this.Name = "FrmInputSalesOrder";
            this.Text = "FrmInputSalesOrder";
            this.Controls.SetChildIndex(this.salesOrderBindingNavigator, 0);
            this.Controls.SetChildIndex(this.tabSalesOrder, 0);
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderBindingNavigator)).EndInit();
            this.salesOrderBindingNavigator.ResumeLayout(false);
            this.salesOrderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_ItemsBindingSource)).EndInit();
            this.tabSalesOrder.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource salesOrderBindingSource;
        private System.Windows.Forms.BindingNavigator salesOrderBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton salesOrderBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource p_ItemsBindingSource;
        private System.Windows.Forms.TabControl tabSalesOrder;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox accountRefTextBox;
        private System.Windows.Forms.TextBox manualRefTextBox;
        private System.Windows.Forms.TextBox nomorSOTextBox;
        private System.Windows.Forms.TextBox otherRefTextBox;
        private System.Windows.Forms.TextBox outlCodeTextBox;
        private System.Windows.Forms.TextBox outlNameTextBox;
        private System.Windows.Forms.TextBox qtyOrderTextBox;
        private System.Windows.Forms.DateTimePicker soCreatedDateTimePicker;
        private System.Windows.Forms.DateTimePicker soDateDateTimePicker;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView detailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}