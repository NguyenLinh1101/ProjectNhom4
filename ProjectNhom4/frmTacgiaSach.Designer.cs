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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.grpDauSach = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvDauSach = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDauSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).BeginInit();
            this.SuspendLayout();
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
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextOffset = new System.Drawing.Point(10, 0);
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
            this.grpDauSach.TabIndex = 9;
            this.grpDauSach.Text = "THÔNG TIN ĐẦU SÁCH";
            this.grpDauSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.grpDauSach.Click += new System.EventHandler(this.grpDauSach_Click);
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
            this.dgvDauSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTacGia,
            this.colTenDauSach});
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
            this.dgvDauSach.ThemeStyle.ReadOnly = false;
            this.dgvDauSach.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDauSach.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDauSach.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDauSach.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDauSach.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDauSach.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDauSach.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaTacGia
            // 
            this.MaTacGia.HeaderText = "Mã tác giả";
            this.MaTacGia.MinimumWidth = 6;
            this.MaTacGia.Name = "MaTacGia";
            // 
            // colTenDauSach
            // 
            this.colTenDauSach.HeaderText = "Tên đầu sách";
            this.colTenDauSach.MinimumWidth = 6;
            this.colTenDauSach.Name = "colTenDauSach";
            // 
            // frmTacgiaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 844);
            this.Controls.Add(this.grpDauSach);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmTacgiaSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTacgiaSach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpDauSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2GroupBox grpDauSach;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDauSach;
    }
}