namespace Jarm_Game.Play_with_Account
{
    partial class frmcarplayernameAcc
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
            this.lblplayername = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.txtplayername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblplayername
            // 
            this.lblplayername.AutoSize = true;
            this.lblplayername.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayername.Location = new System.Drawing.Point(60, 33);
            this.lblplayername.Name = "lblplayername";
            this.lblplayername.Size = new System.Drawing.Size(258, 50);
            this.lblplayername.TabIndex = 5;
            this.lblplayername.Text = "Player Name";
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.Orange;
            this.btnstart.FlatAppearance.BorderSize = 0;
            this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstart.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(132, 176);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(101, 50);
            this.btnstart.TabIndex = 4;
            this.btnstart.Text = "Play";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // txtplayername
            // 
            this.txtplayername.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplayername.Location = new System.Drawing.Point(56, 121);
            this.txtplayername.Name = "txtplayername";
            this.txtplayername.Size = new System.Drawing.Size(262, 33);
            this.txtplayername.TabIndex = 3;
            this.txtplayername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmcarplayernameAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(365, 242);
            this.Controls.Add(this.lblplayername);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.txtplayername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcarplayernameAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcarplayernameAcc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblplayername;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.TextBox txtplayername;
    }
}