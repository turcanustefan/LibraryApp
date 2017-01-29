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
    public partial class AddUserBox : Form
    {
        private Operations link;
        public AddUserBox()
        {
            InitializeComponent();
            link = new Operations();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            if (PassBox.Text == ConfPassBox.Text)
            {
                try
                {
                    link.addUser(UserBox.Text.ToString(), PassBox.Text.ToString(), Convert.ToInt32(PrivBox.Text));
                }
                catch (Exception ex)
                {
                    Err2.Show();
                }
                this.Close();
            }
            else
            {
                Err1.Show();
                Err2.Show();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
