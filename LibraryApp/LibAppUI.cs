using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using BAL;

namespace LibraryApp
{
    
    public partial class LibAppUI : Form
    {
        protected Operations linkBussinessLayer;
        private Login form;
        private String path = getPath();
        private int privilege;
        private String user;
        public LibAppUI(Login _loginForm, int _privilege, String _user)
        {
            
            form = _loginForm;
            privilege = _privilege;
            user = _user;
            
            this.FormClosing += (sender, e) =>
            {
                form.Show();
                form.Controls["IncorrectText"].Hide();
                form.Controls["PasswordBox"].Text = "";
            };
            linkBussinessLayer = new Operations();
            InitializeComponent();
            BooksView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MembersView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoansView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Logs and Statistics.

            // Logs.
            String text = linkBussinessLayer.readLogs(linkBussinessLayer.getCurrentLogFile());
            logBox.Text += text;
            // Get existing log files and list them.
            FileStream file = new FileStream(path + "log_files.txt", FileMode.Open, FileAccess.Read);
            StreamReader stream = new StreamReader(file);
            String line;

            filesBox.DisplayMember = "Text";
            filesBox.ValueMember = "Value";
            while ((line = stream.ReadLine()) != null)
            {
                filesBox.Items.Insert(0, (new { Text = line, Value = line }));
            }
            filesBox.SelectedIndex = 0;
            stream.Close();
            file.Close();


            // Privileges - User & Administrator
            tabAccount.Controls["usernameText"].Text = user;
            if (privilege == 1)
            {
                Logs.Enabled = false;
                BooksControls.Enabled = false;
                MembersControls.Enabled = false;
                LoansControls.Enabled = false;
                tabAccount.Controls["AddUser"].Enabled = false;
                tabAccount.Controls["permissionText"].Text = "User";
                
            }
            else
            {
                tabAccount.Controls["permissionText"].Text = "Administrator";
            }
            UpdateAll();
        }
        public void UpdateAll()
        {
            // Books.
            BooksView.DataSource = linkBussinessLayer.getBooks();

            // Members.
            MembersView.DataSource = linkBussinessLayer.getMembers();
            
            // Loans.
            LoansView.DataSource = linkBussinessLayer.getLoans();

            // Statistics.
            booksNr.Text = linkBussinessLayer.getBooksCount().ToString();
            loansNr.Text = linkBussinessLayer.getLoansCount().ToString();
            membersNr.Text = linkBussinessLayer.getMembersCount().ToString();
            // Logs
            String selected = filesBox.Text.ToString();
            String text = linkBussinessLayer.readLogs(selected + ".txt");
            logBox.Text = "";
            logBox.Text += text;
        }
    
        // INSERT
        private void InsertBook_Click(object sender, EventArgs e)
        {
            AddTemplate add = new AddTemplate(this,user);
            add.Text = "AddBook";
            add.Show();
        }

        private void InsertMember_Click(object sender, EventArgs e)
        {
            AddTemplate add = new AddTemplate(this,user);
            add.Text = "AddMember";
            add.Controls["Label1"].Text = "Name";
            add.Controls["Label2"].Text = "Surname";
            add.Controls["Label3"].Text = "CNP";
            add.Controls["Label4"].Text = "Address";
            add.Controls["Label5"].Text = "Phone";
            add.Controls["Label6"].Text = "Email";
            add.Show();
        }

