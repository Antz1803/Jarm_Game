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
    public partial class frmcarplayernameGuest : Form
    {
        Antipaso Design = new Antipaso();
        public frmcarplayernameGuest()
        {
            InitializeComponent();
            Design.IsVeryHuman(this);
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            clsTwoPlayers info = new clsTwoPlayers(txtplayername.Text);
            frmCarDodgeGuest proceed = new frmCarDodgeGuest(info.playername);
            proceed.Show();
            this.Hide();
        }
    }
}
