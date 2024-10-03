namespace Jarm_Game.Splash_Screen
{
    partial class frmcardodgeloading1
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
            this.pnlloadingbak = new System.Windows.Forms.Panel();
            this.pbxcar1 = new System.Windows.Forms.PictureBox();
            this.pnlLoadingbar = new System.Windows.Forms.Panel();
            this.tmrcarloading = new System.Windows.Forms.Timer(this.components);
            this.pnlloadingbak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxcar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlloadingbak
            // 
            this.pnlloadingbak.BackColor = System.Drawing.Color.Silver;
            this.pnlloadingbak.Controls.Add(this.pnlLoadingbar);
            this.pnlloadingbak.Controls.Add(this.pbxcar1);
            this.pnlloadingbak.Location = new System.Drawing.Point(-2, 419);
            this.pnlloadingbak.Name = "pnlloadingbak";
            this.pnlloadingbak.Size = new System.Drawing.Size(805, 31);
            this.pnlloadingbak.TabIndex = 5;
            // 
            // pbxcar1
            // 
            this.pbxcar1.Image = global::Jarm_Game.Properties.Resources.output_onlinepngtools__7_;
            this.pbxcar1.Location = new System.Drawing.Point(38, 0);
            this.pbxcar1.Name = "pbxcar1";
            this.pbxcar1.Size = new System.Drawing.Size(75, 31);
            this.pbxcar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxcar1.TabIndex = 0;
            this.pbxcar1.TabStop = false;
            // 
            // pnlLoadingbar
            // 
            this.pnlLoadingbar.BackColor = System.Drawing.Color.Red;
            this.pnlLoadingbar.Location = new System.Drawing.Point(2, 0);
            this.pnlLoadingbar.Name = "pnlLoadingbar";
            this.pnlLoadingbar.Size = new System.Drawing.Size(37, 31);
            this.pnlLoadingbar.TabIndex = 6;
            // 
            // tmrcarloading
            // 
            this.tmrcarloading.Enabled = true;
            this.tmrcarloading.Interval = 35;
            this.tmrcarloading.Tick += new System.EventHandler(this.tmrcarloading_Tick);
            // 
            // frmcardodgeloading1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jarm_Game.Properties.Resources.Picsart_23_04_24_10_49_27_021;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlloadingbak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcardodgeloading1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcardodgeloading1";
            this.pnlloadingbak.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxcar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlloadingbak;
        private System.Windows.Forms.PictureBox pbxcar1;
        private System.Windows.Forms.Panel pnlLoadingbar;
        private System.Windows.Forms.Timer tmrcarloading;
    }
}