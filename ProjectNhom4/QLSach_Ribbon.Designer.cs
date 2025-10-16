namespace ProjectNhom4
{
    partial class QLSach_Ribbon
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
            this.panelQLSach = new System.Windows.Forms.Panel();
            this.panelQLSach_contain = new System.Windows.Forms.Panel();
            this.btnDauSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnCuonSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnDanhMuc = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelQLSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQLSach
            // 
            this.panelQLSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(76)))), ((int)(((byte)(170)))));
            this.panelQLSach.Controls.Add(this.btnDanhMuc);
            this.panelQLSach.Controls.Add(this.btnCuonSach);
            this.panelQLSach.Controls.Add(this.btnDauSach);
            this.panelQLSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQLSach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panelQLSach.ForeColor = System.Drawing.Color.Black;
            this.panelQLSach.Location = new System.Drawing.Point(0, 0);
            this.panelQLSach.Name = "panelQLSach";
            this.panelQLSach.Size = new System.Drawing.Size(2035, 90);
            this.panelQLSach.TabIndex = 0;
            // 
            // panelQLSach_contain
            // 
            this.panelQLSach_contain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQLSach_contain.Location = new System.Drawing.Point(0, 90);
            this.panelQLSach_contain.Name = "panelQLSach_contain";
            this.panelQLSach_contain.Size = new System.Drawing.Size(2035, 1289);
            this.panelQLSach_contain.TabIndex = 1;
            // 
            // btnDauSach
            // 
            this.btnDauSach.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDauSach.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnDauSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDauSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDauSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDauSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDauSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(76)))), ((int)(((byte)(170)))));
            this.btnDauSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDauSach.ForeColor = System.Drawing.Color.White;
            this.btnDauSach.Location = new System.Drawing.Point(306, 0);
            this.btnDauSach.MaximumSize = new System.Drawing.Size(247, 90);
            this.btnDauSach.Name = "btnDauSach";
            this.btnDauSach.Size = new System.Drawing.Size(247, 90);
            this.btnDauSach.TabIndex = 0;
            this.btnDauSach.Text = "Đầu sách";
            // 
            // btnCuonSach
            // 
            this.btnCuonSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(76)))), ((int)(((byte)(170)))));
            this.btnCuonSach.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCuonSach.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnCuonSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCuonSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCuonSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCuonSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCuonSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(76)))), ((int)(((byte)(170)))));
            this.btnCuonSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCuonSach.ForeColor = System.Drawing.Color.White;
            this.btnCuonSach.Location = new System.Drawing.Point(674, 0);
            this.btnCuonSach.MaximumSize = new System.Drawing.Size(247, 90);
            this.btnCuonSach.Name = "btnCuonSach";
            this.btnCuonSach.Size = new System.Drawing.Size(247, 90);
            this.btnCuonSach.TabIndex = 0;
            this.btnCuonSach.Text = "Cuốn sách";
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.BackColor = System.Drawing.SystemColors.Control;
            this.btnDanhMuc.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDanhMuc.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnDanhMuc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDanhMuc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDanhMuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDanhMuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDanhMuc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(76)))), ((int)(((byte)(170)))));
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDanhMuc.ForeColor = System.Drawing.Color.White;
            this.btnDanhMuc.Image = global::ProjectNhom4.Properties.Resources.down_arrow;
            this.btnDanhMuc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDanhMuc.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnDanhMuc.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDanhMuc.Location = new System.Drawing.Point(1078, 0);
            this.btnDanhMuc.MaximumSize = new System.Drawing.Size(247, 90);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(76)))), ((int)(((byte)(170)))));
            this.btnDanhMuc.Size = new System.Drawing.Size(247, 90);
            this.btnDanhMuc.TabIndex = 1;
            this.btnDanhMuc.Text = "Danh mục";
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            // 
            // QLSach_Ribbon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelQLSach_contain);
            this.Controls.Add(this.panelQLSach);
            this.Name = "QLSach_Ribbon";
            this.Size = new System.Drawing.Size(2035, 1379);
            this.panelQLSach.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQLSach;
        private System.Windows.Forms.Panel panelQLSach_contain;
        private Guna.UI2.WinForms.Guna2Button btnDauSach;
        private Guna.UI2.WinForms.Guna2Button btnDanhMuc;
        private Guna.UI2.WinForms.Guna2Button btnCuonSach;
        private System.Windows.Forms.Timer timer1;
    }
}
