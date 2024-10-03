namespace Jarm_Game
{
    partial class frmArithmeticSolvingloading1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArithmeticSolvingloading1));
            this.pnlLoadingbar = new System.Windows.Forms.Panel();
            this.pnlloadingbak = new System.Windows.Forms.Panel();
            this.tmrofarithmetic = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlLoadingbar
            // 
            this.pnlLoadingbar.BackColor = System.Drawing.Color.Red;
            this.pnlLoadingbar.Location = new System.Drawing.Point(-1, 419);
            this.pnlLoadingbar.Name = "pnlLoadingbar";
            this.pnlLoadingbar.Size = new System.Drawing.Size(37, 31);
            this.pnlLoadingbar.TabIndex = 7;
            // 
            // pnlloadingbak
            // 
            this.pnlloadingbak.BackColor = System.Drawing.Color.Silver;
            this.pnlloadingbak.Location = new System.Drawing.Point(-2, 419);
            this.pnlloadingbak.Name = "pnlloadingbak";
            this.pnlloadingbak.Size = new System.Drawing.Size(805, 31);
            this.pnlloadingbak.TabIndex = 6;
            // 
            // tmrofarithmetic
            // 
            this.tmrofarithmetic.Enabled = true;
            this.tmrofarithmetic.Interval = 35;
            this.tmrofarithmetic.Tick += new System.EventHandler(this.tmrofarithmertic_Tick);
            // 
            // frmArithmeticSolvingloading1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jarm_Game.Properties.Resources.ArithmeticSolving;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLoadingbar);
            this.Controls.Add(this.pnlloadingbak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArithmeticSolvingloading1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArithmeticSolvingloading";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoadingbar;
        private System.Windows.Forms.Panel pnlloadingbak;
        private System.Windows.Forms.Timer tmrofarithmetic;
    }
}