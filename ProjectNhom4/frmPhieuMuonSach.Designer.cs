namespace ProjectNhom4
{
    partial class frmMuonSach
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
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbThongTinPhieu = new System.Windows.Forms.GroupBox();
            this.lblTongTienCoc = new System.Windows.Forms.Label();
            this.dtpNgayTra = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayTraDuKien = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtTongTienCoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenDocGia = new System.Windows.Forms.Label();
            this.cboDocGia = new System.Windows.Forms.ComboBox();
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.txtMaPhieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.gbDanhSachSach = new System.Windows.Forms.GroupBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnHuy = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dgvSachMuon = new System.Windows.Forms.DataGridView();
            this.col_MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MucPhatViPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoaSach = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnChonSach = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtSearchSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlHeader.SuspendLayout();
            this.gbThongTinPhieu.SuspendLayout();
            this.gbDanhSachSach.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnClose.Location = new System.Drawing.Point(933, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 32);
            this.btnClose.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(310, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHIẾU MƯỢN SÁCH";
            // 
            // gbThongTinPhieu
            // 
            this.gbThongTinPhieu.Controls.Add(this.lblTongTienCoc);
            this.gbThongTinPhieu.Controls.Add(this.dtpNgayTra);
            this.gbThongTinPhieu.Controls.Add(this.lblNgayTraDuKien);
            this.gbThongTinPhieu.Controls.Add(this.dtpNgayMuon);
            this.gbThongTinPhieu.Controls.Add(this.txtTongTienCoc);
            this.gbThongTinPhieu.Controls.Add(this.lblNgayMuon);
            this.gbThongTinPhieu.Controls.Add(this.guna2TextBox1);
            this.gbThongTinPhieu.Controls.Add(this.lblTenDocGia);
            this.gbThongTinPhieu.Controls.Add(this.cboDocGia);
            this.gbThongTinPhieu.Controls.Add(this.lblMaDocGia);
            this.gbThongTinPhieu.Controls.Add(this.txtMaPhieu);
            this.gbThongTinPhieu.Controls.Add(this.lblMaPhieu);
            this.gbThongTinPhieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbThongTinPhieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbThongTinPhieu.Location = new System.Drawing.Point(0, 60);
            this.gbThongTinPhieu.Name = "gbThongTinPhieu";
            this.gbThongTinPhieu.Size = new System.Drawing.Size(1000, 190);
            this.gbThongTinPhieu.TabIndex = 1;
            this.gbThongTinPhieu.TabStop = false;
            this.gbThongTinPhieu.Text = "Thông tin phiếu mượn";
            // 
            // lblTongTienCoc
            // 
            this.lblTongTienCoc.AutoSize = true;
            this.lblTongTienCoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTienCoc.Location = new System.Drawing.Point(575, 141);
            this.lblTongTienCoc.Name = "lblTongTienCoc";
            this.lblTongTienCoc.Size = new System.Drawing.Size(103, 20);
            this.lblTongTienCoc.TabIndex = 12;
            this.lblTongTienCoc.Text = "Tổng tiền cọc";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Checked = true;
            this.dtpNgayTra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpNgayTra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(725, 80);
            this.dtpNgayTra.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayTra.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(225, 36);
            this.dtpNgayTra.TabIndex = 11;
            this.dtpNgayTra.Value = new System.DateTime(2025, 11, 2, 0, 36, 46, 235);
            // 
            // lblNgayTraDuKien
            // 
            this.lblNgayTraDuKien.AutoSize = true;
            this.lblNgayTraDuKien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayTraDuKien.Location = new System.Drawing.Point(575, 85);
            this.lblNgayTraDuKien.Name = "lblNgayTraDuKien";
            this.lblNgayTraDuKien.Size = new System.Drawing.Size(126, 20);
            this.lblNgayTraDuKien.TabIndex = 10;
            this.lblNgayTraDuKien.Text = "Ngày trả dự kiến";
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Checked = true;
            this.dtpNgayMuon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpNgayMuon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(725, 36);
            this.dtpNgayMuon.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayMuon.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(225, 36);
            this.dtpNgayMuon.TabIndex = 9;
            this.dtpNgayMuon.Value = new System.DateTime(2025, 11, 2, 0, 36, 46, 235);
            // 
            // txtTongTienCoc
            // 
            this.txtTongTienCoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTienCoc.DefaultText = "";
            this.txtTongTienCoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongTienCoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongTienCoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTienCoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTienCoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTienCoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTongTienCoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTienCoc.Location = new System.Drawing.Point(725, 128);
            this.txtTongTienCoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongTienCoc.Name = "txtTongTienCoc";
            this.txtTongTienCoc.PlaceholderText = "";
            this.txtTongTienCoc.ReadOnly = true;
            this.txtTongTienCoc.SelectedText = "";
            this.txtTongTienCoc.Size = new System.Drawing.Size(225, 41);
            this.txtTongTienCoc.TabIndex = 8;
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayMuon.Location = new System.Drawing.Point(575, 36);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(92, 20);
            this.lblNgayMuon.TabIndex = 7;
            this.lblNgayMuon.Text = "Ngày mượn";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(147, 128);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.ReadOnly = true;
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(225, 41);
            this.guna2TextBox1.TabIndex = 6;
            // 
            // lblTenDocGia
            // 
            this.lblTenDocGia.AutoSize = true;
            this.lblTenDocGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenDocGia.Location = new System.Drawing.Point(21, 141);
            this.lblTenDocGia.Name = "lblTenDocGia";
            this.lblTenDocGia.Size = new System.Drawing.Size(88, 20);
            this.lblTenDocGia.TabIndex = 5;
            this.lblTenDocGia.Text = "Tên độc giả";
            // 
            // cboDocGia
            // 
            this.cboDocGia.FormattingEnabled = true;
            this.cboDocGia.Location = new System.Drawing.Point(147, 85);
            this.cboDocGia.Name = "cboDocGia";
            this.cboDocGia.Size = new System.Drawing.Size(225, 31);
            this.cboDocGia.TabIndex = 4;
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.AutoSize = true;
            this.lblMaDocGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaDocGia.Location = new System.Drawing.Point(21, 90);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.Size = new System.Drawing.Size(85, 20);
            this.lblMaDocGia.TabIndex = 3;
            this.lblMaDocGia.Text = "Mã độc giả";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPhieu.DefaultText = "";
            this.txtMaPhieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaPhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaPhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaPhieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhieu.Location = new System.Drawing.Point(147, 30);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.PlaceholderText = "";
            this.txtMaPhieu.ReadOnly = true;
            this.txtMaPhieu.SelectedText = "";
            this.txtMaPhieu.Size = new System.Drawing.Size(225, 41);
            this.txtMaPhieu.TabIndex = 2;
            // 
            // lblMaPhieu
            // 
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaPhieu.Location = new System.Drawing.Point(21, 36);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(120, 20);
            this.lblMaPhieu.TabIndex = 1;
            this.lblMaPhieu.Text = "Mã phiếu mượn";
            // 
            // gbDanhSachSach
            // 
            this.gbDanhSachSach.Controls.Add(this.pnlFooter);
            this.gbDanhSachSach.Controls.Add(this.dgvSachMuon);
            this.gbDanhSachSach.Controls.Add(this.btnClear);
            this.gbDanhSachSach.Controls.Add(this.btnXoaSach);
            this.gbDanhSachSach.Controls.Add(this.btnChonSach);
            this.gbDanhSachSach.Controls.Add(this.txtSearchSach);
            this.gbDanhSachSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDanhSachSach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbDanhSachSach.Location = new System.Drawing.Point(0, 250);
            this.gbDanhSachSach.Name = "gbDanhSachSach";
            this.gbDanhSachSach.Size = new System.Drawing.Size(1000, 450);
            this.gbDanhSachSach.TabIndex = 2;
            this.gbDanhSachSach.TabStop = false;
            this.gbDanhSachSach.Text = "Danh sách sách mượn";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnHuy);
            this.pnlFooter.Controls.Add(this.btnLuu);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(3, 375);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(994, 72);
            this.pnlFooter.TabIndex = 5;
            // 
            // btnHuy
            // 
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnHuy.FillColor2 = System.Drawing.Color.IndianRed;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(806, 18);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(179, 45);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            // 
            // btnLuu
            // 
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnLuu.FillColor2 = System.Drawing.Color.IndianRed;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(12, 18);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(179, 45);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu phiếu";
            // 
            // dgvSachMuon
            // 
            this.dgvSachMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSachMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaSach,
            this.TenSach,
            this.GiaBia,
            this.MucPhatViPham,
            this.TienCoc,
            this.TinhTrang});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSachMuon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSachMuon.EnableHeadersVisualStyles = false;
            this.dgvSachMuon.Location = new System.Drawing.Point(6, 105);
            this.dgvSachMuon.Name = "dgvSachMuon";
            this.dgvSachMuon.RowHeadersVisible = false;
            this.dgvSachMuon.RowHeadersWidth = 51;
            this.dgvSachMuon.RowTemplate.Height = 24;
            this.dgvSachMuon.Size = new System.Drawing.Size(982, 255);
            this.dgvSachMuon.TabIndex = 4;
            // 
            // col_MaSach
            // 
            this.col_MaSach.HeaderText = "Mã sách";
            this.col_MaSach.MinimumWidth = 6;
            this.col_MaSach.Name = "col_MaSach";
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            // 
            // GiaBia
            // 
            this.GiaBia.HeaderText = "Giá bìa";
            this.GiaBia.MinimumWidth = 6;
            this.GiaBia.Name = "GiaBia";
            // 
            // MucPhatViPham
            // 
            this.MucPhatViPham.HeaderText = "Mức phạt vi phạm";
            this.MucPhatViPham.MinimumWidth = 6;
            this.MucPhatViPham.Name = "MucPhatViPham";
            // 
            // TienCoc
            // 
            this.TienCoc.HeaderText = "Tiền cọc";
            this.TienCoc.MinimumWidth = 6;
            this.TienCoc.Name = "TienCoc";
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            // 
            // btnClear
            // 
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnClear.FillColor2 = System.Drawing.Color.IndianRed;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(870, 33);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 45);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Xóa tất cả";
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaSach.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnXoaSach.FillColor2 = System.Drawing.Color.IndianRed;
            this.btnXoaSach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaSach.ForeColor = System.Drawing.Color.White;
            this.btnXoaSach.Location = new System.Drawing.Point(695, 33);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(118, 45);
            this.btnXoaSach.TabIndex = 2;
            this.btnXoaSach.Text = "Xóa sách";
            // 
            // btnChonSach
            // 
            this.btnChonSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChonSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChonSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChonSach.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChonSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChonSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnChonSach.FillColor2 = System.Drawing.Color.IndianRed;
            this.btnChonSach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChonSach.ForeColor = System.Drawing.Color.White;
            this.btnChonSach.Location = new System.Drawing.Point(501, 33);
            this.btnChonSach.Name = "btnChonSach";
            this.btnChonSach.Size = new System.Drawing.Size(126, 45);
            this.btnChonSach.TabIndex = 1;
            this.btnChonSach.Text = "Thêm sách";
            // 
            // txtSearchSach
            // 
            this.txtSearchSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchSach.DefaultText = "";
            this.txtSearchSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchSach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchSach.Location = new System.Drawing.Point(25, 30);
            this.txtSearchSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchSach.Name = "txtSearchSach";
            this.txtSearchSach.PlaceholderText = "Tìm mã/tên sách...";
            this.txtSearchSach.SelectedText = "";
            this.txtSearchSach.Size = new System.Drawing.Size(424, 48);
            this.txtSearchSach.TabIndex = 0;
            // 
            // frmMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.gbDanhSachSach);
            this.Controls.Add(this.gbThongTinPhieu);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMuonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuMuonSach";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gbThongTinPhieu.ResumeLayout(false);
            this.gbThongTinPhieu.PerformLayout();
            this.gbDanhSachSach.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbThongTinPhieu;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPhieu;
        private System.Windows.Forms.Label lblMaPhieu;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label lblTenDocGia;
        private System.Windows.Forms.ComboBox cboDocGia;
        private System.Windows.Forms.Label lblMaDocGia;
        private System.Windows.Forms.Label lblTongTienCoc;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label lblNgayTraDuKien;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayMuon;
        private Guna.UI2.WinForms.Guna2TextBox txtTongTienCoc;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.GroupBox gbDanhSachSach;
        private Guna.UI2.WinForms.Guna2GradientButton btnChonSach;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchSach;
        private Guna.UI2.WinForms.Guna2GradientButton btnClear;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoaSach;
        private System.Windows.Forms.DataGridView dgvSachMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MucPhatViPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.Panel pnlFooter;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnHuy;
    }
}