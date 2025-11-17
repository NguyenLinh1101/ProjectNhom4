namespace ProjectNhom4
{
    partial class Baocaosachhong
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
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpNgayKT = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpNgayBĐ = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnXem = new Guna.UI2.WinForms.Guna2Button();
            this.cboKieuMuon = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer2.Location = new System.Drawing.Point(42, 290);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1128, 369);
            this.reportViewer2.TabIndex = 0;
            this.reportViewer2.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.label5.Location = new System.Drawing.Point(12, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1211, 54);
            this.label5.TabIndex = 1;
            this.label5.Text = "BÁO CÁO SÁCH HỎNG";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.dtpNgayKT);
            this.panel2.Controls.Add(this.dtpNgayBĐ);
            this.panel2.Controls.Add(this.guna2Button2);
            this.panel2.Controls.Add(this.btnXem);
            this.panel2.Controls.Add(this.cboKieuMuon);
            this.panel2.Controls.Add(this.reportViewer2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1235, 763);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.Checked = true;
            this.dtpNgayKT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtpNgayKT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayKT.Location = new System.Drawing.Point(423, 182);
            this.dtpNgayKT.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayKT.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(311, 40);
            this.dtpNgayKT.TabIndex = 9;
            this.dtpNgayKT.Value = new System.DateTime(2025, 11, 8, 14, 25, 22, 488);
            // 
            // dtpNgayBĐ
            // 
            this.dtpNgayBĐ.Checked = true;
            this.dtpNgayBĐ.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtpNgayBĐ.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayBĐ.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayBĐ.Location = new System.Drawing.Point(58, 182);
            this.dtpNgayBĐ.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayBĐ.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBĐ.Name = "dtpNgayBĐ";
            this.dtpNgayBĐ.Size = new System.Drawing.Size(311, 40);
            this.dtpNgayBĐ.TabIndex = 8;
            this.dtpNgayBĐ.Value = new System.DateTime(2025, 11, 8, 14, 25, 22, 488);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Red;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(945, 682);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(222, 54);
            this.guna2Button2.TabIndex = 7;
            this.guna2Button2.Text = "Thoát";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnXem
            // 
            this.btnXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(945, 230);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(222, 54);
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "Xem Báo Cáo";
            this.btnXem.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // cboKieuMuon
            // 
            this.cboKieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKieuMuon.FormattingEnabled = true;
            this.cboKieuMuon.Items.AddRange(new object[] {
            "Tại chỗ",
            "Mang về"});
            this.cboKieuMuon.Location = new System.Drawing.Point(806, 182);
            this.cboKieuMuon.Name = "cboKieuMuon";
            this.cboKieuMuon.Size = new System.Drawing.Size(198, 37);
            this.cboKieuMuon.TabIndex = 5;
            this.cboKieuMuon.SelectedIndexChanged += new System.EventHandler(this.cboKieuMuon_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(800, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 32);
            this.label8.TabIndex = 4;
            this.label8.Text = "Kiểu mượn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(417, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 32);
            this.label7.TabIndex = 3;
            this.label7.Text = "Đến ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(36, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Từ ngày";
            // 
            // Baocaosachhong
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1235, 763);
            this.Controls.Add(this.panel2);
            this.Name = "Baocaosachhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo sách hỏng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Baocaosachhong_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
      
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboKieuMuon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnXem;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayKT;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayBĐ;
    }
}