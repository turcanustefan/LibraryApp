using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class valueObject
    {
        private bool authenticatedFlag;
        private int mPrivilege;
        private string mUsername;
        private string mPassword;

        public bool authenticate
        {
            get
            {
                return authenticatedFlag;
            }
            set
            {
                authenticatedFlag = value;
            }
        }
        public int privilege
        {
            get
            {
                return mPrivilege;
            }
            set
            {
                mPrivilege = value;
            }
        }
        public string username
        {
            get
            {
                return mUsername;
            }
            set
            {
                mUsername = value;
            }
        }
        public string password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }
    }
}
