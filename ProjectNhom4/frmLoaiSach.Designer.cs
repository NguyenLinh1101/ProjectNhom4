namespace ProjectNhom4
{
    partial class frmLoaiSach
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
            this.lblLoaiSach = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenLoaiSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaLoaiSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLoaiSach = new System.Windows.Forms.DataGridView();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnNew = new Guna.UI2.WinForms.Guna2Button();
            this.MaLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoaiSach
            // 
            this.lblLoaiSach.AutoSize = true;
            this.lblLoaiSach.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoaiSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.lblLoaiSach.Location = new System.Drawing.Point(482, 28);
            this.lblLoaiSach.Name = "lblLoaiSach";
            this.lblLoaiSach.Size = new System.Drawing.Size(413, 54);
            this.lblLoaiSach.TabIndex = 5;
            this.lblLoaiSach.Text = "QUẢN LÝ LOẠI SÁCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenLoaiSach);
            this.groupBox1.Controls.Add(this.txtMaLoaiSach);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(91, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1203, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại sách";
            // 
            // txtTenLoaiSach
            // 
            this.txtTenLoaiSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLoaiSach.DefaultText = "";
            this.txtTenLoaiSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenLoaiSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenLoaiSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoaiSach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoaiSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoaiSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenLoaiSach.ForeColor = System.Drawing.Color.Black;
            this.txtTenLoaiSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoaiSach.Location = new System.Drawing.Point(697, 44);
            this.txtTenLoaiSach.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTenLoaiSach.Name = "txtTenLoaiSach";
            this.txtTenLoaiSach.PlaceholderText = "";
            this.txtTenLoaiSach.SelectedText = "";
            this.txtTenLoaiSach.Size = new System.Drawing.Size(461, 55);
            this.txtTenLoaiSach.TabIndex = 1;
            // 
            // txtMaLoaiSach
            // 
            this.txtMaLoaiSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaLoaiSach.DefaultText = "";
            this.txtMaLoaiSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaLoaiSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaLoaiSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLoaiSach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLoaiSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLoaiSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaLoaiSach.ForeColor = System.Drawing.Color.Black;
            this.txtMaLoaiSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLoaiSach.Location = new System.Drawing.Point(227, 44);
            this.txtMaLoaiSach.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMaLoaiSach.Name = "txtMaLoaiSach";
            this.txtMaLoaiSach.PlaceholderText = "";
            this.txtMaLoaiSach.SelectedText = "";
            this.txtMaLoaiSach.Size = new System.Drawing.Size(274, 55);
            this.txtMaLoaiSach.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại sách";
            // 
            // dgvLoaiSach
            // 
            this.dgvLoaiSach.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLoaiSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoaiSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLoaiSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoaiSach.ColumnHeadersHeight = 50;
            this.dgvLoaiSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiSach,
            this.TenLoaiSach});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiSach.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoaiSach.EnableHeadersVisualStyles = false;
            this.dgvLoaiSach.GridColor = System.Drawing.Color.Black;
            this.dgvLoaiSach.Location = new System.Drawing.Point(91, 394);
            this.dgvLoaiSach.Name = "dgvLoaiSach";
            this.dgvLoaiSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLoaiSach.RowHeadersWidth = 72;
            this.dgvLoaiSach.RowTemplate.Height = 28;
            this.dgvLoaiSach.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLoaiSach.Size = new System.Drawing.Size(1203, 355);
            this.dgvLoaiSach.TabIndex = 0;
            this.dgvLoaiSach.SelectionChanged += new System.EventHandler(this.dgvLoaiSach_SelectionChanged);
            // 
            // btnThem
            // 
            this.btnThem.BorderThickness = 2;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(417, 770);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(218, 79);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderThickness = 2;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(753, 770);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(218, 79);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderThickness = 2;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1076, 770);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(218, 79);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.BorderRadius = 34;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtSearch.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtSearch.Location = new System.Drawing.Point(91, 117);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = "Nhập tên loại sách";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(1203, 70);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnNew
            // 
            this.btnNew.BorderThickness = 2;
            this.btnNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(91, 770);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(218, 79);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Tạo mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // MaLoaiSach
            // 
            this.MaLoaiSach.DataPropertyName = "MaLoaiSach";
            this.MaLoaiSach.FillWeight = 11F;
            this.MaLoaiSach.HeaderText = "Mã loại sách";
            this.MaLoaiSach.MinimumWidth = 9;
            this.MaLoaiSach.Name = "MaLoaiSach";
            this.MaLoaiSach.Width = 337;
            // 
            // TenLoaiSach
            // 
            this.TenLoaiSach.DataPropertyName = "TenLoaiSach";
            this.TenLoaiSach.FillWeight = 189F;
            this.TenLoaiSach.HeaderText = "Tên loại sách";
            this.TenLoaiSach.MinimumWidth = 9;
            this.TenLoaiSach.Name = "TenLoaiSach";
            this.TenLoaiSach.Width = 775;
            // 
            // frmLoaiSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1385, 885);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvLoaiSach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblLoaiSach);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmLoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoaiSach";
            this.Load += new System.EventHandler(this.frmLoaiSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoaiSach;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaLoaiSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenLoaiSach;
        private System.Windows.Forms.DataGridView dgvLoaiSach;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiSach;
    }
}