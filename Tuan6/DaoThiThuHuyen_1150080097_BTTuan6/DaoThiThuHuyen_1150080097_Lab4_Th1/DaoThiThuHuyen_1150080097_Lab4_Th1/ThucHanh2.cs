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
    public partial class ThucHanh2 : Form
    {
        // Khai báo chuỗi kết nối và đối tượng kết nối
        SqlConnection sqlCon = null;
        string strCon = @"Data Source=LAPTOP-A17NR9K5;Initial Catalog=QuanLySinhVien;Integrated Security=True";

        public ThucHanh2()
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
        // Nút Xem Thông Tin
        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở kết nối
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                // Lấy mã sinh viên từ TextBox
                string maSV = txtMaSV.Text.Trim();

                if (string.IsNullOrWhiteSpace(maSV))
                {
                    MessageBox.Show("Vui lòng nhập mã sinh viên!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo câu lệnh truy vấn có tham số
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT * FROM SinhVien WHERE MaSV = @maSV";
                sqlCmd.Parameters.AddWithValue("@maSV", maSV);
                sqlCmd.Connection = sqlCon;

                // Thực thi truy vấn
                SqlDataReader reader = sqlCmd.ExecuteReader();

                if (reader.Read())
                {
                    // Đọc dữ liệu từng cột trong dòng
                    txtTenSV.Text = reader.GetString(1);
                    txtGioiTinh.Text = reader.GetString(2);
                    dtpNgaySinh.Value = reader.GetDateTime(3);
                    txtQueQuan.Text = reader.GetString(4);
                    txtMaLop.Text = reader.GetString(5);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên có mã: " + maSV, "Kết quả",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa dữ liệu cũ
                    ClearFields();
                }

                // Đóng DataReader
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm dọn sạch các ô nhập khi không tìm thấy dữ liệu
        private void ClearFields()
        {
            txtTenSV.Clear();
            txtGioiTinh.Clear();
            txtQueQuan.Clear();
            txtMaLop.Clear();
            dtpNgaySinh.Value = DateTime.Now;
        }
    }
}
