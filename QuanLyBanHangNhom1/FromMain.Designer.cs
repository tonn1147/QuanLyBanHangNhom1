namespace QuanLyBanHangNhom1
{
    partial class FromMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChatLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTimHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuDanhMuc,
            this.menuTimKiem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThoat});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(72, 26);
            this.menuFile.Text = "Tệp Tin";
            // 
            // menuThoat
            // 
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuThoat.Size = new System.Drawing.Size(224, 26);
            this.menuThoat.Text = "Thoát";
            // 
            // menuDanhMuc
            // 
            this.menuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChatLieu,
            this.menuNhanVien,
            this.menuKhachHang,
            this.menuHangHoa,
            this.menuHoaDon});
            this.menuDanhMuc.Name = "menuDanhMuc";
            this.menuDanhMuc.Size = new System.Drawing.Size(90, 26);
            this.menuDanhMuc.Text = "Danh Mục";
            // 
            // menuChatLieu
            // 
            this.menuChatLieu.Name = "menuChatLieu";
            this.menuChatLieu.Size = new System.Drawing.Size(224, 26);
            this.menuChatLieu.Text = "Chất Liệu";
            this.menuChatLieu.Click += new System.EventHandler(this.menuChatLieu_Click);
            // 
            // menuNhanVien
            // 
            this.menuNhanVien.Name = "menuNhanVien";
            this.menuNhanVien.Size = new System.Drawing.Size(224, 26);
            this.menuNhanVien.Text = "Nhân Viên";
            this.menuNhanVien.Click += new System.EventHandler(this.menuNhanVien_Click);
            // 
            // menuKhachHang
            // 
            this.menuKhachHang.Name = "menuKhachHang";
            this.menuKhachHang.Size = new System.Drawing.Size(224, 26);
            this.menuKhachHang.Text = "Khách Hàng";
            this.menuKhachHang.Click += new System.EventHandler(this.menuKhachHang_Click);
            // 
            // menuHangHoa
            // 
            this.menuHangHoa.Name = "menuHangHoa";
            this.menuHangHoa.Size = new System.Drawing.Size(224, 26);
            this.menuHangHoa.Text = "Hàng Hóa";
            this.menuHangHoa.Click += new System.EventHandler(this.menuHangHoa_Click);
            // 
            // menuTimKiem
            // 
            this.menuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTimHoaDon});
            this.menuTimKiem.Name = "menuTimKiem";
            this.menuTimKiem.Size = new System.Drawing.Size(86, 26);
            this.menuTimKiem.Text = "Tìm Kiếm";
            // 
            // menuTimHoaDon
            // 
            this.menuTimHoaDon.Name = "menuTimHoaDon";
            this.menuTimHoaDon.Size = new System.Drawing.Size(224, 26);
            this.menuTimHoaDon.Text = "Hóa Đơn";
            this.menuTimHoaDon.Click += new System.EventHandler(this.menuTimHoaDon_Click);
            // 
            // menuHoaDon
            // 
            this.menuHoaDon.Name = "menuHoaDon";
            this.menuHoaDon.Size = new System.Drawing.Size(224, 26);
            this.menuHoaDon.Text = "Hóa Đơn";
            this.menuHoaDon.Click += new System.EventHandler(this.menuHoaDon_Click);
            // 
            // FromMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FromMain";
            this.Text = "Chương Trình Quản Lý Bán Hàng Lưu Niệm";
            this.Load += new System.EventHandler(this.FromMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem menuChatLieu;
        private System.Windows.Forms.ToolStripMenuItem menuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem menuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem menuHangHoa;
        private System.Windows.Forms.ToolStripMenuItem menuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem menuTimHoaDon;
        private System.Windows.Forms.ToolStripMenuItem menuHoaDon;
    }
}

