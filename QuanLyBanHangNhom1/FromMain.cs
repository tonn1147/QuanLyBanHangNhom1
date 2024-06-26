﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangNhom1
{
    public partial class FromMain : Form
    {
        public FromMain()
        {
            InitializeComponent();
        }

        private void FromMain_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHoaDon formHoaDon = new FormHoaDon();
            formHoaDon.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormKhachHang formKhachHang = new FormKhachHang();
            formKhachHang.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormNhanVien formNhanVien = new FormNhanVien();
            formNhanVien.ShowDialog();
        }

        private void menuNhanVien_Click(object sender, EventArgs e)
        {
            FormNhanVien formNhanVien = new FormNhanVien();
            formNhanVien.ShowDialog();
        }

        private void menuChatLieu_Click(object sender, EventArgs e)
        {
            FormChatLieu formChatLieu = new FormChatLieu();
            formChatLieu.ShowDialog();
        }

        private void menuKhachHang_Click(object sender, EventArgs e)
        {
            FormKhachHang formKhachHang = new FormKhachHang();
            formKhachHang.ShowDialog();
        }

        private void menuHangHoa_Click(object sender, EventArgs e)
        {
            FormHangHoa formHangHoa = new FormHangHoa();
            formHangHoa.ShowDialog();
        }

        private void menuHoaDon_Click(object sender, EventArgs e)
        {
            FormHoaDon formHoaDon = new FormHoaDon();
            formHoaDon.ShowDialog();
        }

        private void menuTimHoaDon_Click(object sender, EventArgs e)
        {
            FormTimKiemHoaDon formTimKiemHoaDon = new FormTimKiemHoaDon();
            formTimKiemHoaDon.ShowDialog();
        }
    }
}
