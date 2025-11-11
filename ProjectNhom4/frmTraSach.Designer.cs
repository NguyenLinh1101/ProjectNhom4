namespace ProjectNhom4
{
    partial class frmTraSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlThongtin = new System.Windows.Forms.Panel();
            this.grpPhieuMuon = new System.Windows.Forms.GroupBox();
            this.lblMaPhieuMuon = new System.Windows.Forms.Label();
            this.txtMaPhieuMuon = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaDocGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.txtTenDocGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenDocGia = new System.Windows.Forms.Label();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.dtpNgayTra = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayTraThucTe = new System.Windows.Forms.Label();
            this.dtpNgayTraThucTe = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtSoNgayTre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSoNgayTre = new System.Windows.Forms.Label();
            this.grpSachMuon = new System.Windows.Forms.GroupBox();
            this.dgvSachMuon = new System.Windows.Forms.DataGridView();
            this.col_MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TinhTrangMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GiaBia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TienCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTraSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuyTra = new Guna.UI2.WinForms.Guna2Button();
            this.grpSachTra = new System.Windows.Forms.GroupBox();
            this.dgvSachTra = new System.Windows.Forms.DataGridView();
            this.colT_MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colT_TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colT_TinhTrangTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colT_TienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colT_GiaBia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXacNhanTra = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.pnlThongtin.SuspendLayout();
            this.grpPhieuMuon.SuspendLayout();
            this.grpSachMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).BeginInit();
            this.grpSachTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachTra)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(982, 60);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnClose.Location = new System.Drawing.Point(915, 0);
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
            this.lblTitle.Size = new System.Drawing.Size(273, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TRẢ SÁCH MƯỢN";
            // 
            // pnlThongtin
            // 
            this.pnlThongtin.Controls.Add(this.grpPhieuMuon);
            this.pnlThongtin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThongtin.Location = new System.Drawing.Point(0, 60);
            this.pnlThongtin.Name = "pnlThongtin";
            this.pnlThongtin.Size = new System.Drawing.Size(982, 192);
            this.pnlThongtin.TabIndex = 2;
            // 
            // grpPhieuMuon
            // 
            this.grpPhieuMuon.Controls.Add(this.lblSoNgayTre);
            this.grpPhieuMuon.Controls.Add(this.txtSoNgayTre);
            this.grpPhieuMuon.Controls.Add(this.dtpNgayTraThucTe);
            this.grpPhieuMuon.Controls.Add(this.lblNgayTraThucTe);
            this.grpPhieuMuon.Controls.Add(this.dtpNgayTra);
            this.grpPhieuMuon.Controls.Add(this.lblNgayTra);
            this.grpPhieuMuon.Controls.Add(this.dtpNgayMuon);
            this.grpPhieuMuon.Controls.Add(this.lblNgayMuon);
            this.grpPhieuMuon.Controls.Add(this.txtTenDocGia);
            this.grpPhieuMuon.Controls.Add(this.lblTenDocGia);
            this.grpPhieuMuon.Controls.Add(this.txtMaDocGia);
            this.grpPhieuMuon.Controls.Add(this.lblMaDocGia);
            this.grpPhieuMuon.Controls.Add(this.txtMaPhieuMuon);
            this.grpPhieuMuon.Controls.Add(this.lblMaPhieuMuon);
            this.grpPhieuMuon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpPhieuMuon.Location = new System.Drawing.Point(12, 6);
            this.grpPhieuMuon.Name = "grpPhieuMuon";
            this.grpPhieuMuon.Size = new System.Drawing.Size(967, 186);
            this.grpPhieuMuon.TabIndex = 0;
            this.grpPhieuMuon.TabStop = false;
            this.grpPhieuMuon.Text = "Thông tin phiếu mượn";
            // 
            // lblMaPhieuMuon
            // 
            this.lblMaPhieuMuon.AutoSize = true;
            this.lblMaPhieuMuon.Location = new System.Drawing.Point(29, 41);
            this.lblMaPhieuMuon.Name = "lblMaPhieuMuon";
            this.lblMaPhieuMuon.Size = new System.Drawing.Size(120, 20);
            this.lblMaPhieuMuon.TabIndex = 0;
            this.lblMaPhieuMuon.Text = "Mã phiếu mượn";
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
            this.txtMaPhieuMuon.Location = new System.Drawing.Point(155, 41);
            this.txtMaPhieuMuon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            this.txtMaPhieuMuon.PlaceholderText = "";
            this.txtMaPhieuMuon.SelectedText = "";
            this.txtMaPhieuMuon.Size = new System.Drawing.Size(185, 34);
            this.txtMaPhieuMuon.TabIndex = 1;
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
            this.txtMaDocGia.Location = new System.Drawing.Point(155, 83);
            this.txtMaDocGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.PlaceholderText = "";
            this.txtMaDocGia.SelectedText = "";
            this.txtMaDocGia.Size = new System.Drawing.Size(185, 34);
            this.txtMaDocGia.TabIndex = 3;
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.AutoSize = true;
            this.lblMaDocGia.Location = new System.Drawing.Point(29, 83);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.Size = new System.Drawing.Size(85, 20);
            this.lblMaDocGia.TabIndex = 2;
            this.lblMaDocGia.Text = "Mã độc giả";
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
            this.txtTenDocGia.Location = new System.Drawing.Point(155, 125);
            this.txtTenDocGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.PlaceholderText = "";
            this.txtTenDocGia.SelectedText = "";
            this.txtTenDocGia.Size = new System.Drawing.Size(185, 34);
            this.txtTenDocGia.TabIndex = 5;
            // 
            // lblTenDocGia
            // 
            this.lblTenDocGia.AutoSize = true;
            this.lblTenDocGia.Location = new System.Drawing.Point(29, 125);
            this.lblTenDocGia.Name = "lblTenDocGia";
            this.lblTenDocGia.Size = new System.Drawing.Size(88, 20);
            this.lblTenDocGia.TabIndex = 4;
            this.lblTenDocGia.Text = "Tên độc giả";
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Location = new System.Drawing.Point(469, 23);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(92, 20);
            this.lblNgayMuon.TabIndex = 6;
            this.lblNgayMuon.Text = "Ngày mượn";
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Checked = true;
            this.dtpNgayMuon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpNgayMuon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(622, 23);
            this.dtpNgayMuon.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayMuon.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(206, 28);
            this.dtpNgayMuon.TabIndex = 7;
            this.dtpNgayMuon.Value = new System.DateTime(2025, 11, 2, 17, 9, 29, 530);
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Location = new System.Drawing.Point(469, 55);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(70, 20);
            this.lblNgayTra.TabIndex = 8;
            this.lblNgayTra.Text = "Ngày trả";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Checked = true;
            this.dtpNgayTra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpNgayTra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(622, 57);
            this.dtpNgayTra.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayTra.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(206, 28);
            this.dtpNgayTra.TabIndex = 9;
            this.dtpNgayTra.Value = new System.DateTime(2025, 11, 2, 17, 9, 29, 530);
            // 
            // lblNgayTraThucTe
            // 
            this.lblNgayTraThucTe.AutoSize = true;
            this.lblNgayTraThucTe.Location = new System.Drawing.Point(469, 91);
            this.lblNgayTraThucTe.Name = "lblNgayTraThucTe";
            this.lblNgayTraThucTe.Size = new System.Drawing.Size(124, 20);
            this.lblNgayTraThucTe.TabIndex = 10;
            this.lblNgayTraThucTe.Text = "Ngày trả thực tế";
            // 
            // dtpNgayTraThucTe
            // 
            this.dtpNgayTraThucTe.Checked = true;
            this.dtpNgayTraThucTe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpNgayTraThucTe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayTraThucTe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTraThucTe.Location = new System.Drawing.Point(622, 91);
            this.dtpNgayTraThucTe.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayTraThucTe.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayTraThucTe.Name = "dtpNgayTraThucTe";
            this.dtpNgayTraThucTe.Size = new System.Drawing.Size(206, 28);
            this.dtpNgayTraThucTe.TabIndex = 11;
            this.dtpNgayTraThucTe.Value = new System.DateTime(2025, 11, 2, 17, 9, 29, 530);
            // 
            // txtSoNgayTre
            // 
            this.txtSoNgayTre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoNgayTre.DefaultText = "";
            this.txtSoNgayTre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoNgayTre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoNgayTre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoNgayTre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoNgayTre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoNgayTre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoNgayTre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoNgayTre.Location = new System.Drawing.Point(622, 125);
            this.txtSoNgayTre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoNgayTre.Name = "txtSoNgayTre";
            this.txtSoNgayTre.PlaceholderText = "";
            this.txtSoNgayTre.SelectedText = "";
            this.txtSoNgayTre.Size = new System.Drawing.Size(206, 34);
            this.txtSoNgayTre.TabIndex = 12;
            // 
            // lblSoNgayTre
            // 
            this.lblSoNgayTre.AutoSize = true;
            this.lblSoNgayTre.Location = new System.Drawing.Point(469, 125);
            this.lblSoNgayTre.Name = "lblSoNgayTre";
            this.lblSoNgayTre.Size = new System.Drawing.Size(88, 20);
            this.lblSoNgayTre.TabIndex = 13;
            this.lblSoNgayTre.Text = "Số ngày trễ";
            // 
            // grpSachMuon
            // 
            this.grpSachMuon.Controls.Add(this.dgvSachMuon);
            this.grpSachMuon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpSachMuon.Location = new System.Drawing.Point(12, 258);
            this.grpSachMuon.Name = "grpSachMuon";
            this.grpSachMuon.Size = new System.Drawing.Size(493, 278);
            this.grpSachMuon.TabIndex = 3;
            this.grpSachMuon.TabStop = false;
            this.grpSachMuon.Text = "Danh sách Sách Mượn";
            // 
            // dgvSachMuon
            // 
            this.dgvSachMuon.AllowUserToAddRows = false;
            this.dgvSachMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSachMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaSach,
            this.col_TenSach,
            this.col_TinhTrangMuon,
            this.col_GiaBia,
            this.col_TienCoc,
            this.col_TrangThai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSachMuon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSachMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSachMuon.EnableHeadersVisualStyles = false;
            this.dgvSachMuon.Location = new System.Drawing.Point(3, 23);
            this.dgvSachMuon.Name = "dgvSachMuon";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSachMuon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSachMuon.RowHeadersVisible = false;
            this.dgvSachMuon.RowHeadersWidth = 51;
            this.dgvSachMuon.RowTemplate.Height = 24;
            this.dgvSachMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachMuon.Size = new System.Drawing.Size(487, 252);
            this.dgvSachMuon.TabIndex = 3;
            // 
            // col_MaSach
            // 
            this.col_MaSach.HeaderText = "Mã Sách";
            this.col_MaSach.MinimumWidth = 6;
            this.col_MaSach.Name = "col_MaSach";
            // 
            // col_TenSach
            // 
            this.col_TenSach.HeaderText = "Tên Sách";
            this.col_TenSach.MinimumWidth = 6;
            this.col_TenSach.Name = "col_TenSach";
            // 
            // col_TinhTrangMuon
            // 
            this.col_TinhTrangMuon.HeaderText = "Tình Trạng Khi Mượn";
            this.col_TinhTrangMuon.MinimumWidth = 6;
            this.col_TinhTrangMuon.Name = "col_TinhTrangMuon";
            // 
            // col_GiaBia
            // 
            this.col_GiaBia.HeaderText = "Giá Bìa";
            this.col_GiaBia.MinimumWidth = 6;
            this.col_GiaBia.Name = "col_GiaBia";
            // 
            // col_TienCoc
            // 
            this.col_TienCoc.HeaderText = "Tiền Cọc";
            this.col_TienCoc.MinimumWidth = 6;
            this.col_TienCoc.Name = "col_TienCoc";
            // 
            // col_TrangThai
            // 
            this.col_TrangThai.HeaderText = "Trạng Thái";
            this.col_TrangThai.MinimumWidth = 6;
            this.col_TrangThai.Name = "col_TrangThai";
            // 
            // btnTraSach
            // 
            this.btnTraSach.BorderRadius = 5;
            this.btnTraSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTraSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTraSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTraSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTraSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnTraSach.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTraSach.ForeColor = System.Drawing.Color.White;
            this.btnTraSach.Location = new System.Drawing.Point(508, 368);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(58, 51);
            this.btnTraSach.TabIndex = 4;
            this.btnTraSach.Text = "Trả Sách";
            // 
            // btnHuyTra
            // 
            this.btnHuyTra.BorderRadius = 5;
            this.btnHuyTra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyTra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyTra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuyTra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuyTra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnHuyTra.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyTra.ForeColor = System.Drawing.Color.White;
            this.btnHuyTra.Location = new System.Drawing.Point(508, 482);
            this.btnHuyTra.Name = "btnHuyTra";
            this.btnHuyTra.Size = new System.Drawing.Size(58, 51);
            this.btnHuyTra.TabIndex = 5;
            this.btnHuyTra.Text = "Hủy Trả";
            // 
            // grpSachTra
            // 
            this.grpSachTra.Controls.Add(this.dgvSachTra);
            this.grpSachTra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpSachTra.Location = new System.Drawing.Point(572, 269);
            this.grpSachTra.Name = "grpSachTra";
            this.grpSachTra.Size = new System.Drawing.Size(395, 267);
            this.grpSachTra.TabIndex = 6;
            this.grpSachTra.TabStop = false;
            this.grpSachTra.Text = "Sách Trả Trong Lần Này";
            // 
            // dgvSachTra
            // 
            this.dgvSachTra.AllowUserToAddRows = false;
            this.dgvSachTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSachTra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSachTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colT_MaSach,
            this.colT_TenSach,
            this.colT_TinhTrangTra,
            this.colT_TienPhat,
            this.colT_GiaBia});
            this.dgvSachTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSachTra.EnableHeadersVisualStyles = false;
            this.dgvSachTra.Location = new System.Drawing.Point(3, 23);
            this.dgvSachTra.Name = "dgvSachTra";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSachTra.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSachTra.RowHeadersVisible = false;
            this.dgvSachTra.RowHeadersWidth = 51;
            this.dgvSachTra.RowTemplate.Height = 24;
            this.dgvSachTra.Size = new System.Drawing.Size(389, 241);
            this.dgvSachTra.TabIndex = 0;
            // 
            // colT_MaSach
            // 
            this.colT_MaSach.HeaderText = "Mã Sách";
            this.colT_MaSach.MinimumWidth = 6;
            this.colT_MaSach.Name = "colT_MaSach";
            // 
            // colT_TenSach
            // 
            this.colT_TenSach.HeaderText = "Tên Sách";
            this.colT_TenSach.MinimumWidth = 6;
            this.colT_TenSach.Name = "colT_TenSach";
            // 
            // colT_TinhTrangTra
            // 
            this.colT_TinhTrangTra.HeaderText = "Tình Trạng Trả";
            this.colT_TinhTrangTra.MinimumWidth = 6;
            this.colT_TinhTrangTra.Name = "colT_TinhTrangTra";
            // 
            // colT_TienPhat
            // 
            this.colT_TienPhat.HeaderText = "Tiền Phạt";
            this.colT_TienPhat.MinimumWidth = 6;
            this.colT_TienPhat.Name = "colT_TienPhat";
            // 
            // colT_GiaBia
            // 
            this.colT_GiaBia.HeaderText = "Giá bìa";
            this.colT_GiaBia.MinimumWidth = 6;
            this.colT_GiaBia.Name = "colT_GiaBia";
            // 
            // btnXacNhanTra
            // 
            this.btnXacNhanTra.BorderRadius = 5;
            this.btnXacNhanTra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhanTra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhanTra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXacNhanTra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXacNhanTra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnXacNhanTra.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacNhanTra.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanTra.Location = new System.Drawing.Point(12, 559);
            this.btnXacNhanTra.Name = "btnXacNhanTra";
            this.btnXacNhanTra.Size = new System.Drawing.Size(195, 51);
            this.btnXacNhanTra.TabIndex = 7;
            this.btnXacNhanTra.Text = "Xác nhận Trả";
            // 
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 5;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(769, 559);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(195, 51);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            // 
            // frmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhanTra);
            this.Controls.Add(this.grpSachTra);
            this.Controls.Add(this.btnHuyTra);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.grpSachMuon);
            this.Controls.Add(this.pnlThongtin);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmTraSach";
            this.Text = "frmTraSach";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlThongtin.ResumeLayout(false);
            this.grpPhieuMuon.ResumeLayout(false);
            this.grpPhieuMuon.PerformLayout();
            this.grpSachMuon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).EndInit();
            this.grpSachTra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachTra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlThongtin;
        private System.Windows.Forms.GroupBox grpPhieuMuon;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label lblNgayMuon;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDocGia;
        private System.Windows.Forms.Label lblTenDocGia;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDocGia;
        private System.Windows.Forms.Label lblMaDocGia;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPhieuMuon;
        private System.Windows.Forms.Label lblMaPhieuMuon;
        private System.Windows.Forms.Label lblSoNgayTre;
        private Guna.UI2.WinForms.Guna2TextBox txtSoNgayTre;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayTraThucTe;
        private System.Windows.Forms.Label lblNgayTraThucTe;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.GroupBox grpSachMuon;
        private System.Windows.Forms.DataGridView dgvSachMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TinhTrangMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GiaBia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TienCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TrangThai;
        private Guna.UI2.WinForms.Guna2Button btnTraSach;
        private Guna.UI2.WinForms.Guna2Button btnHuyTra;
        private System.Windows.Forms.GroupBox grpSachTra;
        private System.Windows.Forms.DataGridView dgvSachTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colT_MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colT_TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colT_TinhTrangTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colT_TienPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colT_GiaBia;
        private Guna.UI2.WinForms.Guna2Button btnXacNhanTra;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    }
}