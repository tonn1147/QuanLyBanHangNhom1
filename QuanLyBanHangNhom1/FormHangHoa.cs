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
    public partial class FormHangHoa : Form
    {
        public FormHangHoa()
        {
            InitializeComponent();
        }
        private readonly SqlConnection _conn = new SqlConnection(AppConfiguration.ConnectionString);
        private SqlCommand _cmd;
        private DataTable _dataTable;
        private SqlDataAdapter _adapter;

        private List<string> _listMaChatLieu;
        private string HangHoaPrefix = "HH";
        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData("select * from tblHang");
                txtChatlieu.DataSource = getListMaChatLieu();
            }
            catch (Exception ex)
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
            TxtMaHanghoa.Text = "";
            txtTenHangHoa.Text = "";
            txtChatlieu.Text = "";
            txtSoLuong.Text = "";
            txtDongianhap.Text = "";
            txtDongiaban.Text = "";
            txtGhichu.Text = "";

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

        private List<string> getListMaChatLieu()
        {
            try
            {
                ConnectDb();
                string sql = $"SELECT MaChatLieu FROM dbo.tblChatLieu";
                SqlCommand command = new SqlCommand(sql, _conn);
                SqlDataReader dataReader = command.ExecuteReader();
                List<string> ListMaChatLieu = new List<string>();
                while (dataReader.Read())
                {
                    ListMaChatLieu.Add(dataReader.GetValue(0).ToString());
                }
                DisconnectDb();
                return ListMaChatLieu;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);

            }
            return null;
        }

        //Tạo Id cho obj định thêm
        private void Them_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(HangHoaPrefix);
            DateTime date = DateTime.Now;
            string dateString = date.ToString("yyyyMMdd_HHmmss");
            sb.Append(dateString);
            TxtMaHanghoa.Text = sb.ToString();
        }

        //update data
        private void Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDb();
                SqlCommand command = _conn.CreateCommand();
                command.CommandText = $"UPDATE dbo.tblHang SET  TenHang = @TenHangHoa, MaChatLieu = @Chatlieu, SoLuong = @Soluong, DonGiaNhap = @Dongianhap, DonGiaBan = @Dongiaban, GhiChu = @Ghichu WHERE MaHang = @maHangHoa;";

                if (string.IsNullOrEmpty(TxtMaHanghoa.Text) || string.IsNullOrEmpty(txtTenHangHoa.Text) || string.IsNullOrEmpty(txtSoLuong.Text) || string.IsNullOrEmpty(txtDongianhap.Text) || string.IsNullOrEmpty(txtChatlieu.Text) || string.IsNullOrEmpty(txtDongiaban.Text)) throw new Exception("khong duoc de trong");

                command.Parameters.AddWithValue("maHangHoa", TxtMaHanghoa.Text);
                command.Parameters.AddWithValue("TenHangHoa", txtTenHangHoa.Text);
                command.Parameters.AddWithValue("Chatlieu", txtChatlieu.Text);
                command.Parameters.AddWithValue("Soluong", txtSoLuong.Text);
                command.Parameters.AddWithValue("Dongianhap", txtDongianhap.Text);
                command.Parameters.AddWithValue("Dongiaban", txtDongiaban.Text);
                command.Parameters.AddWithValue("Ghichu", txtGhichu.Text);

                command.ExecuteNonQuery();
                LoadData("SELECT * from dbo.tblHang;");
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
                command.CommandText = $"INSERT INTO dbo.tblHang VALUES (@maHangHoa, @tenHangHoa,@Chatlieu,@Soluong,@Dongianhap,@Dongiaban,'',@Ghichu);";

                if (string.IsNullOrEmpty(txtTenHangHoa.Text) || string.IsNullOrEmpty(TxtMaHanghoa.Text) || string.IsNullOrEmpty(txtChatlieu.Text) || string.IsNullOrEmpty(txtSoLuong.Text) || string.IsNullOrEmpty(txtDongianhap.Text) || string.IsNullOrEmpty(txtDongiaban.Text)) throw new Exception("khong duoc de trong");

                command.Parameters.AddWithValue("tenHangHoa", txtTenHangHoa.Text);
                command.Parameters.AddWithValue("maHangHoa", TxtMaHanghoa.Text);
                command.Parameters.AddWithValue("Chatlieu", txtChatlieu.Text);
                command.Parameters.AddWithValue("Soluong", txtSoLuong.Text);
                command.Parameters.AddWithValue("Dongianhap", txtDongianhap.Text);
                command.Parameters.AddWithValue("Dongiaban", txtDongiaban.Text);
                command.Parameters.AddWithValue("Ghichu", txtGhichu.Text);

                command.ExecuteNonQuery();
                LoadData("SELECT * from dbo.tblHang;");
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
                if (txtTenHangHoa.Text is null || txtTenHangHoa.Text.Length == 0) throw new AggregateException("Ten hang hoa khong hop le");
                ConnectDb();
                SqlCommand command = _conn.CreateCommand();
                command.CommandText = $"DELETE FROM dbo.tblHang WHERE MaHang = @tenHangHoa";

                command.Parameters.AddWithValue("tenHangHoa", TxtMaHanghoa.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("deleted successfully!");
                LoadData("SELECT * from dbo.tblHang;");
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            TxtMaHanghoa.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenHangHoa.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtChatlieu.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtSoLuong.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtDongianhap.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtDongiaban.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtGhichu.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
        }

        private void Dong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
