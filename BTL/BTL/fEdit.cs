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
    public partial class fEdit : Form
    {
        string connectionString = "Data Source = LAPTOP-2BLG522N\\SQLSERVER1; Initial Catalog  = QLNH; Integrated Security = True";

        public fEdit(string ten, float soluong, DateTime ngay, decimal chiphi)
        {
            InitializeComponent();
            tbTenNL.Text = ten;
            tbSL.Text = soluong.ToString();
            dateTimePicker1.Value = ngay;
            tbCP.Text = chiphi.ToString();
        }

        private void AddIngredient(string ten, float soluong, DateTime ngay, decimal chiphi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO nguyenlieu (ten, soluong, ngay, chiphi) VALUES (@ten, @soluong, @ngay, @chiphi)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ten", ten);
                    command.Parameters.AddWithValue("@soluong", soluong);
                    command.Parameters.AddWithValue("@ngay", ngay);
                    command.Parameters.AddWithValue("@chiphi", chiphi);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UpdateIngredient(string ten, float soluong, DateTime ngay, decimal chiphi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo truy vấn cập nhật
                string query = "UPDATE nguyenlieu SET soluong = @soluong, ngay = @ngay, chiphi = @chiphi WHERE ten = @ten";

                // Tạo đối tượng SqlCommand và thiết lập tham số
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ten", ten);
                    command.Parameters.AddWithValue("@soluong", soluong);
                    command.Parameters.AddWithValue("@ngay", ngay);
                    command.Parameters.AddWithValue("@chiphi", chiphi);

                    // Mở kết nối và thực thi truy vấn cập nhật
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thông tin nguyên liệu đã được cập nhật thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật thông tin nguyên liệu.");
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ten = tbTenNL.Text;
            float soluong = float.Parse(tbSL.Text);
            DateTime ngay = dateTimePicker1.Value;
            decimal chiphi = decimal.Parse(tbCP.Text);
            DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UpdateIngredient(ten, soluong, ngay, chiphi);
            }
            this.Close();
        }
    }
}
