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
    public partial class frmcarplayernameAcc : Form
    {
        Antipaso Design = new Antipaso();
        public frmcarplayernameAcc()
        {
            InitializeComponent();
            Design.IsVeryHuman(this);
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            clsTwoPlayers info = new clsTwoPlayers(txtplayername.Text);
            frmCarDodgeAcc proceed = new frmCarDodgeAcc(info.playername);
            proceed.Show();
            this.Hide();
        }
    }
}
