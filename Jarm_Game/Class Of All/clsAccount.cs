using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jarm_Game
{
    abstract class clsAccount
    {
        private string Username;
        private string Password;

        public string username
        {
            get { return Username; }
            set { Username = value; }
        }
        public string password
        {
            get { return Password; }
            set { Password = value; }

        }

        public abstract void LoginReader(Control password1, Label incorrectpassword);
        public abstract void registerdata(Control username, Control password);
    }
}
