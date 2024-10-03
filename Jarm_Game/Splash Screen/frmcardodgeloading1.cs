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
using Jarm_Game.Play_with_Account;
namespace Jarm_Game.Splash_Screen
{
    public partial class frmcardodgeloading1 : Form
    {
        Antipaso Design = new Antipaso();
        public frmcardodgeloading1()
        {
            InitializeComponent();
            Design.IsVeryHuman(this);
        }

        private void tmrcarloading_Tick(object sender, EventArgs e)
        {
            pnlLoadingbar.Width += 10;
            pbxcar1.Left += 10;
            if (pnlLoadingbar.Width >= 807) //Loading screen
            {
                tmrcarloading.Stop();
                frmcarplayernameAcc car = new frmcarplayernameAcc();
                this.Hide();
                car.ShowDialog();
            }
        }
    }
}
