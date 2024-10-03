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
    public partial class frmArithmeticSolvingloading1 : Form
    {
        Antipaso Design = new Antipaso();
        public frmArithmeticSolvingloading1()
        {
            InitializeComponent();
            Design.IsVeryHuman(this);
        }

        private void tmrofarithmertic_Tick(object sender, EventArgs e)
        {
            pnlLoadingbar.Width += 10;
            if (pnlLoadingbar.Width >= 807) //Loading screen
            {
                tmrofarithmetic.Stop();
             frmPlayerNameAccount arithmetic = new frmPlayerNameAccount();
                this.Hide();
                arithmetic.ShowDialog();
            }
        }
    }
}
