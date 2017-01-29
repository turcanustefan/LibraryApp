namespace LibraryApp
{
    partial class AddUserBox
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
            this.PassBox = new System.Windows.Forms.TextBox();
            this.ConfPassBox = new System.Windows.Forms.TextBox();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.ConfPassLabel = new System.Windows.Forms.Label();
            this.PrivBox = new System.Windows.Forms.TextBox();
            this.PrivLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Err2 = new System.Windows.Forms.Label();
            this.Err1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(160, 45);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(100, 22);
            this.UserBox.TabIndex = 0;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(160, 73);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(100, 22);
            this.PassBox.TabIndex = 1;
            // 
            // ConfPassBox
            // 
            this.ConfPassBox.Location = new System.Drawing.Point(160, 101);
            this.ConfPassBox.Name = "ConfPassBox";
            this.ConfPassBox.PasswordChar = '*';
            this.ConfPassBox.Size = new System.Drawing.Size(100, 22);
            this.ConfPassBox.TabIndex = 2;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(189, 184);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(102, 31);
            this.AddUserButton.TabIndex = 4;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(29, 48);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(77, 17);
            this.UserLabel.TabIndex = 3;
            this.UserLabel.Text = "Username:";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(29, 76);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(73, 17);
            this.PassLabel.TabIndex = 3;
            this.PassLabel.Text = "Password:";
            // 
            // ConfPassLabel
            // 
            this.ConfPassLabel.AutoSize = true;
            this.ConfPassLabel.Location = new System.Drawing.Point(29, 104);
            this.ConfPassLabel.Name = "ConfPassLabel";
            this.ConfPassLabel.Size = new System.Drawing.Size(125, 17);
            this.ConfPassLabel.TabIndex = 3;
            this.ConfPassLabel.Text = "Confirm Password:";
            // 
            // PrivBox
            // 
            this.PrivBox.Location = new System.Drawing.Point(160, 129);
            this.PrivBox.Name = "PrivBox";
            this.PrivBox.Size = new System.Drawing.Size(100, 22);
            this.PrivBox.TabIndex = 3;
            // 
            // PrivLabel
            // 
            this.PrivLabel.AutoSize = true;
            this.PrivLabel.Location = new System.Drawing.Point(29, 132);
            this.PrivLabel.Name = "PrivLabel";
            this.PrivLabel.Size = new System.Drawing.Size(66, 17);
            this.PrivLabel.TabIndex = 3;
            this.PrivLabel.Text = "Privilege:";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(52, 184);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(102, 31);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Err2
            // 
            this.Err2.AutoSize = true;
            this.Err2.ForeColor = System.Drawing.Color.Red;
            this.Err2.Location = new System.Drawing.Point(92, 154);
            this.Err2.Name = "Err2";
            this.Err2.Size = new System.Drawing.Size(155, 17);
            this.Err2.TabIndex = 5;
            this.Err2.Text = "*Something went wrong";
            this.Err2.Visible = false;
            // 
            // Err1
            // 
            this.Err1.AutoSize = true;
            this.Err1.ForeColor = System.Drawing.Color.Red;
            this.Err1.Location = new System.Drawing.Point(266, 104);
            this.Err1.Name = "Err1";
            this.Err1.Size = new System.Drawing.Size(13, 17);
            this.Err1.TabIndex = 5;
            this.Err1.Text = "*";
            this.Err1.Visible = false;
            // 
            // AddUserBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 253);
            this.Controls.Add(this.Err1);
            this.Controls.Add(this.Err2);
            this.Controls.Add(this.PrivLabel);
            this.Controls.Add(this.ConfPassLabel);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.PrivBox);
            this.Controls.Add(this.ConfPassBox);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUserBox";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUserBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox ConfPassBox;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label ConfPassLabel;
        private System.Windows.Forms.TextBox PrivBox;
        private System.Windows.Forms.Label PrivLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label Err2;
        private System.Windows.Forms.Label Err1;
    }
}