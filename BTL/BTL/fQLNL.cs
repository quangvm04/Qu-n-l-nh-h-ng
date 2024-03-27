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
    public partial class fQLNL : Form
    {
        string connectionString = "Data Source = LAPTOP-2BLG522N\\SQLSERVER1; Initial Catalog  = QLNH; Integrated Security = True";
        public fQLNL()
        {
            InitializeComponent();
            UpdateData();
        }

        private void fQLNL_Load(object sender, EventArgs e)
        {
            LoadData(); // Gọi hàm để tải dữ liệu vào DataGridView khi Form được load
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM nguyenlieu"; // Truy vấn lấy dữ liệu từ bảng Ingredients

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable; // Gán DataTable làm nguồn dữ liệu cho DataGridView
            }
        }

        private void UpdateData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                dataGridView1.AutoGenerateColumns = false;
                string query = "SELECT * FROM nguyenlieu";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.Columns["tennl"].DataPropertyName = "ten";
                dataGridView1.Columns["sl"].DataPropertyName = "soluong";
                dataGridView1.Columns["ngay"].DataPropertyName = "ngay";
                dataGridView1.Columns["chiphi"].DataPropertyName = "chiphi";
                dataGridView1.DataSource = dataTable;
            }
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdateData(); // Gọi hàm cập nhật dữ liệu sau khi sửa
        }

        private void dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
                UpdateData(); // Gọi hàm cập nhật dữ liệu sau khi xóa
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void DeleteIngredient(string ten)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM nguyenlieu WHERE ten = @ten";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ten", ten);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thông tin nguyên liệu đã được xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa thông tin nguyên liệu.");
                    }
                }
            }
            UpdateData();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            var addMaterialForm = new fAdd();
            addMaterialForm.ShowDialog();
            UpdateData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string ten = (string)dataGridView1.SelectedRows[0].Cells["tennl"].Value;
                if (string.IsNullOrWhiteSpace(ten))
                {
                    MessageBox.Show("Hãy chọn nguyên liệu cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DeleteIngredient(ten);
                        UpdateData();
                    }
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn nguyên liệu cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string ten = (string)dataGridView1.SelectedRows[0].Cells["tennl"].Value;
                if (string.IsNullOrWhiteSpace(ten))
                {
                    MessageBox.Show("Hãy chọn nguyên liệu cần sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // Lấy thông tin của hàng được chọn
                    float soluong = float.Parse(dataGridView1.SelectedRows[0].Cells["sl"].Value.ToString());
                    DateTime ngay = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["ngay"].Value.ToString());
                    decimal chiphi = decimal.Parse(dataGridView1.SelectedRows[0].Cells["chiphi"].Value.ToString());

                    // Tạo một form sửa và truyền thông tin của nguyên liệu đến form
                    fEdit editForm = new fEdit(ten, soluong, ngay, chiphi);
                    editForm.ShowDialog(); // Hiển thị form sửa

                    // Sau khi form sửa đóng lại, cập nhật dữ liệu trong DataGridView nếu có sự thay đổi
                    UpdateData();
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn nguyên liệu cần sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void fQLNL_Load_1(object sender, EventArgs e)
        {

        }
    }
}
