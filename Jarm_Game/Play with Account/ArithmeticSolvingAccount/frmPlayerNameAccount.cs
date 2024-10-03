using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DesignProperty;
namespace Jarm_Game
{
    public partial class frmPlayerNameAccount : Form
    {
        Antipaso Design = new Antipaso();
        public frmPlayerNameAccount()
        {
            InitializeComponent();
            Design.IsVeryHuman(this);
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The rules are laided out in this manner:" +
              " \n\nEvery player answers alternately once they answer, " +
              "meaning if one answers, it proceeds to another player. " +
              "If one player wrongly answers, then the other player wins.",
              "Rules of Multiplication Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            clsTwoPlayers info = new clsTwoPlayers(txtplayer1.Text, txtplayer2.Text);
            frmAddition proceed = new frmAddition(info.p1, info.p2);
            proceed.Show();
            this.Hide();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            clsTwoPlayers info = new clsTwoPlayers(txtplayer1.Text, txtplayer2.Text);
            frmSubstraction proceed = new frmSubstraction(info.p1, info.p2);
            proceed.Show();
            this.Hide();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            clsTwoPlayers info2 = new clsTwoPlayers(txtplayer1.Text, txtplayer2.Text);
            frmMultiplication proceed = new frmMultiplication(info2.p1, info2.p2);
            proceed.Show();
            this.Hide();
        }

        private void btnback1_Click(object sender, EventArgs e)
        {
            frmAccount PlayerAccount = new frmAccount(" "," "," "," "," "," ");
            PlayerAccount.Show();
            this.Close();
        }
    }
}
