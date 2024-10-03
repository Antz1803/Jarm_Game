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

namespace Jarm_Game.Play_with_Account
{
    public partial class frmCarDodgeAcc : Form
    {
        clsCardodge cons = new clsCardodge();
        Antipaso Design = new Antipaso();
        public frmCarDodgeAcc(string playername)
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
      
        private void frmCarDodgeAcc_KeyUp(object sender, KeyEventArgs e)
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

        private void frmCarDodgeAcc_KeyDown(object sender, KeyEventArgs e)
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
            frmAccount acc = new frmAccount("","","","","","");
            acc.Show();
            this.Close();
        }

    }
}
