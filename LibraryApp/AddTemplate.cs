using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace LibraryApp
{
    public partial class AddTemplate : Form
    {
        LibAppUI parent;
        String user;
        Operations linkBussinessLayer;
        public int mID, bID, lID;
        public AddTemplate(LibAppUI _param, String _user)
        {
            parent = _param;
            user = _user;
            this.FormClosing += (sender, e) =>
            {
                parent.Update();
            };
            linkBussinessLayer = new Operations();
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (this.Text == "AddBook")
            {
                linkBussinessLayer.writeLogs("**BOOK** " + Text1.Text + " by " + Text2.Text + " has been *ADDED* by " + user);
                linkBussinessLayer.insertBook(Text1.Text, Text2.Text, Text3.Text, Text4.Text, Text5.Text, Convert.ToInt32(Text6.Text));
            }
            if (this.Text == "AddMember")
            {
                linkBussinessLayer.writeLogs("**MEMBER** " + Text1.Text + " " + Text2.Text + " CNP: " + Text3.Text + " has been *ADDED* by " + user);
                linkBussinessLayer.insertMember(Text1.Text, Text2.Text, Text3.Text, Text4.Text, Text5.Text, Text6.Text);
            }
            if (this.Text == "AddLoan")
            {
                linkBussinessLayer.writeLogs("**LOAN** " + Text1.Text + " " + Text2.Text + " BOOK: " + Text3.Text + " has been *ADDED* by " + user);
                //linkBussinessLayer.insertLoan()
            }
            if (this.Text == "UpdateBook")
            {
                linkBussinessLayer.writeLogs("**BOOK** " + Text1.Text + " by " + Text2.Text + " has been *UPDATED* by " + user);
                linkBussinessLayer.updateBook(bID,Text1.Text, Text2.Text, Text3.Text, Text4.Text, Text5.Text, Convert.ToInt32(Text6.Text));
            }
            if (this.Text == "UpdateMember")
            {
                linkBussinessLayer.writeLogs("**MEMBER** " + Text1.Text + " " + Text2.Text + " CNP: " + Text3.Text + " has been *UPDATED* by " + user);
                linkBussinessLayer.updateMember(mID, Text1.Text, Text2.Text, Text3.Text, Text4.Text, Text5.Text, Text6.Text);
            }
            if (this.Text == "UpdateLoan")
            {
                linkBussinessLayer.writeLogs("**LOAN** " + Text1.Text + " " + Text2.Text + " has been *UPDATED* by " + user);
                linkBussinessLayer.updateLoan(lID, bID, mID, Text3.Text, Text4.Text);
            }
            parent.UpdateAll();
            this.Close();
        }
    }
}
