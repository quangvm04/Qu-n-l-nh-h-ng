using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace BTL
{
    public partial class Form4 : Form
    {
        string connectstring = "Data Source = LAPTOP-2BLG522N\\SQLSERVER1; Initial Catalog  = QLNH; Integrated Security = True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public Form4()
        {
            InitializeComponent();
        }
        private void txt6_Color()
        {
            textBox6.Text = "Nhập tên nhân viên";
            textBox6.ForeColor = Color.Gray;
        }
        
        private void delete_data()
        {           
            //Xóa dữ liệu trong các textBox
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            //Cài đặt lại thời gian mặc định
            dateTimePicker1.Value = DateTime.Now;
            //Cài lại các radiobutton vè trạng thái ban đầu
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
     
        private bool checkinput(string input)
        {
            int number;
            bool isNumeric = int.TryParse(input, out number);
            return isNumeric;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNV_table.QLNV' table. You can move, or remove it, as needed.
            this.qLNVTableAdapter3.Fill(this.qLNV_table.QLNV);           
            //tải dữ liệu từ bảng QLNV trong CSDL vào dataGridView1
            conn = new SqlConnection(connectstring);
            conn.Open();
            cmd = new SqlCommand("Select * from QLNV", conn);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            //Thiết lập văn bản mặc định và màu chữ cho textBox6          
            txt6_Color();         
        }
        // Tạo một biến toàn cục gender 
        string gender;
        //Gán giá trị cho gender khi click và các radiobutton
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Nam";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Nữ";
        }

        private bool ktramaNV(string maNV)
        {
            string query = "select count(*) from QLNV where MaNV = @maNV";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@maNV", maNV);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
        //Button thêm
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkinput(textBox3.Text))
            {
                //Kiểm tra mã nhân viên có tồn tại không
                string maNV = textBox1.Text;
                if (ktramaNV(maNV))
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng kiểm tra lại!");
                    return;
                }
                try
                {
                    if (textBox1.Text != "")
                    {
                        //tạo câu lệnh chèn dữ liệu vào bảng QLNV
                        cmd = conn.CreateCommand();
                        cmd.CommandText = "insert into QLNV values(N'" + textBox1.Text + "',N'" + textBox2.Text + "','" +
                            dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',N'" + gender + "','" + textBox3.Text + "',N'" + textBox4.Text + "','" + textBox5.Text + "')";
                        cmd.ExecuteNonQuery();

                        // Xóa dữ liệu hiện tại của DataTable
                        dt.Clear();
                        //Đổ dữ liệu từ câu truy vấn vào DataTable
                        adapter.Fill(dt);
                        // Cập nhật DataSource của DataGridView với dữ liệu tìm kiếm được
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập thông tin nhân viên", "Thông báo", MessageBoxButtons.OK);
                    }

                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập đúng thông tin", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Nhập sai dữ liệu số điện thoại .");
            }
                     
        }                                 
        

        //Button cập nhật
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkinput(textBox3.Text))
            {
                try
                {
                    //tạo lệnh cập nhật thông tịn cho các bản ghi trong bảng QLNV
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "update QLNV set MaNV = '" + textBox1.Text + "', TenNV = N'" + textBox2.Text + "', NgaySinh = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") +
                        "', GioiTinh = N'" + gender + "', SoDT = '" + textBox3.Text + "', Luong = " + textBox5.Text + ", Vitri = N'" + textBox4.Text + "' where MaNV = '" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();

                    // Xóa dữ liệu hiện tại của DataTable
                    dt.Clear();
                    //Đổ dữ liệu từ câu truy vấn vào DataTable
                    adapter.Fill(dt);
                    // Cập nhật DataSource của DataGridView với dữ liệu tìm kiếm được
                    dataGridView1.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần sửa", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Nhập sai dữ liệu số điện thoại .");
            }
            
        }

        //Button xóa
        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                //tạo câu lện xóa dữ liệu
                cmd = conn.CreateCommand();
                cmd.CommandText = "delete from QLNV where MaNV = N'" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();

                // Xóa dữ liệu hiện tại của DataTable
                dt.Clear();
                //Đổ dữ liệu từ câu truy vấn vào DataTable
                adapter.Fill(dt);
                // Cập nhật DataSource của DataGridView với dữ liệu tìm kiếm được
                dataGridView1.DataSource = dt;
                delete_data();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK);
            }
            
        }

        //Button tìm kiếm
        private void button4_Click(object sender, EventArgs e)
        {
            string keyword = textBox6.Text.Trim();

            // Kiểm tra nếu từ khóa tìm kiếm là rỗng
            if (string.IsNullOrEmpty(keyword))
            {
                // Hiển thị toàn bộ dữ liệu khi không có từ khóa tìm kiếm
                MessageBox.Show("Vui lòng nhập tên nhân viên!");
            }
            else
            {
                // Tạo câu truy vấn SQL để tìm kiếm các món ăn có tên chứa từ khóa
                string query = "SELECT * FROM QLNV WHERE TenNV LIKE N'%" + keyword + "%'";

                // Tạo đối tượng SqlCommand và SqlDataAdapter để thực hiện câu truy vấn
                cmd = new SqlCommand(query, conn);
                adapter = new SqlDataAdapter(cmd);

                // Xóa dữ liệu hiện tại của DataTable
                dt.Clear();

                // Đổ dữ liệu từ câu truy vấn vào DataTable
                adapter.Fill(dt);

                // Cập nhật DataSource của DataGridView với dữ liệu tìm kiếm được
                dataGridView1.DataSource = dt;
            }
        }

        //Button reset
        private void button5_Click(object sender, EventArgs e)
        {
            //Xóa dữ liệu hiện tại cảu DataTable
            dt.Clear();
            delete_data();
            //Tải lại Form4
            Form4_Load(sender, e);
        }

        private void dgv_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            // lấy chỉ số của ô hiện tại 
            int i = dataGridView1.CurrentRow.Index;
            // hiển thị dữ liệu dòng đó lên các textbox, datetimePicker và bỏ khoảng trống thừa
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString().Trim();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString().Trim();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[4].Value.ToString().Trim();
            textBox4.Text = dataGridView1.Rows[i].Cells[5].Value.ToString().Trim();
            textBox5.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            //hiển thị dữ liệu lên radiobutton 
            gender = dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim();
            if (gender.Equals("Nam"))
            {
                radioButton1.Checked = true;
            }
            else if(gender.Equals("Nữ"))
            {
                radioButton2.Checked = true;
            }


        }
        
        
        
        //TextBox tìm kiếm 
        private void tb6_click(object sender, EventArgs e)
        {          
            //Xóa dữ lệu ở texBox6
            if(textBox6.Text == "Nhập tên nhân viên")
                textBox6.Clear();
        }
    }
}
