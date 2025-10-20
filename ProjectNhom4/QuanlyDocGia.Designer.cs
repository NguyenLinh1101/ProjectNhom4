namespace ProjectNhom4
{
    partial class QuanlyDocGia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlTimKiem = new Guna.UI2.WinForms.Guna2Panel();
            this.cbLocTruong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlDanhSach = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvDocGia = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlChucNang = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.Ma_Doc_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Cap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Het_Han = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpThongTinDocGia = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnChonAnh = new Guna.UI2.WinForms.Guna2Button();
            this.picDocGia = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlThongTin = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMaDocGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.lblNgayHetHan = new System.Windows.Forms.Label();
            this.txtMaPhieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNgayCap = new System.Windows.Forms.Label();
            this.lblLoaiDocGia = new System.Windows.Forms.Label();
            this.txtLoaiDocGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpNgayCap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpNgayHetHandtpNgayHetHan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pnlTimKiem.SuspendLayout();
            this.pnlDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.pnlChucNang.SuspendLayout();
            this.grpThongTinDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDocGia)).BeginInit();
            this.pnlThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.lblTieuDe.Location = new System.Drawing.Point(830, 25);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(371, 54);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ ĐỘC GIẢ";
            // 
            // pnlTimKiem
            // 
            this.pnlTimKiem.Controls.Add(this.txtTimKiem);
            this.pnlTimKiem.Controls.Add(this.cbLocTruong);
            this.pnlTimKiem.Location = new System.Drawing.Point(470, 90);
            this.pnlTimKiem.Name = "pnlTimKiem";
            this.pnlTimKiem.Size = new System.Drawing.Size(1000, 60);
            this.pnlTimKiem.TabIndex = 1;
            // 
            // cbLocTruong
            // 
            this.cbLocTruong.BackColor = System.Drawing.Color.Transparent;
            this.cbLocTruong.BorderRadius = 6;
            this.cbLocTruong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocTruong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocTruong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLocTruong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLocTruong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLocTruong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLocTruong.ItemHeight = 30;
            this.cbLocTruong.Items.AddRange(new object[] {
            "\"Số điện thoại\",",
            "\"CCCD\""});
            this.cbLocTruong.Location = new System.Drawing.Point(0, 10);
            this.cbLocTruong.Name = "cbLocTruong";
            this.cbLocTruong.Size = new System.Drawing.Size(200, 36);
            this.cbLocTruong.TabIndex = 0;
            // 
            // pnlDanhSach
            // 
            this.pnlDanhSach.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnlDanhSach.BorderRadius = 10;
            this.pnlDanhSach.BorderThickness = 1;
            this.pnlDanhSach.Controls.Add(this.dgvDocGia);
            this.pnlDanhSach.FillColor = System.Drawing.Color.White;
            this.pnlDanhSach.Location = new System.Drawing.Point(100, 230);
            this.pnlDanhSach.Name = "pnlDanhSach";
            this.pnlDanhSach.Size = new System.Drawing.Size(1740, 450);
            this.pnlDanhSach.TabIndex = 2;
            // 
            // dgvDocGia
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDocGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocGia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDocGia.ColumnHeadersHeight = 35;
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Doc_Gia,
            this.Ho_Ten,
            this.Ngay_Sinh,
            this.Email,
            this.Ngay_Cap,
            this.Ngay_Het_Han});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocGia.GridColor = System.Drawing.Color.Silver;
            this.dgvDocGia.Location = new System.Drawing.Point(0, 0);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.RowHeadersVisible = false;
            this.dgvDocGia.RowHeadersWidth = 51;
            this.dgvDocGia.RowTemplate.Height = 24;
            this.dgvDocGia.Size = new System.Drawing.Size(1740, 450);
            this.dgvDocGia.TabIndex = 0;
            this.dgvDocGia.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDocGia.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDocGia.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDocGia.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDocGia.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDocGia.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDocGia.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.dgvDocGia.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.dgvDocGia.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDocGia.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDocGia.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDocGia.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDocGia.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvDocGia.ThemeStyle.ReadOnly = false;
            this.dgvDocGia.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDocGia.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDocGia.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDocGia.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDocGia.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDocGia.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDocGia.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.Controls.Add(this.btnLamMoi);
            this.pnlChucNang.Controls.Add(this.btnXoa);
            this.pnlChucNang.Controls.Add(this.btnSua);
            this.pnlChucNang.Controls.Add(this.btnThem);
            this.pnlChucNang.Location = new System.Drawing.Point(100, 160);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(1740, 60);
            this.pnlChucNang.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 8;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(12, 17);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 8;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(484, 17);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(130, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1086, 17);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderRadius = 8;
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(1607, 17);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(130, 40);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            // 
            // Ma_Doc_Gia
            // 
            this.Ma_Doc_Gia.HeaderText = "Mã Độc Giả";
            this.Ma_Doc_Gia.MinimumWidth = 6;
            this.Ma_Doc_Gia.Name = "Ma_Doc_Gia";
            // 
            // Ho_Ten
            // 
            this.Ho_Ten.HeaderText = "Họ và Tên";
            this.Ho_Ten.MinimumWidth = 6;
            this.Ho_Ten.Name = "Ho_Ten";
            // 
            // Ngay_Sinh
            // 
            this.Ngay_Sinh.HeaderText = "Ngày Sinh";
            this.Ngay_Sinh.MinimumWidth = 6;
            this.Ngay_Sinh.Name = "Ngay_Sinh";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // Ngay_Cap
            // 
            this.Ngay_Cap.HeaderText = "Ngày Cấp Thẻ";
            this.Ngay_Cap.MinimumWidth = 6;
            this.Ngay_Cap.Name = "Ngay_Cap";
            // 
            // Ngay_Het_Han
            // 
            this.Ngay_Het_Han.HeaderText = "Ngày Hết Hạn";
            this.Ngay_Het_Han.MinimumWidth = 6;
            this.Ngay_Het_Han.Name = "Ngay_Het_Han";
            // 
            // grpThongTinDocGia
            // 
            this.grpThongTinDocGia.BorderRadius = 10;
            this.grpThongTinDocGia.Controls.Add(this.pnlThongTin);
            this.grpThongTinDocGia.Controls.Add(this.btnChonAnh);
            this.grpThongTinDocGia.Controls.Add(this.picDocGia);
            this.grpThongTinDocGia.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.grpThongTinDocGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpThongTinDocGia.ForeColor = System.Drawing.Color.White;
            this.grpThongTinDocGia.Location = new System.Drawing.Point(100, 700);
            this.grpThongTinDocGia.Name = "grpThongTinDocGia";
            this.grpThongTinDocGia.Size = new System.Drawing.Size(1740, 380);
            this.grpThongTinDocGia.TabIndex = 4;
            this.grpThongTinDocGia.Text = "Thông tin chi tiết độc giả";
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChonAnh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChonAnh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChonAnh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChonAnh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChonAnh.ForeColor = System.Drawing.Color.White;
            this.btnChonAnh.Location = new System.Drawing.Point(70, 290);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(120, 35);
            this.btnChonAnh.TabIndex = 1;
            this.btnChonAnh.Text = "Chọn ảnh";
            // 
            // picDocGia
            // 
            this.picDocGia.BorderRadius = 10;
            this.picDocGia.Image = global::ProjectNhom4.Properties.Resources.user;
            this.picDocGia.ImageRotate = 0F;
            this.picDocGia.Location = new System.Drawing.Point(40, 60);
            this.picDocGia.Name = "picDocGia";
            this.picDocGia.Size = new System.Drawing.Size(180, 220);
            this.picDocGia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDocGia.TabIndex = 0;
            this.picDocGia.TabStop = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderRadius = 6;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.IconLeft = global::ProjectNhom4.Properties.Resources.search;
            this.txtTimKiem.Location = new System.Drawing.Point(220, 10);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "Nhập tên độc giả để tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(788, 46);
            this.txtTimKiem.TabIndex = 1;
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlThongTin.Controls.Add(this.dtpNgayHetHandtpNgayHetHan);
            this.pnlThongTin.Controls.Add(this.dtpNgayCap);
            this.pnlThongTin.Controls.Add(this.lblMaPhieu);
            this.pnlThongTin.Controls.Add(this.lblNgayHetHan);
            this.pnlThongTin.Controls.Add(this.txtMaPhieu);
            this.pnlThongTin.Controls.Add(this.lblNgayCap);
            this.pnlThongTin.Controls.Add(this.lblLoaiDocGia);
            this.pnlThongTin.Controls.Add(this.txtLoaiDocGia);
            this.pnlThongTin.Controls.Add(this.lblSDT);
            this.pnlThongTin.Controls.Add(this.guna2TextBox2);
            this.pnlThongTin.Controls.Add(this.lblEmail);
            this.pnlThongTin.Controls.Add(this.txtEmail);
            this.pnlThongTin.Controls.Add(this.lblHoTen);
            this.pnlThongTin.Controls.Add(this.txtHoTen);
            this.pnlThongTin.Controls.Add(this.lblMaDocGia);
            this.pnlThongTin.Controls.Add(this.txtMaDocGia);
            this.pnlThongTin.FillColor = System.Drawing.Color.Transparent;
            this.pnlThongTin.ForeColor = System.Drawing.Color.Black;
            this.pnlThongTin.Location = new System.Drawing.Point(390, 63);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(1300, 280);
            this.pnlThongTin.TabIndex = 2;
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.BorderRadius = 6;
            this.txtMaDocGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDocGia.DefaultText = "";
            this.txtMaDocGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDocGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDocGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDocGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDocGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDocGia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDocGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDocGia.Location = new System.Drawing.Point(180, 23);
            this.txtMaDocGia.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.PlaceholderText = "";
            this.txtMaDocGia.SelectedText = "";
            this.txtMaDocGia.Size = new System.Drawing.Size(327, 38);
            this.txtMaDocGia.TabIndex = 0;
            this.txtMaDocGia.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.AutoSize = true;
            this.lblMaDocGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaDocGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMaDocGia.Location = new System.Drawing.Point(40, 23);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.Size = new System.Drawing.Size(89, 20);
            this.lblMaDocGia.TabIndex = 1;
            this.lblMaDocGia.Text = "Mã độc giả:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHoTen.Location = new System.Drawing.Point(40, 90);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(60, 20);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderRadius = 6;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Location = new System.Drawing.Point(180, 90);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(327, 38);
            this.txtHoTen.TabIndex = 2;
            this.txtHoTen.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmail.Location = new System.Drawing.Point(40, 160);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 6;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(180, 155);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(327, 38);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderRadius = 6;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(180, 214);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(327, 38);
            this.guna2TextBox2.TabIndex = 6;
            this.guna2TextBox2.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSDT.Location = new System.Drawing.Point(40, 227);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(104, 20);
            this.lblSDT.TabIndex = 8;
            this.lblSDT.Text = "Số điện thoại:";
            this.lblSDT.Click += new System.EventHandler(this.lblSDT_Click);
            // 
            // lblMaPhieu
            // 
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMaPhieu.Location = new System.Drawing.Point(700, 227);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(183, 20);
            this.lblMaPhieu.TabIndex = 16;
            this.lblMaPhieu.Text = "Mã phiếu (mượn / phạt):";
            this.lblMaPhieu.Click += new System.EventHandler(this.lblMaPhieu_Click);
            // 
            // lblNgayHetHan
            // 
            this.lblNgayHetHan.AutoSize = true;
            this.lblNgayHetHan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayHetHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNgayHetHan.Location = new System.Drawing.Point(700, 160);
            this.lblNgayHetHan.Name = "lblNgayHetHan";
            this.lblNgayHetHan.Size = new System.Drawing.Size(107, 20);
            this.lblNgayHetHan.TabIndex = 15;
            this.lblNgayHetHan.Text = "Ngày hết hạn:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.BorderRadius = 6;
            this.txtMaPhieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPhieu.DefaultText = "";
            this.txtMaPhieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaPhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaPhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPhieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhieu.Location = new System.Drawing.Point(898, 214);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.PlaceholderText = "";
            this.txtMaPhieu.SelectedText = "";
            this.txtMaPhieu.Size = new System.Drawing.Size(327, 38);
            this.txtMaPhieu.TabIndex = 14;
            this.txtMaPhieu.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // lblNgayCap
            // 
            this.lblNgayCap.AutoSize = true;
            this.lblNgayCap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNgayCap.Location = new System.Drawing.Point(702, 90);
            this.lblNgayCap.Name = "lblNgayCap";
            this.lblNgayCap.Size = new System.Drawing.Size(105, 20);
            this.lblNgayCap.TabIndex = 12;
            this.lblNgayCap.Text = "Ngày cấp thẻ:";
            // 
            // lblLoaiDocGia
            // 
            this.lblLoaiDocGia.AutoSize = true;
            this.lblLoaiDocGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoaiDocGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLoaiDocGia.Location = new System.Drawing.Point(700, 23);
            this.lblLoaiDocGia.Name = "lblLoaiDocGia";
            this.lblLoaiDocGia.Size = new System.Drawing.Size(96, 20);
            this.lblLoaiDocGia.TabIndex = 10;
            this.lblLoaiDocGia.Text = "Loại độc giả:";
            // 
            // txtLoaiDocGia
            // 
            this.txtLoaiDocGia.BorderRadius = 6;
            this.txtLoaiDocGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoaiDocGia.DefaultText = "";
            this.txtLoaiDocGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoaiDocGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoaiDocGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoaiDocGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoaiDocGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaiDocGia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLoaiDocGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaiDocGia.Location = new System.Drawing.Point(898, 23);
            this.txtLoaiDocGia.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtLoaiDocGia.Name = "txtLoaiDocGia";
            this.txtLoaiDocGia.PlaceholderText = "";
            this.txtLoaiDocGia.SelectedText = "";
            this.txtLoaiDocGia.Size = new System.Drawing.Size(327, 38);
            this.txtLoaiDocGia.TabIndex = 9;
            this.txtLoaiDocGia.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // dtpNgayCap
            // 
            this.dtpNgayCap.BorderRadius = 6;
            this.dtpNgayCap.BorderThickness = 1;
            this.dtpNgayCap.Checked = true;
            this.dtpNgayCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgayCap.FillColor = System.Drawing.Color.White;
            this.dtpNgayCap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayCap.Location = new System.Drawing.Point(898, 90);
            this.dtpNgayCap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayCap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayCap.Name = "dtpNgayCap";
            this.dtpNgayCap.Size = new System.Drawing.Size(327, 36);
            this.dtpNgayCap.TabIndex = 17;
            this.dtpNgayCap.Value = new System.DateTime(2025, 10, 20, 11, 0, 11, 630);
            // 
            // dtpNgayHetHandtpNgayHetHan
            // 
            this.dtpNgayHetHandtpNgayHetHan.BorderRadius = 6;
            this.dtpNgayHetHandtpNgayHetHan.BorderThickness = 1;
            this.dtpNgayHetHandtpNgayHetHan.Checked = true;
            this.dtpNgayHetHandtpNgayHetHan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgayHetHandtpNgayHetHan.FillColor = System.Drawing.Color.White;
            this.dtpNgayHetHandtpNgayHetHan.FocusedColor = System.Drawing.Color.White;
            this.dtpNgayHetHandtpNgayHetHan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayHetHandtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayHetHandtpNgayHetHan.Location = new System.Drawing.Point(898, 155);
            this.dtpNgayHetHandtpNgayHetHan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayHetHandtpNgayHetHan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayHetHandtpNgayHetHan.Name = "dtpNgayHetHandtpNgayHetHan";
            this.dtpNgayHetHandtpNgayHetHan.Size = new System.Drawing.Size(327, 36);
            this.dtpNgayHetHandtpNgayHetHan.TabIndex = 18;
            this.dtpNgayHetHandtpNgayHetHan.Value = new System.DateTime(2025, 10, 20, 11, 0, 11, 630);
            // 
            // QuanlyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.grpThongTinDocGia);
            this.Controls.Add(this.pnlChucNang);
            this.Controls.Add(this.pnlDanhSach);
            this.Controls.Add(this.pnlTimKiem);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(820, 30);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuanlyDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanlyDocGia";
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.pnlChucNang.ResumeLayout(false);
            this.grpThongTinDocGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDocGia)).EndInit();
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private Guna.UI2.WinForms.Guna2Panel pnlTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cbLocTruong;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2Panel pnlDanhSach;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDocGia;
        private Guna.UI2.WinForms.Guna2Panel pnlChucNang;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Doc_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Cap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Het_Han;
        private Guna.UI2.WinForms.Guna2GroupBox grpThongTinDocGia;
        private Guna.UI2.WinForms.Guna2Button btnChonAnh;
        private Guna.UI2.WinForms.Guna2PictureBox picDocGia;
        private Guna.UI2.WinForms.Guna2Panel pnlThongTin;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDocGia;
        private System.Windows.Forms.Label lblMaDocGia;
        private System.Windows.Forms.Label lblSDT;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label lblHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.Label lblNgayHetHan;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPhieu;
        private System.Windows.Forms.Label lblNgayCap;
        private System.Windows.Forms.Label lblLoaiDocGia;
        private Guna.UI2.WinForms.Guna2TextBox txtLoaiDocGia;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayCap;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayHetHandtpNgayHetHan;
    }
}