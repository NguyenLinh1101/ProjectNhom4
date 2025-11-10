namespace ProjectNhom4
{
    partial class frmformphuChonSach
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.plsearch = new System.Windows.Forms.Panel();
            this.btnThoat = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnChon = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dgvDanhSachSach = new System.Windows.Forms.DataGridView();
            this.Ma_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_Dau_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Dau_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia_Bia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_Trang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tinh_Trang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lib_Only = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mo_Ta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlHeader.SuspendLayout();
            this.plsearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSach)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(882, 56);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(837, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.lblTitle.Location = new System.Drawing.Point(334, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CHỌN SÁCH";
            // 
            // plsearch
            // 
            this.plsearch.Controls.Add(this.btnThoat);
            this.plsearch.Controls.Add(this.btnChon);
            this.plsearch.Controls.Add(this.btnLamMoi);
            this.plsearch.Controls.Add(this.txtSearchSach);
            this.plsearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.plsearch.Location = new System.Drawing.Point(0, 56);
            this.plsearch.Name = "plsearch";
            this.plsearch.Size = new System.Drawing.Size(882, 54);
            this.plsearch.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnThoat.FillColor2 = System.Drawing.Color.IndianRed;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(773, 18);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 32);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Đóng";
            // 
            // btnChon
            // 
            this.btnChon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChon.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnChon.FillColor2 = System.Drawing.Color.IndianRed;
            this.btnChon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChon.ForeColor = System.Drawing.Color.White;
            this.btnChon.Location = new System.Drawing.Point(632, 18);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(94, 32);
            this.btnChon.TabIndex = 3;
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnLamMoi.FillColor2 = System.Drawing.Color.IndianRed;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(459, 18);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(124, 32);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm mới";
            // 
            // dgvDanhSachSach
            // 
            this.dgvDanhSachSach.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Sach,
            this.Ma_Dau_Sach,
            this.Ten_Dau_Sach,
            this.Gia_Bia,
            this.So_Trang,
            this.So_Luong,
            this.Tinh_Trang,
            this.Lib_Only,
            this.Mo_Ta,
            this.GiaBia});
            this.dgvDanhSachSach.EnableHeadersVisualStyles = false;
            this.dgvDanhSachSach.Location = new System.Drawing.Point(3, 116);
            this.dgvDanhSachSach.Name = "dgvDanhSachSach";
            this.dgvDanhSachSach.RowHeadersVisible = false;
            this.dgvDanhSachSach.RowHeadersWidth = 51;
            this.dgvDanhSachSach.RowTemplate.Height = 24;
            this.dgvDanhSachSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachSach.Size = new System.Drawing.Size(882, 398);
            this.dgvDanhSachSach.TabIndex = 2;
            this.dgvDanhSachSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSach_CellContentClick);
            // 
            // Ma_Sach
            // 
            this.Ma_Sach.DataPropertyName = "Ma_Sach";
            this.Ma_Sach.HeaderText = "Mã sách";
            this.Ma_Sach.MinimumWidth = 6;
            this.Ma_Sach.Name = "Ma_Sach";
            this.Ma_Sach.Width = 125;
            // 
            // Ma_Dau_Sach
            // 
            this.Ma_Dau_Sach.DataPropertyName = "Ma_Dau_Sach";
            this.Ma_Dau_Sach.HeaderText = "Mã Đầu Sách";
            this.Ma_Dau_Sach.MinimumWidth = 6;
            this.Ma_Dau_Sach.Name = "Ma_Dau_Sach";
            this.Ma_Dau_Sach.Width = 125;
            // 
            // Ten_Dau_Sach
            // 
            this.Ten_Dau_Sach.DataPropertyName = "Ten_Dau_Sach";
            this.Ten_Dau_Sach.HeaderText = "Tên Đầu Sách";
            this.Ten_Dau_Sach.MinimumWidth = 6;
            this.Ten_Dau_Sach.Name = "Ten_Dau_Sach";
            this.Ten_Dau_Sach.Width = 125;
            // 
            // Gia_Bia
            // 
            this.Gia_Bia.DataPropertyName = "Gia_Bia";
            this.Gia_Bia.HeaderText = "Giá Bìa";
            this.Gia_Bia.MinimumWidth = 6;
            this.Gia_Bia.Name = "Gia_Bia";
            this.Gia_Bia.Width = 125;
            // 
            // So_Trang
            // 
            this.So_Trang.DataPropertyName = "So_Trang";
            this.So_Trang.HeaderText = "Số Trang";
            this.So_Trang.MinimumWidth = 6;
            this.So_Trang.Name = "So_Trang";
            this.So_Trang.Width = 125;
            // 
            // So_Luong
            // 
            this.So_Luong.DataPropertyName = "So_Luong";
            this.So_Luong.HeaderText = "Số Lượng";
            this.So_Luong.MinimumWidth = 6;
            this.So_Luong.Name = "So_Luong";
            this.So_Luong.Width = 125;
            // 
            // Tinh_Trang
            // 
            this.Tinh_Trang.DataPropertyName = "Tinh_Trang";
            this.Tinh_Trang.HeaderText = "Tình Trạng ";
            this.Tinh_Trang.MinimumWidth = 6;
            this.Tinh_Trang.Name = "Tinh_Trang";
            this.Tinh_Trang.Width = 125;
            // 
            // Lib_Only
            // 
            this.Lib_Only.DataPropertyName = "Lib_Only";
            this.Lib_Only.HeaderText = "Lib_Only";
            this.Lib_Only.MinimumWidth = 6;
            this.Lib_Only.Name = "Lib_Only";
            this.Lib_Only.Width = 125;
            // 
            // Mo_Ta
            // 
            this.Mo_Ta.DataPropertyName = "Mo_Ta";
            this.Mo_Ta.HeaderText = "Mô Tả";
            this.Mo_Ta.MinimumWidth = 6;
            this.Mo_Ta.Name = "Mo_Ta";
            this.Mo_Ta.Width = 125;
            // 
            // GiaBia
            // 
            this.GiaBia.HeaderText = "Giá bìa";
            this.GiaBia.MinimumWidth = 6;
            this.GiaBia.Name = "GiaBia";
            this.GiaBia.Width = 125;
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
            this.txtSearchSach.Location = new System.Drawing.Point(3, 2);
            this.txtSearchSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchSach.Name = "txtSearchSach";
            this.txtSearchSach.PlaceholderText = "Tìm mã/tên/tác giả.";
            this.txtSearchSach.SelectedText = "";
            this.txtSearchSach.Size = new System.Drawing.Size(424, 48);
            this.txtSearchSach.TabIndex = 1;
            // 
            // frmformphuChonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 513);
            this.Controls.Add(this.dgvDanhSachSach);
            this.Controls.Add(this.plsearch);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmformphuChonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmformphuChonSach";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.plsearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.Panel plsearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchSach;
        private Guna.UI2.WinForms.Guna2GradientButton btnThoat;
        private Guna.UI2.WinForms.Guna2GradientButton btnChon;
        private Guna.UI2.WinForms.Guna2GradientButton btnLamMoi;
        private System.Windows.Forms.DataGridView dgvDanhSachSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Dau_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Dau_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia_Bia;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Trang;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tinh_Trang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lib_Only;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mo_Ta;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBia;
    }
}