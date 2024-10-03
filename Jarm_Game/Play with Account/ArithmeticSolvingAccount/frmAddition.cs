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
    public partial class frmAddition : Form
    {
        Antipaso Design = new Antipaso();
        public frmAddition(string P1, string P2)
        {
            InitializeComponent();
            txtplayer1.Text = P1;
            txtplayer2.Text = P2;

            Design.IsVeryHuman(this);
        }
        int prod;
        clsAddition question = new clsAddition("", "");
        Random random = new Random();
        public void Question(int ope1, int ope2) // This void has a function that give the random value 
        {
            txtquestion.Text = $"{ope1} + {ope2}?";
        }
        private void frmAddition_Load(object sender, EventArgs e)
        {
            Question(question.ope1, question.ope2);
            Players();
            prod = question.Answer();
        }
        public void Players() //
        {
            clsTwoPlayers PlayerName = new clsTwoPlayers(txtplayer1.Text, txtplayer2.Text);
            if (question.pl % 2 == 0)
            {
                txtplayerturn.Text = PlayerName.Player1Turn().ToString();
                txtplayer1.BackColor = Color.Yellow;
                txtplayerturn.BackColor = Color.Yellow;
                txtplayer2.BackColor = Color.White;
            }
            else
            {
                txtplayerturn.Text = PlayerName.Player2Turn().ToString();
                txtplayer2.BackColor = Color.PaleGreen;
                txtplayerturn.BackColor = Color.PaleGreen;
                txtplayer1.BackColor = Color.White;
            }
            txtanswer.Focus();
        }
        private void btnpress_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtanswer.Text) == prod)
            {
                question.pl = (question.pl + 1) % 2;
                Players();
                Question(question.ope1 = random.Next(1, 11), question.ope2 = random.Next(1, 11));
                prod = question.Answer();
                txtanswer.Text = " ";
            }
            else
            {
                clsTwoPlayers result = new clsTwoPlayers(txtplayer1.Text, txtplayer2.Text);
                if (question.pl == 0)
                {
                    lblresult.Text = result.Player1Loses().ToString();
                }
                else
                {
                    lblresult.Text = result.Player2Loses().ToString();
                }
                txtanswer.Hide();
                btnpress.Hide();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //Restart the Game
            frmPlayerNameAccount PlayerNames = new frmPlayerNameAccount();
            PlayerNames.Show();
            this.Close();
        }
    }
}
