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
    public partial class Quanlymonan : Form
    {
        string chuoiketnoi = "Data Source = LAPTOP-2BLG522N\\SQLSERVER1; Initial Catalog  = QLNH; Integrated Security = True";
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        DataTable dt = new DataTable();
        public Quanlymonan()
        {
            InitializeComponent();
        }

        private bool ktramamonan(string mamonan)
        {
            string query = "select count(*) from ql_monan where [Mã món ăn] = @mamonan";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@mamonan", mamonan);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNHDataSet2.ql_monan' table. You can move, or remove it, as needed.
            this.ql_monanTableAdapter.Fill(this.qLNHDataSet2.ql_monan);
            // load dữ liệu từ bảng ql_monan vào datagridview
            con = new SqlConnection(chuoiketnoi);
            con.Open();

            cmd = new SqlCommand("select * from ql_monan", con);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            // giá trị măc định và màu chữ của textbox tìm kiếm
            tb_timkiem.Text = "Nhập tên món";
            tb_timkiem.ForeColor = Color.Blue;
        }

        private void bt_themmon_Click(object sender, EventArgs e)
        {
            // kiểm tra ô dữ liệu trống
            if (string.IsNullOrEmpty(tb_mamonan.Text) || string.IsNullOrEmpty(tb_tenmon.Text) || string.IsNullOrEmpty(tb_giamonan.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần thiết!");
                return; // dừng hàm và không thêm vào CSDL
            }
            string mamonan = tb_mamonan.Text;
            if (ktramamonan(mamonan))
            {
                MessageBox.Show("Mã món ăn đã tồn tại. Vui lòng kiểm tra lại!");
                return;
            }
            //câu lệnh SQL thêm dữ liệu vào CSDL
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into ql_monan values(N'" + tb_mamonan.Text + "',N'" + tb_tenmon.Text + "','" + tb_giamonan.Text + "',N'" + tb_nguyenlieu.Text + "',N'" + tb_mota.Text + "')";
            cmd.ExecuteNonQuery();

            // xóa dữ liệu của datagridview hiện tại và cập nhật lại từ CSDL
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bt_xoamon_Click(object sender, EventArgs e)
        {
            // câu lệnh SQL xóa dữ liệu
            cmd = con.CreateCommand();
            cmd.CommandText = "delete from ql_monan where [Mã món ăn] = N'" + tb_mamonan.Text + "'";
            cmd.ExecuteNonQuery();

            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dvg_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            // lấy chỉ số của ô hiện tại
            int i;
            i = dataGridView1.CurrentRow.Index;

            // hiển thị dữ liệu dòng đó lên các textbox
            tb_mamonan.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tb_tenmon.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tb_giamonan.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            tb_nguyenlieu.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            tb_mota.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void bt_lammoi_Click(object sender, EventArgs e)
        {
            // xóa dữ liệu hiện tại của các ô
            tb_mamonan.Text = "";
            tb_tenmon.Text = "";
            tb_giamonan.Text = "";
            tb_nguyenlieu.Text = "";
            tb_mota.Text = "";

            tb_timkiem.Text = "Nhập tên món";
            tb_timkiem.ForeColor = Color.Blue;

            // dữ liệu vừa tìm kiếm ra khỏi datagridview
            dt.Clear();

            //load lại từ CSDL
            Form2_Load(sender, e);
        }

        private void bt_chinhsua_Click(object sender, EventArgs e)
        {
            // câu lệnh SQL để cập nhật thông tin vào CSDL
            cmd = con.CreateCommand();
            cmd.CommandText = "update ql_monan set [Tên món ăn]=N'" + tb_tenmon.Text + "', [Giá món ăn] = '" + tb_giamonan.Text + "', [Nguyên liệu]=N'" + tb_nguyenlieu.Text + "',[Mô tả]=N'" + tb_mota.Text + "' where [Mã món ăn] = '" + tb_mamonan.Text + "'";
            cmd.ExecuteNonQuery();

            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            // Lấy từ khóa tìm kiếm từ TextBox và loại bỏ khoảng trắng thừa
            string keyword = tb_timkiem.Text.Trim();

            // Kiểm tra nếu từ khóa tìm kiếm là rỗng
            if (string.IsNullOrEmpty(keyword))
            {
                // Hiển thị toàn bộ dữ liệu khi không có từ khóa tìm kiếm
                MessageBox.Show("Vui lòng nhập tên món ăn!");
            }
            else
            {
                // Tạo câu truy vấn SQL để tìm kiếm các món ăn có tên chứa từ khóa
                string query = "SELECT * FROM ql_monan WHERE [Tên món ăn] LIKE N'%" + keyword + "%'";

                // Tạo đối tượng SqlCommand và SqlDataAdapter để thực hiện câu truy vấn
                cmd = new SqlCommand(query, con);
                adapter = new SqlDataAdapter(cmd);

                // Xóa dữ liệu hiện tại của DataTable
                dt.Clear();

                // Đổ dữ liệu từ câu truy vấn vào DataTable
                adapter.Fill(dt);

                // Cập nhật DataSource của DataGridView với dữ liệu tìm kiếm được
                dataGridView1.DataSource = dt;
            }
        }

        private void tb_timkiem_click(object sender, EventArgs e)
        {
            if (tb_timkiem.Text == "Nhập tên món")
            {
                // xóa giá trị mặc định và đổi màu font
                tb_timkiem.Text = "";
                tb_timkiem.ForeColor = Color.Black;
            }
        }
    }
}
