namespace GUI
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.TopPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RegistrationPicture = new System.Windows.Forms.PictureBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.IdeasButton = new System.Windows.Forms.Button();
            this.ClientListButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.textboxNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textboxEmail = new System.Windows.Forms.TextBox();
            this.textboxRole = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SearchPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.SlateGray;
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.SearchPanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1253, 80);
            this.TopPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SearchPanel
            // 
            this.SearchPanel.AutoScroll = true;
            this.SearchPanel.BackColor = System.Drawing.Color.Black;
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Controls.Add(this.SearchBox);
            this.SearchPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchPanel.Location = new System.Drawing.Point(3, 85);
            this.SearchPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(1144, 79);
            this.SearchPanel.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Location = new System.Drawing.Point(347, 34);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(44, 44);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SearchBox.Location = new System.Drawing.Point(447, 28);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(249, 22);
            this.SearchBox.TabIndex = 3;
            this.SearchBox.Text = "Search";
            this.SearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.Black;
            this.LeftPanel.Controls.Add(this.pictureBox4);
            this.LeftPanel.Controls.Add(this.pictureBox3);
            this.LeftPanel.Controls.Add(this.pictureBox2);
            this.LeftPanel.Controls.Add(this.RegistrationPicture);
            this.LeftPanel.Controls.Add(this.RegistrationButton);
            this.LeftPanel.Controls.Add(this.IdeasButton);
            this.LeftPanel.Controls.Add(this.ClientListButton);
            this.LeftPanel.Controls.Add(this.AccountButton);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 80);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(209, 538);
            this.LeftPanel.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(20, 166);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 44);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(20, 90);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 44);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(20, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 44);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // RegistrationPicture
            // 
            this.RegistrationPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegistrationPicture.BackgroundImage")));
            this.RegistrationPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RegistrationPicture.Location = new System.Drawing.Point(20, 240);
            this.RegistrationPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrationPicture.Name = "RegistrationPicture";
            this.RegistrationPicture.Size = new System.Drawing.Size(44, 44);
            this.RegistrationPicture.TabIndex = 2;
            this.RegistrationPicture.TabStop = false;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RegistrationButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegistrationButton.FlatAppearance.BorderSize = 0;
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.RegistrationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistrationButton.Location = new System.Drawing.Point(0, 225);
            this.RegistrationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RegistrationButton.Size = new System.Drawing.Size(209, 75);
            this.RegistrationButton.TabIndex = 2;
            this.RegistrationButton.Text = "   Registration";
            this.RegistrationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // IdeasButton
            // 
            this.IdeasButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.IdeasButton.FlatAppearance.BorderSize = 0;
            this.IdeasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IdeasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdeasButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.IdeasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IdeasButton.Location = new System.Drawing.Point(0, 150);
            this.IdeasButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdeasButton.Name = "IdeasButton";
            this.IdeasButton.Size = new System.Drawing.Size(209, 75);
            this.IdeasButton.TabIndex = 2;
            this.IdeasButton.Text = "Ideas";
            this.IdeasButton.UseVisualStyleBackColor = true;
            this.IdeasButton.Click += new System.EventHandler(this.IdeasButton_Click);
            // 
            // ClientListButton
            // 
            this.ClientListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientListButton.FlatAppearance.BorderSize = 0;
            this.ClientListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientListButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.ClientListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientListButton.Location = new System.Drawing.Point(0, 75);
            this.ClientListButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientListButton.Name = "ClientListButton";
            this.ClientListButton.Size = new System.Drawing.Size(209, 75);
            this.ClientListButton.TabIndex = 2;
            this.ClientListButton.Text = "Client List";
            this.ClientListButton.UseVisualStyleBackColor = true;
            this.ClientListButton.Click += new System.EventHandler(this.ClientListButton_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountButton.FlatAppearance.BorderSize = 0;
            this.AccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.AccountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountButton.Location = new System.Drawing.Point(0, 0);
            this.AccountButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(209, 75);
            this.AccountButton.TabIndex = 2;
            this.AccountButton.Text = "Account";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // textboxNumber
            // 
            this.textboxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxNumber.Location = new System.Drawing.Point(389, 405);
            this.textboxNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textboxNumber.Name = "textboxNumber";
            this.textboxNumber.Size = new System.Drawing.Size(301, 30);
            this.textboxNumber.TabIndex = 29;
            this.textboxNumber.TextChanged += new System.EventHandler(this.textboxNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(259, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Number:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(259, 340);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(80, 29);
            this.labelEmail.TabIndex = 27;
            this.labelEmail.Text = "Email:";
            // 
            // textboxEmail
            // 
            this.textboxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxEmail.Location = new System.Drawing.Point(389, 339);
            this.textboxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.Size = new System.Drawing.Size(301, 30);
            this.textboxEmail.TabIndex = 26;
            this.textboxEmail.TextChanged += new System.EventHandler(this.textboxEmail_TextChanged);
            // 
            // textboxRole
            // 
            this.textboxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxRole.Location = new System.Drawing.Point(389, 281);
            this.textboxRole.Margin = new System.Windows.Forms.Padding(4);
            this.textboxRole.Name = "textboxRole";
            this.textboxRole.Size = new System.Drawing.Size(301, 30);
            this.textboxRole.TabIndex = 24;
            this.textboxRole.TextChanged += new System.EventHandler(this.textboxRole_TextChanged);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.BackColor = System.Drawing.Color.Transparent;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelRole.ForeColor = System.Drawing.Color.White;
            this.labelRole.Location = new System.Drawing.Point(259, 281);
            this.labelRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(70, 29);
            this.labelRole.TabIndex = 23;
            this.labelRole.Text = "Role:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(259, 207);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(84, 29);
            this.labelName.TabIndex = 22;
            this.labelName.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 36);
            this.label1.TabIndex = 21;
            this.label1.Text = "My Account";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(389, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 22);
            this.textBox1.TabIndex = 30;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1253, 618);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textboxNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textboxEmail);
            this.Controls.Add(this.textboxRole);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Account";
            this.Text = "Top G";
            this.Load += new System.EventHandler(this.Account_Load);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel TopPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button IdeasButton;
        private System.Windows.Forms.Button ClientListButton;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.PictureBox RegistrationPicture;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox textboxNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textboxEmail;
        private System.Windows.Forms.TextBox textboxRole;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}