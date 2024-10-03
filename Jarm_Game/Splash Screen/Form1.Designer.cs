namespace Jarm_Game
{
    partial class frmSplashscreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashscreen));
            this.pnlLoadingbar = new System.Windows.Forms.Panel();
            this.pnlloadingbak = new System.Windows.Forms.Panel();
            this.tmrOfSplashScreen = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlLoadingbar
            // 
            this.pnlLoadingbar.BackColor = System.Drawing.Color.Red;
            this.pnlLoadingbar.Location = new System.Drawing.Point(-2, 653);
            this.pnlLoadingbar.Name = "pnlLoadingbar";
            this.pnlLoadingbar.Size = new System.Drawing.Size(37, 37);
            this.pnlLoadingbar.TabIndex = 3;
            // 
            // pnlloadingbak
            // 
            this.pnlloadingbak.BackColor = System.Drawing.Color.Silver;
            this.pnlloadingbak.Location = new System.Drawing.Point(-2, 653);
            this.pnlloadingbak.Name = "pnlloadingbak";
            this.pnlloadingbak.Size = new System.Drawing.Size(975, 37);
            this.pnlloadingbak.TabIndex = 2;
            // 
            // tmrOfSplashScreen
            // 
            this.tmrOfSplashScreen.Enabled = true;
            this.tmrOfSplashScreen.Interval = 35;
            this.tmrOfSplashScreen.Tick += new System.EventHandler(this.tmrOfSplashScreen_Tick);
            // 
            // frmSplashscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 690);
            this.Controls.Add(this.pnlLoadingbar);
            this.Controls.Add(this.pnlloadingbak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplashscreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoadingbar;
        private System.Windows.Forms.Panel pnlloadingbak;
        private System.Windows.Forms.Timer tmrOfSplashScreen;
    }
}

