using System;
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
    }
}
