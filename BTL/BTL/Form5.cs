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

namespace BTL
{
    public partial class Form5 : Form
    {
        private bool ktramahoadon(string Mahoadon)
        {
            using (SqlConnection connection = new SqlConnection(chuoiketnoi))
            {
                string query = "SELECT COUNT(*) FROM hoadon WHERE Mahoadon = @Mahoadon";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Mahoadon", Mahoadon);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0; // Trả về true nếu đã tồn tại, ngược lại trả về false
                }
            }
        }
        string chuoiketnoi = "Data Source = LAPTOP-2BLG522N\\SQLSERVER1; Initial Catalog  = QLNH; Integrated Security = True";
        public Form5()
        {
            InitializeComponent();
            UpdateData();
            tb_timkiem.Text = "Nhập mã hóa đơn";
            tb_timkiem.ForeColor = Color.Blue;
        }
        private void themhoadon(string Mahoadon, DateTime Ngaylap, decimal Tongtien)
        {
            using (SqlConnection connection = new SqlConnection(chuoiketnoi))
            {
                if (ktramahoadon(Mahoadon))
                {
                    MessageBox.Show("Mã hóa đơn đã tồn tại. Vui lòng kiểm tra lại.");
                    return;
                }
                string query = "INSERT INTO hoadon (Mahoadon, Ngaylap, Tongtien) VALUES (@Mahoadon, @Ngaylap, @Tongtien)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Mahoadon", Mahoadon);
                    command.Parameters.AddWithValue("@Ngaylap", Ngaylap);
                    command.Parameters.AddWithValue("@Tongtien", Tongtien);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Hóa đơn đã được thêm vào thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm hóa đơn mới.");
                    }
                }
            }

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            // kiểm tra ô dữ liệu trống
            if (string.IsNullOrEmpty(tb_mahoadon.Text) || string.IsNullOrEmpty(tb_tongtien.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần thiết!");
                return; // dừng hàm và không thêm vào CSDL
            }

            //câu lệnh SQL thêm dữ liệu vào CSDL
            string Mahoadon = tb_mahoadon.Text;
            DateTime Ngaylap = dateTimePicker1.Value;
            decimal Tongtien;
            decimal.TryParse(tb_tongtien.Text, out Tongtien);
            themhoadon(Mahoadon, Ngaylap, Tongtien);
            UpdateData();
            // xóa dữ liệu của datagridview hiện tại và cập nhật lại từ CSDL
        }
        private void UpdateData()
        {
            using (SqlConnection connection = new SqlConnection(chuoiketnoi))
            {
                dataGridView1.AutoGenerateColumns = false;
                string query = "SELECT * FROM hoadon";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.Columns["mhd"].DataPropertyName = "Mahoadon";
                dataGridView1.Columns["ngaylap"].DataPropertyName = "Ngaylap";
                dataGridView1.Columns["tongtien"].DataPropertyName = "Tongtien";
                dataGridView1.DataSource = dt;
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string Mahoadon = (string)dataGridView1.SelectedRows[0].Cells["mhd"].Value;
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(chuoiketnoi))
                    {
                        string query = "DELETE FROM hoadon WHERE Mahoadon = @Mahoadon";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Mahoadon", Mahoadon);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Hóa đơn đã được xóa thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Không thể xóa hóa đơn.");
                            }
                        }
                    }
                    UpdateData();
                }

            }
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(chuoiketnoi);
            string query = "SELECT * FROM hoadon WHERE Mahoadon = @keyword";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            string keyword = tb_timkiem.Text.Trim();
            // Kiểm tra nếu từ khóa tìm kiếm là rỗng
            if (string.IsNullOrEmpty(keyword))
            {
                // Hiển thị toàn bộ dữ liệu khi không có từ khóa tìm kiếm
                MessageBox.Show("Vui lòng mã hóa đơn!");
            }
            else
            {
                cmd.Parameters.AddWithValue("@keyword", keyword);
                con.Open();

                // Xóa dữ liệu hiện tại của DataTable
                dt.Clear();

                // Đổ dữ liệu từ câu truy vấn vào DataTable
                adapter.Fill(dt);

                // Cập nhật DataSource của DataGridView với dữ liệu tìm kiếm được
                dataGridView1.DataSource = dt;
            }
        }

        private void tb_timkiem_Click(object sender, EventArgs e)
        {
            if (tb_timkiem.Text == "Nhập mã hóa đơn")
            {
                tb_timkiem.Text = "";
                tb_timkiem.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
    }

}
