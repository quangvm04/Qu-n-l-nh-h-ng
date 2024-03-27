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
    public partial class fAdd : Form
    {
        string connectionString = "Data Source = LAPTOP-2BLG522N\\SQLSERVER1; Initial Catalog  = QLNH; Integrated Security = True";
        float soluong;
        DateTime ngay;
        decimal chiphi;

        public fAdd()
        {
            InitializeComponent();
        }

        private bool IsIngredientExists(string ten)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM nguyenlieu WHERE ten = @ten";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ten", ten);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0; // Trả về true nếu nguyên liệu đã tồn tại, ngược lại trả về false
                }
            }
        }

        private void AddIngredient(string ten, float soluong, DateTime ngay, decimal chiphi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (IsIngredientExists(ten))
                {
                    MessageBox.Show("Nguyên liệu đã tồn tại. Vui lòng kiểm tra lại.");
                    return;
                }
                string query = "INSERT INTO nguyenlieu (ten, soluong, ngay, chiphi) VALUES (@ten, @soluong, @ngay, @chiphi)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ten", ten);
                    command.Parameters.AddWithValue("@soluong", soluong);
                    command.Parameters.AddWithValue("@ngay", ngay);
                    command.Parameters.AddWithValue("@chiphi", chiphi);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Nguyên liệu đã được thêm vào thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm nguyên liệu mới.");
                    }
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float quantity;
            decimal cost;
            if ((string.IsNullOrWhiteSpace(tbTenNL.Text)) || string.IsNullOrWhiteSpace(tbCP.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!float.TryParse(tbSL.Text, out quantity))
            {
                MessageBox.Show("Số lượng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!decimal.TryParse(tbCP.Text, out cost))
            {
                MessageBox.Show("Chi phí không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string ten = tbTenNL.Text;
                soluong = quantity;
                ngay = dateTimePicker1.Value;
                chiphi = cost;
                AddIngredient(ten, soluong, ngay, chiphi);
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
