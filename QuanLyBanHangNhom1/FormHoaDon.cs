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

        private readonly SqlConnection _conn = new SqlConnection(AppConfiguration.ConnectionString);
        private SqlCommand _cmd;
        private DataTable _dataTable;
        private SqlDataAdapter _adapter;

        private List<string> _listMaNhanVien;
        private List<string> _listMaKhachHang;
        private List<string> _listMaHang;
        private string MaHoaDonPrefix = "HD";
        private int TongTien = 0;

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData("select * from tblHang");

                _listMaNhanVien = GetListMaNhanVien();
                _listMaKhachHang = GetListMaKhachHang();
                _listMaHang = GetListMaHang();
                MaKhachHang.DataSource = _listMaKhachHang;
                MaNhanVien.DataSource = _listMaNhanVien;
                MaHang.DataSource = _listMaHang;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        private void label1_Click(object sender, EventArgs e)
        {
            //THAY DOI NHO
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
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            MaHang.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            TenHang.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            SoLuong.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            DonGia.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            ThanhTien.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            GiamGia.Text = (int.Parse(ThanhTien.Text) - int.Parse(DonGia.Text)).ToString();
        }

        private void ConnectDb()
        {
            try
            {
                _conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisconnectDb()
        {
            if (_conn != null && _conn.State == ConnectionState.Open)
            {
                _conn.Close();
            }
        }

        private void ClearData()
        {
            MaHoaDon.Text = "";
            NgayBan.Value = DateTime.Now;
            MaNhanVien.SelectedIndex = 0;
            TenNhanVien.Text = "";
            MaKhachHang.SelectedIndex = 0;
            DiaChi.Text = "";
            TenKhachHang.Text = "";
            DienThoai.Text = "";
        }

        private void LoadData(string query)
        {
            try
            {
                _adapter = new SqlDataAdapter(query,_conn);
                _dataTable = new DataTable();
                _adapter.Fill(_dataTable);
                dataGridView1.DataSource = _dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<string> GetListMaNhanVien()
        {
            try
            {
                ConnectDb();
                string sql = $"SELECT MaNhanVien FROM dbo.tblNhanVien";
                SqlCommand command = new SqlCommand(sql, _conn);
                SqlDataReader dataReader = command.ExecuteReader();
                List<string> ListMaNhanVien = new List<string>();
                while (dataReader.Read())
                {
                    ListMaNhanVien.Add(dataReader.GetValue(0).ToString());
                }
                DisconnectDb();
                return ListMaNhanVien;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace,ex.Message);
                
            }
            return null;
        }

        private List<string> GetListMaKhachHang()
        {
            try
            {
                ConnectDb();
                string sql = $"SELECT MaKhach FROM dbo.tblKhach";
                SqlCommand command = new SqlCommand(sql, _conn);
                SqlDataReader dataReader = command.ExecuteReader();
                List<string> ListKhachHang = new List<string>();
                while (dataReader.Read())
                {
                    ListKhachHang.Add(dataReader.GetValue(0).ToString());
                }
                DisconnectDb();
                return ListKhachHang;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);

            }
            return null;
        }

        private void HuyHoaDon_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ThemHoaDon_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(MaHoaDonPrefix);
            DateTime date = DateTime.Now;
            string dateString = date.ToString("yyyyMMdd_HHmmss");
            sb.Append(dateString);
            MaHoaDon.Text = sb.ToString();
        }

        private void MaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ConnectDb();

                string sql = $"SELECT TenNhanVien FROM dbo.tblNhanVien WHERE MaNhanVien = @maNhanVien";
                SqlCommand command = new SqlCommand(sql, _conn);
                command.Parameters.AddWithValue("maNhanVien", MaNhanVien.Text);

                SqlDataReader dataReader = command.ExecuteReader();
                if (!dataReader.Read()) throw new ArgumentException("Can not found MaNhanVien");

                TenNhanVien.Text = dataReader.GetValue(0).ToString();

                DisconnectDb();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void MaKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ConnectDb();

                string sql = $"SELECT TenKhach,DiaChi,DienThoai FROM dbo.tblKhach WHERE MaKhach = @maKhach";
                SqlCommand command = new SqlCommand(sql, _conn);
                command.Parameters.AddWithValue("maKhach", MaKhachHang.Text);

                SqlDataReader dataReader = command.ExecuteReader();
                if (!dataReader.Read()) throw new ArgumentException("Can not found MakhachHang");

                TenKhachHang.Text = dataReader.GetValue(0).ToString();
                DiaChi.Text = dataReader.GetValue(1).ToString();
                DienThoai.Text = dataReader.GetValue(2).ToString();

                DisconnectDb();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private List<string> GetListMaHang()
        {
            try
            {
                ConnectDb();
                string sql = $"SELECT MaHang FROM dbo.tblHang";
                SqlCommand command = new SqlCommand(sql, _conn);
                SqlDataReader dataReader = command.ExecuteReader();
                List<string> ListMaHang = new List<string>();
                while (dataReader.Read())
                {
                    ListMaHang.Add(dataReader.GetValue(0).ToString());
                }
                DisconnectDb();
                return ListMaHang;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);

            }
            return null;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ThemVaoHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}
