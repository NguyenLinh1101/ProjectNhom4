﻿namespace ProjectNhom4
{
    partial class UC_TrangChu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pic1Background = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblXinchao = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1Background)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.lblXinchao);
            this.pnlMain.Controls.Add(this.pic1Background);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1991, 1284);
            this.pnlMain.TabIndex = 2;
            // 
            // pic1Background
            // 
            this.pic1Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic1Background.Image = global::ProjectNhom4.Properties.Resources.hustthuvien;
            this.pic1Background.ImageRotate = 0F;
            this.pic1Background.Location = new System.Drawing.Point(0, 0);
            this.pic1Background.Name = "pic1Background";
            this.pic1Background.Size = new System.Drawing.Size(1991, 1284);
            this.pic1Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1Background.TabIndex = 0;
            this.pic1Background.TabStop = false;
            // 
            // lblXinchao
            // 
            this.lblXinchao.AutoSize = true;
            this.lblXinchao.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblXinchao.Location = new System.Drawing.Point(1446, 13);
            this.lblXinchao.Name = "lblXinchao";
            this.lblXinchao.Size = new System.Drawing.Size(517, 38);
            this.lblXinchao.TabIndex = 1;
            this.lblXinchao.Text = "Chào mừng trở lại, (Tên người dùng)!";
            // 
            // UC_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "UC_TrangChu";
            this.Size = new System.Drawing.Size(1991, 1284);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1Background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2PictureBox pic1Background;
        private System.Windows.Forms.Label lblXinchao;
    }
}
