namespace ProjectNhom4
{
    partial class QLSach_Ribbon
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
            this.components = new System.ComponentModel.Container();
            this.panelQLSach = new System.Windows.Forms.Panel();
            this.btnCuonSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnDauSach = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dropDown_DanhMuc = new System.Windows.Forms.Panel();
            this.btnDanhMuc = new Guna.UI2.WinForms.Guna2Button();
            this.btnChuDe = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoaiSach = new Guna.UI2.WinForms.Guna2Button();
            this.panelQLSach.SuspendLayout();
            this.dropDown_DanhMuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQLSach
            // 
            this.panelQLSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelQLSach.Controls.Add(this.btnCuonSach);
            this.panelQLSach.Controls.Add(this.btnDauSach);
            this.panelQLSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQLSach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panelQLSach.ForeColor = System.Drawing.Color.Black;
            this.panelQLSach.Location = new System.Drawing.Point(0, 0);
            this.panelQLSach.Name = "panelQLSach";
            this.panelQLSach.Size = new System.Drawing.Size(1131, 120);
            this.panelQLSach.TabIndex = 0;
            this.panelQLSach.Paint += new System.Windows.Forms.PaintEventHandler(this.panelQLSach_Paint);
            // 
            // btnCuonSach
            // 
            this.btnCuonSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnCuonSach.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCuonSach.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnCuonSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCuonSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCuonSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCuonSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCuonSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnCuonSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCuonSach.ForeColor = System.Drawing.Color.White;
            this.btnCuonSach.Location = new System.Drawing.Point(405, 19);
            this.btnCuonSach.MaximumSize = new System.Drawing.Size(247, 90);
            this.btnCuonSach.Name = "btnCuonSach";
            this.btnCuonSach.Size = new System.Drawing.Size(247, 90);
            this.btnCuonSach.TabIndex = 0;
            this.btnCuonSach.Text = "Cuốn sách";
            this.btnCuonSach.Click += new System.EventHandler(this.btnCuonSach_Click);
            // 
            // btnDauSach
            // 
            this.btnDauSach.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDauSach.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnDauSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDauSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDauSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDauSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDauSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnDauSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDauSach.ForeColor = System.Drawing.Color.White;
            this.btnDauSach.Location = new System.Drawing.Point(26, 19);
            this.btnDauSach.MaximumSize = new System.Drawing.Size(247, 90);
            this.btnDauSach.Name = "btnDauSach";
            this.btnDauSach.Size = new System.Drawing.Size(247, 90);
            this.btnDauSach.TabIndex = 0;
            this.btnDauSach.Text = "Đầu sách";
            this.btnDauSach.Click += new System.EventHandler(this.btnDauSach_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 120);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1131, 629);
            this.panelContainer.TabIndex = 1;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelQLSach_contain_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dropDown_DanhMuc
            // 
            this.dropDown_DanhMuc.Controls.Add(this.btnDanhMuc);
            this.dropDown_DanhMuc.Controls.Add(this.btnChuDe);
            this.dropDown_DanhMuc.Controls.Add(this.btnLoaiSach);
            this.dropDown_DanhMuc.Location = new System.Drawing.Point(777, 19);
            this.dropDown_DanhMuc.MaximumSize = new System.Drawing.Size(247, 404);
            this.dropDown_DanhMuc.MinimumSize = new System.Drawing.Size(247, 90);
            this.dropDown_DanhMuc.Name = "dropDown_DanhMuc";
            this.dropDown_DanhMuc.Size = new System.Drawing.Size(247, 90);
            this.dropDown_DanhMuc.TabIndex = 3;
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.BackColor = System.Drawing.SystemColors.Control;
            this.btnDanhMuc.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDanhMuc.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnDanhMuc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDanhMuc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDanhMuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDanhMuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDanhMuc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDanhMuc.ForeColor = System.Drawing.Color.White;
            this.btnDanhMuc.Image = global::ProjectNhom4.Properties.Resources.down_chevron;
            this.btnDanhMuc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDanhMuc.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnDanhMuc.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.btnDanhMuc.MaximumSize = new System.Drawing.Size(247, 90);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnDanhMuc.Size = new System.Drawing.Size(247, 90);
            this.btnDanhMuc.TabIndex = 1;
            this.btnDanhMuc.Text = "Danh mục";
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click_1);
            // 
            // btnChuDe
            // 
            this.btnChuDe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChuDe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChuDe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChuDe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChuDe.FillColor = System.Drawing.Color.White;
            this.btnChuDe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChuDe.ForeColor = System.Drawing.Color.Firebrick;
            this.btnChuDe.Location = new System.Drawing.Point(12, 205);
            this.btnChuDe.Name = "btnChuDe";
            this.btnChuDe.Size = new System.Drawing.Size(221, 64);
            this.btnChuDe.TabIndex = 1;
            this.btnChuDe.Text = "Chủ Đề";
            this.btnChuDe.Click += new System.EventHandler(this.btnChuDe_Click);
            // 
            // btnLoaiSach
            // 
            this.btnLoaiSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoaiSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoaiSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoaiSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoaiSach.FillColor = System.Drawing.Color.White;
            this.btnLoaiSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoaiSach.ForeColor = System.Drawing.Color.Firebrick;
            this.btnLoaiSach.Location = new System.Drawing.Point(12, 110);
            this.btnLoaiSach.Name = "btnLoaiSach";
            this.btnLoaiSach.Size = new System.Drawing.Size(221, 64);
            this.btnLoaiSach.TabIndex = 2;
            this.btnLoaiSach.Text = "Loại Sách";
            this.btnLoaiSach.Click += new System.EventHandler(this.btnLoaiSach_Click);
            // 
            // QLSach_Ribbon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dropDown_DanhMuc);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelQLSach);
            this.Name = "QLSach_Ribbon";
            this.Size = new System.Drawing.Size(1131, 749);
            this.panelQLSach.ResumeLayout(false);
            this.dropDown_DanhMuc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQLSach;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button btnDauSach;
        private Guna.UI2.WinForms.Guna2Button btnCuonSach;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel dropDown_DanhMuc;
        private Guna.UI2.WinForms.Guna2Button btnDanhMuc;
        private Guna.UI2.WinForms.Guna2Button btnChuDe;
        private Guna.UI2.WinForms.Guna2Button btnLoaiSach;
    }
}
