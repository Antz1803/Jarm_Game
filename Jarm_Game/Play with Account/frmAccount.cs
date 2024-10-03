using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.DesignProperty;
using Jarm_Game.Splash_Screen;

namespace Jarm_Game
{
    public partial class frmAccount : Form
    {
        Antipaso Design = new Antipaso();
        clsLogin cons = new clsLogin();
        public frmAccount(string name, string nickname, string age, string gender ,string status, string gmail)
        {
            InitializeComponent();
            Design.IsVeryHuman(this);
            pnlgamemenu.Visible = false;
            pnlprofile.Visible = false;
            pnlAboutUs.Visible = false;
            lblresultprofile.Visible = false;
            pbxselect1.Hide();
            pbxselect2.Hide();
            pbxselect3.Hide();
            pbxselect4.Hide();
            pbxselect5.Hide();
            pbxselect6.Hide();
            pnlgamemenu.Visible = false;
            pnlprofile.Visible = false;
            pnlAboutUs.Visible = false;
            lblresultprofile.Text = "\n" + "PROFILE INFORMATION\n" + "\n" + $"Name: {name}" + $"\nNickname: {nickname}" + $"\nAge: {age}" + $"\nGender: {gender}" + $"\nStatus: {status}" + $"\nGmail: {gmail}";
        }

        private void btngamemenu_Click(object sender, EventArgs e)
        {
            pnlgamemenu.Visible = true;
            pnlAboutUs.Visible = false;
            pnlprofile.Visible = false;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
           
            lblresultprofile.Visible = true;
            pnlprofile.Visible = true;
            pnlgamemenu.Visible = false;
            pnlAboutUs.Visible = false;
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            pnlAboutUs.Visible = true;
            pnlgamemenu.Visible = false;
            pnlprofile.Visible = false;
            lblresult.Text = cons.DisplayAboutUs();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmUserRegisterAndLogin home = new frmUserRegisterAndLogin();
            this.Close();
            home.ShowDialog();
        }

        private void btncardodge_Click(object sender, EventArgs e)
        {
            frmcardodgeloading1 carDodge1 = new frmcardodgeloading1();
            this.Hide();
            carDodge1.ShowDialog();
        }

        private void btnarithmeticsolving1_Click(object sender, EventArgs e)
        {
            frmArithmeticSolvingloading1 arithmetic = new frmArithmeticSolvingloading1();
            this.Hide();
            arithmetic.ShowDialog();
        }
        #region button have animated
        private void btngamemenu_MouseEnter(object sender, EventArgs e)
        {
            pbxselect1.Show();
            pbxselect2.Hide();
            pbxselect3.Hide();
            pbxselect4.Hide();
            pbxselect5.Hide();
            pbxselect6.Hide();
        }

        private void btngamemenu_MouseLeave(object sender, EventArgs e)
        {
            pbxselect1.Hide();
            pbxselect2.Hide();
            pbxselect3.Hide();
            pbxselect4.Hide();
            pbxselect5.Hide();
            pbxselect6.Hide();
        }

        private void btnProfile_MouseEnter(object sender, EventArgs e)
        {
            pbxselect1.Hide();
            pbxselect2.Show();
            pbxselect3.Hide();
            pbxselect4.Hide();
            pbxselect5.Hide();
            pbxselect6.Hide();
        }

        private void btnProfile_MouseLeave(object sender, EventArgs e)
        {
            pbxselect1.Hide();
            pbxselect2.Hide();
            pbxselect3.Hide();
            pbxselect4.Hide();
            pbxselect5.Hide();
            pbxselect6.Hide();
        }

        private void btnAboutUs_MouseEnter(object sender, EventArgs e)
        {
            pbxselect1.Hide();
            pbxselect2.Hide();
            pbxselect3.Show();
            pbxselect4.Hide();
            pbxselect5.Hide();
            pbxselect6.Hide();
        }

        private void btnAboutUs_MouseLeave(object sender, EventArgs e)
        {
            pbxselect1.Hide();
            pbxselect2.Hide();
            pbxselect3.Hide();
            pbxselect4.Hide();
            pbxselect5.Hide();
            pbxselect6.Hide();
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            pbxselect1.Hide();
            pbxselect2.Hide();
            pbxselect3.Hide();
            pbxselect4.Show();
            pbxselect5.Hide();
            pbxselect6.Hide();
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            pbxselect1.Hide();
            pbxselect2.Hide();
            pbxselect3.Hide();
            pbxselect4.Hide();
            pbxselect5.Hide();
            pbxselect6.Hide();
        }

        private void btncardodge_MouseEnter(object sender, EventArgs e)
        {
            pbxselect1.Hide();
            pbxselect2.Hide();
            pbxselect3.Hide();
            pbxselect4.Hide();
            pbxselect5.Show();
            pbxselect6.Hide();
        }

        private void btncardodge_MouseLeave(object sender, EventArgs e)
        {
            pbxselect1.Hide();
            pbxselect2.Hide();
            pbxselect3.Hide();
            pbxselect4.Hide();
            pbxselect5.Hide();
            pbxselect6.Hide();
        }

        private void btnarithmeticsolving1_MouseEnter(object sender, EventArgs e)
        {
            pbxselect1.Hide();
            pbxselect2.Hide();
            pbxselect3.Hide();
            pbxselect4.Hide();
            pbxselect5.Hide();
            pbxselect6.Show();
        }

        private void btnarithmeticsolving1_MouseLeave(object sender, EventArgs e)
        {
            pbxselect1.Hide();
            pbxselect2.Hide();
            pbxselect3.Hide();
            pbxselect4.Hide();
            pbxselect5.Hide();
            pbxselect6.Hide();
        }
        #endregion
    }
}