        private void InsertLoan_Click(object sender, EventArgs e)
        {
            AddTemplate add = new AddTemplate(this,user);
            add.Text = "AddLoan";
            add.Controls["Label1"].Text = "Book";
            add.Controls["Label2"].Text = "Member";
            add.Controls["Label3"].Text = "Date";
            add.Controls["Label4"].Text = "Expiry Date";
            add.Controls["Label5"].Hide();
            add.Controls["Label6"].Hide();
            add.Controls["Text5"].Hide();
            add.Controls["Text6"].Hide();
            add.Show();

        }
        // DOUBLE CLICK EVENT
        private void BooksView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewTemplate view = new ViewTemplate();
            DataGridViewCellCollection x = BooksView.CurrentRow.Cells;
            view.Text = "";
            view.Controls["Label1"].Text = "Title:";
            view.Controls["Label2"].Text = "Author:";
            view.Controls["Label3"].Text = "Year:";
            view.Controls["Label4"].Text = "Publisher:";
            view.Controls["Label5"].Text = "ISBN:";
            view.Controls["Label6"].Text = "Copies:";
            view.Controls["viewText1"].Text = x[0].Value.ToString();
            view.Controls["viewText2"].Text = x[1].Value.ToString();
            view.Controls["viewText3"].Text = x[2].Value.ToString();
            view.Controls["viewText4"].Text = x[3].Value.ToString();
            view.Controls["viewText5"].Text = x[4].Value.ToString();
            view.Controls["viewText6"].Text = x[5].Value.ToString();
            view.Show();
        }
        private void MembersView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewTemplate view = new ViewTemplate();
            DataGridViewCellCollection x = MembersView.CurrentRow.Cells;
            view.Text = "";
            view.Controls["Label1"].Text = "Name:";
            view.Controls["Label2"].Text = "Surname:";
            view.Controls["Label3"].Text = "CNP:";
            view.Controls["Label4"].Text = "Address:";
            view.Controls["Label5"].Text = "Phone:";
            view.Controls["Label6"].Text = "Email:";
            view.Controls["viewText1"].Text = x[0].Value.ToString();
            view.Controls["viewText2"].Text = x[1].Value.ToString();
            view.Controls["viewText3"].Text = x[2].Value.ToString();
            view.Controls["viewText4"].Text = x[3].Value.ToString();
            view.Controls["viewText5"].Text = x[4].Value.ToString();
            view.Controls["viewText6"].Text = x[5].Value.ToString();
            view.Show();
        }
        private void LoansView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewTemplate view = new ViewTemplate();
            DataGridViewCellCollection x = LoansView.CurrentRow.Cells;
            view.Text = "";
            view.Controls["Label1"].Text = "Name:";
            view.Controls["Label2"].Text = "Title:";
            view.Controls["Label3"].Text = "Author:";
            view.Controls["Label4"].Text = "Date:";
            view.Controls["Label5"].Text = "Exp.Date:";
            view.Controls["Label6"].Hide();
            view.Controls["viewText1"].Text = x[0].Value.ToString() + " " + x[1].Value.ToString();
            view.Controls["viewText2"].Text = x[2].Value.ToString();
            view.Controls["viewText3"].Text = x[3].Value.ToString();
            view.Controls["viewText4"].Text = x[5].Value.ToString();
            view.Controls["viewText5"].Text = x[6].Value.ToString();
            view.Controls["viewText6"].Hide();
            view.Show();
        }
        // CLICK EVENT
        private void BooksView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BooksControls.Controls["DeleteBook"].Enabled = true;
            BooksControls.Controls["UpdateBook"].Enabled = true;

        }
        private void MembersView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MembersControls.Controls["DeleteMember"].Enabled = true;
            MembersControls.Controls["UpdateMember"].Enabled = true;
        }
        private void LoansView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoansControls.Controls["DeleteLoan"].Enabled = true;
            LoansControls.Controls["UpdateLoan"].Enabled = true;
        }
        // SEARCH
        private void BSearchButton_Click(object sender, EventArgs e)
        {
            String keyword = BFTextBox.Text;
            DataTable dt = new DataTable();
            bool flag = false;
            try
            {
                if (keyword != "")
                {
                    if (FindBTitle.Checked == true)
                    {
                        flag = true;
                        dt = linkBussinessLayer.searchBooksByTitle(keyword);
                    }
                    if (FindBAuthor.Checked == true)
                    {
                        flag = true;
                        dt = linkBussinessLayer.searchBooksByAuthor(keyword);
                    }
                    if (FindISBN.Checked == true)
                    {
                        flag = true;
                        dt = linkBussinessLayer.searchBooksByISBN(keyword);
                    }
                    if (FindBYear.Checked == true)
                    {
                        flag = true;
                        int value;
                        if (int.TryParse(keyword, out value))
                            dt = linkBussinessLayer.searchBooksByYear(Convert.ToInt32(keyword));
                    }

                }
                if (flag == true)
                    BooksView.DataSource = dt;
                else
                    BooksView.DataSource = linkBussinessLayer.getBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("\nException: " + ex.StackTrace.ToString());
            }
        }

        private void MSearchButton_Click(object sender, EventArgs e)
        {
            String keyword = MFTextBox.Text;
            DataTable dt = new DataTable();
            bool flag = false;
            try
            {
                if (keyword != "")
                {
                    if (FindMName.Checked == true)
                    {
                        flag = true;
                        dt = linkBussinessLayer.searchMembersByName(keyword);
                    }
                    if (FindMID.Checked == true)
                    {
                        flag = true;
                        int value;
                        if(int.TryParse(keyword,out value))
                            dt = linkBussinessLayer.searchMembersByID(Convert.ToInt32(value));
                        
                    }
                    if (FindMCNP.Checked == true)
                    {
                        flag = true;
                        dt = linkBussinessLayer.searchMembersByCNP(keyword);
                    }
                    if (FindMPhone.Checked == true)
                    {
                        flag = true;
                        dt = linkBussinessLayer.searchMembersByPhone(keyword);
                    }

                }
                if (flag == true)
                    MembersView.DataSource = dt;
                else
                    MembersView.DataSource = linkBussinessLayer.getMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("\nException: " + ex.StackTrace.ToString());
            }
        }

        private void LSearchButton_Click(object sender, EventArgs e)
        {
            String keyword = MFTextBox.Text;
            DataTable dt = new DataTable();
            bool flag = false;
            try
            {
                if (keyword != "")
                {
                    if (FindLMember.Checked == true)
                    {
                        flag = true;
                        dt = linkBussinessLayer.searchLoansByMember(keyword);
                    }
                    if (FindLBook.Checked == true)
                    {
                        flag = true;
                        dt = linkBussinessLayer.searchLoansByBook(keyword);

                    }
                    

                }
                if (flag == true)
                    MembersView.DataSource = dt;
                else
                    MembersView.DataSource = linkBussinessLayer.getMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("\nException: " + ex.StackTrace.ToString());
            }
        }
        // DELETE
        private void DeleteBook_Click(object sender, EventArgs e)
        {
            string value0, value1, value2, value4, value5;
            foreach (DataGridViewRow row in BooksView.SelectedRows)
            {
                value0 = row.Cells[0].Value.ToString();
                value1 = row.Cells[1].Value.ToString();
                value2 = row.Cells[2].Value.ToString();
                value4 = row.Cells[4].Value.ToString();
                value5 = row.Cells[5].Value.ToString();
                String log = "**BOOK** " + value0 + " by " + value1 + " has been *REMOVED* by " + user;
                linkBussinessLayer.writeLogs(log);
                linkBussinessLayer.deleteBook(value0, value1, value4, value2, 1);
                
            }
            UpdateAll();

        }
        private void DeleteMember_Click(object sender, EventArgs e)
        {
            string value0, value1, value2;

            foreach (DataGridViewRow row in MembersView.SelectedRows)
            {
                value0 = row.Cells[0].Value.ToString();
                value1 = row.Cells[1].Value.ToString();
                value2 = row.Cells[2].Value.ToString();

                String log = "**MEMBER** " + value0 + " " + value1 + " CNP: " + value2 + " has been *REMOVED* by " + user;
                linkBussinessLayer.writeLogs(log);
                linkBussinessLayer.deleteMember(value0, value1, value2);
                
            }
            UpdateAll();
        }

        private void DeleteLoan_Click(object sender, EventArgs e)
        {
            string value0, value1, value2, value3;
            foreach (DataGridViewRow row in LoansView.SelectedRows)
            {
                value0 = row.Cells[0].Value.ToString();
                value1 = row.Cells[1].Value.ToString();
                value2 = row.Cells[2].Value.ToString();
                value3 = row.Cells[3].Value.ToString();

                String log = "**LOAN** " + value0 + " " + value1 + " - " + value2 + " by " + value3 + " has been *REMOVED* by " + user;
                linkBussinessLayer.writeLogs(log);
                //linkBussinessLayer.deleteLoan()

            }
            UpdateAll();
        }

        // LOGS
        private void LogButton_Click(object sender, EventArgs e)
        {
            String selected = filesBox.Text.ToString();
            String text = linkBussinessLayer.readLogs(selected + ".txt");
            logBox.Text = "";
            logBox.Text += text;
        }
        // UPDATE
        private void UpdateBook_Click(object sender, EventArgs e)
        {
            AddTemplate add = new AddTemplate(this,user);
            add.Text = "UpdateBook";
            add.Controls["AddButton"].Text = "Update";
            int bid=0;
            foreach (DataGridViewRow row in BooksView.SelectedRows)
            {
                add.Controls["Text1"].Text = row.Cells[0].Value.ToString();
                add.Controls["Text2"].Text = row.Cells[1].Value.ToString();
                add.Controls["Text3"].Text = row.Cells[2].Value.ToString();
                add.Controls["Text4"].Text = row.Cells[3].Value.ToString();
                add.Controls["Text5"].Text = row.Cells[4].Value.ToString();
                add.Controls["Text6"].Text = row.Cells[5].Value.ToString();
                bid = linkBussinessLayer.getBookID(row.Cells[0].Value.ToString(),row.Cells[1].Value.ToString());
            }
            add.bID = bid;
            add.Show();
        }

        private void UpdateMember_Click(object sender, EventArgs e)
        {
            AddTemplate add = new AddTemplate(this,user);
            add.Text = "UpdateMember";
            add.Controls["AddButton"].Text = "Update";
            add.Controls["Label1"].Text = "Name";
            add.Controls["Label2"].Text = "Surname";
            add.Controls["Label3"].Text = "CNP";
            add.Controls["Label4"].Text = "Address";
            add.Controls["Label5"].Text = "Phone";
            add.Controls["Label6"].Text = "Email";
            int mid=0;
            foreach (DataGridViewRow row in MembersView.SelectedRows)
            {
                add.Controls["Text1"].Text = row.Cells[0].Value.ToString();
                add.Controls["Text2"].Text = row.Cells[1].Value.ToString();
                add.Controls["Text3"].Text = row.Cells[2].Value.ToString();
                add.Controls["Text4"].Text = row.Cells[3].Value.ToString();
                add.Controls["Text5"].Text = row.Cells[4].Value.ToString();
                add.Controls["Text6"].Text = row.Cells[5].Value.ToString();
                mid = linkBussinessLayer.getMemberID(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
            }
            add.mID = mid;
            add.Show();
        }

        private void UpdateLoan_Click(object sender, EventArgs e)
        {
            AddTemplate add = new AddTemplate(this,user);
            add.Text = "UpdateLoan";
            add.Controls["AddButton"].Text = "Update";
            add.Controls["Label1"].Text = "Book";
            add.Controls["Label2"].Text = "Member";
            add.Controls["Label3"].Text = "Date";
            add.Controls["Label4"].Text = "Expiry Date";
            add.Controls["Text1"].Enabled = false;
            add.Controls["Text2"].Enabled = false;
            add.Controls["Text2"].Enabled = false;
            add.Controls["Label5"].Hide();
            add.Controls["Label6"].Hide();
            add.Controls["Text5"].Hide();
            add.Controls["Text6"].Hide();
            int bid = 0, mid = 0;
            foreach (DataGridViewRow row in LoansView.SelectedRows)
            {
                add.Controls["Text1"].Text = row.Cells[2].Value.ToString();
                add.Controls["Text2"].Text = row.Cells[0].Value.ToString() + " " + row.Cells[1].Value.ToString();
                add.Controls["Text3"].Text = row.Cells[5].Value.ToString();
                add.Controls["Text4"].Text = row.Cells[6].Value.ToString();
                mid = linkBussinessLayer.getMemberID(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                bid = linkBussinessLayer.getBookID(row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());
            }
            add.bID = bid;
            add.mID = mid;
            add.lID = linkBussinessLayer.getLoanID(bid, mid);
            add.Show();
        }
        public static String getPath()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var newPath = Path.Combine(outPutDirectory, "..\\..\\Resources\\");
            string path = new Uri(newPath).LocalPath;
            return path;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerBox.Text = DateTime.Now.ToString();
        }

        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            this.Close();
        }

        private void AddUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUserBox add = new AddUserBox();
            add.Show();
        }
    }
}
