namespace LibraryApp
{
    partial class Login
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
            this.UserBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.IncorrectText = new System.Windows.Forms.Label();
            this.AuthButton = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.AuthImage = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(103, 62);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(144, 22);
            this.UserBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(103, 89);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(144, 22);
            this.PasswordBox.TabIndex = 1;
            // 
            // IncorrectText
            // 
            this.IncorrectText.AutoSize = true;
            this.IncorrectText.ForeColor = System.Drawing.Color.Brown;
            this.IncorrectText.Location = new System.Drawing.Point(64, 114);
            this.IncorrectText.Name = "IncorrectText";
            this.IncorrectText.Size = new System.Drawing.Size(222, 17);
            this.IncorrectText.TabIndex = 1;
            this.IncorrectText.Text = "*Incorrect Username or Password!";
            this.IncorrectText.Visible = false;
            // 
            // AuthButton
            // 
            this.AuthButton.Location = new System.Drawing.Point(116, 134);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(106, 30);
            this.AuthButton.TabIndex = 2;
            this.AuthButton.Text = "Authenticate";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(12, 66);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(75, 17);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(18, 94);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(69, 17);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password:";
            // 
            // AuthImage
            // 
            this.AuthImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthImage.AutoSize = true;
            this.AuthImage.BackgroundImage = global::LibraryApp.Properties.Resources.book;
            this.AuthImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AuthImage.Location = new System.Drawing.Point(148, 13);
            this.AuthImage.Name = "AuthImage";
            this.AuthImage.Size = new System.Drawing.Size(48, 43);
            this.AuthImage.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 196);
            this.Controls.Add(this.AuthImage);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.IncorrectText);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UserBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label IncorrectText;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Panel AuthImage;
    }
}