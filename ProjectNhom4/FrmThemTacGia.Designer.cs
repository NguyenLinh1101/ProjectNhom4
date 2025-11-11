namespace ProjectNhom4
{
    partial class FrmThemTacGia
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
            this.grbTTTG = new System.Windows.Forms.GroupBox();
            this.cboQuocTich = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpNamMat = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaTacGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNamMat = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblQuocTich = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaTacGia = new System.Windows.Forms.Label();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.grbTTTG.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTTTG
            // 
            this.grbTTTG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbTTTG.Controls.Add(this.btnHuy);
            this.grbTTTG.Controls.Add(this.btnLuu);
            this.grbTTTG.Controls.Add(this.cboQuocTich);
            this.grbTTTG.Controls.Add(this.cbGioiTinh);
            this.grbTTTG.Controls.Add(this.dtpNamMat);
            this.grbTTTG.Controls.Add(this.dtpNgaySinh);
            this.grbTTTG.Controls.Add(this.txtHoTen);
            this.grbTTTG.Controls.Add(this.txtMaTacGia);
            this.grbTTTG.Controls.Add(this.lblGioiTinh);
            this.grbTTTG.Controls.Add(this.lblNamMat);
            this.grbTTTG.Controls.Add(this.lblNgaySinh);
            this.grbTTTG.Controls.Add(this.lblQuocTich);
            this.grbTTTG.Controls.Add(this.lblHoTen);
            this.grbTTTG.Controls.Add(this.lblMaTacGia);
            this.grbTTTG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTTTG.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbTTTG.ForeColor = System.Drawing.Color.Black;
            this.grbTTTG.Location = new System.Drawing.Point(0, 0);
            this.grbTTTG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTTTG.Name = "grbTTTG";
            this.grbTTTG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTTTG.Size = new System.Drawing.Size(1055, 374);
            this.grbTTTG.TabIndex = 11;
            this.grbTTTG.TabStop = false;
            this.grbTTTG.Text = "Thông Tin Tác Giả";
            // 
            // cboQuocTich
            // 
            this.cboQuocTich.AutoCompleteCustomSource.AddRange(new string[] {
            "Nam",
            "Nữ"});
            this.cboQuocTich.BackColor = System.Drawing.Color.Transparent;
            this.cboQuocTich.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboQuocTich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuocTich.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboQuocTich.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboQuocTich.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboQuocTich.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboQuocTich.ItemHeight = 30;
            this.cboQuocTich.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cboQuocTich.Location = new System.Drawing.Point(642, 213);
            this.cboQuocTich.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboQuocTich.Name = "cboQuocTich";
            this.cboQuocTich.Size = new System.Drawing.Size(265, 36);
            this.cboQuocTich.TabIndex = 21;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.AutoCompleteCustomSource.AddRange(new string[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cbGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbGioiTinh.ItemHeight = 30;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbGioiTinh.Location = new System.Drawing.Point(642, 140);
            this.cbGioiTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(265, 36);
            this.cbGioiTinh.TabIndex = 20;
            // 
            // dtpNamMat
            // 
            this.dtpNamMat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpNamMat.Checked = true;
            this.dtpNamMat.CustomFormat = "yyyy";
            this.dtpNamMat.FillColor = System.Drawing.Color.White;
            this.dtpNamMat.FocusedColor = System.Drawing.Color.White;
            this.dtpNamMat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNamMat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNamMat.Location = new System.Drawing.Point(642, 60);
            this.dtpNamMat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNamMat.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNamMat.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNamMat.Name = "dtpNamMat";
            this.dtpNamMat.Size = new System.Drawing.Size(265, 58);
            this.dtpNamMat.TabIndex = 16;
            this.dtpNamMat.Value = new System.DateTime(2025, 10, 21, 13, 49, 34, 0);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinh.FocusedColor = System.Drawing.Color.White;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(172, 213);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(265, 58);
            this.dtpNgaySinh.TabIndex = 15;
            this.dtpNgaySinh.Value = new System.DateTime(2025, 10, 21, 13, 49, 34, 0);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Location = new System.Drawing.Point(172, 140);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(265, 57);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaTacGia.DefaultText = "";
            this.txtMaTacGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaTacGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaTacGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaTacGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaTacGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTacGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaTacGia.ForeColor = System.Drawing.Color.Black;
            this.txtMaTacGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTacGia.Location = new System.Drawing.Point(172, 57);
            this.txtMaTacGia.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.PlaceholderText = "";
            this.txtMaTacGia.SelectedText = "";
            this.txtMaTacGia.Size = new System.Drawing.Size(265, 57);
            this.txtMaTacGia.TabIndex = 0;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGioiTinh.Location = new System.Drawing.Point(522, 140);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(95, 28);
            this.lblGioiTinh.TabIndex = 9;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblNamMat
            // 
            this.lblNamMat.AutoSize = true;
            this.lblNamMat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNamMat.Location = new System.Drawing.Point(522, 60);
            this.lblNamMat.Name = "lblNamMat";
            this.lblNamMat.Size = new System.Drawing.Size(100, 28);
            this.lblNamMat.TabIndex = 9;
            this.lblNamMat.Text = "Năm mất";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgaySinh.Location = new System.Drawing.Point(46, 213);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(107, 28);
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblQuocTich
            // 
            this.lblQuocTich.AutoSize = true;
            this.lblQuocTich.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQuocTich.Location = new System.Drawing.Point(519, 213);
            this.lblQuocTich.Name = "lblQuocTich";
            this.lblQuocTich.Size = new System.Drawing.Size(103, 28);
            this.lblQuocTich.TabIndex = 4;
            this.lblQuocTich.Text = "Quốc tịch";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoTen.Location = new System.Drawing.Point(41, 132);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(115, 28);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Tên tác giả";
            // 
            // lblMaTacGia
            // 
            this.lblMaTacGia.AutoSize = true;
            this.lblMaTacGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaTacGia.Location = new System.Drawing.Point(41, 60);
            this.lblMaTacGia.Name = "lblMaTacGia";
            this.lblMaTacGia.Size = new System.Drawing.Size(112, 28);
            this.lblMaTacGia.TabIndex = 4;
            this.lblMaTacGia.Text = "Mã tác giả";
            // 
            // btnLuu
            // 
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(848, 293);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(142, 53);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(614, 293);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(142, 53);
            this.btnHuy.TabIndex = 23;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FrmThemTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 374);
            this.Controls.Add(this.grbTTTG);
            this.Name = "FrmThemTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThemTacGia";
            this.Load += new System.EventHandler(this.FrmThemTacGia_Load);
            this.grbTTTG.ResumeLayout(false);
            this.grbTTTG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTTTG;
        private Guna.UI2.WinForms.Guna2ComboBox cboQuocTich;
        private Guna.UI2.WinForms.Guna2ComboBox cbGioiTinh;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNamMat;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txtMaTacGia;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNamMat;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblQuocTich;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaTacGia;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    }
}