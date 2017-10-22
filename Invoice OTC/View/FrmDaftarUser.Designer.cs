namespace Invoice_OTC.View
{
    partial class FrmDaftarUser
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
            System.Windows.Forms.Label passWordLabel;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label userNameLabel;
            this.authLevelTextBox = new System.Windows.Forms.TextBox();
            this.passWordTextBox = new System.Windows.Forms.TextBox();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.accountItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            authLevelLabel = new System.Windows.Forms.Label();
            passWordLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accountItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // authLevelLabel
            // 
            authLevelLabel.AutoSize = true;
            authLevelLabel.Location = new System.Drawing.Point(18, 42);
            authLevelLabel.Name = "authLevelLabel";
            authLevelLabel.Size = new System.Drawing.Size(61, 13);
            authLevelLabel.TabIndex = 1;
            authLevelLabel.Text = "Auth Level:";
            // 
            // authLevelTextBox
            // 
            this.authLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountItemBindingSource, "AuthLevel", true));
            this.authLevelTextBox.Location = new System.Drawing.Point(93, 39);
            this.authLevelTextBox.Name = "authLevelTextBox";
            this.authLevelTextBox.Size = new System.Drawing.Size(200, 20);
            this.authLevelTextBox.TabIndex = 2;
            // 
            // passWordLabel
            // 
            passWordLabel.AutoSize = true;
            passWordLabel.Location = new System.Drawing.Point(18, 68);
            passWordLabel.Name = "passWordLabel";
            passWordLabel.Size = new System.Drawing.Size(62, 13);
            passWordLabel.TabIndex = 7;
            passWordLabel.Text = "Pass Word:";
            // 
            // passWordTextBox
            // 
            this.passWordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountItemBindingSource, "PassWord", true));
            this.passWordTextBox.Location = new System.Drawing.Point(93, 65);
            this.passWordTextBox.Name = "passWordTextBox";
            this.passWordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passWordTextBox.TabIndex = 8;
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(18, 94);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(46, 13);
            userIDLabel.TabIndex = 9;
            userIDLabel.Text = "User ID:";
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountItemBindingSource, "UserID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(93, 91);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.userIDTextBox.TabIndex = 10;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(18, 120);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(63, 13);
            userNameLabel.TabIndex = 11;
            userNameLabel.Text = "User Name:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountItemBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(93, 117);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.userNameTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // accountItemBindingSource
            // 
            this.accountItemBindingSource.DataSource = typeof(Invoice_OTC.Model.accountItem);
            // 
            // FrmDaftarUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 306);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(authLevelLabel);
            this.Controls.Add(this.authLevelTextBox);
            this.Controls.Add(passWordLabel);
            this.Controls.Add(this.passWordTextBox);
            this.Controls.Add(userIDLabel);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Name = "FrmDaftarUser";
            this.Text = "FrmDaftarUser";
            this.Load += new System.EventHandler(this.FrmDaftarUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource accountItemBindingSource;
        private System.Windows.Forms.TextBox authLevelTextBox;
        private System.Windows.Forms.TextBox passWordTextBox;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}