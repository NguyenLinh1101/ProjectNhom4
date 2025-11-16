namespace ProjectNhom4
{
    partial class UC_QuanlyThongTinTacGia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblqlTacGia = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.dgvTacGia = new System.Windows.Forms.DataGridView();
            this.Ma_Tac_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Tac_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioi_Tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quoc_Tich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.errorProviderTacGia = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelRoot = new System.Windows.Forms.Panel();
            this.grbTTTG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTacGia)).BeginInit();
            this.panelRoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblqlTacGia
            // 
            this.lblqlTacGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblqlTacGia.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblqlTacGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.lblqlTacGia.Location = new System.Drawing.Point(0, 4);
            this.lblqlTacGia.Name = "lblqlTacGia";
            this.lblqlTacGia.Size = new System.Drawing.Size(1262, 68);
            this.lblqlTacGia.TabIndex = 8;
            this.lblqlTacGia.Text = "QUẢN LÝ TÁC GIẢ";
            this.lblqlTacGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblqlTacGia.Click += new System.EventHandler(this.lblDauSach_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderRadius = 35;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::ProjectNhom4.Properties.Resources.search;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtSearch.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtSearch.Location = new System.Drawing.Point(111, 80);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = "Nhập để tìm kiếm tác giả";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(1020, 66);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // grbTTTG
            // 
            this.grbTTTG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTTTG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            this.grbTTTG.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbTTTG.ForeColor = System.Drawing.Color.Black;
            this.grbTTTG.Location = new System.Drawing.Point(127, 179);
            this.grbTTTG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTTTG.Name = "grbTTTG";
            this.grbTTTG.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTTTG.Size = new System.Drawing.Size(956, 306);
            this.grbTTTG.TabIndex = 10;
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
            // dgvTacGia
            // 
            this.dgvTacGia.AllowUserToAddRows = false;
            this.dgvTacGia.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTacGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTacGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTacGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTacGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTacGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTacGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTacGia.ColumnHeadersHeight = 50;
            this.dgvTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Tac_Gia,
            this.Ten_Tac_Gia,
            this.Ngay_Sinh,
            this.Gioi_Tinh,
            this.Quoc_Tich});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTacGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTacGia.EnableHeadersVisualStyles = false;
            this.dgvTacGia.GridColor = System.Drawing.Color.Black;
            this.dgvTacGia.Location = new System.Drawing.Point(73, 493);
            this.dgvTacGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTacGia.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTacGia.RowHeadersWidth = 72;
            this.dgvTacGia.RowTemplate.Height = 28;
            this.dgvTacGia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTacGia.Size = new System.Drawing.Size(1133, 489);
            this.dgvTacGia.TabIndex = 11;
            this.dgvTacGia.SelectionChanged += new System.EventHandler(this.dgvTacGia_SelectionChanged);
            // 
            // Ma_Tac_Gia
            // 
            this.Ma_Tac_Gia.DataPropertyName = "Ma_Tac_Gia";
            this.Ma_Tac_Gia.HeaderText = "Mã tác giả";
            this.Ma_Tac_Gia.MinimumWidth = 9;
            this.Ma_Tac_Gia.Name = "Ma_Tac_Gia";
            // 
            // Ten_Tac_Gia
            // 
            this.Ten_Tac_Gia.DataPropertyName = "Ten_Tac_Gia";
            this.Ten_Tac_Gia.HeaderText = "Tên tác giả";
            this.Ten_Tac_Gia.MinimumWidth = 9;
            this.Ten_Tac_Gia.Name = "Ten_Tac_Gia";
            // 
            // Ngay_Sinh
            // 
            this.Ngay_Sinh.DataPropertyName = "Ngay_Sinh";
            this.Ngay_Sinh.HeaderText = "Ngày sinh";
            this.Ngay_Sinh.MinimumWidth = 9;
            this.Ngay_Sinh.Name = "Ngay_Sinh";
            // 
            // Gioi_Tinh
            // 
            this.Gioi_Tinh.DataPropertyName = "Gioi_Tinh";
            this.Gioi_Tinh.HeaderText = "Giới tính";
            this.Gioi_Tinh.MinimumWidth = 9;
            this.Gioi_Tinh.Name = "Gioi_Tinh";
            // 
            // Quoc_Tich
            // 
            this.Quoc_Tich.DataPropertyName = "Quoc_Tich";
            this.Quoc_Tich.HeaderText = "Quốc tịch";
            this.Quoc_Tich.MinimumWidth = 9;
            this.Quoc_Tich.Name = "Quoc_Tich";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.Controls.Add(this.btnLuu);
            this.guna2Panel1.Controls.Add(this.btnSua);
            this.guna2Panel1.Controls.Add(this.btnHuy);
            this.guna2Panel1.Controls.Add(this.btnThem);
            this.guna2Panel1.Controls.Add(this.btnXoa);
            this.guna2Panel1.Location = new System.Drawing.Point(127, 1005);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1047, 88);
            this.guna2Panel1.TabIndex = 21;
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
            this.btnLuu.Location = new System.Drawing.Point(669, 13);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(137, 66);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btnSua.Location = new System.Drawing.Point(251, 13);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(137, 66);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
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
            this.btnHuy.Location = new System.Drawing.Point(878, 13);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(137, 66);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BorderColor = System.Drawing.Color.Transparent;
            this.btnThem.BorderThickness = 2;
            this.btnThem.CheckedState.FillColor = System.Drawing.Color.White;
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
            this.btnThem.Location = new System.Drawing.Point(42, 13);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 66);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(460, 13);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 66);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // errorProviderTacGia
            // 
            this.errorProviderTacGia.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProviderTacGia.ContainerControl = this;
            // 
            // panelRoot
            // 
            this.panelRoot.Controls.Add(this.guna2Panel1);
            this.panelRoot.Controls.Add(this.dgvTacGia);
            this.panelRoot.Controls.Add(this.grbTTTG);
            this.panelRoot.Controls.Add(this.txtSearch);
            this.panelRoot.Controls.Add(this.lblqlTacGia);
            this.panelRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRoot.Location = new System.Drawing.Point(0, 0);
            this.panelRoot.Name = "panelRoot";
            this.panelRoot.Size = new System.Drawing.Size(1262, 1102);
            this.panelRoot.TabIndex = 22;
            // 
            // UC_QuanlyThongTinTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRoot);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_QuanlyThongTinTacGia";
            this.Size = new System.Drawing.Size(1262, 1102);
            this.Load += new System.EventHandler(this.UC_QuanlyThongTinTacGia_Load);
            this.grbTTTG.ResumeLayout(false);
            this.grbTTTG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTacGia)).EndInit();
            this.panelRoot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblqlTacGia;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.GroupBox grbTTTG;
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
        private Guna.UI2.WinForms.Guna2ComboBox cbGioiTinh;
        private System.Windows.Forms.DataGridView dgvTacGia;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private System.Windows.Forms.ErrorProvider errorProviderTacGia;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Tac_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Tac_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioi_Tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quoc_Tich;
        private Guna.UI2.WinForms.Guna2ComboBox cboQuocTich;
        private System.Windows.Forms.Panel panelRoot;
    }
}
