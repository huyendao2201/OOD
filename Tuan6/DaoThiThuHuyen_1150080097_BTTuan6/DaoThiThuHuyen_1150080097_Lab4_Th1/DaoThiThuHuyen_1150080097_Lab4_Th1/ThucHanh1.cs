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

namespace DaoThiThuHuyen_1150080097_Lab4_Th1
{
    public partial class ThucHanh1 : Form
    {
        // Khai báo chuỗi kết nối và đối tượng kết nối
        SqlConnection sqlCon = null;
        string strCon = @"Data Source=LAPTOP-A17NR9K5;Initial Catalog=QuanLySinhVien;Integrated Security=True";

        public ThucHanh1()
        {
            InitializeComponent();
        }

        // Hàm mở kết nối
        private void btnMoKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    MessageBox.Show("Kết nối CSDL thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kết nối đã được mở sẵn!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối: " + ex.Message);
            }
        }

        // Hàm đóng kết nối
        private void btnDongKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                    MessageBox.Show("Đã đóng kết nối!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kết nối hiện đang đóng!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đóng kết nối: " + ex.Message);
            }
        }
        // Truy vấn lấy 1 giá trị
        private void btnCount_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Mở kết nối
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                // 2️⃣ Tạo truy vấn
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT COUNT(*) FROM SinhVien";
                sqlCmd.Connection = sqlCon;

                // 3️⃣ Thực thi và lấy kết quả
                int soLuongSV = (int)sqlCmd.ExecuteScalar();

                // 4️⃣ Hiển thị kết quả ra màn hình
                MessageBox.Show("Số lượng sinh viên là: " + soLuongSV,
                                "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy vấn: " + ex.Message);
            }
        }
    }
}
