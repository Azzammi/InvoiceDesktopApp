namespace Invoice_OTC.View
{
    partial class FrmDetailedSlsman
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
            System.Windows.Forms.Label slsmAddressLabel;
            System.Windows.Forms.Label slsmCodeLabel;
            System.Windows.Forms.Label slsmNameLabel;
            System.Windows.Forms.Label slsmPhotoLabel;
            System.Windows.Forms.Label slsmSupvLabel;
            System.Windows.Forms.Label slsmTelpLabel;
            System.Windows.Forms.Label statLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetailedSlsman));
            this.salesmanItemBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.salesmanItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.salesmanItemBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.browsePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.slsmAddressTextBox = new System.Windows.Forms.TextBox();
            this.slsmCodeTextBox = new System.Windows.Forms.TextBox();
            this.slsmNameTextBox = new System.Windows.Forms.TextBox();
            this.slsmPhotoTextBox = new System.Windows.Forms.TextBox();
            this.slsmSupvTextBox = new System.Windows.Forms.TextBox();
            this.slsmTelpTextBox = new System.Windows.Forms.TextBox();
            this.salesmanItemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.outletItemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.outletItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.findStrip1 = new Invoice_OTC.Controller.FindStrip();
            slsmAddressLabel = new System.Windows.Forms.Label();
            slsmCodeLabel = new System.Windows.Forms.Label();
            slsmNameLabel = new System.Windows.Forms.Label();
            slsmPhotoLabel = new System.Windows.Forms.Label();
            slsmSupvLabel = new System.Windows.Forms.Label();
            slsmTelpLabel = new System.Windows.Forms.Label();
            statLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanItemBindingNavigator)).BeginInit();
            this.salesmanItemBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanItemBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // slsmAddressLabel
            // 
            slsmAddressLabel.AutoSize = true;
            slsmAddressLabel.Location = new System.Drawing.Point(21, 130);
            slsmAddressLabel.Name = "slsmAddressLabel";
            slsmAddressLabel.Size = new System.Drawing.Size(73, 13);
            slsmAddressLabel.TabIndex = 3;
            slsmAddressLabel.Text = "Slsm Address:";
            // 
            // slsmCodeLabel
            // 
            slsmCodeLabel.AutoSize = true;
            slsmCodeLabel.Location = new System.Drawing.Point(21, 74);
            slsmCodeLabel.Name = "slsmCodeLabel";
            slsmCodeLabel.Size = new System.Drawing.Size(60, 13);
            slsmCodeLabel.TabIndex = 5;
            slsmCodeLabel.Text = "Slsm Code:";
            // 
            // slsmNameLabel
            // 
            slsmNameLabel.AutoSize = true;
            slsmNameLabel.Location = new System.Drawing.Point(21, 100);
            slsmNameLabel.Name = "slsmNameLabel";
            slsmNameLabel.Size = new System.Drawing.Size(63, 13);
            slsmNameLabel.TabIndex = 7;
            slsmNameLabel.Text = "Slsm Name:";
            // 
            // slsmPhotoLabel
            // 
            slsmPhotoLabel.AutoSize = true;
            slsmPhotoLabel.Location = new System.Drawing.Point(398, 290);
            slsmPhotoLabel.Name = "slsmPhotoLabel";
            slsmPhotoLabel.Size = new System.Drawing.Size(63, 13);
            slsmPhotoLabel.TabIndex = 9;
            slsmPhotoLabel.Text = "Slsm Photo:";
            // 
            // slsmSupvLabel
            // 
            slsmSupvLabel.AutoSize = true;
            slsmSupvLabel.Location = new System.Drawing.Point(21, 264);
            slsmSupvLabel.Name = "slsmSupvLabel";
            slsmSupvLabel.Size = new System.Drawing.Size(60, 13);
            slsmSupvLabel.TabIndex = 11;
            slsmSupvLabel.Text = "Slsm Supv:";
            // 
            // slsmTelpLabel
            // 
            slsmTelpLabel.AutoSize = true;
            slsmTelpLabel.Location = new System.Drawing.Point(21, 294);
            slsmTelpLabel.Name = "slsmTelpLabel";
            slsmTelpLabel.Size = new System.Drawing.Size(56, 13);
            slsmTelpLabel.TabIndex = 13;
            slsmTelpLabel.Text = "Slsm Telp:";
            // 
            // statLabel
            // 
            statLabel.AutoSize = true;
            statLabel.Location = new System.Drawing.Point(21, 326);
            statLabel.Name = "statLabel";
            statLabel.Size = new System.Drawing.Size(29, 13);
            statLabel.TabIndex = 15;
            statLabel.Text = "Stat:";
            // 
            // salesmanItemBindingNavigator
            // 
            this.salesmanItemBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.salesmanItemBindingNavigator.BindingSource = this.salesmanItemBindingSource;
            this.salesmanItemBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.salesmanItemBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.salesmanItemBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.salesmanItemBindingNavigatorSaveItem});
            this.salesmanItemBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.salesmanItemBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.salesmanItemBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.salesmanItemBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.salesmanItemBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.salesmanItemBindingNavigator.Name = "salesmanItemBindingNavigator";
            this.salesmanItemBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.salesmanItemBindingNavigator.Size = new System.Drawing.Size(1054, 25);
            this.salesmanItemBindingNavigator.TabIndex = 0;
            this.salesmanItemBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // salesmanItemBindingSource
            // 
            this.salesmanItemBindingSource.DataSource = typeof(Invoice_OTC.Model.SalesmanItem);
            this.salesmanItemBindingSource.CurrentChanged += new System.EventHandler(this.salesmanItemBindingSource_CurrentChanged);
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // salesmanItemBindingNavigatorSaveItem
            // 
            this.salesmanItemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salesmanItemBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("salesmanItemBindingNavigatorSaveItem.Image")));
            this.salesmanItemBindingNavigatorSaveItem.Name = "salesmanItemBindingNavigatorSaveItem";
            this.salesmanItemBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.salesmanItemBindingNavigatorSaveItem.Text = "Save Data";
            this.salesmanItemBindingNavigatorSaveItem.Click += new System.EventHandler(this.salesmanItemBindingNavigatorSaveItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browsePictureToolStripMenuItem,
            this.deletesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // browsePictureToolStripMenuItem
            // 
            this.browsePictureToolStripMenuItem.Name = "browsePictureToolStripMenuItem";
            this.browsePictureToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.browsePictureToolStripMenuItem.Text = "Browse Picture";
            this.browsePictureToolStripMenuItem.Click += new System.EventHandler(this.browsePictureToolStripMenuItem_Click);
            // 
            // deletesToolStripMenuItem
            // 
            this.deletesToolStripMenuItem.Name = "deletesToolStripMenuItem";
            this.deletesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deletesToolStripMenuItem.Text = "Delete(s)";
            // 
            // statCheckBox
            // 
            this.statCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.salesmanItemBindingSource, "Stat", true));
            this.statCheckBox.Location = new System.Drawing.Point(100, 321);
            this.statCheckBox.Name = "statCheckBox";
            this.statCheckBox.Size = new System.Drawing.Size(104, 24);
            this.statCheckBox.TabIndex = 5;
            this.statCheckBox.Text = "checkBox1";
            this.statCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.salesmanItemBindingSource, "SlsmPhoto", true));
            this.pictureBox1.Location = new System.Drawing.Point(401, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(574, 316);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(147, 32);
            this.browseBtn.TabIndex = 8;
            this.browseBtn.Text = "Browse Photo";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browsePictureToolStripMenuItem_Click);
            // 
            // slsmAddressTextBox
            // 
            this.slsmAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesmanItemBindingSource, "SlsmAddress", true));
            this.slsmAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.slsmAddressTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.slsmAddressTextBox.Location = new System.Drawing.Point(100, 127);
            this.slsmAddressTextBox.Multiline = true;
            this.slsmAddressTextBox.Name = "slsmAddressTextBox";
            this.slsmAddressTextBox.Size = new System.Drawing.Size(275, 128);
            this.slsmAddressTextBox.TabIndex = 2;
            // 
            // slsmCodeTextBox
            // 
            this.slsmCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesmanItemBindingSource, "SlsmCode", true));
            this.slsmCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.slsmCodeTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.slsmCodeTextBox.Location = new System.Drawing.Point(100, 71);
            this.slsmCodeTextBox.Name = "slsmCodeTextBox";
            this.slsmCodeTextBox.Size = new System.Drawing.Size(275, 24);
            this.slsmCodeTextBox.TabIndex = 0;
            // 
            // slsmNameTextBox
            // 
            this.slsmNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesmanItemBindingSource, "SlsmName", true));
            this.slsmNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.slsmNameTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.slsmNameTextBox.Location = new System.Drawing.Point(100, 97);
            this.slsmNameTextBox.Name = "slsmNameTextBox";
            this.slsmNameTextBox.Size = new System.Drawing.Size(275, 24);
            this.slsmNameTextBox.TabIndex = 1;
            // 
            // slsmPhotoTextBox
            // 
            this.slsmPhotoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesmanItemBindingSource, "SlsmPhoto", true));
            this.slsmPhotoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.slsmPhotoTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.slsmPhotoTextBox.Location = new System.Drawing.Point(477, 287);
            this.slsmPhotoTextBox.Name = "slsmPhotoTextBox";
            this.slsmPhotoTextBox.Size = new System.Drawing.Size(245, 24);
            this.slsmPhotoTextBox.TabIndex = 9;
            // 
            // slsmSupvTextBox
            // 
            this.slsmSupvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesmanItemBindingSource, "SlsmSupv", true));
            this.slsmSupvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.slsmSupvTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.slsmSupvTextBox.Location = new System.Drawing.Point(100, 261);
            this.slsmSupvTextBox.Name = "slsmSupvTextBox";
            this.slsmSupvTextBox.Size = new System.Drawing.Size(275, 24);
            this.slsmSupvTextBox.TabIndex = 3;
            // 
            // slsmTelpTextBox
            // 
            this.slsmTelpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesmanItemBindingSource, "SlsmTelp", true));
            this.slsmTelpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Invoice_OTC.Properties.Settings.Default, "textboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.slsmTelpTextBox.Font = global::Invoice_OTC.Properties.Settings.Default.textboxFont;
            this.slsmTelpTextBox.Location = new System.Drawing.Point(100, 291);
            this.slsmTelpTextBox.Name = "slsmTelpTextBox";
            this.slsmTelpTextBox.Size = new System.Drawing.Size(275, 24);
            this.slsmTelpTextBox.TabIndex = 4;
            // 
            // salesmanItemDataGridView
            // 
            this.salesmanItemDataGridView.AllowUserToAddRows = false;
            this.salesmanItemDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesmanItemDataGridView.AutoGenerateColumns = false;
            this.salesmanItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesmanItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1});
            this.salesmanItemDataGridView.DataSource = this.salesmanItemBindingSource;
            this.salesmanItemDataGridView.Location = new System.Drawing.Point(727, 104);
            this.salesmanItemDataGridView.Name = "salesmanItemDataGridView";
            this.salesmanItemDataGridView.Size = new System.Drawing.Size(303, 531);
            this.salesmanItemDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SlsmCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "SlsmCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SlsmName";
            this.dataGridViewTextBoxColumn2.HeaderText = "SlsmName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SlsmAddress";
            this.dataGridViewTextBoxColumn3.HeaderText = "SlsmAddress";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SlsmTelp";
            this.dataGridViewTextBoxColumn4.HeaderText = "SlsmTelp";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SlsmSupv";
            this.dataGridViewTextBoxColumn5.HeaderText = "SlsmSupv";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SlsmPhoto";
            this.dataGridViewTextBoxColumn6.HeaderText = "SlsmPhoto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Stat";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Stat";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // outletItemDataGridView
            // 
            this.outletItemDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.outletItemDataGridView.AutoGenerateColumns = false;
            this.outletItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outletItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewCheckBoxColumn2});
            this.outletItemDataGridView.DataSource = this.outletItemBindingSource;
            this.outletItemDataGridView.Location = new System.Drawing.Point(24, 380);
            this.outletItemDataGridView.Name = "outletItemDataGridView";
            this.outletItemDataGridView.Size = new System.Drawing.Size(697, 255);
            this.outletItemDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OutletCode";
            this.dataGridViewTextBoxColumn8.HeaderText = "OutletCode";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OutletName";
            this.dataGridViewTextBoxColumn9.HeaderText = "OutletName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "OutletAddress";
            this.dataGridViewTextBoxColumn10.HeaderText = "OutletAddress";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "OutletRoute";
            this.dataGridViewTextBoxColumn11.HeaderText = "OutletRoute";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "OutletStatus";
            this.dataGridViewCheckBoxColumn2.HeaderText = "OutletStatus";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // outletItemBindingSource
            // 
            this.outletItemBindingSource.DataSource = typeof(Invoice_OTC.Model.outletItem);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Daftar Outlet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(727, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Daftar Salesman";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // findStrip1
            // 
            this.findStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.findStrip1.bindingSource = this.salesmanItemBindingSource;
            this.findStrip1.Location = new System.Drawing.Point(0, 25);
            this.findStrip1.Name = "findStrip1";
            this.findStrip1.Size = new System.Drawing.Size(1054, 32);
            this.findStrip1.TabIndex = 2;
            this.findStrip1.Text = "findStrip1";
            // 
            // FrmDetailedSlsman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 647);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outletItemDataGridView);
            this.Controls.Add(this.salesmanItemDataGridView);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(slsmAddressLabel);
            this.Controls.Add(this.slsmAddressTextBox);
            this.Controls.Add(slsmCodeLabel);
            this.Controls.Add(this.slsmCodeTextBox);
            this.Controls.Add(slsmNameLabel);
            this.Controls.Add(this.slsmNameTextBox);
            this.Controls.Add(slsmPhotoLabel);
            this.Controls.Add(this.slsmPhotoTextBox);
            this.Controls.Add(slsmSupvLabel);
            this.Controls.Add(this.slsmSupvTextBox);
            this.Controls.Add(slsmTelpLabel);
            this.Controls.Add(this.slsmTelpTextBox);
            this.Controls.Add(statLabel);
            this.Controls.Add(this.statCheckBox);
            this.Controls.Add(this.findStrip1);
            this.Controls.Add(this.salesmanItemBindingNavigator);
            this.KeyPreview = true;
            this.Name = "FrmDetailedSlsman";
            this.Text = "FrmDetailedSlsman";
            this.Load += new System.EventHandler(this.FrmDetailedSlsman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesmanItemBindingNavigator)).EndInit();
            this.salesmanItemBindingNavigator.ResumeLayout(false);
            this.salesmanItemBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanItemBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outletItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource salesmanItemBindingSource;
        private System.Windows.Forms.BindingNavigator salesmanItemBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton salesmanItemBindingNavigatorSaveItem;
        private Controller.FindStrip findStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem browsePictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletesToolStripMenuItem;
        private System.Windows.Forms.TextBox slsmAddressTextBox;
        private System.Windows.Forms.TextBox slsmCodeTextBox;
        private System.Windows.Forms.TextBox slsmNameTextBox;
        private System.Windows.Forms.TextBox slsmPhotoTextBox;
        private System.Windows.Forms.TextBox slsmSupvTextBox;
        private System.Windows.Forms.TextBox slsmTelpTextBox;
        private System.Windows.Forms.CheckBox statCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.DataGridView salesmanItemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource outletItemBindingSource;
        private System.Windows.Forms.DataGridView outletItemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}