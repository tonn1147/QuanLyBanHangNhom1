namespace QuanLyBanHangNhom1
{
    partial class FormHangHoa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHienThiDanhSach = new System.Windows.Forms.Button();
            this.BoQua = new System.Windows.Forms.Button();
            this.Dong = new System.Windows.Forms.Button();
            this.Luu = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDongiaban = new System.Windows.Forms.TextBox();
            this.txtDongianhap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChatlieu = new System.Windows.Forms.ComboBox();
            this.TxtMaHanghoa = new System.Windows.Forms.TextBox();
            this.txtTenHangHoa = new System.Windows.Forms.TextBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHienThiDanhSach);
            this.panel1.Controls.Add(this.BoQua);
            this.panel1.Controls.Add(this.Dong);
            this.panel1.Controls.Add(this.Luu);
            this.panel1.Controls.Add(this.Xoa);
            this.panel1.Controls.Add(this.Sua);
            this.panel1.Controls.Add(this.Them);
            this.panel1.Location = new System.Drawing.Point(12, 489);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 66);
            this.panel1.TabIndex = 1;
            // 
            // btnHienThiDanhSach
            // 
            this.btnHienThiDanhSach.Location = new System.Drawing.Point(576, 12);
            this.btnHienThiDanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHienThiDanhSach.Name = "btnHienThiDanhSach";
            this.btnHienThiDanhSach.Size = new System.Drawing.Size(151, 38);
            this.btnHienThiDanhSach.TabIndex = 7;
            this.btnHienThiDanhSach.Text = "Hiển Thị Danh Sách";
            this.btnHienThiDanhSach.UseVisualStyleBackColor = true;
            // 
            // BoQua
            // 
            this.BoQua.Location = new System.Drawing.Point(464, 12);
            this.BoQua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BoQua.Name = "BoQua";
            this.BoQua.Size = new System.Drawing.Size(107, 38);
            this.BoQua.TabIndex = 3;
            this.BoQua.Text = "Bỏ Qua";
            this.BoQua.UseVisualStyleBackColor = true;
            this.BoQua.Click += new System.EventHandler(this.BoQua_Click);
            // 
            // Dong
            // 
            this.Dong.Location = new System.Drawing.Point(732, 12);
            this.Dong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dong.Name = "Dong";
            this.Dong.Size = new System.Drawing.Size(121, 38);
            this.Dong.TabIndex = 2;
            this.Dong.Text = "Đóng";
            this.Dong.UseVisualStyleBackColor = true;
            this.Dong.Click += new System.EventHandler(this.Dong_Click_1);
            // 
            // Luu
            // 
            this.Luu.Location = new System.Drawing.Point(356, 12);
            this.Luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(97, 38);
            this.Luu.TabIndex = 4;
            this.Luu.Text = "Lưu";
            this.Luu.UseVisualStyleBackColor = true;
            this.Luu.Click += new System.EventHandler(this.Luu_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(235, 12);
            this.Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(116, 38);
            this.Xoa.TabIndex = 5;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(111, 12);
            this.Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(119, 38);
            this.Sua.TabIndex = 6;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(0, 12);
            this.Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(103, 38);
            this.Them.TabIndex = 1;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDongiaban);
            this.panel2.Controls.Add(this.txtDongianhap);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtChatlieu);
            this.panel2.Controls.Add(this.TxtMaHanghoa);
            this.panel2.Controls.Add(this.txtTenHangHoa);
            this.panel2.Controls.Add(this.txtGhichu);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 287);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtDongiaban
            // 
            this.txtDongiaban.Location = new System.Drawing.Point(111, 234);
            this.txtDongiaban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDongiaban.Name = "txtDongiaban";
            this.txtDongiaban.Size = new System.Drawing.Size(201, 22);
            this.txtDongiaban.TabIndex = 19;
            // 
            // txtDongianhap
            // 
            this.txtDongianhap.Location = new System.Drawing.Point(111, 198);
            this.txtDongianhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDongianhap.Name = "txtDongianhap";
            this.txtDongianhap.Size = new System.Drawing.Size(201, 22);
            this.txtDongianhap.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 238);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Đơn giá bán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 198);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Đơn giá nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Số Lượng";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(111, 158);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(201, 22);
            this.txtSoLuong.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Chất Liệu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtChatlieu
            // 
            this.txtChatlieu.FormattingEnabled = true;
            this.txtChatlieu.Location = new System.Drawing.Point(111, 121);
            this.txtChatlieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChatlieu.Name = "txtChatlieu";
            this.txtChatlieu.Size = new System.Drawing.Size(201, 24);
            this.txtChatlieu.TabIndex = 12;
            // 
            // TxtMaHanghoa
            // 
            this.TxtMaHanghoa.HideSelection = false;
            this.TxtMaHanghoa.Location = new System.Drawing.Point(111, 39);
            this.TxtMaHanghoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMaHanghoa.Name = "TxtMaHanghoa";
            this.TxtMaHanghoa.ReadOnly = true;
            this.TxtMaHanghoa.Size = new System.Drawing.Size(201, 22);
            this.TxtMaHanghoa.TabIndex = 11;
            // 
            // txtTenHangHoa
            // 
            this.txtTenHangHoa.Location = new System.Drawing.Point(111, 81);
            this.txtTenHangHoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenHangHoa.Name = "txtTenHangHoa";
            this.txtTenHangHoa.Size = new System.Drawing.Size(201, 22);
            this.txtTenHangHoa.TabIndex = 10;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(543, 48);
            this.txtGhichu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(248, 115);
            this.txtGhichu.TabIndex = 8;
            this.txtGhichu.TextChanged += new System.EventHandler(this.DienThoai_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(479, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Ghi chú";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 4;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Hàng Hoá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hàng Hoá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Hàng Hoá";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 306);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(856, 176);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // FormHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 569);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHangHoa";
            this.Text = "FormHangHoa";
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Dong;
        private System.Windows.Forms.Button BoQua;
        private System.Windows.Forms.Button Luu;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button btnHienThiDanhSach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtMaHanghoa;
        private System.Windows.Forms.TextBox txtTenHangHoa;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtChatlieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDongiaban;
        private System.Windows.Forms.TextBox txtDongianhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}