using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Admin : IAdmin
    {
        #region Instance Properties

        private string adminID;
        private string adminFirstName;
        private string adminLastName;
        private string userName;
        private string passWord;
        #endregion

        public string AdminID
        {
            get
            {
                return adminID;
            }
            set
            {
                adminID = value;
            }
        }

        public string AdminFirstName
        {
            get
            {
                return adminFirstName;
            }
            set
            {
                adminFirstName = value;
            }
        }

        public string AdminLastName
        {
            get
            {
                return adminLastName;
            }
            set
            {
                adminLastName = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public string Password
        {
            get
            {
                return passWord;
            }
            set
            {
                passWord = value;
            }
        }

        public Admin(string AdminID, string AdminFirstName, string AdminLastName, string UserName, string Password)
        {
            this.adminID = AdminID;
            this.adminFirstName = AdminFirstName;
            this.adminLastName = AdminLastName;
            this.userName = UserName;
            this.passWord = Password;


        }

    }
}
