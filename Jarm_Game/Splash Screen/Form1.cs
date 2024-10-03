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
    public partial class frmSplashscreen : Form
    {
        Antipaso Design = new Antipaso();
        public frmSplashscreen()
        {
            InitializeComponent();
            Design.IsVeryHuman(this);
        }

        private void tmrOfSplashScreen_Tick(object sender, EventArgs e)
        {
            pnlLoadingbar.Width += 15;
            if (pnlLoadingbar.Width >= 1000) //Loading screen
            {
                tmrOfSplashScreen.Stop();
                frmUserRegisterAndLogin register = new frmUserRegisterAndLogin();
                this.Hide();
                register.ShowDialog();
            }
        }
    }
}
