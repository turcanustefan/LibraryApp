namespace LibraryApp
{
    partial class AddTemplate
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
            this.Text1 = new System.Windows.Forms.TextBox();
            this.Text2 = new System.Windows.Forms.TextBox();
            this.Text3 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Text4 = new System.Windows.Forms.TextBox();
            this.Text5 = new System.Windows.Forms.TextBox();
            this.Text6 = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text1
            // 
            this.Text1.Location = new System.Drawing.Point(12, 42);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(100, 22);
            this.Text1.TabIndex = 0;
            // 
            // Text2
            // 
            this.Text2.Location = new System.Drawing.Point(12, 107);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(100, 22);
            this.Text2.TabIndex = 1;
            // 
            // Text3
            // 
            this.Text3.Location = new System.Drawing.Point(12, 179);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(100, 22);
            this.Text3.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(46, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 17);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Title";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(38, 87);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(50, 17);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Author";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(42, 159);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(39, 17);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "ISBN";
            // 
            // Text4
            // 
            this.Text4.Location = new System.Drawing.Point(190, 42);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(100, 22);
            this.Text4.TabIndex = 3;
            // 
            // Text5
            // 
            this.Text5.Location = new System.Drawing.Point(190, 107);
            this.Text5.Name = "Text5";
            this.Text5.Size = new System.Drawing.Size(100, 22);
            this.Text5.TabIndex = 4;
            // 
            // Text6
            // 
            this.Text6.Location = new System.Drawing.Point(190, 179);
            this.Text6.Name = "Text6";
            this.Text6.Size = new System.Drawing.Size(100, 22);
            this.Text6.TabIndex = 5;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(218, 159);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(51, 17);
            this.Label6.TabIndex = 1;
            this.Label6.Text = "Copies";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(218, 87);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(38, 17);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "Year";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(202, 22);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(67, 17);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "Publisher";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(111, 227);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(81, 42);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 313);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Text6);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.Text5);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.Text1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTemplate";
            this.Text = "AddBook";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        #endregion

        private System.Windows.Forms.TextBox Text1;
        private System.Windows.Forms.TextBox Text2;
        private System.Windows.Forms.TextBox Text3;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox Text4;
        private System.Windows.Forms.TextBox Text5;
        private System.Windows.Forms.TextBox Text6;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Button AddButton;
    }
}