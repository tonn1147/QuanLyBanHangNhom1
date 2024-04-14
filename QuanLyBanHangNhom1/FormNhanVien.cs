using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangNhom1
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private readonly SqlConnection _conn = new SqlConnection(AppConfiguration.ConnectionString);
        private SqlCommand _cmd;
        private DataTable _dataTable;
        private SqlDataAdapter _adapter;

        private string MaNhanVienPrefix = "NV";
        private List<string> _listGioiTinh = new List<string> { "Nam", "Nữ "};

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
            MaNhanVien.Text = "";
            TenNhanVien.Text = "";
            GioiTinh.SelectedIndex = 0;
            DiaChi.Text = "";
            DienThoai.Text = "";
            NgaySinh.Value = DateTime.Now;
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

        private void Them_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(MaNhanVienPrefix);
            DateTime date = DateTime.Now;
            string dateString = date.ToString("yyyyMMdd_HHmmss");
            sb.Append(dateString);
            MaNhanVien.Text = sb.ToString();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDb();
                SqlCommand command = _conn.CreateCommand();
                command.CommandText = $"UPDATE dbo.tblNhanVien SET TenNhanVien = @tenNhanVien,GioiTinh = @gioiTinh, DiaChi = @diaChi,DienThoai = @dienThoai, NgaySinh = @NgaySinh WHERE MaNhanVien = @maNhanVien;";

                if (string.IsNullOrEmpty(MaNhanVien.Text) || string.IsNullOrEmpty(TenNhanVien.Text) || string.IsNullOrEmpty(DiaChi.Text) || string.IsNullOrEmpty(DienThoai.Text)) throw new Exception("khong duoc de trong");

                command.Parameters.AddWithValue("maNhanVien", MaNhanVien.Text);
                command.Parameters.AddWithValue("tenNhanVien", TenNhanVien.Text);
                command.Parameters.AddWithValue("gioiTinh",GioiTinh.Text);
                command.Parameters.AddWithValue("DiaChi", DiaChi.Text);
                command.Parameters.AddWithValue("dienThoai", DienThoai.Text);
                command.Parameters.AddWithValue("ngaySinh",NgaySinh.Value.ToString("dd/MM/yyyy"));
                command.ExecuteNonQuery();
                LoadData("SELECT * from dbo.tblNhanVien;");
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

        private void Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(MaNhanVien.Text)) throw new AggregateException("Ma Khach Hang khong hop le");
                ConnectDb();
                SqlCommand command = _conn.CreateCommand();
                command.CommandText = $"DELETE FROM dbo.tblNhanVien WHERE MaNhanVien = @maNhanVien";

                command.Parameters.AddWithValue("maNhanVien", MaNhanVien.Text);
                command.ExecuteNonQuery();
                LoadData("SELECT * from dbo.tblNhanVien;");
                MessageBox.Show("deleted successfully!");

                DisconnectDb();
            }
            catch (ArgumentException ex)
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

        private void Luu_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDb();
                SqlCommand command = _conn.CreateCommand();
                command.CommandText = $"INSERT INTO dbo.tblNhanVien VALUES (@maNhanVien,@tenNhanVien,@gioiTinh,@diaChi,@dienThoai,@NgaySinh);";

                if (string.IsNullOrEmpty(MaNhanVien.Text) || string.IsNullOrEmpty(TenNhanVien.Text) || string.IsNullOrEmpty(DiaChi.Text) || string.IsNullOrEmpty(DienThoai.Text)) throw new Exception("khong duoc de trong");

                command.Parameters.AddWithValue("maNhanVien", MaNhanVien.Text);
                command.Parameters.AddWithValue("tenNhanVien", TenNhanVien.Text);
                command.Parameters.AddWithValue("gioiTinh", GioiTinh.Text);
                command.Parameters.AddWithValue("DiaChi", DiaChi.Text);
                command.Parameters.AddWithValue("dienThoai", DienThoai.Text);
                command.Parameters.AddWithValue("ngaySinh", NgaySinh.Value);
                command.ExecuteNonQuery();
                LoadData("SELECT * from dbo.tblNhanVien;");
                MessageBox.Show("created successfully!");
                DisconnectDb();
            }
            catch (Exception ex)
            {
                DisconnectDb();
                MessageBox.Show(ex.StackTrace,ex.Message);
            }
            ClearData();
        }

        private void BoQua_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            MaNhanVien.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            TenNhanVien.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            GioiTinh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            DiaChi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            DienThoai.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            NgaySinh.Value = (DateTime)dataGridView1.Rows[i].Cells[5].Value;
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData($"SELECT * FROM dbo.tblNhanVien");
                GioiTinh.DataSource = _listGioiTinh;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
