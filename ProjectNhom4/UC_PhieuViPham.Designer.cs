namespace ProjectNhom4
{
    partial class UC_PhieuViPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDSPhieuPhat = new System.Windows.Forms.Label();
            this.dgvPhieuViPham = new System.Windows.Forms.DataGridView();
            this.Ma_Phieu_Phat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doc_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Lap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trang_Thai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.grpThongTinPhieuPhat = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTrangthainopphat = new System.Windows.Forms.ComboBox();
            this.txtTongTienPhat = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboThuThu = new System.Windows.Forms.ComboBox();
            this.txtTenDocGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenDocGia = new System.Windows.Forms.Label();
            this.txtMaDocGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.dtpNgayLapPhieu = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.txtMaPhieuPhat = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaPhieuPhat = new System.Windows.Forms.Label();
            this.txtMaPhieuMuon = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpChiTietViPham = new System.Windows.Forms.GroupBox();
            this.btnXoadong = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemdong = new Guna.UI2.WinForms.Guna2Button();
            this.dgvChiTietViPham = new System.Windows.Forms.DataGridView();
            this.Ma_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_Vi_Pham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ly_Do = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Tien_Phat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXuatPhieu = new Guna.UI2.WinForms.Guna2Button();
            this.lblTrangthai = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuViPham)).BeginInit();
            this.grpThongTinPhieuPhat.SuspendLayout();
            this.grpChiTietViPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietViPham)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblDSPhieuPhat);
            this.pnlTitle.Controls.Add(this.lblTrangthai);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1171, 60);
            this.pnlTitle.TabIndex = 10;
            // 
            // lblDSPhieuPhat
            // 
            this.lblDSPhieuPhat.AutoSize = true;
            this.lblDSPhieuPhat.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDSPhieuPhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.lblDSPhieuPhat.Location = new System.Drawing.Point(473, 10);
            this.lblDSPhieuPhat.Name = "lblDSPhieuPhat";
            this.lblDSPhieuPhat.Size = new System.Drawing.Size(355, 38);
            this.lblDSPhieuPhat.TabIndex = 7;
            this.lblDSPhieuPhat.Text = "DANH SÁCH PHIẾU PHẠT";
            // 
            // dgvPhieuViPham
            // 
            this.dgvPhieuViPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuViPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuViPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuViPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuViPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Phieu_Phat,
            this.Doc_Gia,
            this.Ngay_Lap,
            this.Trang_Thai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieuViPham.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhieuViPham.EnableHeadersVisualStyles = false;
            this.dgvPhieuViPham.Location = new System.Drawing.Point(15, 108);
            this.dgvPhieuViPham.Name = "dgvPhieuViPham";
            this.dgvPhieuViPham.RowHeadersVisible = false;
            this.dgvPhieuViPham.RowHeadersWidth = 51;
            this.dgvPhieuViPham.RowTemplate.Height = 24;
            this.dgvPhieuViPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuViPham.Size = new System.Drawing.Size(486, 400);
            this.dgvPhieuViPham.TabIndex = 24;
            this.dgvPhieuViPham.SelectionChanged += new System.EventHandler(this.dgvPhieuViPham_SelectionChanged);
            // 
            // Ma_Phieu_Phat
            // 
            this.Ma_Phieu_Phat.DataPropertyName = "Ma_Phieu_Phat";
            this.Ma_Phieu_Phat.HeaderText = "Mã Phiếu Phạt";
            this.Ma_Phieu_Phat.MinimumWidth = 6;
            this.Ma_Phieu_Phat.Name = "Ma_Phieu_Phat";
            // 
            // Doc_Gia
            // 
            this.Doc_Gia.DataPropertyName = "Doc_Gia";
            this.Doc_Gia.HeaderText = "Độc Giả";
            this.Doc_Gia.MinimumWidth = 6;
            this.Doc_Gia.Name = "Doc_Gia";
            // 
            // Ngay_Lap
            // 
            this.Ngay_Lap.DataPropertyName = "Ngay_Lap";
            this.Ngay_Lap.HeaderText = "Ngày Lập";
            this.Ngay_Lap.MinimumWidth = 6;
            this.Ngay_Lap.Name = "Ngay_Lap";
            // 
            // Trang_Thai
            // 
            this.Trang_Thai.DataPropertyName = "Trang_Thai";
            this.Trang_Thai.HeaderText = "Trạng Thái";
            this.Trang_Thai.MinimumWidth = 6;
            this.Trang_Thai.Name = "Trang_Thai";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cboTrangThai.BorderColor = System.Drawing.Color.Silver;
            this.cboTrangThai.BorderRadius = 8;
            this.cboTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTrangThai.ItemHeight = 30;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Mã Phiếu Mượn",
            "Mã Độc Giả",
            "Ngày Mượn"});
            this.cboTrangThai.Location = new System.Drawing.Point(15, 66);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(128, 36);
            this.cboTrangThai.TabIndex = 25;
            this.cboTrangThai.SelectedIndexChanged += new System.EventHandler(this.cboTrangThai_SelectedIndexChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AcceptsTab = true;
            this.txtTimKiem.BorderColor = System.Drawing.Color.Silver;
            this.txtTimKiem.BorderRadius = 8;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.IconLeft = global::ProjectNhom4.Properties.Resources.search;
            this.txtTimKiem.Location = new System.Drawing.Point(173, 67);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.PlaceholderText = "Nhập tên độc giả tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(256, 36);
            this.txtTimKiem.TabIndex = 26;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BorderColor = System.Drawing.Color.Transparent;
            this.btnThem.BorderThickness = 2;
            this.btnThem.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnThem.HoverState.FillColor = System.Drawing.Color.White;
            this.btnThem.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnThem.Location = new System.Drawing.Point(3, 514);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 39);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BorderColor = System.Drawing.Color.Transparent;
            this.btnSua.BorderThickness = 2;
            this.btnSua.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnSua.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSua.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnSua.Location = new System.Drawing.Point(114, 514);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 39);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BorderColor = System.Drawing.Color.Transparent;
            this.btnXoa.BorderThickness = 2;
            this.btnXoa.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnXoa.HoverState.FillColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnXoa.Location = new System.Drawing.Point(228, 514);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 39);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.BorderColor = System.Drawing.Color.Transparent;
            this.btnLuu.BorderThickness = 2;
            this.btnLuu.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnLuu.HoverState.FillColor = System.Drawing.Color.White;
            this.btnLuu.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnLuu.Location = new System.Drawing.Point(342, 514);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(108, 39);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BorderColor = System.Drawing.Color.Transparent;
            this.btnHuy.BorderThickness = 2;
            this.btnHuy.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnHuy.HoverState.FillColor = System.Drawing.Color.White;
            this.btnHuy.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnHuy.Location = new System.Drawing.Point(456, 514);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(108, 39);
            this.btnHuy.TabIndex = 31;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // grpThongTinPhieuPhat
            // 
            this.grpThongTinPhieuPhat.Controls.Add(this.label3);
            this.grpThongTinPhieuPhat.Controls.Add(this.cboTrangthainopphat);
            this.grpThongTinPhieuPhat.Controls.Add(this.txtTongTienPhat);
            this.grpThongTinPhieuPhat.Controls.Add(this.label9);
            this.grpThongTinPhieuPhat.Controls.Add(this.label1);
            this.grpThongTinPhieuPhat.Controls.Add(this.cboThuThu);
            this.grpThongTinPhieuPhat.Controls.Add(this.txtTenDocGia);
            this.grpThongTinPhieuPhat.Controls.Add(this.lblTenDocGia);
            this.grpThongTinPhieuPhat.Controls.Add(this.txtMaDocGia);
            this.grpThongTinPhieuPhat.Controls.Add(this.lblMaDocGia);
            this.grpThongTinPhieuPhat.Controls.Add(this.dtpNgayLapPhieu);
            this.grpThongTinPhieuPhat.Controls.Add(this.lblNgayLap);
            this.grpThongTinPhieuPhat.Controls.Add(this.txtMaPhieuPhat);
            this.grpThongTinPhieuPhat.Controls.Add(this.lblMaPhieuPhat);
            this.grpThongTinPhieuPhat.Controls.Add(this.txtMaPhieuMuon);
            this.grpThongTinPhieuPhat.Controls.Add(this.label2);
            this.grpThongTinPhieuPhat.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpThongTinPhieuPhat.Location = new System.Drawing.Point(517, 67);
            this.grpThongTinPhieuPhat.Name = "grpThongTinPhieuPhat";
            this.grpThongTinPhieuPhat.Size = new System.Drawing.Size(647, 210);
            this.grpThongTinPhieuPhat.TabIndex = 33;
            this.grpThongTinPhieuPhat.TabStop = false;
            this.grpThongTinPhieuPhat.Text = "Thông tin phiếu phạt";
            this.grpThongTinPhieuPhat.Enter += new System.EventHandler(this.grpThongTinPhieuPhat_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(315, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Trạng thái";
            // 
            // cboTrangthainopphat
            // 
            this.cboTrangthainopphat.FormattingEnabled = true;
            this.cboTrangthainopphat.Location = new System.Drawing.Point(444, 61);
            this.cboTrangthainopphat.Name = "cboTrangthainopphat";
            this.cboTrangthainopphat.Size = new System.Drawing.Size(182, 25);
            this.cboTrangthainopphat.TabIndex = 1;
            this.cboTrangthainopphat.SelectedIndexChanged += new System.EventHandler(this.cboTrangthainopphat_SelectedIndexChanged);
            // 
            // txtTongTienPhat
            // 
            this.txtTongTienPhat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTienPhat.DefaultText = "";
            this.txtTongTienPhat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongTienPhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongTienPhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTienPhat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTienPhat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTienPhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTongTienPhat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTienPhat.Location = new System.Drawing.Point(444, 164);
            this.txtTongTienPhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongTienPhat.Name = "txtTongTienPhat";
            this.txtTongTienPhat.PlaceholderText = "";
            this.txtTongTienPhat.SelectedText = "";
            this.txtTongTienPhat.Size = new System.Drawing.Size(181, 35);
            this.txtTongTienPhat.TabIndex = 2;
            this.txtTongTienPhat.TextChanged += new System.EventHandler(this.txtTongTienPhat_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(315, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Tổng tiền phạt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(315, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Thủ Thư";
            // 
            // cboThuThu
            // 
            this.cboThuThu.FormattingEnabled = true;
            this.cboThuThu.Location = new System.Drawing.Point(444, 28);
            this.cboThuThu.Name = "cboThuThu";
            this.cboThuThu.Size = new System.Drawing.Size(182, 25);
            this.cboThuThu.TabIndex = 25;
            this.cboThuThu.SelectedIndexChanged += new System.EventHandler(this.cboThuThu_SelectedIndexChanged);
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDocGia.DefaultText = "";
            this.txtTenDocGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDocGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDocGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDocGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDocGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDocGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenDocGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDocGia.Location = new System.Drawing.Point(134, 161);
            this.txtTenDocGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.PlaceholderText = "";
            this.txtTenDocGia.SelectedText = "";
            this.txtTenDocGia.Size = new System.Drawing.Size(148, 35);
            this.txtTenDocGia.TabIndex = 23;
            this.txtTenDocGia.TextChanged += new System.EventHandler(this.txtTenDocGia_TextChanged);
            // 
            // lblTenDocGia
            // 
            this.lblTenDocGia.AutoSize = true;
            this.lblTenDocGia.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenDocGia.Location = new System.Drawing.Point(6, 164);
            this.lblTenDocGia.Name = "lblTenDocGia";
            this.lblTenDocGia.Size = new System.Drawing.Size(82, 17);
            this.lblTenDocGia.TabIndex = 22;
            this.lblTenDocGia.Text = "Tên Độc Giả";
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDocGia.DefaultText = "";
            this.txtMaDocGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDocGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDocGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDocGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDocGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDocGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaDocGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDocGia.Location = new System.Drawing.Point(134, 118);
            this.txtMaDocGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.PlaceholderText = "";
            this.txtMaDocGia.SelectedText = "";
            this.txtMaDocGia.Size = new System.Drawing.Size(148, 35);
            this.txtMaDocGia.TabIndex = 21;
            this.txtMaDocGia.TextChanged += new System.EventHandler(this.txtMaDocGia_TextChanged);
            this.txtMaDocGia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaPhieuMuon_KeyDown);
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.AutoSize = true;
            this.lblMaDocGia.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaDocGia.Location = new System.Drawing.Point(6, 118);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.Size = new System.Drawing.Size(79, 17);
            this.lblMaDocGia.TabIndex = 20;
            this.lblMaDocGia.Text = "Mã Độc Giả";
            // 
            // dtpNgayLapPhieu
            // 
            this.dtpNgayLapPhieu.Checked = true;
            this.dtpNgayLapPhieu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpNgayLapPhieu.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayLapPhieu.Location = new System.Drawing.Point(444, 109);
            this.dtpNgayLapPhieu.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayLapPhieu.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            this.dtpNgayLapPhieu.Size = new System.Drawing.Size(181, 36);
            this.dtpNgayLapPhieu.TabIndex = 19;
            this.dtpNgayLapPhieu.Value = new System.DateTime(2025, 10, 29, 0, 0, 0, 0);
            this.dtpNgayLapPhieu.ValueChanged += new System.EventHandler(this.dtpNgayLapPhieu_ValueChanged);
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayLap.Location = new System.Drawing.Point(315, 118);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(105, 17);
            this.lblNgayLap.TabIndex = 5;
            this.lblNgayLap.Text = "Ngày Lập Phiếu";
            this.lblNgayLap.Click += new System.EventHandler(this.lblNgayLap_Click);
            // 
            // txtMaPhieuPhat
            // 
            this.txtMaPhieuPhat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPhieuPhat.DefaultText = "";
            this.txtMaPhieuPhat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaPhieuPhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaPhieuPhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhieuPhat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhieuPhat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhieuPhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaPhieuPhat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhieuPhat.Location = new System.Drawing.Point(134, 30);
            this.txtMaPhieuPhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPhieuPhat.Name = "txtMaPhieuPhat";
            this.txtMaPhieuPhat.PlaceholderText = "";
            this.txtMaPhieuPhat.SelectedText = "";
            this.txtMaPhieuPhat.Size = new System.Drawing.Size(148, 35);
            this.txtMaPhieuPhat.TabIndex = 4;
            this.txtMaPhieuPhat.TextChanged += new System.EventHandler(this.txtMaPhieuPhat_TextChanged);
            // 
            // lblMaPhieuPhat
            // 
            this.lblMaPhieuPhat.AutoSize = true;
            this.lblMaPhieuPhat.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaPhieuPhat.Location = new System.Drawing.Point(6, 30);
            this.lblMaPhieuPhat.Name = "lblMaPhieuPhat";
            this.lblMaPhieuPhat.Size = new System.Drawing.Size(98, 17);
            this.lblMaPhieuPhat.TabIndex = 3;
            this.lblMaPhieuPhat.Text = "Mã Phiếu Phạt";
            // 
            // txtMaPhieuMuon
            // 
            this.txtMaPhieuMuon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPhieuMuon.DefaultText = "";
            this.txtMaPhieuMuon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaPhieuMuon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaPhieuMuon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhieuMuon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhieuMuon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhieuMuon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaPhieuMuon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhieuMuon.Location = new System.Drawing.Point(134, 75);
            this.txtMaPhieuMuon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            this.txtMaPhieuMuon.PlaceholderText = "";
            this.txtMaPhieuMuon.SelectedText = "";
            this.txtMaPhieuMuon.Size = new System.Drawing.Size(148, 35);
            this.txtMaPhieuMuon.TabIndex = 0;
            this.txtMaPhieuMuon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaPhieuMuon_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu mượn";
            // 
            // grpChiTietViPham
            // 
            this.grpChiTietViPham.Controls.Add(this.btnXoadong);
            this.grpChiTietViPham.Controls.Add(this.btnThemdong);
            this.grpChiTietViPham.Controls.Add(this.dgvChiTietViPham);
            this.grpChiTietViPham.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpChiTietViPham.Location = new System.Drawing.Point(517, 283);
            this.grpChiTietViPham.Name = "grpChiTietViPham";
            this.grpChiTietViPham.Size = new System.Drawing.Size(647, 225);
            this.grpChiTietViPham.TabIndex = 34;
            this.grpChiTietViPham.TabStop = false;
            this.grpChiTietViPham.Text = "Chi tiết vi phạm";
            // 
            // btnXoadong
            // 
            this.btnXoadong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoadong.BorderColor = System.Drawing.Color.Transparent;
            this.btnXoadong.BorderThickness = 2;
            this.btnXoadong.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnXoadong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoadong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoadong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoadong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoadong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnXoadong.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoadong.ForeColor = System.Drawing.Color.White;
            this.btnXoadong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnXoadong.HoverState.FillColor = System.Drawing.Color.White;
            this.btnXoadong.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnXoadong.Location = new System.Drawing.Point(516, 179);
            this.btnXoadong.Name = "btnXoadong";
            this.btnXoadong.Size = new System.Drawing.Size(131, 39);
            this.btnXoadong.TabIndex = 38;
            this.btnXoadong.Text = "Xóa sách";
            this.btnXoadong.Click += new System.EventHandler(this.btnXoadong_Click);
            // 
            // btnThemdong
            // 
            this.btnThemdong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemdong.BorderColor = System.Drawing.Color.Transparent;
            this.btnThemdong.BorderThickness = 2;
            this.btnThemdong.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnThemdong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemdong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemdong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemdong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemdong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnThemdong.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemdong.ForeColor = System.Drawing.Color.White;
            this.btnThemdong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnThemdong.HoverState.FillColor = System.Drawing.Color.White;
            this.btnThemdong.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnThemdong.Location = new System.Drawing.Point(375, 179);
            this.btnThemdong.Name = "btnThemdong";
            this.btnThemdong.Size = new System.Drawing.Size(131, 39);
            this.btnThemdong.TabIndex = 37;
            this.btnThemdong.Text = "Thêm sách";
            this.btnThemdong.Click += new System.EventHandler(this.btnluuphieuphat_Click);
            // 
            // dgvChiTietViPham
            // 
            this.dgvChiTietViPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietViPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChiTietViPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietViPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Sach,
            this.Ma_Vi_Pham,
            this.Ten_Sach,
            this.Ly_Do,
            this.Tien_Phat});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietViPham.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChiTietViPham.EnableHeadersVisualStyles = false;
            this.dgvChiTietViPham.Location = new System.Drawing.Point(0, 24);
            this.dgvChiTietViPham.Name = "dgvChiTietViPham";
            this.dgvChiTietViPham.RowHeadersVisible = false;
            this.dgvChiTietViPham.RowHeadersWidth = 51;
            this.dgvChiTietViPham.RowTemplate.Height = 24;
            this.dgvChiTietViPham.Size = new System.Drawing.Size(647, 149);
            this.dgvChiTietViPham.TabIndex = 0;
            this.dgvChiTietViPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietViPham_CellContentClick);
            this.dgvChiTietViPham.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietViPham_CellValueChanged);
            this.dgvChiTietViPham.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvChiTietViPham_DataError);
            // 
            // Ma_Sach
            // 
            this.Ma_Sach.DataPropertyName = "Ma_Sach";
            this.Ma_Sach.HeaderText = "Mã Sách";
            this.Ma_Sach.MinimumWidth = 6;
            this.Ma_Sach.Name = "Ma_Sach";
            // 
            // Ma_Vi_Pham
            // 
            this.Ma_Vi_Pham.DataPropertyName = "Ma_Vi_Pham";
            this.Ma_Vi_Pham.HeaderText = "Mã vi phạm";
            this.Ma_Vi_Pham.MinimumWidth = 6;
            this.Ma_Vi_Pham.Name = "Ma_Vi_Pham";
            this.Ma_Vi_Pham.ReadOnly = true;
            // 
            // Ten_Sach
            // 
            this.Ten_Sach.DataPropertyName = "Ten_Sach";
            this.Ten_Sach.HeaderText = "Tên Sách";
            this.Ten_Sach.MinimumWidth = 6;
            this.Ten_Sach.Name = "Ten_Sach";
            // 
            // Ly_Do
            // 
            this.Ly_Do.DataPropertyName = "Ly_Do";
            this.Ly_Do.HeaderText = "Lý do";
            this.Ly_Do.MinimumWidth = 8;
            this.Ly_Do.Name = "Ly_Do";
            this.Ly_Do.ReadOnly = true;
            // 
            // Tien_Phat
            // 
            this.Tien_Phat.DataPropertyName = "Tien_Phat";
            this.Tien_Phat.HeaderText = "Tiền phạt";
            this.Tien_Phat.MinimumWidth = 6;
            this.Tien_Phat.Name = "Tien_Phat";
            // 
            // btnXuatPhieu
            // 
            this.btnXuatPhieu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXuatPhieu.BorderColor = System.Drawing.Color.Transparent;
            this.btnXuatPhieu.BorderThickness = 2;
            this.btnXuatPhieu.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnXuatPhieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatPhieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatPhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatPhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatPhieu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnXuatPhieu.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatPhieu.ForeColor = System.Drawing.Color.White;
            this.btnXuatPhieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnXuatPhieu.HoverState.FillColor = System.Drawing.Color.White;
            this.btnXuatPhieu.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(232)))));
            this.btnXuatPhieu.Location = new System.Drawing.Point(993, 523);
            this.btnXuatPhieu.Name = "btnXuatPhieu";
            this.btnXuatPhieu.Size = new System.Drawing.Size(171, 39);
            this.btnXuatPhieu.TabIndex = 37;
            this.btnXuatPhieu.Text = "Xuất Phiếu";
            this.btnXuatPhieu.Click += new System.EventHandler(this.btnXuatPhieu_Click);
            // 
            // lblTrangthai
            // 
            this.lblTrangthai.AutoSize = true;
            this.lblTrangthai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangthai.Location = new System.Drawing.Point(11, 40);
            this.lblTrangthai.Name = "lblTrangthai";
            this.lblTrangthai.Size = new System.Drawing.Size(75, 20);
            this.lblTrangthai.TabIndex = 32;
            this.lblTrangthai.Text = "Trạng thái";
            this.lblTrangthai.Click += new System.EventHandler(this.lblLoc_Click);
            // 
            // UC_PhieuViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXuatPhieu);
            this.Controls.Add(this.grpChiTietViPham);
            this.Controls.Add(this.grpThongTinPhieuPhat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.dgvPhieuViPham);
            this.Controls.Add(this.pnlTitle);
            this.Name = "UC_PhieuViPham";
            this.Size = new System.Drawing.Size(1171, 575);
            this.Load += new System.EventHandler(this.UC_PhieuPhat_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuViPham)).EndInit();
            this.grpThongTinPhieuPhat.ResumeLayout(false);
            this.grpThongTinPhieuPhat.PerformLayout();
            this.grpChiTietViPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietViPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTitle;
        private System.Windows.Forms.Label lblDSPhieuPhat;
        private System.Windows.Forms.DataGridView dgvPhieuViPham;
        private Guna.UI2.WinForms.Guna2ComboBox cboTrangThai;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private System.Windows.Forms.GroupBox grpThongTinPhieuPhat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNgayLap;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPhieuPhat;
        private System.Windows.Forms.Label lblMaPhieuPhat;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPhieuMuon;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayLapPhieu;
        private System.Windows.Forms.ComboBox cboThuThu;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDocGia;
        private System.Windows.Forms.Label lblTenDocGia;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDocGia;
        private System.Windows.Forms.Label lblMaDocGia;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTongTienPhat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpChiTietViPham;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private System.Windows.Forms.DataGridView dgvChiTietViPham;
        private Guna.UI2.WinForms.Guna2Button btnXoadong;
        private Guna.UI2.WinForms.Guna2Button btnThemdong;
        private Guna.UI2.WinForms.Guna2Button btnXuatPhieu;
        private System.Windows.Forms.Label lblTrangthai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTrangthainopphat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Phieu_Phat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Lap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trang_Thai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Vi_Pham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Sach;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ly_Do;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tien_Phat;
    }
}
