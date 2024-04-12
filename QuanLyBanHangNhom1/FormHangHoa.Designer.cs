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
            this.Dong = new System.Windows.Forms.Button();
            this.BoQua = new System.Windows.Forms.Button();
            this.Luu = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dong);
            this.panel1.Controls.Add(this.BoQua);
            this.panel1.Controls.Add(this.Luu);
            this.panel1.Controls.Add(this.Xoa);
            this.panel1.Controls.Add(this.Sua);
            this.panel1.Controls.Add(this.Them);
            this.panel1.Location = new System.Drawing.Point(12, 489);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 67);
            this.panel1.TabIndex = 1;
            // 
            // Dong
            // 
            this.Dong.Location = new System.Drawing.Point(683, 12);
            this.Dong.Name = "Dong";
            this.Dong.Size = new System.Drawing.Size(121, 38);
            this.Dong.TabIndex = 2;
            this.Dong.Text = "Đóng";
            this.Dong.UseVisualStyleBackColor = true;
            // 
            // BoQua
            // 
            this.BoQua.Location = new System.Drawing.Point(556, 12);
            this.BoQua.Name = "BoQua";
            this.BoQua.Size = new System.Drawing.Size(121, 38);
            this.BoQua.TabIndex = 3;
            this.BoQua.Text = "Bỏ Qua";
            this.BoQua.UseVisualStyleBackColor = true;
            // 
            // Luu
            // 
            this.Luu.Location = new System.Drawing.Point(429, 12);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(121, 38);
            this.Luu.TabIndex = 4;
            this.Luu.Text = "Lưu";
            this.Luu.UseVisualStyleBackColor = true;
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(302, 12);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(121, 38);
            this.Xoa.TabIndex = 5;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(175, 12);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(121, 38);
            this.Sua.TabIndex = 6;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(48, 12);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(121, 38);
            this.Them.TabIndex = 1;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            // 
            // FormHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 568);
            this.Controls.Add(this.panel1);
            this.Name = "FormHangHoa";
            this.Text = "FormHangHoa";
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            this.panel1.ResumeLayout(false);
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
    }
}