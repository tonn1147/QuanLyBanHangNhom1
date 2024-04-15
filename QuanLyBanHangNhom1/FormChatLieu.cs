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
    public partial class FormChatLieu : Form
    {
        public FormChatLieu()
        {
            InitializeComponent();
        }
        private readonly SqlConnection _conn = new SqlConnection(AppConfiguration.ConnectionString);
        private SqlCommand _cmd;
        private DataTable _dataTable;
        private SqlDataAdapter _adapter;

        private string MaChatlieuPrefix = "CL";

        private void FormChatLieu_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData("select * from tblChatLieu");

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
            MaChatLieu.Text = "";
            TenChatLieu.Text = "";
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
            sb.Append(MaChatlieuPrefix);
            DateTime date = DateTime.Now;
            string dateString = date.ToString("yyyyMMdd_HHmmss");
            sb.Append(dateString);
            MaChatLieu.Text = sb.ToString();
        }

        //update data
        private void Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDb();
                SqlCommand command = _conn.CreateCommand();
                command.CommandText = $"UPDATE dbo.tblChatLieu SET  TenChatLieu = @tenChatLieu WHERE MaChatLieu = @maChatLieu;";

                command.Parameters.AddWithValue("maChatLieu", MaChatLieu.Text);
                command.Parameters.AddWithValue("tenChatLieu", TenChatLieu.Text);
                command.ExecuteNonQuery();
                LoadData("SELECT * from dbo.tblChatLieu;");
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
                command.CommandText = $"INSERT INTO dbo.tblChatLieu VALUES (@maChatLieu, @tenChatLieu);";

                command.Parameters.AddWithValue("maChatLieu", MaChatLieu.Text);
                command.Parameters.AddWithValue("tenChatLieu", TenChatLieu.Text);
                command.ExecuteNonQuery();
                LoadData("SELECT * from dbo.tblChatLieu;");
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
                if (MaChatLieu.Text is null || MaChatLieu.Text.Length == 0) throw new AggregateException("Ma Khach Hang khong hop le");
                ConnectDb();
                SqlCommand command = _conn.CreateCommand();
                command.CommandText = $"DELETE FROM dbo.tblChatLieu WHERE MaChatLieu = @maChatLieu";

                command.Parameters.AddWithValue("maChatLieu", MaChatLieu.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("deleted successfully!");
                LoadData("select * from tblChatLieu");
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            MaChatLieu.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            TenChatLieu.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }

        private void Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}