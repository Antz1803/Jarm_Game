﻿namespace Jarm_Game
{
    partial class frmSubstraction1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubstraction1));
            this.lblMultiplication = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtanswer = new System.Windows.Forms.TextBox();
            this.btnpress = new System.Windows.Forms.Button();
            this.txtquestion = new System.Windows.Forms.TextBox();
            this.txtplayerturn = new System.Windows.Forms.TextBox();
            this.txtplayer2 = new System.Windows.Forms.TextBox();
            this.txtplayer1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMultiplication
            // 
            this.lblMultiplication.AutoSize = true;
            this.lblMultiplication.BackColor = System.Drawing.Color.Transparent;
            this.lblMultiplication.Font = new System.Drawing.Font("MV Boli", 45F, System.Drawing.FontStyle.Bold);
            this.lblMultiplication.Location = new System.Drawing.Point(343, 23);
            this.lblMultiplication.Name = "lblMultiplication";
            this.lblMultiplication.Size = new System.Drawing.Size(574, 79);
            this.lblMultiplication.TabIndex = 47;
            this.lblMultiplication.Text = "Substraction Game";
            // 
            // lblresult
            // 
            this.lblresult.BackColor = System.Drawing.Color.Transparent;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(252, 401);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(670, 82);
            this.lblresult.TabIndex = 48;
            this.lblresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtanswer
            // 
            this.txtanswer.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanswer.Location = new System.Drawing.Point(460, 330);
            this.txtanswer.Name = "txtanswer";
            this.txtanswer.Size = new System.Drawing.Size(172, 32);
            this.txtanswer.TabIndex = 59;
            // 
            // btnpress
            // 
            this.btnpress.BackColor = System.Drawing.Color.LightGreen;
            this.btnpress.FlatAppearance.BorderSize = 0;
            this.btnpress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpress.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpress.Location = new System.Drawing.Point(800, 323);
            this.btnpress.Name = "btnpress";
            this.btnpress.Size = new System.Drawing.Size(165, 42);
            this.btnpress.TabIndex = 58;
            this.btnpress.Text = "Submit";
            this.btnpress.UseVisualStyleBackColor = false;
            this.btnpress.Click += new System.EventHandler(this.btnpress_Click);
            // 
            // txtquestion
            // 
            this.txtquestion.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquestion.Location = new System.Drawing.Point(460, 277);
            this.txtquestion.Name = "txtquestion";
            this.txtquestion.ReadOnly = true;
            this.txtquestion.Size = new System.Drawing.Size(172, 32);
            this.txtquestion.TabIndex = 57;
            // 
            // txtplayerturn
            // 
            this.txtplayerturn.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplayerturn.Location = new System.Drawing.Point(460, 201);
            this.txtplayerturn.Name = "txtplayerturn";
            this.txtplayerturn.Size = new System.Drawing.Size(503, 32);
            this.txtplayerturn.TabIndex = 56;
            this.txtplayerturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtplayer2
            // 
            this.txtplayer2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplayer2.Location = new System.Drawing.Point(791, 131);
            this.txtplayer2.Name = "txtplayer2";
            this.txtplayer2.Size = new System.Drawing.Size(172, 32);
            this.txtplayer2.TabIndex = 55;
            // 
            // txtplayer1
            // 
            this.txtplayer1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplayer1.Location = new System.Drawing.Point(460, 131);
            this.txtplayer1.Name = "txtplayer1";
            this.txtplayer1.Size = new System.Drawing.Size(172, 32);
            this.txtplayer1.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 40);
            this.label4.TabIndex = 53;
            this.label4.Text = "Question:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 40);
            this.label3.TabIndex = 52;
            this.label3.Text = "Player\'s Turn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(650, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 40);
            this.label2.TabIndex = 51;
            this.label2.Text = "Player 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 40);
            this.label1.TabIndex = 50;
            this.label1.Text = "Player 1:";
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(800, 270);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(165, 42);
            this.btnRestart.TabIndex = 49;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // frmSubstraction1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jarm_Game.Properties.Resources.quesbakdes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 513);
            this.Controls.Add(this.lblMultiplication);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txtanswer);
            this.Controls.Add(this.btnpress);
            this.Controls.Add(this.txtquestion);
            this.Controls.Add(this.txtplayerturn);
            this.Controls.Add(this.txtplayer2);
            this.Controls.Add(this.txtplayer1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSubstraction1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSubstraction2";
            this.Load += new System.EventHandler(this.frmSubstraction1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMultiplication;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtanswer;
        private System.Windows.Forms.Button btnpress;
        private System.Windows.Forms.TextBox txtquestion;
        private System.Windows.Forms.TextBox txtplayerturn;
        private System.Windows.Forms.TextBox txtplayer2;
        private System.Windows.Forms.TextBox txtplayer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestart;
    }
}