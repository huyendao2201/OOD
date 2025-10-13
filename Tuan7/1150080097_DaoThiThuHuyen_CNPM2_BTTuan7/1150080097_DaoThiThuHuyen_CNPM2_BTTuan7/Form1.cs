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

namespace _1150080097_DaoThiThuHuyen_CNPM2_BTTuan7
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối và đối tượng kết nối
        SqlConnection sqlCon = null;
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBConnect.mdf;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        // Hàm mở kết nối
        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        // Hàm đóng kết nối
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        // Hàm hiển thị danh sách sinh viên trong ListView
        private void HienThiDanhSach()
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT * FROM SinhVien";
                sqlCmd.Connection = sqlCon;

                SqlDataReader reader = sqlCmd.ExecuteReader();
                lsvDanhSachSV.Items.Clear();

                while (reader.Read())
                {
                    string maSV = reader.GetString(0);
                    string tenSV = reader.GetString(1);
                    string gioiTinh = reader.GetString(2);
                    string ngaySinh = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                    string queQuan = reader.GetString(4);
                    string maLop = reader.GetString(5);

                    ListViewItem lvi = new ListViewItem(maSV);
                    lvi.SubItems.Add(tenSV);
                    lvi.SubItems.Add(gioiTinh);
                    lvi.SubItems.Add(ngaySinh);
                    lvi.SubItems.Add(queQuan);
                    lvi.SubItems.Add(maLop);

                    lsvDanhSachSV.Items.Add(lvi);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị danh sách: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

        // Sự kiện nút “Thêm sinh viên”
        /*
         Thêm sinh viên không sử dụng Parameter
                private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            try
            {
                MoKetNoi();

                string maSV = txtMaSV.Text.Trim();
                string tenSV = txtTenSV.Text.Trim();
                string gioiTinh = cbGioiTinh.Text;
                string ngaySinh = dtpNgaySinh.Value.Month + "/" + dtpNgaySinh.Value.Day + "/" + dtpNgaySinh.Value.Year;
                string queQuan = txtQueQuan.Text.Trim();
                string maLop = txtMaLop.Text.Trim();

                // Câu lệnh SQL thêm sinh viên (không dùng parameter)
                string sql = "INSERT INTO SinhVien VALUES ('" + maSV + "', '" + tenSV + "', '" + gioiTinh + "', '" + ngaySinh + "', '" + queQuan + "', '" + maLop + "')";
                SqlCommand sqlCmd = new SqlCommand(sql, sqlCon);

                int kq = sqlCmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show("Thêm sinh viên thành công!");
                    HienThiDanhSach();
                }
                else
                {
                    MessageBox.Show("Thêm sinh viên thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

         */

        /*
         Thêm sinh viên có sử dụng Parameter
        */
        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            try
            {
                MoKetNoi();

                string sql = "INSERT INTO SinhVien VALUES (@MaSV, @TenSV, @GioiTinh, @NgaySinh, @QueQuan, @MaLop)";
                SqlCommand cmd = new SqlCommand(sql, sqlCon);

                // Lấy dữ liệu từ form và gán vào Parameter
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text.Trim());
                cmd.Parameters.AddWithValue("@TenSV", txtTenSV.Text.Trim());
                cmd.Parameters.AddWithValue("@GioiTinh", cbGioiTinh.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text.Trim());
                cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());

                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show("Thêm sinh viên thành công (dùng Parameter)!");
                    HienThiDanhSach();
                }
                else
                {
                    MessageBox.Show("Không thể thêm sinh viên!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

        // Sự kiện khi Form load
        private void Form1_Load(object sender, EventArgs e)
        {
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            HienThiDanhSach();
        }
    }
}
