namespace ProjectNhom4
{
    partial class frmTacgiaSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle73 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle74 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle75 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle76 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle77 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle78 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvThongTinTacGia = new Guna.UI2.WinForms.Guna2DataGridView();
            this.grpDauSach = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.dgvThongTinDauSach = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnChitiet = new Guna.UI2.WinForms.Guna2Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuaTacGia = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinTacGia)).BeginInit();
            this.grpDauSach.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinDauSach)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongTinTacGia
            // 
            dataGridViewCellStyle73.BackColor = System.Drawing.Color.White;
            this.dgvThongTinTacGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle73;
            this.dgvThongTinTacGia.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle74.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle74.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle74.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle74.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle74.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle74.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinTacGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle74;
            this.dgvThongTinTacGia.ColumnHeadersHeight = 27;
            this.dgvThongTinTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle75.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle75.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle75.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle75.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle75.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle75.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongTinTacGia.DefaultCellStyle = dataGridViewCellStyle75;
            this.dgvThongTinTacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongTinTacGia.GridColor = System.Drawing.Color.DarkGray;
            this.dgvThongTinTacGia.Location = new System.Drawing.Point(0, 40);
            this.dgvThongTinTacGia.Name = "dgvThongTinTacGia";
            this.dgvThongTinTacGia.RowHeadersVisible = false;
            this.dgvThongTinTacGia.RowHeadersWidth = 51;
            this.dgvThongTinTacGia.RowTemplate.Height = 24;
            this.dgvThongTinTacGia.Size = new System.Drawing.Size(648, 508);
            this.dgvThongTinTacGia.TabIndex = 0;
            this.dgvThongTinTacGia.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinTacGia.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThongTinTacGia.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThongTinTacGia.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThongTinTacGia.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThongTinTacGia.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvThongTinTacGia.ThemeStyle.GridColor = System.Drawing.Color.DarkGray;
            this.dgvThongTinTacGia.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvThongTinTacGia.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongTinTacGia.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvThongTinTacGia.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongTinTacGia.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThongTinTacGia.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvThongTinTacGia.ThemeStyle.ReadOnly = false;
            this.dgvThongTinTacGia.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinTacGia.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongTinTacGia.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvThongTinTacGia.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvThongTinTacGia.ThemeStyle.RowsStyle.Height = 24;
            this.dgvThongTinTacGia.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongTinTacGia.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongTinTacGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDauSach_CellContentClick);
            // 
            // grpDauSach
            // 
            this.grpDauSach.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpDauSach.BorderRadius = 10;
            this.grpDauSach.Controls.Add(this.btnBack);
            this.grpDauSach.Controls.Add(this.dgvThongTinTacGia);
            this.grpDauSach.CustomBorderColor = System.Drawing.Color.Silver;
            this.grpDauSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDauSach.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpDauSach.ForeColor = System.Drawing.Color.Black;
            this.grpDauSach.Location = new System.Drawing.Point(0, 0);
            this.grpDauSach.Name = "grpDauSach";
            this.grpDauSach.Size = new System.Drawing.Size(648, 548);
            this.grpDauSach.TabIndex = 9;
            this.grpDauSach.Text = "THÔNG TIN TÁC GIẢ";
            this.grpDauSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.grpDauSach.Click += new System.EventHandler(this.grpDauSach_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.OrangeRed;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::ProjectNhom4.Properties.Resources.go_back_arrow;
            this.btnBack.Location = new System.Drawing.Point(469, 18);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBack.Size = new System.Drawing.Size(37, 36);
            this.btnBack.TabIndex = 18;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.AutoScroll = true;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.guna2CircleButton1);
            this.guna2GroupBox1.Controls.Add(this.dgvThongTinDauSach);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(678, 548);
            this.guna2GroupBox1.TabIndex = 10;
            this.guna2GroupBox1.Text = "THÔNG TIN ĐẦU SÁCH";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2CircleButton1.BackColor = System.Drawing.Color.Silver;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = global::ProjectNhom4.Properties.Resources.go_back_arrow;
            this.guna2CircleButton1.Location = new System.Drawing.Point(490, 18);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(37, 36);
            this.guna2CircleButton1.TabIndex = 19;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // dgvThongTinDauSach
            // 
            dataGridViewCellStyle76.BackColor = System.Drawing.Color.White;
            this.dgvThongTinDauSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle76;
            this.dgvThongTinDauSach.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle77.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle77.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle77.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle77.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle77.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle77.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle77.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinDauSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle77;
            this.dgvThongTinDauSach.ColumnHeadersHeight = 27;
            this.dgvThongTinDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle78.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle78.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle78.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle78.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle78.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle78.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle78.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongTinDauSach.DefaultCellStyle = dataGridViewCellStyle78;
            this.dgvThongTinDauSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongTinDauSach.GridColor = System.Drawing.Color.DarkGray;
            this.dgvThongTinDauSach.Location = new System.Drawing.Point(0, 40);
            this.dgvThongTinDauSach.Name = "dgvThongTinDauSach";
            this.dgvThongTinDauSach.ReadOnly = true;
            this.dgvThongTinDauSach.RowHeadersVisible = false;
            this.dgvThongTinDauSach.RowHeadersWidth = 51;
            this.dgvThongTinDauSach.RowTemplate.Height = 24;
            this.dgvThongTinDauSach.Size = new System.Drawing.Size(678, 508);
            this.dgvThongTinDauSach.TabIndex = 0;
            this.dgvThongTinDauSach.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinDauSach.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThongTinDauSach.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThongTinDauSach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThongTinDauSach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThongTinDauSach.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvThongTinDauSach.ThemeStyle.GridColor = System.Drawing.Color.DarkGray;
            this.dgvThongTinDauSach.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvThongTinDauSach.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongTinDauSach.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvThongTinDauSach.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongTinDauSach.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThongTinDauSach.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvThongTinDauSach.ThemeStyle.ReadOnly = true;
            this.dgvThongTinDauSach.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinDauSach.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongTinDauSach.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvThongTinDauSach.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvThongTinDauSach.ThemeStyle.RowsStyle.Height = 24;
            this.dgvThongTinDauSach.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongTinDauSach.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongTinDauSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
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
            this.btnChitiet.Location = new System.Drawing.Point(1101, 15);
            this.btnChitiet.Name = "btnChitiet";
            this.btnChitiet.Size = new System.Drawing.Size(185, 55);
            this.btnChitiet.TabIndex = 17;
            this.btnChitiet.Text = "Xem chi tiết";
            this.btnChitiet.Click += new System.EventHandler(this.btnChitiet_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsTab = true;
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtSearch.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtSearch.Location = new System.Drawing.Point(113, 92);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = "Nhập để tìm kiếm cuốn sách";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(1119, 64);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.label1.Location = new System.Drawing.Point(-20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1359, 45);
            this.label1.TabIndex = 18;
            this.label1.Text = "QUẢN LÝ TÁC GIẢ SÁCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(80, 0, 80, 0);
            this.panel1.Size = new System.Drawing.Size(1490, 827);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SuaTacGia
            // 
            this.SuaTacGia.BorderRadius = 10;
            this.SuaTacGia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SuaTacGia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SuaTacGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SuaTacGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SuaTacGia.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SuaTacGia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SuaTacGia.ForeColor = System.Drawing.Color.White;
            this.SuaTacGia.Location = new System.Drawing.Point(738, 15);
            this.SuaTacGia.Name = "SuaTacGia";
            this.SuaTacGia.Size = new System.Drawing.Size(113, 55);
            this.SuaTacGia.TabIndex = 19;
            this.SuaTacGia.Text = "Sửa";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(922, 15);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(121, 55);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "Lưu";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2Button1);
            this.panel3.Controls.Add(this.SuaTacGia);
            this.panel3.Controls.Add(this.btnChitiet);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(80, 743);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1330, 84);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(80, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1330, 195);
            this.panel4.TabIndex = 21;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(80, 195);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.guna2GroupBox1);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpDauSach);
            this.splitContainer1.Size = new System.Drawing.Size(1330, 548);
            this.splitContainer1.SplitterDistance = 678;
            this.splitContainer1.TabIndex = 10;
            // 
            // frmTacgiaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 827);
            this.Controls.Add(this.panel1);
            this.Name = "frmTacgiaSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTacgiaSach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTacgiaSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinTacGia)).EndInit();
            this.grpDauSach.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinDauSach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThongTinTacGia;
        private Guna.UI2.WinForms.Guna2GroupBox grpDauSach;
        private Guna.UI2.WinForms.Guna2CircleButton btnBack;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThongTinDauSach;
        private Guna.UI2.WinForms.Guna2Button btnChitiet;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button SuaTacGia;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}