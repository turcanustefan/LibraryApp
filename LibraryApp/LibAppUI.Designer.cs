namespace LibraryApp
{
    partial class LibAppUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Books = new System.Windows.Forms.TabPage();
            this.FindBooks = new System.Windows.Forms.GroupBox();
            this.FindBYear = new System.Windows.Forms.RadioButton();
            this.FindISBN = new System.Windows.Forms.RadioButton();
            this.FindBAuthor = new System.Windows.Forms.RadioButton();
            this.FindBTitle = new System.Windows.Forms.RadioButton();
            this.BFTextBox = new System.Windows.Forms.TextBox();
            this.BSearchButton = new System.Windows.Forms.Button();
            this.BooksView = new System.Windows.Forms.DataGridView();
            this.BooksControls = new System.Windows.Forms.GroupBox();
            this.InsertBook = new System.Windows.Forms.Button();
            this.UpdateBook = new System.Windows.Forms.Button();
            this.DeleteBook = new System.Windows.Forms.Button();
            this.Members = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FindMID = new System.Windows.Forms.RadioButton();
            this.FindMPhone = new System.Windows.Forms.RadioButton();
            this.FindMCNP = new System.Windows.Forms.RadioButton();
            this.FindMName = new System.Windows.Forms.RadioButton();
            this.MFTextBox = new System.Windows.Forms.TextBox();
            this.MSearchButton = new System.Windows.Forms.Button();
            this.MembersView = new System.Windows.Forms.DataGridView();
            this.MembersControls = new System.Windows.Forms.GroupBox();
            this.InsertMember = new System.Windows.Forms.Button();
            this.UpdateMember = new System.Windows.Forms.Button();
            this.DeleteMember = new System.Windows.Forms.Button();
            this.Loans = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FindLMember = new System.Windows.Forms.RadioButton();
            this.FindLBook = new System.Windows.Forms.RadioButton();
            this.LFTextBox = new System.Windows.Forms.TextBox();
            this.LSearchButton = new System.Windows.Forms.Button();
            this.LoansView = new System.Windows.Forms.DataGridView();
            this.LoansControls = new System.Windows.Forms.GroupBox();
            this.InsertLoan = new System.Windows.Forms.Button();
            this.UpdateLoan = new System.Windows.Forms.Button();
            this.DeleteLoan = new System.Windows.Forms.Button();
            this.Logs = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.loansNr = new System.Windows.Forms.Label();
            this.membersNr = new System.Windows.Forms.Label();
            this.booksNr = new System.Windows.Forms.Label();
            this.LoansStats = new System.Windows.Forms.Label();
            this.MemberStats = new System.Windows.Forms.Label();
            this.BookStats = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.LogButton = new System.Windows.Forms.Button();
            this.filesBox = new System.Windows.Forms.ComboBox();
            this.tabCtrlAccount = new System.Windows.Forms.TabControl();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.permissionText = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.AddUser = new System.Windows.Forms.LinkLabel();
            this.labelHelp = new System.Windows.Forms.Label();
            this.labelAcountPermissions6 = new System.Windows.Forms.Label();
            this.labelAcountPermissions3 = new System.Windows.Forms.Label();
            this.labelAcountPermissions5 = new System.Windows.Forms.Label();
            this.labelAcountPermissions4 = new System.Windows.Forms.Label();
            this.labelAcountPermissions2 = new System.Windows.Forms.Label();
            this.labelAcountPermissions1 = new System.Windows.Forms.Label();
            this.labelAcountRole = new System.Windows.Forms.Label();
            this.labelAcountUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerBox = new System.Windows.Forms.TextBox();
            this.Tabs.SuspendLayout();
            this.Books.SuspendLayout();
            this.FindBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksView)).BeginInit();
            this.BooksControls.SuspendLayout();
            this.Members.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MembersView)).BeginInit();
            this.MembersControls.SuspendLayout();
            this.Loans.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoansView)).BeginInit();
            this.LoansControls.SuspendLayout();
            this.Logs.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabCtrlAccount.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.Books);
            this.Tabs.Controls.Add(this.Members);
            this.Tabs.Controls.Add(this.Loans);
            this.Tabs.Controls.Add(this.Logs);
            this.Tabs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Tabs.Location = new System.Drawing.Point(0, 75);
            this.Tabs.Multiline = true;
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(824, 461);
            this.Tabs.TabIndex = 0;
            // 
            // Books
            // 
            this.Books.Controls.Add(this.FindBooks);
            this.Books.Controls.Add(this.BooksView);
            this.Books.Controls.Add(this.BooksControls);
            this.Books.Location = new System.Drawing.Point(4, 25);
            this.Books.Name = "Books";
            this.Books.Padding = new System.Windows.Forms.Padding(3);
            this.Books.Size = new System.Drawing.Size(816, 432);
            this.Books.TabIndex = 0;
            this.Books.Text = "Books";
            this.Books.UseVisualStyleBackColor = true;
            // 
            // FindBooks
            // 
            this.FindBooks.Controls.Add(this.FindBYear);
            this.FindBooks.Controls.Add(this.FindISBN);
            this.FindBooks.Controls.Add(this.FindBAuthor);
            this.FindBooks.Controls.Add(this.FindBTitle);
            this.FindBooks.Controls.Add(this.BFTextBox);
            this.FindBooks.Controls.Add(this.BSearchButton);
            this.FindBooks.Location = new System.Drawing.Point(107, 6);
            this.FindBooks.Name = "FindBooks";
            this.FindBooks.Size = new System.Drawing.Size(442, 92);
            this.FindBooks.TabIndex = 5;
            this.FindBooks.TabStop = false;
            this.FindBooks.Text = "Find";
            // 
            // FindBYear
            // 
            this.FindBYear.AutoSize = true;
            this.FindBYear.Location = new System.Drawing.Point(228, 59);
            this.FindBYear.Name = "FindBYear";
            this.FindBYear.Size = new System.Drawing.Size(59, 21);
            this.FindBYear.TabIndex = 5;
            this.FindBYear.TabStop = true;
            this.FindBYear.Text = "Year";
            this.FindBYear.UseVisualStyleBackColor = true;
            // 
            // FindISBN
            // 
            this.FindISBN.AutoSize = true;
            this.FindISBN.Location = new System.Drawing.Point(162, 59);
            this.FindISBN.Name = "FindISBN";
            this.FindISBN.Size = new System.Drawing.Size(60, 21);
            this.FindISBN.TabIndex = 5;
            this.FindISBN.TabStop = true;
            this.FindISBN.Text = "ISBN";
            this.FindISBN.UseVisualStyleBackColor = true;
            // 
            // FindBAuthor
            // 
            this.FindBAuthor.AutoSize = true;
            this.FindBAuthor.Location = new System.Drawing.Point(89, 59);
            this.FindBAuthor.Name = "FindBAuthor";
            this.FindBAuthor.Size = new System.Drawing.Size(71, 21);
            this.FindBAuthor.TabIndex = 5;
            this.FindBAuthor.TabStop = true;
            this.FindBAuthor.Text = "Author";
            this.FindBAuthor.UseVisualStyleBackColor = true;
            // 
            // FindBTitle
            // 
            this.FindBTitle.AutoSize = true;
            this.FindBTitle.Location = new System.Drawing.Point(27, 59);
            this.FindBTitle.Name = "FindBTitle";
            this.FindBTitle.Size = new System.Drawing.Size(56, 21);
            this.FindBTitle.TabIndex = 5;
            this.FindBTitle.TabStop = true;
            this.FindBTitle.Text = "Title";
            this.FindBTitle.UseVisualStyleBackColor = true;
            // 
            // BFTextBox
            // 
            this.BFTextBox.Location = new System.Drawing.Point(27, 21);
            this.BFTextBox.Name = "BFTextBox";
            this.BFTextBox.Size = new System.Drawing.Size(245, 22);
            this.BFTextBox.TabIndex = 3;
            // 
            // BSearchButton
            // 
            this.BSearchButton.Location = new System.Drawing.Point(313, 20);
            this.BSearchButton.Name = "BSearchButton";
            this.BSearchButton.Size = new System.Drawing.Size(92, 23);
            this.BSearchButton.TabIndex = 4;
            this.BSearchButton.Text = "Search";
            this.BSearchButton.UseVisualStyleBackColor = true;
            this.BSearchButton.Click += new System.EventHandler(this.BSearchButton_Click);
            // 
            // BooksView
            // 
            this.BooksView.AllowUserToAddRows = false;
            this.BooksView.AllowUserToDeleteRows = false;
            this.BooksView.AllowUserToResizeColumns = false;
            this.BooksView.AllowUserToResizeRows = false;
            this.BooksView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BooksView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.BooksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BooksView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BooksView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.BooksView.Location = new System.Drawing.Point(107, 104);
            this.BooksView.MultiSelect = false;
            this.BooksView.Name = "BooksView";
            this.BooksView.RowHeadersVisible = false;
            this.BooksView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.BooksView.RowTemplate.Height = 24;
            this.BooksView.Size = new System.Drawing.Size(593, 310);
            this.BooksView.TabIndex = 2;
            this.BooksView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksView_CellClick);
            this.BooksView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksView_CellDoubleClick);
            // 
            // BooksControls
            // 
            this.BooksControls.Controls.Add(this.InsertBook);
            this.BooksControls.Controls.Add(this.UpdateBook);
            this.BooksControls.Controls.Add(this.DeleteBook);
            this.BooksControls.Location = new System.Drawing.Point(706, 6);
            this.BooksControls.Name = "BooksControls";
            this.BooksControls.Size = new System.Drawing.Size(104, 153);
            this.BooksControls.TabIndex = 1;
            this.BooksControls.TabStop = false;
            this.BooksControls.Text = "Controls";
            // 
            // InsertBook
            // 
            this.InsertBook.Location = new System.Drawing.Point(6, 21);
            this.InsertBook.Name = "InsertBook";
            this.InsertBook.Size = new System.Drawing.Size(91, 32);
            this.InsertBook.TabIndex = 0;
            this.InsertBook.Text = "Insert";
            this.InsertBook.UseVisualStyleBackColor = true;
            this.InsertBook.Click += new System.EventHandler(this.InsertBook_Click);
            // 
            // UpdateBook
            // 
            this.UpdateBook.Enabled = false;
            this.UpdateBook.Location = new System.Drawing.Point(6, 97);
            this.UpdateBook.Name = "UpdateBook";
            this.UpdateBook.Size = new System.Drawing.Size(91, 32);
            this.UpdateBook.TabIndex = 0;
            this.UpdateBook.Text = "Update";
            this.UpdateBook.UseVisualStyleBackColor = true;
            this.UpdateBook.Click += new System.EventHandler(this.UpdateBook_Click);
            // 
            // DeleteBook
            // 
            this.DeleteBook.Enabled = false;
            this.DeleteBook.Location = new System.Drawing.Point(6, 59);
            this.DeleteBook.Name = "DeleteBook";
            this.DeleteBook.Size = new System.Drawing.Size(91, 32);
            this.DeleteBook.TabIndex = 0;
            this.DeleteBook.Text = "Delete";
            this.DeleteBook.UseVisualStyleBackColor = true;
            this.DeleteBook.Click += new System.EventHandler(this.DeleteBook_Click);
            // 
            // Members
            // 
            this.Members.Controls.Add(this.groupBox1);
            this.Members.Controls.Add(this.MembersView);
            this.Members.Controls.Add(this.MembersControls);
            this.Members.Location = new System.Drawing.Point(4, 25);
            this.Members.Name = "Members";
            this.Members.Padding = new System.Windows.Forms.Padding(3);
            this.Members.Size = new System.Drawing.Size(816, 432);
            this.Members.TabIndex = 1;
            this.Members.Text = "Members";
            this.Members.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FindMID);
            this.groupBox1.Controls.Add(this.FindMPhone);
            this.groupBox1.Controls.Add(this.FindMCNP);
            this.groupBox1.Controls.Add(this.FindMName);
            this.groupBox1.Controls.Add(this.MFTextBox);
            this.groupBox1.Controls.Add(this.MSearchButton);
            this.groupBox1.Location = new System.Drawing.Point(107, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 92);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find";
            // 
            // FindMID
            // 
            this.FindMID.AutoSize = true;
            this.FindMID.Location = new System.Drawing.Point(27, 60);
            this.FindMID.Name = "FindMID";
            this.FindMID.Size = new System.Drawing.Size(42, 21);
            this.FindMID.TabIndex = 5;
            this.FindMID.TabStop = true;
            this.FindMID.Text = "ID";
            this.FindMID.UseVisualStyleBackColor = true;
            // 
            // FindMPhone
            // 
            this.FindMPhone.AutoSize = true;
            this.FindMPhone.Location = new System.Drawing.Point(210, 60);
            this.FindMPhone.Name = "FindMPhone";
            this.FindMPhone.Size = new System.Drawing.Size(70, 21);
            this.FindMPhone.TabIndex = 5;
            this.FindMPhone.TabStop = true;
            this.FindMPhone.Text = "Phone";
            this.FindMPhone.UseVisualStyleBackColor = true;
            // 
            // FindMCNP
            // 
            this.FindMCNP.AutoSize = true;
            this.FindMCNP.Location = new System.Drawing.Point(147, 60);
            this.FindMCNP.Name = "FindMCNP";
            this.FindMCNP.Size = new System.Drawing.Size(57, 21);
            this.FindMCNP.TabIndex = 5;
            this.FindMCNP.TabStop = true;
            this.FindMCNP.Text = "CNP";
            this.FindMCNP.UseVisualStyleBackColor = true;
            // 
            // FindMName
            // 
            this.FindMName.AutoSize = true;
            this.FindMName.Location = new System.Drawing.Point(75, 60);
            this.FindMName.Name = "FindMName";
            this.FindMName.Size = new System.Drawing.Size(66, 21);
            this.FindMName.TabIndex = 5;
            this.FindMName.TabStop = true;
            this.FindMName.Text = "Name";
            this.FindMName.UseVisualStyleBackColor = true;
            // 
            // MFTextBox
            // 
            this.MFTextBox.Location = new System.Drawing.Point(27, 21);
            this.MFTextBox.Name = "MFTextBox";
            this.MFTextBox.Size = new System.Drawing.Size(245, 22);
            this.MFTextBox.TabIndex = 3;
            // 
            // MSearchButton
            // 
            this.MSearchButton.Location = new System.Drawing.Point(313, 20);
            this.MSearchButton.Name = "MSearchButton";
            this.MSearchButton.Size = new System.Drawing.Size(92, 23);
            this.MSearchButton.TabIndex = 4;
            this.MSearchButton.Text = "Search";
            this.MSearchButton.UseVisualStyleBackColor = true;
            this.MSearchButton.Click += new System.EventHandler(this.MSearchButton_Click);
            // 
            // MembersView
            // 
            this.MembersView.AllowUserToAddRows = false;
            this.MembersView.AllowUserToDeleteRows = false;
            this.MembersView.AllowUserToResizeColumns = false;
            this.MembersView.AllowUserToResizeRows = false;
            this.MembersView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MembersView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.MembersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MembersView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MembersView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MembersView.Location = new System.Drawing.Point(107, 104);
            this.MembersView.MultiSelect = false;
            this.MembersView.Name = "MembersView";
            this.MembersView.RowHeadersVisible = false;
            this.MembersView.RowTemplate.Height = 24;
            this.MembersView.ShowCellErrors = false;
            this.MembersView.ShowCellToolTips = false;
            this.MembersView.ShowEditingIcon = false;
            this.MembersView.ShowRowErrors = false;
            this.MembersView.Size = new System.Drawing.Size(593, 310);
            this.MembersView.TabIndex = 6;
            this.MembersView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MembersView_CellClick);
            this.MembersView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MembersView_CellDoubleClick);
            // 
            // MembersControls
            // 
            this.MembersControls.Controls.Add(this.InsertMember);
            this.MembersControls.Controls.Add(this.UpdateMember);
            this.MembersControls.Controls.Add(this.DeleteMember);
            this.MembersControls.Location = new System.Drawing.Point(706, 6);
            this.MembersControls.Name = "MembersControls";
            this.MembersControls.Size = new System.Drawing.Size(104, 153);
            this.MembersControls.TabIndex = 4;
            this.MembersControls.TabStop = false;
            this.MembersControls.Text = "Controls";
            // 
            // InsertMember
            // 
            this.InsertMember.Location = new System.Drawing.Point(6, 21);
            this.InsertMember.Name = "InsertMember";
            this.InsertMember.Size = new System.Drawing.Size(91, 32);
            this.InsertMember.TabIndex = 0;
            this.InsertMember.Text = "Insert";
            this.InsertMember.UseVisualStyleBackColor = true;
            this.InsertMember.Click += new System.EventHandler(this.InsertMember_Click);
            // 
            // UpdateMember
            // 
            this.UpdateMember.Enabled = false;
            this.UpdateMember.Location = new System.Drawing.Point(6, 97);
            this.UpdateMember.Name = "UpdateMember";
            this.UpdateMember.Size = new System.Drawing.Size(91, 32);
            this.UpdateMember.TabIndex = 0;
            this.UpdateMember.Text = "Update";
            this.UpdateMember.UseVisualStyleBackColor = true;
            this.UpdateMember.Click += new System.EventHandler(this.UpdateMember_Click);
            // 
            // DeleteMember
            // 
            this.DeleteMember.Enabled = false;
            this.DeleteMember.Location = new System.Drawing.Point(6, 59);
            this.DeleteMember.Name = "DeleteMember";
            this.DeleteMember.Size = new System.Drawing.Size(91, 32);
            this.DeleteMember.TabIndex = 0;
            this.DeleteMember.Text = "Delete";
            this.DeleteMember.UseVisualStyleBackColor = true;
            this.DeleteMember.Click += new System.EventHandler(this.DeleteMember_Click);
            // 
            // Loans
            // 
            this.Loans.Controls.Add(this.groupBox2);
            this.Loans.Controls.Add(this.LoansView);
            this.Loans.Controls.Add(this.LoansControls);
            this.Loans.Location = new System.Drawing.Point(4, 25);
            this.Loans.Name = "Loans";
            this.Loans.Padding = new System.Windows.Forms.Padding(3);
            this.Loans.Size = new System.Drawing.Size(816, 432);
            this.Loans.TabIndex = 2;
            this.Loans.Text = "Loans";
            this.Loans.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FindLMember);
            this.groupBox2.Controls.Add(this.FindLBook);
            this.groupBox2.Controls.Add(this.LFTextBox);
            this.groupBox2.Controls.Add(this.LSearchButton);
            this.groupBox2.Location = new System.Drawing.Point(107, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 92);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find";
            // 
            // FindLMember
            // 
            this.FindLMember.AutoSize = true;
            this.FindLMember.Location = new System.Drawing.Point(89, 59);
            this.FindLMember.Name = "FindLMember";
            this.FindLMember.Size = new System.Drawing.Size(80, 21);
            this.FindLMember.TabIndex = 5;
            this.FindLMember.TabStop = true;
            this.FindLMember.Text = "Member";
            this.FindLMember.UseVisualStyleBackColor = true;
            // 
            // FindLBook
            // 
            this.FindLBook.AutoSize = true;
            this.FindLBook.Location = new System.Drawing.Point(27, 59);
            this.FindLBook.Name = "FindLBook";
            this.FindLBook.Size = new System.Drawing.Size(61, 21);
            this.FindLBook.TabIndex = 5;
            this.FindLBook.TabStop = true;
            this.FindLBook.Text = "Book";
            this.FindLBook.UseVisualStyleBackColor = true;
            // 
            // LFTextBox
            // 
            this.LFTextBox.Location = new System.Drawing.Point(27, 21);
            this.LFTextBox.Name = "LFTextBox";
            this.LFTextBox.Size = new System.Drawing.Size(245, 22);
            this.LFTextBox.TabIndex = 3;
            // 
            // LSearchButton
            // 
            this.LSearchButton.Location = new System.Drawing.Point(313, 20);
            this.LSearchButton.Name = "LSearchButton";
            this.LSearchButton.Size = new System.Drawing.Size(92, 23);
            this.LSearchButton.TabIndex = 4;
            this.LSearchButton.Text = "Search";
            this.LSearchButton.UseVisualStyleBackColor = true;
            this.LSearchButton.Click += new System.EventHandler(this.LSearchButton_Click);
            // 
            // LoansView
            // 
            this.LoansView.AllowUserToAddRows = false;
            this.LoansView.AllowUserToDeleteRows = false;
            this.LoansView.AllowUserToResizeColumns = false;
            this.LoansView.AllowUserToResizeRows = false;
            this.LoansView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LoansView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoansView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LoansView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LoansView.DefaultCellStyle = dataGridViewCellStyle2;
            this.LoansView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.LoansView.Location = new System.Drawing.Point(107, 104);
            this.LoansView.MultiSelect = false;
            this.LoansView.Name = "LoansView";
            this.LoansView.RowHeadersVisible = false;
            this.LoansView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.LoansView.RowTemplate.Height = 24;
            this.LoansView.ShowCellErrors = false;
            this.LoansView.ShowCellToolTips = false;
            this.LoansView.ShowEditingIcon = false;
            this.LoansView.Size = new System.Drawing.Size(593, 310);
            this.LoansView.TabIndex = 6;
            this.LoansView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoansView_CellClick);
            this.LoansView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoansView_CellDoubleClick);
            // 
            // LoansControls
            // 
            this.LoansControls.Controls.Add(this.InsertLoan);
            this.LoansControls.Controls.Add(this.UpdateLoan);
            this.LoansControls.Controls.Add(this.DeleteLoan);
            this.LoansControls.Location = new System.Drawing.Point(706, 6);
            this.LoansControls.Name = "LoansControls";
            this.LoansControls.Size = new System.Drawing.Size(104, 153);
            this.LoansControls.TabIndex = 5;
            this.LoansControls.TabStop = false;
            this.LoansControls.Text = "Controls";
            // 
            // InsertLoan
            // 
            this.InsertLoan.Location = new System.Drawing.Point(6, 21);
            this.InsertLoan.Name = "InsertLoan";
            this.InsertLoan.Size = new System.Drawing.Size(91, 32);
            this.InsertLoan.TabIndex = 0;
            this.InsertLoan.Text = "Insert";
            this.InsertLoan.UseVisualStyleBackColor = true;
            this.InsertLoan.Click += new System.EventHandler(this.InsertLoan_Click);
            // 
            // UpdateLoan
            // 
            this.UpdateLoan.Enabled = false;
            this.UpdateLoan.Location = new System.Drawing.Point(6, 97);
            this.UpdateLoan.Name = "UpdateLoan";
            this.UpdateLoan.Size = new System.Drawing.Size(91, 32);
            this.UpdateLoan.TabIndex = 0;
            this.UpdateLoan.Text = "Update";
            this.UpdateLoan.UseVisualStyleBackColor = true;
            this.UpdateLoan.Click += new System.EventHandler(this.UpdateLoan_Click);
            // 
            // DeleteLoan
            // 
            this.DeleteLoan.Enabled = false;
            this.DeleteLoan.Location = new System.Drawing.Point(6, 59);
            this.DeleteLoan.Name = "DeleteLoan";
            this.DeleteLoan.Size = new System.Drawing.Size(91, 32);
            this.DeleteLoan.TabIndex = 0;
            this.DeleteLoan.Text = "Delete";
            this.DeleteLoan.UseVisualStyleBackColor = true;
            this.DeleteLoan.Click += new System.EventHandler(this.DeleteLoan_Click);
            // 
            // Logs
            // 
            this.Logs.Controls.Add(this.groupBox3);
            this.Logs.Controls.Add(this.logBox);
            this.Logs.Controls.Add(this.LogButton);
            this.Logs.Controls.Add(this.filesBox);
            this.Logs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Logs.Location = new System.Drawing.Point(4, 25);
            this.Logs.Name = "Logs";
            this.Logs.Padding = new System.Windows.Forms.Padding(3);
            this.Logs.Size = new System.Drawing.Size(816, 432);
            this.Logs.TabIndex = 3;
            this.Logs.Text = "Logs & Statistics";
            this.Logs.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.loansNr);
            this.groupBox3.Controls.Add(this.membersNr);
            this.groupBox3.Controls.Add(this.booksNr);
            this.groupBox3.Controls.Add(this.LoansStats);
            this.groupBox3.Controls.Add(this.MemberStats);
            this.groupBox3.Controls.Add(this.BookStats);
            this.groupBox3.Location = new System.Drawing.Point(532, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 144);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistics";
            // 
            // loansNr
            // 
            this.loansNr.AutoSize = true;
            this.loansNr.Location = new System.Drawing.Point(88, 88);
            this.loansNr.Name = "loansNr";
            this.loansNr.Size = new System.Drawing.Size(27, 17);
            this.loansNr.TabIndex = 4;
            this.loansNr.Text = "Nr.";
            // 
            // membersNr
            // 
            this.membersNr.AutoSize = true;
            this.membersNr.Location = new System.Drawing.Point(87, 60);
            this.membersNr.Name = "membersNr";
            this.membersNr.Size = new System.Drawing.Size(27, 17);
            this.membersNr.TabIndex = 4;
            this.membersNr.Text = "Nr.";
            // 
            // booksNr
            // 
            this.booksNr.AutoSize = true;
            this.booksNr.Location = new System.Drawing.Point(87, 32);
            this.booksNr.Name = "booksNr";
            this.booksNr.Size = new System.Drawing.Size(27, 17);
            this.booksNr.TabIndex = 4;
            this.booksNr.Text = "Nr.";
            // 
            // LoansStats
            // 
            this.LoansStats.AutoSize = true;
            this.LoansStats.Location = new System.Drawing.Point(6, 88);
            this.LoansStats.Name = "LoansStats";
            this.LoansStats.Size = new System.Drawing.Size(51, 17);
            this.LoansStats.TabIndex = 3;
            this.LoansStats.Text = "Loans:";
            // 
            // MemberStats
            // 
            this.MemberStats.AutoSize = true;
            this.MemberStats.Location = new System.Drawing.Point(6, 60);
            this.MemberStats.Name = "MemberStats";
            this.MemberStats.Size = new System.Drawing.Size(70, 17);
            this.MemberStats.TabIndex = 1;
            this.MemberStats.Text = "Members:";
            // 
            // BookStats
            // 
            this.BookStats.AutoSize = true;
            this.BookStats.Location = new System.Drawing.Point(6, 32);
            this.BookStats.Name = "BookStats";
            this.BookStats.Size = new System.Drawing.Size(51, 17);
            this.BookStats.TabIndex = 0;
            this.BookStats.Text = "Books:";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(26, 68);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(475, 324);
            this.logBox.TabIndex = 0;
            this.logBox.Text = "";
            // 
            // LogButton
            // 
            this.LogButton.Location = new System.Drawing.Point(672, 67);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(81, 24);
            this.LogButton.TabIndex = 1;
            this.LogButton.Text = "Show";
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // filesBox
            // 
            this.filesBox.FormattingEnabled = true;
            this.filesBox.Location = new System.Drawing.Point(532, 67);
            this.filesBox.Name = "filesBox";
            this.filesBox.Size = new System.Drawing.Size(134, 24);
            this.filesBox.TabIndex = 0;
            // 
            // tabCtrlAccount
            // 
            this.tabCtrlAccount.Controls.Add(this.tabAccount);
            this.tabCtrlAccount.Location = new System.Drawing.Point(493, 0);
            this.tabCtrlAccount.Margin = new System.Windows.Forms.Padding(4);
            this.tabCtrlAccount.Name = "tabCtrlAccount";
            this.tabCtrlAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabCtrlAccount.RightToLeftLayout = true;
            this.tabCtrlAccount.SelectedIndex = 0;
            this.tabCtrlAccount.Size = new System.Drawing.Size(327, 98);
            this.tabCtrlAccount.TabIndex = 21;
            this.tabCtrlAccount.TabStop = false;
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.permissionText);
            this.tabAccount.Controls.Add(this.usernameText);
            this.tabAccount.Controls.Add(this.Logout);
            this.tabAccount.Controls.Add(this.AddUser);
            this.tabAccount.Controls.Add(this.labelHelp);
            this.tabAccount.Controls.Add(this.labelAcountPermissions6);
            this.tabAccount.Controls.Add(this.labelAcountPermissions3);
            this.tabAccount.Controls.Add(this.labelAcountPermissions5);
            this.tabAccount.Controls.Add(this.labelAcountPermissions4);
            this.tabAccount.Controls.Add(this.labelAcountPermissions2);
            this.tabAccount.Controls.Add(this.labelAcountPermissions1);
            this.tabAccount.Controls.Add(this.labelAcountRole);
            this.tabAccount.Controls.Add(this.labelAcountUserName);
            this.tabAccount.Controls.Add(this.label1);
            this.tabAccount.Controls.Add(this.label3);
            this.tabAccount.Location = new System.Drawing.Point(4, 25);
            this.tabAccount.Margin = new System.Windows.Forms.Padding(4);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(4);
            this.tabAccount.Size = new System.Drawing.Size(319, 69);
            this.tabAccount.TabIndex = 0;
            this.tabAccount.Text = "Account";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // permissionText
            // 
            this.permissionText.AutoSize = true;
            this.permissionText.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permissionText.ForeColor = System.Drawing.Color.Red;
            this.permissionText.Location = new System.Drawing.Point(110, 28);
            this.permissionText.Name = "permissionText";
            this.permissionText.Size = new System.Drawing.Size(86, 16);
            this.permissionText.TabIndex = 15;
            this.permissionText.Text = "<permission>";
            // 
            // usernameText
            // 
            this.usernameText.AutoSize = true;
            this.usernameText.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.Location = new System.Drawing.Point(109, 5);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(79, 16);
            this.usernameText.TabIndex = 15;
            this.usernameText.Text = "<username>";
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.LinkColor = System.Drawing.Color.Black;
            this.Logout.Location = new System.Drawing.Point(219, 50);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(68, 17);
            this.Logout.TabIndex = 14;
            this.Logout.TabStop = true;
            this.Logout.Text = "[ Logout ]";
            this.Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_LinkClicked);
            // 
            // AddUser
            // 
            this.AddUser.AutoSize = true;
            this.AddUser.LinkColor = System.Drawing.Color.Black;
            this.AddUser.Location = new System.Drawing.Point(129, 50);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(83, 17);
            this.AddUser.TabIndex = 13;
            this.AddUser.TabStop = true;
            this.AddUser.Text = "[ Add User ]";
            this.AddUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddUser_LinkClicked);
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelp.Location = new System.Drawing.Point(667, 4);
            this.labelHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(41, 17);
            this.labelHelp.TabIndex = 12;
            this.labelHelp.Text = "Help";
            // 
            // labelAcountPermissions6
            // 
            this.labelAcountPermissions6.AutoSize = true;
            this.labelAcountPermissions6.Location = new System.Drawing.Point(569, 44);
            this.labelAcountPermissions6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAcountPermissions6.Name = "labelAcountPermissions6";
            this.labelAcountPermissions6.Size = new System.Drawing.Size(0, 17);
            this.labelAcountPermissions6.TabIndex = 7;
            // 
            // labelAcountPermissions3
            // 
            this.labelAcountPermissions3.AutoSize = true;
            this.labelAcountPermissions3.Location = new System.Drawing.Point(501, 44);
            this.labelAcountPermissions3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAcountPermissions3.Name = "labelAcountPermissions3";
            this.labelAcountPermissions3.Size = new System.Drawing.Size(0, 17);
            this.labelAcountPermissions3.TabIndex = 7;
            // 
            // labelAcountPermissions5
            // 
            this.labelAcountPermissions5.AutoSize = true;
            this.labelAcountPermissions5.Location = new System.Drawing.Point(569, 23);
            this.labelAcountPermissions5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAcountPermissions5.Name = "labelAcountPermissions5";
            this.labelAcountPermissions5.Size = new System.Drawing.Size(0, 17);
            this.labelAcountPermissions5.TabIndex = 7;
            // 
            // labelAcountPermissions4
            // 
            this.labelAcountPermissions4.AutoSize = true;
            this.labelAcountPermissions4.Location = new System.Drawing.Point(569, 4);
            this.labelAcountPermissions4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAcountPermissions4.Name = "labelAcountPermissions4";
            this.labelAcountPermissions4.Size = new System.Drawing.Size(0, 17);
            this.labelAcountPermissions4.TabIndex = 6;
            // 
            // labelAcountPermissions2
            // 
            this.labelAcountPermissions2.AutoSize = true;
            this.labelAcountPermissions2.Location = new System.Drawing.Point(501, 23);
            this.labelAcountPermissions2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAcountPermissions2.Name = "labelAcountPermissions2";
            this.labelAcountPermissions2.Size = new System.Drawing.Size(0, 17);
            this.labelAcountPermissions2.TabIndex = 7;
            // 
            // labelAcountPermissions1
            // 
            this.labelAcountPermissions1.AutoSize = true;
            this.labelAcountPermissions1.Location = new System.Drawing.Point(501, 4);
            this.labelAcountPermissions1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAcountPermissions1.Name = "labelAcountPermissions1";
            this.labelAcountPermissions1.Size = new System.Drawing.Size(0, 17);
            this.labelAcountPermissions1.TabIndex = 6;
            // 
            // labelAcountRole
            // 
            this.labelAcountRole.AutoSize = true;
            this.labelAcountRole.Location = new System.Drawing.Point(183, 25);
            this.labelAcountRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAcountRole.Name = "labelAcountRole";
            this.labelAcountRole.Size = new System.Drawing.Size(0, 17);
            this.labelAcountRole.TabIndex = 5;
            // 
            // labelAcountUserName
            // 
            this.labelAcountUserName.AutoSize = true;
            this.labelAcountUserName.Location = new System.Drawing.Point(183, 4);
            this.labelAcountUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAcountUserName.Name = "labelAcountUserName";
            this.labelAcountUserName.Size = new System.Drawing.Size(0, 17);
            this.labelAcountUserName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = ":Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = ":Permissions ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerBox
            // 
            this.timerBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.timerBox.Location = new System.Drawing.Point(0, 0);
            this.timerBox.Name = "timerBox";
            this.timerBox.Size = new System.Drawing.Size(175, 22);
            this.timerBox.TabIndex = 22;
            // 
            // LibAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 538);
            this.Controls.Add(this.timerBox);
            this.Controls.Add(this.tabCtrlAccount);
            this.Controls.Add(this.Tabs);
            this.MaximizeBox = false;
            this.Name = "LibAppUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Application";
            this.Tabs.ResumeLayout(false);
            this.Books.ResumeLayout(false);
            this.FindBooks.ResumeLayout(false);
            this.FindBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksView)).EndInit();
            this.BooksControls.ResumeLayout(false);
            this.Members.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MembersView)).EndInit();
            this.MembersControls.ResumeLayout(false);
            this.Loans.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoansView)).EndInit();
            this.LoansControls.ResumeLayout(false);
            this.Logs.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabCtrlAccount.ResumeLayout(false);
            this.tabAccount.ResumeLayout(false);
            this.tabAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Books;
        private System.Windows.Forms.Button UpdateBook;
        private System.Windows.Forms.Button DeleteBook;
        private System.Windows.Forms.Button InsertBook;
        private System.Windows.Forms.TabPage Members;
        private System.Windows.Forms.TabPage Loans;
        private System.Windows.Forms.TabPage Logs;
        private System.Windows.Forms.GroupBox BooksControls;
        private System.Windows.Forms.GroupBox MembersControls;
        private System.Windows.Forms.Button InsertMember;
        private System.Windows.Forms.Button UpdateMember;
        private System.Windows.Forms.Button DeleteMember;
        private System.Windows.Forms.GroupBox LoansControls;
        private System.Windows.Forms.Button InsertLoan;
        private System.Windows.Forms.Button UpdateLoan;
        private System.Windows.Forms.Button DeleteLoan;
        private System.Windows.Forms.GroupBox FindBooks;
        private System.Windows.Forms.TextBox BFTextBox;
        private System.Windows.Forms.Button BSearchButton;
        private System.Windows.Forms.DataGridView BooksView;
        private System.Windows.Forms.RadioButton FindBYear;
        private System.Windows.Forms.RadioButton FindISBN;
        private System.Windows.Forms.RadioButton FindBAuthor;
        private System.Windows.Forms.RadioButton FindBTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FindMID;
        private System.Windows.Forms.RadioButton FindMPhone;
        private System.Windows.Forms.RadioButton FindMCNP;
        private System.Windows.Forms.RadioButton FindMName;
        private System.Windows.Forms.TextBox MFTextBox;
        private System.Windows.Forms.Button MSearchButton;
        private System.Windows.Forms.DataGridView MembersView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton FindLMember;
        private System.Windows.Forms.RadioButton FindLBook;
        private System.Windows.Forms.TextBox LFTextBox;
        private System.Windows.Forms.Button LSearchButton;
        private System.Windows.Forms.DataGridView LoansView;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.ComboBox filesBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LoansStats;
        private System.Windows.Forms.Label MemberStats;
        private System.Windows.Forms.Label BookStats;
        private System.Windows.Forms.Label loansNr;
        private System.Windows.Forms.Label membersNr;
        private System.Windows.Forms.Label booksNr;
        private System.Windows.Forms.TabControl tabCtrlAccount;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Label labelAcountPermissions6;
        private System.Windows.Forms.Label labelAcountPermissions3;
        private System.Windows.Forms.Label labelAcountPermissions5;
        private System.Windows.Forms.Label labelAcountPermissions4;
        private System.Windows.Forms.Label labelAcountPermissions2;
        private System.Windows.Forms.Label labelAcountPermissions1;
        private System.Windows.Forms.Label labelAcountRole;
        private System.Windows.Forms.Label labelAcountUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Logout;
        private System.Windows.Forms.LinkLabel AddUser;
        private System.Windows.Forms.TextBox timerBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label permissionText;
        private System.Windows.Forms.Label usernameText;
    }
}

