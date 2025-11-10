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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbThongTinPhieu = new System.Windows.Forms.GroupBox();
            this.txtMaDocGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaPhieuMuon = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTongTienCoc = new System.Windows.Forms.Label();
            this.txtTongTienCoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenDocGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenDocGia = new System.Windows.Forms.Label();
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.gbDanhSachSach = new System.Windows.Forms.GroupBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnHuy = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dgvSachMuon = new System.Windows.Forms.DataGridView();
            this.btnClear = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoaSach = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnChonSach = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtSearchSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.Ma_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_Dau_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Dau_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia_Bia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tinh_Trang = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
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
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // gbThongTinPhieu
            // 
            this.gbThongTinPhieu.Controls.Add(this.txtMaDocGia);
            this.gbThongTinPhieu.Controls.Add(this.txtMaPhieuMuon);
            this.gbThongTinPhieu.Controls.Add(this.lblTongTienCoc);
            this.gbThongTinPhieu.Controls.Add(this.txtTongTienCoc);
            this.gbThongTinPhieu.Controls.Add(this.txtTenDocGia);
            this.gbThongTinPhieu.Controls.Add(this.lblTenDocGia);
            this.gbThongTinPhieu.Controls.Add(this.lblMaDocGia);
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
            this.txtMaDocGia.Location = new System.Drawing.Point(147, 85);
            this.txtMaDocGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.PlaceholderText = "";
            this.txtMaDocGia.SelectedText = "";
            this.txtMaDocGia.Size = new System.Drawing.Size(225, 35);
            this.txtMaDocGia.TabIndex = 29;
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
            this.txtMaPhieuMuon.Location = new System.Drawing.Point(147, 30);
            this.txtMaPhieuMuon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            this.txtMaPhieuMuon.PlaceholderText = "";
            this.txtMaPhieuMuon.SelectedText = "";
            this.txtMaPhieuMuon.Size = new System.Drawing.Size(225, 35);
            this.txtMaPhieuMuon.TabIndex = 13;
            // 
            // lblTongTienCoc
            // 
            this.lblTongTienCoc.AutoSize = true;
            this.lblTongTienCoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTienCoc.Location = new System.Drawing.Point(575, 100);
            this.lblTongTienCoc.Name = "lblTongTienCoc";
            this.lblTongTienCoc.Size = new System.Drawing.Size(103, 20);
            this.lblTongTienCoc.TabIndex = 12;
            this.lblTongTienCoc.Text = "Tổng tiền cọc";
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
            this.txtTongTienCoc.Location = new System.Drawing.Point(725, 90);
            this.txtTongTienCoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongTienCoc.Name = "txtTongTienCoc";
            this.txtTongTienCoc.PlaceholderText = "";
            this.txtTongTienCoc.ReadOnly = true;
            this.txtTongTienCoc.SelectedText = "";
            this.txtTongTienCoc.Size = new System.Drawing.Size(225, 41);
            this.txtTongTienCoc.TabIndex = 8;
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
            this.txtTenDocGia.Location = new System.Drawing.Point(725, 24);
            this.txtTenDocGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.PlaceholderText = "";
            this.txtTenDocGia.ReadOnly = true;
            this.txtTenDocGia.SelectedText = "";
            this.txtTenDocGia.Size = new System.Drawing.Size(225, 41);
            this.txtTenDocGia.TabIndex = 6;
            // 
            // lblTenDocGia
            // 
            this.lblTenDocGia.AutoSize = true;
            this.lblTenDocGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenDocGia.Location = new System.Drawing.Point(575, 30);
            this.lblTenDocGia.Name = "lblTenDocGia";
            this.lblTenDocGia.Size = new System.Drawing.Size(88, 20);
            this.lblTenDocGia.TabIndex = 5;
            this.lblTenDocGia.Text = "Tên độc giả";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSachMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Sach,
            this.Ma_Dau_Sach,
            this.Ten_Dau_Sach,
            this.Gia_Bia,
            this.Tinh_Trang});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSachMuon.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSachMuon.EnableHeadersVisualStyles = false;
            this.dgvSachMuon.Location = new System.Drawing.Point(6, 105);
            this.dgvSachMuon.Name = "dgvSachMuon";
            this.dgvSachMuon.RowHeadersVisible = false;
            this.dgvSachMuon.RowHeadersWidth = 51;
            this.dgvSachMuon.RowTemplate.Height = 24;
            this.dgvSachMuon.Size = new System.Drawing.Size(982, 255);
            this.dgvSachMuon.TabIndex = 4;
            this.dgvSachMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSachMuon_CellContentClick);
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
            this.btnChonSach.Click += new System.EventHandler(this.btnChonSach_Click);
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
            this.txtSearchSach.IconLeft = global::ProjectNhom4.Properties.Resources.search;
            this.txtSearchSach.Location = new System.Drawing.Point(25, 30);
            this.txtSearchSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchSach.Name = "txtSearchSach";
            this.txtSearchSach.PlaceholderText = "Tìm mã/tên sách...";
            this.txtSearchSach.SelectedText = "";
            this.txtSearchSach.Size = new System.Drawing.Size(424, 48);
            this.txtSearchSach.TabIndex = 0;
            // 
            // Ma_Sach
            // 
            this.Ma_Sach.HeaderText = "Mã sách";
            this.Ma_Sach.MinimumWidth = 6;
            this.Ma_Sach.Name = "Ma_Sach";
            // 
            // Ma_Dau_Sach
            // 
            this.Ma_Dau_Sach.DataPropertyName = "Ma_Dau_Sach";
            this.Ma_Dau_Sach.HeaderText = "Mã Đầu Sách";
            this.Ma_Dau_Sach.MinimumWidth = 6;
            this.Ma_Dau_Sach.Name = "Ma_Dau_Sach";
            // 
            // Ten_Dau_Sach
            // 
            this.Ten_Dau_Sach.DataPropertyName = "Ten_Dau_Sach";
            this.Ten_Dau_Sach.HeaderText = "Tên Đầu Sách";
            this.Ten_Dau_Sach.MinimumWidth = 6;
            this.Ten_Dau_Sach.Name = "Ten_Dau_Sach";
            // 
            // Gia_Bia
            // 
            this.Gia_Bia.DataPropertyName = "Gia_Bia ";
            this.Gia_Bia.HeaderText = "Giá bìa";
            this.Gia_Bia.MinimumWidth = 6;
            this.Gia_Bia.Name = "Gia_Bia";
            // 
            // Tinh_Trang
            // 
            this.Tinh_Trang.DataPropertyName = "Tinh_Trang";
            this.Tinh_Trang.HeaderText = "Tình trạng";
            this.Tinh_Trang.MinimumWidth = 6;
            this.Tinh_Trang.Name = "Tinh_Trang";
            // 
            // frmMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.gbDanhSachSach);
            this.Controls.Add(this.gbThongTinPhieu);
            this.Controls.Add(this.pnlHeader);
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
        private System.Windows.Forms.Label lblMaPhieu;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDocGia;
        private System.Windows.Forms.Label lblTenDocGia;
        private System.Windows.Forms.Label lblMaDocGia;
        private System.Windows.Forms.Label lblTongTienCoc;
        private Guna.UI2.WinForms.Guna2TextBox txtTongTienCoc;
        private System.Windows.Forms.GroupBox gbDanhSachSach;
        private Guna.UI2.WinForms.Guna2GradientButton btnChonSach;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchSach;
        private Guna.UI2.WinForms.Guna2GradientButton btnClear;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoaSach;
        private System.Windows.Forms.DataGridView dgvSachMuon;
        private System.Windows.Forms.Panel pnlFooter;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnHuy;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPhieuMuon;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Dau_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Dau_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia_Bia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tinh_Trang;
    }
}