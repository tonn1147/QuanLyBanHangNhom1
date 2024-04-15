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
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private readonly SqlConnection _conn = new SqlConnection(AppConfiguration.ConnectionString);
        private SqlCommand _cmd;
        private DataTable _dataTable;
        private SqlDataAdapter _adapter;

        private string MaKhachhangPrefix = "KH";

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData("select * from tblKhach");

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            MaKhachHang.Text = "";
            DiaChi.Text = "";
            TenKhachHang.Text = "";
            DienThoai.Text = "";
        }

        private void LoadData(string query)
        {
            try
            {
                _adapter = new SqlDataAdapter(query, _conn);
                _dataTable = new DataTable();
                _adapter.Fill(_dataTable);
                dataGridView1.DataSource = _dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Tạo Id cho obj định thêm
        private void Them_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(MaKhachhangPrefix);
            DateTime date = DateTime.Now;
            string dateString = date.ToString("yyyyMMdd_HHmmss");
            sb.Append(dateString);
            MaKhachHang.Text = sb.ToString();
        }

        //update data
        private void Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDb();
                SqlCommand command = _conn.CreateCommand();
                command.CommandText = $"UPDATE dbo.tblKhach SET  TenKhach = @tenKhachHang,DiaChi = @DiaChi, DienThoai = @dienThoai WHERE MaKhach = @maKhachHang;";

                if (string.IsNullOrEmpty(MaKhachHang.Text) || string.IsNullOrEmpty(TenKhachHang.Text) || string.IsNullOrEmpty(DiaChi.Text) || string.IsNullOrEmpty(DienThoai.Text)) throw new Exception("khong duoc de trong");

                command.Parameters.AddWithValue("maKhachHang", MaKhachHang.Text);
                command.Parameters.AddWithValue("tenKhachHang", TenKhachHang.Text);
                command.Parameters.AddWithValue("DiaChi", DiaChi.Text);
                command.Parameters.AddWithValue("dienThoai", DienThoai.Text);
                command.ExecuteNonQuery();
                LoadData("SELECT * from dbo.tblKhach;");
                MessageBox.Show("updated successfully!");
                DisconnectDb();


            }
            catch (Exception ex)
            {
                DisconnectDb();
                MessageBox.Show(ex.Message);
            }
            ClearData();
        }

        private void BoQua_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        //Create Data
        private void Luu_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDb();
                SqlCommand command = _conn.CreateCommand();
                command.CommandText = $"INSERT INTO dbo.tblKhach VALUES (@maKhachHang, @tenKhachHang,@diaChi,@dienThoai);";

                if (string.IsNullOrEmpty(MaKhachHang.Text) || string.IsNullOrEmpty(TenKhachHang.Text) || string.IsNullOrEmpty(DiaChi.Text) || string.IsNullOrEmpty(DienThoai.Text)) throw new Exception("khong duoc de trong");

                command.Parameters.AddWithValue("maKhachHang", MaKhachHang.Text);
                command.Parameters.AddWithValue("tenKhachHang", TenKhachHang.Text);
                command.Parameters.AddWithValue("diaChi", DiaChi.Text);
                command.Parameters.AddWithValue("dienThoai", DienThoai.Text);
                command.ExecuteNonQuery();
                LoadData("SELECT * from dbo.tblKhach;");
                MessageBox.Show("created successfully!");
                DisconnectDb();


            }
            catch (Exception ex)
            {
                DisconnectDb();
                MessageBox.Show(ex.Message);
            }
            ClearData();
        }

        //deleteData
        private void Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MaKhachHang.Text is null || MaKhachHang.Text.Length == 0) throw new AggregateException("Ma Khach Hang khong hop le");
                ConnectDb();
                SqlCommand command = _conn.CreateCommand();
                command.CommandText = $"DELETE FROM dbo.tblKhach WHERE MaKhach = @maKhachHang";

                command.Parameters.AddWithValue("maKhachHang", MaKhachHang.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("deleted successfully!");
                DisconnectDb();
            }catch (ArgumentException ex)
            {
                DisconnectDb();
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                DisconnectDb();
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            MaKhachHang.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            TenKhachHang.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            DiaChi.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            DienThoai.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
