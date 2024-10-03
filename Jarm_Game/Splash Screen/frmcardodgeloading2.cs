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
    public partial class frmcardodgeloading2 : Form
    {
        Antipaso Design = new Antipaso();
        public frmcardodgeloading2()
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
                frmcarplayernameGuest car = new frmcarplayernameGuest();
                this.Hide();
                car.ShowDialog();
            }
        }
    }
}
