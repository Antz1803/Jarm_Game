using System;
using System.DesignProperty;
using System.Windows.Forms;

namespace Jarm_Game
{
    public partial class frmCarDodgeGuest : Form
    {
        clsCardodge cons = new clsCardodge();
        Antipaso Design = new Antipaso();

        public frmCarDodgeGuest(string playername)
        {
            InitializeComponent();
            lblgameover.Hide();
            pbxenemy.Visible = true;
            pbxplayer.Visible = true;
            pbxexplosion.Visible = !true;
            btntryagain.Visible = !true;
            lblplayername.Text = $"# {playername} #";
            Design.IsVeryHuman(this);
            btnExit.Visible = !true;
        }
        bool right, left;
        private void tmrofcardodge_Tick(object sender, EventArgs e)
        {
            cons.GameResult(pbxenemy, pbxplayer, pbxexplosion, tmrofcardodge, lblgameover, lblscore, btntryagain,btnExit);
            cons.EnemyMovement(pbxenemy);
            cons.Arrow_Key_Movement(right, left, pbxplayer);
        }

        private void frmCarDodge_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                right = !true;
            }

            if (e.KeyCode == Keys.Up)
            {
                left = !true;
            }
        }

        private void frmCarDodge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                right = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                left = true;
            }
        }

        private void btntryagain_Click(object sender, EventArgs e)
        {
            cons.GameReset(pbxenemy, pbxplayer, pbxexplosion, tmrofcardodge, lblgameover, lblscore);
            btntryagain.Visible = !true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmPlayUsGuest guest = new frmPlayUsGuest();
            guest.Show();
            this.Close();
        }

    }
}
