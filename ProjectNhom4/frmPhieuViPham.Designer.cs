namespace ProjectNhom4
{
    partial class frmPhieuViPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private UC_PhieuViPham ucPhieuViPham;

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
            // Khởi tạo và thêm UC_PhieuViPham vào Form
            this.ucPhieuViPham = new ProjectNhom4.UC_PhieuViPham();
            this.SuspendLayout();
            // 
            // ucPhieuViPham
            // 
            this.ucPhieuViPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPhieuViPham.Location = new System.Drawing.Point(0, 0);
            this.ucPhieuViPham.Name = "ucPhieuViPham";
            this.ucPhieuViPham.Size = new System.Drawing.Size(1000, 700); // Đặt kích thước mặc định cho Form
            this.ucPhieuViPham.TabIndex = 0;
            // 
            // frmPhieuViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.ucPhieuViPham);
            this.Name = "frmPhieuViPham";
            this.Text = "Quản Lý Phiếu Vi Phạm";
            this.Load += new System.EventHandler(this.frmPhieuViPham_Load);
            this.ResumeLayout(false);

        }

        #endregion
       
    }
}