namespace ProjectNhom4
{
    partial class QLTacGia_Ribbon
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
            this.panelQLTacGia = new System.Windows.Forms.Panel();
            this.btnTacGiaSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnTacGia = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelQLTacGia.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQLTacGia
            // 
            this.panelQLTacGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelQLTacGia.Controls.Add(this.btnTacGiaSach);
            this.panelQLTacGia.Controls.Add(this.btnTacGia);
            this.panelQLTacGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQLTacGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panelQLTacGia.ForeColor = System.Drawing.Color.Black;
            this.panelQLTacGia.Location = new System.Drawing.Point(0, 0);
            this.panelQLTacGia.Name = "panelQLTacGia";
            this.panelQLTacGia.Size = new System.Drawing.Size(1316, 126);
            this.panelQLTacGia.TabIndex = 1;
            // 
            // btnTacGiaSach
            // 
            this.btnTacGiaSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnTacGiaSach.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTacGiaSach.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnTacGiaSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTacGiaSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTacGiaSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTacGiaSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTacGiaSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnTacGiaSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTacGiaSach.ForeColor = System.Drawing.Color.White;
            this.btnTacGiaSach.Location = new System.Drawing.Point(692, 24);
            this.btnTacGiaSach.MaximumSize = new System.Drawing.Size(247, 90);
            this.btnTacGiaSach.Name = "btnTacGiaSach";
            this.btnTacGiaSach.Size = new System.Drawing.Size(247, 90);
            this.btnTacGiaSach.TabIndex = 0;
            this.btnTacGiaSach.Text = "Tác giả sách";
            this.btnTacGiaSach.Click += new System.EventHandler(this.btnTacGiaSach_Click);
            // 
            // btnTacGia
            // 
            this.btnTacGia.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTacGia.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnTacGia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTacGia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTacGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTacGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTacGia.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnTacGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTacGia.ForeColor = System.Drawing.Color.White;
            this.btnTacGia.Location = new System.Drawing.Point(299, 24);
            this.btnTacGia.MaximumSize = new System.Drawing.Size(247, 90);
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.Size = new System.Drawing.Size(247, 90);
            this.btnTacGia.TabIndex = 0;
            this.btnTacGia.Text = "Tác giả";
            this.btnTacGia.Click += new System.EventHandler(this.btnTacGia_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 126);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1316, 765);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelContainer);
            this.panel1.Controls.Add(this.panelQLTacGia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 891);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // QLTacGia_Ribbon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "QLTacGia_Ribbon";
            this.Size = new System.Drawing.Size(1316, 891);
            this.Load += new System.EventHandler(this.QLTacGia_Ribbon_Load);
            this.panelQLTacGia.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQLTacGia;
        private Guna.UI2.WinForms.Guna2Button btnTacGiaSach;
        private Guna.UI2.WinForms.Guna2Button btnTacGia;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
    }
}