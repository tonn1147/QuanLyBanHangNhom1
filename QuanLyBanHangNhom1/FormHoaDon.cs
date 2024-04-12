using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangNhom1
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        DataTable table = new DataTable();
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(AppConfiguration.ConnectionString);
                cmd = new SqlCommand("select * from tblHDBan", con);
                string selectquery = "select * from tblHDBan";
                SqlDataAdapter adpt = new SqlDataAdapter(selectquery, con);
                DataTable table = new DataTable();
                adpt.Fill(table);
                dataGridView1.DataSource = table;

                MessageBox.Show(NgayBan.Value.ToString());

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            MaHoaDon.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            NgayBan.Value = (DateTime)dataGridView1.Rows[i].Cells[1].Value;
            MaNhanVien.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            TenNhanVien.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }
    }
}
