namespace ProjectNhom4
{
    partial class UC_PhieuMuonSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbTruong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.MaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.MaThuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblChiTietDS = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.flpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.48148F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.51852F));
            this.tlpMain.Controls.Add(this.pnlLeft, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1350, 700);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlButtons);
            this.pnlLeft.Controls.Add(this.lblChiTietDS);
            this.pnlLeft.Controls.Add(this.dgvPhieuMuon);
            this.pnlLeft.Controls.Add(this.pnlSearch);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(3, 53);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(607, 644);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Controls.Add(this.cbTruong);
            this.pnlSearch.Controls.Add(this.txtTimKiem);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(607, 100);
            this.pnlSearch.TabIndex = 0;
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
            this.txtTimKiem.Location = new System.Drawing.Point(172, 35);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.PlaceholderText = "Nhập để tìm kiếm ";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(394, 36);
            this.txtTimKiem.TabIndex = 10;
            // 
            // cbTruong
            // 
            this.cbTruong.BackColor = System.Drawing.Color.Transparent;
            this.cbTruong.BorderColor = System.Drawing.Color.Silver;
            this.cbTruong.BorderRadius = 8;
            this.cbTruong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTruong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTruong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTruong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTruong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTruong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTruong.ItemHeight = 30;
            this.cbTruong.Items.AddRange(new object[] {
            "Mã Phiếu Mượn",
            "Mã Độc Giả",
            "Ngày Mượn"});
            this.cbTruong.Location = new System.Drawing.Point(27, 35);
            this.cbTruong.Name = "cbTruong";
            this.cbTruong.Size = new System.Drawing.Size(130, 36);
            this.cbTruong.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tên trường";
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuMuon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuMuon,
            this.MaDocGia,
            this.NgayMuon,
            this.NgayTra,
            this.TienCoc,
            this.KieuMuon,
            this.MaThuThu});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieuMuon.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPhieuMuon.EnableHeadersVisualStyles = false;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(6, 106);
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.RowHeadersVisible = false;
            this.dgvPhieuMuon.RowHeadersWidth = 51;
            this.dgvPhieuMuon.RowTemplate.Height = 24;
            this.dgvPhieuMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(597, 512);
            this.dgvPhieuMuon.TabIndex = 1;
            // 
            // MaPhieuMuon
            // 
            this.MaPhieuMuon.HeaderText = "Mã Phiếu Mượn";
            this.MaPhieuMuon.MinimumWidth = 6;
            this.MaPhieuMuon.Name = "MaPhieuMuon";
            // 
            // MaDocGia
            // 
            this.MaDocGia.HeaderText = "Mã Độc Giả";
            this.MaDocGia.MinimumWidth = 6;
            this.MaDocGia.Name = "MaDocGia";
            // 
            // NgayMuon
            // 
            this.NgayMuon.HeaderText = "Ngày Mượn";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            // 
            // NgayTra
            // 
            this.NgayTra.HeaderText = "Ngày Trả";
            this.NgayTra.MinimumWidth = 6;
            this.NgayTra.Name = "NgayTra";
            // 
            // TienCoc
            // 
            this.TienCoc.HeaderText = "Tiền Cọc";
            this.TienCoc.MinimumWidth = 6;
            this.TienCoc.Name = "TienCoc";
            // 
            // KieuMuon
            // 
            this.KieuMuon.HeaderText = "Kiểu Mượn";
            this.KieuMuon.MinimumWidth = 6;
            this.KieuMuon.Name = "KieuMuon";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.flpButtons);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 574);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(607, 70);
            this.pnlButtons.TabIndex = 2;
            // 
            // flpButtons
            // 
            this.flpButtons.Controls.Add(this.btnThem);
            this.flpButtons.Controls.Add(this.btnSua);
            this.flpButtons.Controls.Add(this.btnXoa);
            this.flpButtons.Controls.Add(this.btnLuu);
            this.flpButtons.Controls.Add(this.btnHuy);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpButtons.Location = new System.Drawing.Point(0, 0);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.flpButtons.Size = new System.Drawing.Size(607, 70);
            this.flpButtons.TabIndex = 0;
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
            this.btnThem.Location = new System.Drawing.Point(13, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 39);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
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
            this.btnSua.Location = new System.Drawing.Point(127, 13);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 39);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
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
            this.btnXoa.Location = new System.Drawing.Point(241, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 39);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
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
            this.btnLuu.Location = new System.Drawing.Point(355, 13);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(108, 39);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Lưu";
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
            this.btnHuy.Location = new System.Drawing.Point(469, 13);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(108, 39);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            // 
            // MaThuThu
            // 
            this.MaThuThu.HeaderText = "Mã Thủ Thư";
            this.MaThuThu.MinimumWidth = 6;
            this.MaThuThu.Name = "MaThuThu";
            // 
            // lblChiTietDS
            // 
            this.lblChiTietDS.AutoSize = true;
            this.lblChiTietDS.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietDS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(76)))), ((int)(((byte)(170)))));
            this.lblChiTietDS.Location = new System.Drawing.Point(85, 241);
            this.lblChiTietDS.Name = "lblChiTietDS";
            this.lblChiTietDS.Size = new System.Drawing.Size(533, 54);
            this.lblChiTietDS.TabIndex = 6;
            this.lblChiTietDS.Text = "DANH SÁCH PHIẾU MƯỢN";
            // 
            // UC_PhieuMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.tlpMain);
            this.Name = "UC_PhieuMuonSach";
            this.Size = new System.Drawing.Size(1350, 700);
            this.tlpMain.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.flpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cbTruong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn KieuMuon;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuThu;
        private System.Windows.Forms.Label lblChiTietDS;
    }
}
