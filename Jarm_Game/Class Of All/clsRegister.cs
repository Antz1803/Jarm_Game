using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jarm_Game
{
    internal class clsRegister : clsAccount
    {
        private string Name;
        private string Nickname;
        private string Age;
        private string Gender;
        private string Status;
        private string Gmail;

        //Encapsulation of the data input
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string nickname
        {
            get { return Nickname; }
            set { Nickname = value; }
        }
        public string age
        {
            get { return Age; }
            set { Age = value; }
        }
        public string gender
        {
            get { return Gender; }
            set { Gender = value; }
        }
        public string status
        {
            get { return Status; }
            set { Status = value; }
        }
        public string gmail
        {
            get { return Gmail; }
            set { Gmail = value; }
        }

        public override void LoginReader(Control password1, Label incorrectpassword)
        {
            try
            {

                var cons = new System.IO.StreamReader
               ("C:\\" + password1.Text + "\\Account.ID"); // Password file Reader

                cons.Close();
                incorrectpassword.Visible = !true;
                frmAccount account = new frmAccount(name,nickname, age,gender,status,gmail);
                account.Show();
            }

            catch (System.IO.DirectoryNotFoundException)
            {
                incorrectpassword.Visible = true;
                incorrectpassword.Text = "Incorrect password !!! "; // Message of the user if the password wrong
            }
        }

        public override void registerdata(Control username, Control password)
        {
            try
            {
                var cons2 = new System.IO.StreamWriter("C:\\" + username.Text + password.Text + "\\Account.ID");
                cons2.Write(username.Text + "\n" + password.Text);
                cons2.Close();
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                System.IO.Directory.CreateDirectory("C:\\" + password.Text);
                var cons2 = new System.IO.StreamWriter("C:\\" + password.Text + "\\Account.ID");
                cons2.Write(username.Text + "\n" + password.Text);
                cons2.Close();
            }
        }
        public string DisplayProfile()
        {
            return "\n" + "PROFILE INFORMATION\n" + "\n" + $"Name:{Name}" + $"\nNickname: {Nickname}" + $"\nAge: {Age}" + $"\nGender: {Gender}" + $"\nStatus: {Status}" + $"\nGmail: {Gmail}";
        }


        public string number()
        {
            return @"[0-9]+";
        }
        public string AtoZuppercase()
        {
            return @"[A-Z]+";

        }
        public string atozlowercase()
        {
            return @"[a-z]+";

        }
        public string specialsymbol()
        {
            return @"[!@#$%^&*()_+=\[{\]};:<>]+";

        }
    }
}
