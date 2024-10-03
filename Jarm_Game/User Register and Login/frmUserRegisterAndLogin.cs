using System;
using System.DesignProperty;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Jarm_Game
{
    public partial class frmUserRegisterAndLogin : Form
    {
        Antipaso Design = new Antipaso();
        clsLogin cons = new clsLogin();
        public frmUserRegisterAndLogin()
        {
            InitializeComponent();    
            lblincorrectpassword.Visible = false;
            pnllogin.Visible = false;
            Design.IsVeryHuman(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            //User input information form
            clsTwoPlayers info = new clsTwoPlayers(txtName.Text, txtNickname.Text, txtAge.Text, txtGender.Text, txtStatus.Text, txtGmail.Text);
            frmAccount account = new frmAccount(info.Name, info.Nickname, info.Age,info.Gender, info.Status , info.Gmail);

            //Password checker of characters and file writer
            cons.username = Convert.ToString(txtUsername.Text);
            cons.password = Convert.ToString(txtPassword.Text);
            var input = txtPassword.Text;
            var DapatNaayNumbers = new Regex(cons.number());
            var DapatNaayUpperChar = new Regex(cons.AtoZuppercase());
            var DapatNaayLowerChar = new Regex(cons.atozlowercase());
            var DapatNaaySymbols = new Regex(cons.specialsymbol());

            if (!DapatNaayUpperChar.IsMatch(input))  // Password must have a condition required example Jeo@1223
            {
                MessageBox.Show(cons.hasUpperChar(),
                    "Upper case required!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning); // Password must have Capital letter
            }
            else if (!DapatNaayLowerChar.IsMatch(input))
            {
                MessageBox.Show(cons.hasLowerChar(),
                    "Lower case required!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning); // Password must have Small letter
            }
            else if (!DapatNaayNumbers.IsMatch(input))
            {
                MessageBox.Show(cons.hasNumbers(),
                    "Numbers required!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning); // Password must have Numeric Value
            }
            else if (!DapatNaaySymbols.IsMatch(input))
            {
                MessageBox.Show(cons.hasSymbols(),
                    "Symbol required!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning); // Password must have Unique Symbol
            }
            else
            {
                if (txtUsername.Text != null && txtPassword.Text != null &&
                    txtUsername.Text != string.Empty && txtPassword.Text != string.Empty) // password cannot be null
                {
                    cons.registerdata(txtUsername, txtPassword);
                    MessageBox.Show("Successfully Register", "Register!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnllogin.Visible = true;
                }
                else
                {
                    MessageBox.Show("Please cannot be null", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }


        private void chkShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowpassword.Checked)
            {
                txtPassword.PasswordChar = '\0'; // show password
            }
            else
            {
                txtPassword.PasswordChar = '*'; // hide password
            }
        }

        private void chkShowpassword1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowpassword1.Checked)
            {
                txtPassword1.PasswordChar = '\0'; // show password
            }
            else
            {
                txtPassword1.PasswordChar = '*'; // hide password
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //Password checker of characters and file reader
            cons.username = Convert.ToString(txtUsername.Text);
            cons.password = Convert.ToString(txtPassword.Text);
            var input = txtPassword.Text;
            var DapatNaayNumbers = new Regex(cons.number());
            var DapatNaayUpperChar = new Regex(cons.AtoZuppercase());
            var DapatNaayLowerChar = new Regex(cons.atozlowercase());
            var DapatNaaySymbols = new Regex(cons.specialsymbol());

            if (!DapatNaayUpperChar.IsMatch(input))  // Password must have a condition required example Jeo@1223
            {
                MessageBox.Show(cons.hasUpperChar(),
                    "Upper case required!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning); // Password must have Capital letter
            }
            else if (!DapatNaayLowerChar.IsMatch(input))
            {
                MessageBox.Show(cons.hasLowerChar(),
                    "Lower case required!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning); // Password must have Small letter
            }
            else if (!DapatNaayNumbers.IsMatch(input))
            {
                MessageBox.Show(cons.hasNumbers(),
                    "Numbers required!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning); // Password must have Numeric Value
            }
            else if (!DapatNaaySymbols.IsMatch(input))
            {
                MessageBox.Show(cons.hasSymbols(),
                    "Symbol required!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning); // Password must have Unique Symbol
            }
            else
            {

                if (txtUsername.Text != null &&
                    txtPassword.Text != null &&
                    txtUsername.Text != string.Empty &&
                    txtPassword.Text != string.Empty) // password cannot be null
                {

                    cons.LoginReader(txtPassword1, lblincorrectpassword);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please cannot be null!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #region Button have any events   
        private void btnregister1_MouseEnter(object sender, EventArgs e)
        {
            btnregister.Show();
            btnregister1.Hide();
        }
        private void btnregister_MouseLeave(object sender, EventArgs e)
        {
            btnregister.Hide();
            btnregister1.Show();
        }

        private void btnlogin1_MouseEnter(object sender, EventArgs e)
        {
            btnlogin.Show();
            btnlogin1.Hide();
        }

        private void btnlogin_MouseLeave(object sender, EventArgs e)
        {
            btnlogin.Hide();
            btnlogin1.Show();
        }
        #endregion
        #region Button events to proceed other form

        private void pbxplayguest_Click(object sender, EventArgs e)
        {
            frmPlayUsGuest playguest = new frmPlayUsGuest();
            playguest.Show();
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmUserRegisterAndLogin home = new frmUserRegisterAndLogin();
            this.Close();
            home.ShowDialog();
        }
        private void btnback1_Click(object sender, EventArgs e)
        {
            frmUserRegisterAndLogin home = new frmUserRegisterAndLogin();
            this.Close();
            home.ShowDialog();
        }
        #endregion
    }
}












































































#region design is very human
namespace System.DesignProperty
{
    internal class Antipaso
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        internal static extern IntPtr CreateRoundRectRgn
(
int nLeftRect,
int nTopRect,
int nRightRect,
int nBottomRect,
int nWidthEllipse,
int nHeightEllipse
            );

        internal void IsVeryHuman(Control cons)
        {
            cons.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cons.Width, cons.Height, 50, 50));
        }
    }
}

#endregion