using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1150080097_DaoThiThuHuyen_CNPM2_BTTuan7
{
    public partial class FormXoaDuLieu : Form
    {
        SqlConnection sqlCon = null;
        string strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=|DataDirectory|\DBConnect.mdf;
              Integrated Security=True";

        public FormXoaDuLieu()
        {
            InitializeComponent();
        }

        // Mở / Đóng kết nối
        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        //  Hiển thị danh sách sinh viên
        private void HienThiDSSinhVien()
        {
            try
            {
                MoKetNoi();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT * FROM SinhVien";
                sqlCmd.Connection = sqlCon;

                lsvDanhSach.Items.Clear();
                SqlDataReader reader = sqlCmd.ExecuteReader();

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
                    lsvDanhSach.Items.Add(lvi);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sinh viên: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

        private void FormXoaDuLieu_Load(object sender, EventArgs e)
        {
            HienThiDSSinhVien();
        }

        string maSV = "";

        // Sự kiện chọn sinh viên trong danh sách
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;

            ListViewItem lvi = lsvDanhSach.SelectedItems[0];
            maSV = lvi.SubItems[0].Text.Trim();
        }

        // Nút Xóa sinh viên
        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (maSV == "")
            {
                MessageBox.Show("Bạn chưa chọn sinh viên nào để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có thực sự muốn xóa sinh viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                XoaSinhVien(maSV);
            }
        }

        // Hàm xóa
        /*Khong co parameter
                 private void XoaSinhVien(string maSV)
        {
            try
            {
                MoKetNoi();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "DELETE FROM SinhVien WHERE MaSV = '" + maSV + "'";
                sqlCmd.Connection = sqlCon;

                int kq = sqlCmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo");
                    HienThiDSSinhVien();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nào bị xóa!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

         */
        // Co parameter
        private void XoaSinhVien(string maSV)
        {
            try
            {
                MoKetNoi();

                // Câu lệnh DELETE có sử dụng Parameter
                string sql = "DELETE FROM SinhVien WHERE MaSV = @MaSV";

                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.CommandType = CommandType.Text;

                // Gán giá trị
                cmd.Parameters.AddWithValue("@MaSV", maSV);

                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show("Xóa dữ liệu sinh viên thành công (dùng Parameter)!", "Thông báo");
                    HienThiDSSinhVien();
                }
                else
                {
                    MessageBox.Show("Không có bản ghi nào bị xóa!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

    }
}
