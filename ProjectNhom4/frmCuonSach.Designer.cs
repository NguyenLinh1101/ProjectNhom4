namespace ProjectNhom4
{
    partial class frmCuonSach
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
            this.lblMaSach = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblMaDauSach = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lbtLibOnly = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtMaDauSach = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbLibOnly = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaSach.Location = new System.Drawing.Point(61, 57);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(82, 25);
            this.lblMaSach.TabIndex = 0;
            this.lblMaSach.Text = "Mã sách";
            this.lblMaSach.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Location = new System.Drawing.Point(520, 350);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(84, 37);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.Control;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Location = new System.Drawing.Point(634, 350);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 37);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTinhTrang.Location = new System.Drawing.Point(61, 165);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(101, 25);
            this.lblTinhTrang.TabIndex = 3;
            this.lblTinhTrang.Text = "Tình trạng";
            // 
            // lblMaDauSach
            // 
            this.lblMaDauSach.AutoSize = true;
            this.lblMaDauSach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaDauSach.Location = new System.Drawing.Point(61, 109);
            this.lblMaDauSach.Name = "lblMaDauSach";
            this.lblMaDauSach.Size = new System.Drawing.Size(119, 25);
            this.lblMaDauSach.TabIndex = 4;
            this.lblMaDauSach.Text = "Mã đầu sách";
            this.lblMaDauSach.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMoTa.Location = new System.Drawing.Point(61, 282);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(62, 25);
            this.lblMoTa.TabIndex = 5;
            this.lblMoTa.Text = "Mô tả";
            // 
            // lbtLibOnly
            // 
            this.lbtLibOnly.AutoSize = true;
            this.lbtLibOnly.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbtLibOnly.Location = new System.Drawing.Point(61, 222);
            this.lbtLibOnly.Name = "lbtLibOnly";
            this.lbtLibOnly.Size = new System.Drawing.Size(148, 25);
            this.lbtLibOnly.TabIndex = 6;
            this.lbtLibOnly.Text = "Đọc tại thư viện";
            // 
            // txtMaSach
            // 
            this.txtMaSach.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaSach.Location = new System.Drawing.Point(269, 58);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(207, 26);
            this.txtMaSach.TabIndex = 7;
            // 
            // txtMaDauSach
            // 
            this.txtMaDauSach.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaDauSach.Location = new System.Drawing.Point(269, 110);
            this.txtMaDauSach.Name = "txtMaDauSach";
            this.txtMaDauSach.ReadOnly = true;
            this.txtMaDauSach.Size = new System.Drawing.Size(207, 26);
            this.txtMaDauSach.TabIndex = 9;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(269, 282);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(449, 26);
            this.txtMoTa.TabIndex = 11;
            this.txtMoTa.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "Có sẵn",
            "Đang mượn"});
            this.cboTinhTrang.Location = new System.Drawing.Point(269, 166);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(121, 28);
            this.cboTinhTrang.TabIndex = 12;
            // 
            // cbLibOnly
            // 
            this.cbLibOnly.AutoSize = true;
            this.cbLibOnly.Location = new System.Drawing.Point(269, 222);
            this.cbLibOnly.Name = "cbLibOnly";
            this.cbLibOnly.Size = new System.Drawing.Size(22, 21);
            this.cbLibOnly.TabIndex = 13;
            this.cbLibOnly.UseVisualStyleBackColor = true;
            this.cbLibOnly.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmCuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 427);
            this.Controls.Add(this.cbLibOnly);
            this.Controls.Add(this.cboTinhTrang);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtMaDauSach);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.lbtLibOnly);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblMaDauSach);
            this.Controls.Add(this.lblTinhTrang);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblMaSach);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCuonSach";
            this.Text = "CuonSach";
            this.Load += new System.EventHandler(this.frmCuonSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblMaDauSach;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lbtLibOnly;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtMaDauSach;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.CheckBox cbLibOnly;
    }
}