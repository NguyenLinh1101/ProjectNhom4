namespace ProjectNhom4
{
    partial class frmQuanlyCuonSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gnlPanelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTieude = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.grpDauSach = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvDauSach = new Guna.UI2.WinForms.Guna2DataGridView();
            this.grpCuonSach = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvCuonSach = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnChitiet = new Guna.UI2.WinForms.Guna2Button();
            this.gnlPanelHeader.SuspendLayout();
            this.grpDauSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).BeginInit();
            this.grpCuonSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // gnlPanelHeader
            // 
            this.gnlPanelHeader.Controls.Add(this.lblTieude);
            this.gnlPanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gnlPanelHeader.Location = new System.Drawing.Point(0, 0);
            this.gnlPanelHeader.Name = "gnlPanelHeader";
            this.gnlPanelHeader.Size = new System.Drawing.Size(1500, 80);
            this.gnlPanelHeader.TabIndex = 0;
            this.gnlPanelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.gnlPanelHeader_Paint);
            // 
            // lblTieude
            // 
            this.lblTieude.AutoSize = true;
            this.lblTieude.BackColor = System.Drawing.Color.Transparent;
            this.lblTieude.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTieude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblTieude.Location = new System.Drawing.Point(576, 9);
            this.lblTieude.Name = "lblTieude";
            this.lblTieude.Size = new System.Drawing.Size(529, 65);
            this.lblTieude.TabIndex = 0;
            this.lblTieude.Text = "QUẢN LÝ CUỐN SÁCH";
            this.lblTieude.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsTab = true;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
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
            this.txtSearch.Location = new System.Drawing.Point(118, 121);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = "Nhập để tìm kiếm cuốn sách";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(1359, 64);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // grpDauSach
            // 
            this.grpDauSach.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpDauSach.BorderRadius = 10;
            this.grpDauSach.Controls.Add(this.dgvDauSach);
            this.grpDauSach.CustomBorderColor = System.Drawing.Color.Silver;
            this.grpDauSach.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpDauSach.ForeColor = System.Drawing.Color.Black;
            this.grpDauSach.Location = new System.Drawing.Point(56, 230);
            this.grpDauSach.Name = "grpDauSach";
            this.grpDauSach.Size = new System.Drawing.Size(698, 454);
            this.grpDauSach.TabIndex = 8;
            this.grpDauSach.Text = "THÔNG TIN ĐẦU SÁCH";
            this.grpDauSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvDauSach
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDauSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDauSach.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDauSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDauSach.ColumnHeadersHeight = 27;
            this.dgvDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDauSach.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDauSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDauSach.GridColor = System.Drawing.Color.DarkGray;
            this.dgvDauSach.Location = new System.Drawing.Point(0, 40);
            this.dgvDauSach.Name = "dgvDauSach";
            this.dgvDauSach.ReadOnly = true;
            this.dgvDauSach.RowHeadersVisible = false;
            this.dgvDauSach.RowHeadersWidth = 51;
            this.dgvDauSach.RowTemplate.Height = 24;
            this.dgvDauSach.Size = new System.Drawing.Size(698, 414);
            this.dgvDauSach.TabIndex = 0;
            this.dgvDauSach.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDauSach.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDauSach.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDauSach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDauSach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDauSach.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDauSach.ThemeStyle.GridColor = System.Drawing.Color.DarkGray;
            this.dgvDauSach.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDauSach.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDauSach.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDauSach.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDauSach.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDauSach.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvDauSach.ThemeStyle.ReadOnly = true;
            this.dgvDauSach.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDauSach.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDauSach.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDauSach.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDauSach.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDauSach.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDauSach.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDauSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDauSach_CellContentClick);
            // 
            // grpCuonSach
            // 
            this.grpCuonSach.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpCuonSach.BorderRadius = 10;
            this.grpCuonSach.Controls.Add(this.dgvCuonSach);
            this.grpCuonSach.CustomBorderColor = System.Drawing.Color.Silver;
            this.grpCuonSach.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpCuonSach.ForeColor = System.Drawing.Color.Black;
            this.grpCuonSach.Location = new System.Drawing.Point(760, 230);
            this.grpCuonSach.Name = "grpCuonSach";
            this.grpCuonSach.Size = new System.Drawing.Size(698, 454);
            this.grpCuonSach.TabIndex = 9;
            this.grpCuonSach.Text = "THÔNG TIN CUỐN SÁCH";
            this.grpCuonSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvCuonSach
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvCuonSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCuonSach.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuonSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCuonSach.ColumnHeadersHeight = 27;
            this.dgvCuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCuonSach.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCuonSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCuonSach.GridColor = System.Drawing.Color.DarkGray;
            this.dgvCuonSach.Location = new System.Drawing.Point(0, 40);
            this.dgvCuonSach.Name = "dgvCuonSach";
            this.dgvCuonSach.ReadOnly = true;
            this.dgvCuonSach.RowHeadersVisible = false;
            this.dgvCuonSach.RowHeadersWidth = 51;
            this.dgvCuonSach.RowTemplate.Height = 24;
            this.dgvCuonSach.Size = new System.Drawing.Size(698, 414);
            this.dgvCuonSach.TabIndex = 0;
            this.dgvCuonSach.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCuonSach.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCuonSach.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCuonSach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCuonSach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCuonSach.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCuonSach.ThemeStyle.GridColor = System.Drawing.Color.DarkGray;
            this.dgvCuonSach.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCuonSach.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCuonSach.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvCuonSach.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCuonSach.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCuonSach.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvCuonSach.ThemeStyle.ReadOnly = true;
            this.dgvCuonSach.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCuonSach.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCuonSach.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvCuonSach.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCuonSach.ThemeStyle.RowsStyle.Height = 24;
            this.dgvCuonSach.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCuonSach.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCuonSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuonSach_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 10;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(56, 732);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(158, 55);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 10;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(431, 732);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(158, 55);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(885, 732);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(158, 55);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChitiet
            // 
            this.btnChitiet.BorderRadius = 10;
            this.btnChitiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChitiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChitiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChitiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChitiet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnChitiet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChitiet.ForeColor = System.Drawing.Color.White;
            this.btnChitiet.Location = new System.Drawing.Point(1300, 732);
            this.btnChitiet.Name = "btnChitiet";
            this.btnChitiet.Size = new System.Drawing.Size(158, 55);
            this.btnChitiet.TabIndex = 16;
            this.btnChitiet.Text = "Xem chi tiết";
            this.btnChitiet.Click += new System.EventHandler(this.btnChitiet_Click);
            // 
            // frmQuanlyCuonSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.btnChitiet);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpCuonSach);
            this.Controls.Add(this.grpDauSach);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gnlPanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanlyCuonSach";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanlyCuonsach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanlyCuonSach_Load);
            this.gnlPanelHeader.ResumeLayout(false);
            this.gnlPanelHeader.PerformLayout();
            this.grpDauSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).EndInit();
            this.grpCuonSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuonSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel gnlPanelHeader;
        private System.Windows.Forms.Label lblTieude;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2GroupBox grpDauSach;
        private Guna.UI2.WinForms.Guna2GroupBox grpCuonSach;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCuonSach;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnChitiet;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDauSach;
    }
}