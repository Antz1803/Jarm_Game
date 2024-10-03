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
    public partial class frmArithmeticSolvingloading2 : Form
    {
        Antipaso Design = new Antipaso();
        public frmArithmeticSolvingloading2()
        {
            InitializeComponent();
            Design.IsVeryHuman(this);
        }

        private void tmrofarithmetic_Tick(object sender, EventArgs e)
        {
            pnlLoadingbar.Width += 10;
            if (pnlLoadingbar.Width >= 807) //Loading screen
            {
                tmrofarithmetic.Stop();
                frmPlayerNameGuest arithmetic = new frmPlayerNameGuest();
                this.Hide();
                arithmetic.ShowDialog();
            }
        }
    }
}
