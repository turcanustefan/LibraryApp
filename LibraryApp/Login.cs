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
    public partial class Login : Form
    {
        private Operations linkBussinessLayer;
        public Login()
        {
            InitializeComponent();
            linkBussinessLayer = new Operations();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            
            String user = UserBox.Text;
            String pass = PasswordBox.Text;
            if (linkBussinessLayer.verifyUser(user,pass) > 0)
            {
                LibAppUI appInterface = new LibAppUI(this, linkBussinessLayer.getUserPrivilege(user, pass), user);
                appInterface.Show();
                this.Hide();
            }
            else
            {
                IncorrectText.Show();
            }
        }
    }
}
