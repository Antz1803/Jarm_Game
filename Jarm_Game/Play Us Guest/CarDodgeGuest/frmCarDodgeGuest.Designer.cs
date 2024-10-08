﻿namespace Jarm_Game
{
    partial class frmCarDodgeGuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarDodgeGuest));
            this.pbxexplosion = new System.Windows.Forms.PictureBox();
            this.pbxplayer = new System.Windows.Forms.PictureBox();
            this.pbxenemy = new System.Windows.Forms.PictureBox();
            this.tmrofcardodge = new System.Windows.Forms.Timer(this.components);
            this.lblgameover = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.btntryagain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblplayername = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxexplosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxenemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxexplosion
            // 
            this.pbxexplosion.BackColor = System.Drawing.Color.Transparent;
            this.pbxexplosion.Image = global::Jarm_Game.Properties.Resources.explosion;
            this.pbxexplosion.Location = new System.Drawing.Point(314, 190);
            this.pbxexplosion.Name = "pbxexplosion";
            this.pbxexplosion.Size = new System.Drawing.Size(168, 91);
            this.pbxexplosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxexplosion.TabIndex = 0;
            this.pbxexplosion.TabStop = false;
            // 
            // pbxplayer
            // 
            this.pbxplayer.BackColor = System.Drawing.Color.Transparent;
            this.pbxplayer.Image = global::Jarm_Game.Properties.Resources.output_onlinepngtools__7_;
            this.pbxplayer.Location = new System.Drawing.Point(283, 494);
            this.pbxplayer.Name = "pbxplayer";
            this.pbxplayer.Size = new System.Drawing.Size(214, 125);
            this.pbxplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxplayer.TabIndex = 1;
            this.pbxplayer.TabStop = false;
            // 
            // pbxenemy
            // 
            this.pbxenemy.BackColor = System.Drawing.Color.Transparent;
            this.pbxenemy.Image = global::Jarm_Game.Properties.Resources.output_onlinepngtools__9_;
            this.pbxenemy.Location = new System.Drawing.Point(876, 140);
            this.pbxenemy.Name = "pbxenemy";
            this.pbxenemy.Size = new System.Drawing.Size(214, 125);
            this.pbxenemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxenemy.TabIndex = 2;
            this.pbxenemy.TabStop = false;
            // 
            // tmrofcardodge
            // 
            this.tmrofcardodge.Enabled = true;
            this.tmrofcardodge.Interval = 45;
            this.tmrofcardodge.Tick += new System.EventHandler(this.tmrofcardodge_Tick);
            // 
            // lblgameover
            // 
            this.lblgameover.AutoSize = true;
            this.lblgameover.BackColor = System.Drawing.Color.Transparent;
            this.lblgameover.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgameover.ForeColor = System.Drawing.Color.Cyan;
            this.lblgameover.Location = new System.Drawing.Point(650, 387);
            this.lblgameover.Name = "lblgameover";
            this.lblgameover.Size = new System.Drawing.Size(297, 64);
            this.lblgameover.TabIndex = 3;
            this.lblgameover.Text = "Game Over";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.DimGray;
            this.lblscore.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.ForeColor = System.Drawing.Color.Black;
            this.lblscore.Location = new System.Drawing.Point(183, 265);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(42, 46);
            this.lblscore.TabIndex = 4;
            this.lblscore.Text = "0";
            // 
            // btntryagain
            // 
            this.btntryagain.BackColor = System.Drawing.Color.Goldenrod;
            this.btntryagain.FlatAppearance.BorderSize = 0;
            this.btntryagain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntryagain.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntryagain.Location = new System.Drawing.Point(31, 524);
            this.btntryagain.Name = "btntryagain";
            this.btntryagain.Size = new System.Drawing.Size(90, 62);
            this.btntryagain.TabIndex = 0;
            this.btntryagain.TabStop = false;
            this.btntryagain.Text = "Try Again!";
            this.btntryagain.UseVisualStyleBackColor = false;
            this.btntryagain.Click += new System.EventHandler(this.btntryagain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Jarm_Game.Properties.Resources.cardodgebak;
            this.pictureBox1.Location = new System.Drawing.Point(-16, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 694);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblplayername
            // 
            this.lblplayername.BackColor = System.Drawing.Color.DimGray;
            this.lblplayername.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayername.Location = new System.Drawing.Point(32, 157);
            this.lblplayername.Name = "lblplayername";
            this.lblplayername.Size = new System.Drawing.Size(183, 43);
            this.lblplayername.TabIndex = 6;
            this.lblplayername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Goldenrod;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(128, 524);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 62);
            this.btnExit.TabIndex = 16;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit!";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCarDodgeGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Jarm_Game.Properties.Resources.Car_Dodge;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1090, 690);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblplayername);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.btntryagain);
            this.Controls.Add(this.lblgameover);
            this.Controls.Add(this.pbxplayer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxenemy);
            this.Controls.Add(this.pbxexplosion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCarDodgeGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCarDodge";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCarDodge_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmCarDodge_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbxexplosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxenemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxexplosion;
        private System.Windows.Forms.PictureBox pbxplayer;
        private System.Windows.Forms.PictureBox pbxenemy;
        private System.Windows.Forms.Timer tmrofcardodge;
        private System.Windows.Forms.Label lblgameover;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Button btntryagain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblplayername;
        private System.Windows.Forms.Button btnExit;
    }
}