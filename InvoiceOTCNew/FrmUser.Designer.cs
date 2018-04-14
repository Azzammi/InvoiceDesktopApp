namespace InvoiceOTCNew
{
    partial class FrmUser
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
            System.Windows.Forms.Label authLevelLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label usernameLabel;
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authLevelComboBox = new System.Windows.Forms.ComboBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            authLevelLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // authLevelLabel
            // 
            authLevelLabel.AutoSize = true;
            authLevelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            authLevelLabel.Location = new System.Drawing.Point(3, 102);
            authLevelLabel.Name = "authLevelLabel";
            authLevelLabel.Size = new System.Drawing.Size(88, 35);
            authLevelLabel.TabIndex = 3;
            authLevelLabel.Text = "Auth Level:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            passwordLabel.Location = new System.Drawing.Point(3, 68);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(88, 34);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password:";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            userIDLabel.Location = new System.Drawing.Point(3, 0);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(88, 34);
            userIDLabel.TabIndex = 9;
            userIDLabel.Text = "User ID:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            usernameLabel.Location = new System.Drawing.Point(3, 34);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(88, 34);
            usernameLabel.TabIndex = 11;
            usernameLabel.Text = "Username:";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(InvoiceOTC.Model.User);
            // 
            // authLevelComboBox
            // 
            this.authLevelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "AuthLevel", true));
            this.authLevelComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authLevelComboBox.FormattingEnabled = true;
            this.authLevelComboBox.Items.AddRange(new object[] {
            "Accounting",
            "Admin\t",
            "Superuser"});
            this.authLevelComboBox.Location = new System.Drawing.Point(97, 105);
            this.authLevelComboBox.Name = "authLevelComboBox";
            this.authLevelComboBox.Size = new System.Drawing.Size(329, 21);
            this.authLevelComboBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Password", true));
            this.passwordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTextBox.Location = new System.Drawing.Point(97, 71);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(329, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserID", true));
            this.userIDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userIDTextBox.Location = new System.Drawing.Point(97, 3);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(329, 20);
            this.userIDTextBox.TabIndex = 0;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Username", true));
            this.usernameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameTextBox.Location = new System.Drawing.Point(97, 37);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(329, 20);
            this.usernameTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.14452F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.85548F));
            this.tableLayoutPanel2.Controls.Add(authLevelLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.passwordTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(passwordLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.authLevelComboBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(userIDLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.usernameTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.userIDTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(usernameLabel, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 58);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(429, 137);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 236);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUser";
            this.Text = "FrmUser";
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.ComboBox authLevelComboBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}