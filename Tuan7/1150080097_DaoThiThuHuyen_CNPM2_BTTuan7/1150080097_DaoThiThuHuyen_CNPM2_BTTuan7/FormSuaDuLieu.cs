using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1150080097_DaoThiThuHuyen_CNPM2_BTTuan7
{
    public partial class FormSuaDuLieu : Form
    {
        // khai bao ket noi 
        SqlConnection sqlCon = null;
        string strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=|DataDirectory|\DBConnect.mdf;
              Integrated Security=True";

        public FormSuaDuLieu()
        {
            InitializeComponent();
        }

        // mo/dong ket noi
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

        // hien thi ds ma lop
        private void HienThiDSMaLop()
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT DISTINCT MaLop FROM SinhVien";
                sqlCmd.Connection = sqlCon;

                SqlDataReader reader = sqlCmd.ExecuteReader();
                cbMaLop.Items.Clear();
                while (reader.Read())
                {
                    string maLop = reader.GetString(0);
                    cbMaLop.Items.Add(maLop);
                }
                reader.Close();
            }
            finally
            {
                DongKetNoi();
            }
        }

        // hien thi sinh vien theo lop 
        private void HienThiDSSinhVienTheoLop(string maLop)
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT * FROM SinhVien WHERE MaLop = '" + maLop + "'";
                sqlCmd.Connection = sqlCon;

                SqlDataReader reader = sqlCmd.ExecuteReader();
                lsvDanhSach.Items.Clear();

                while (reader.Read())
                {
                    string maSV = reader.GetString(0);
                    string tenSV = reader.GetString(1);
                    string gioiTinh = reader.GetString(2);
                    string ngaySinh = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                    string queQuan = reader.GetString(4);
                    string maLopSV = reader.GetString(5);

                    ListViewItem lvi = new ListViewItem(maSV);
                    lvi.SubItems.Add(tenSV);
                    lvi.SubItems.Add(gioiTinh);
                    lvi.SubItems.Add(ngaySinh);
                    lvi.SubItems.Add(queQuan);
                    lvi.SubItems.Add(maLopSV);
                    lsvDanhSach.Items.Add(lvi);
                }
                reader.Close();
            }
            finally
            {
                DongKetNoi();
            }
        }

      
        private void FormSuaDuLieu_Load(object sender, EventArgs e)
        {
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            HienThiDSMaLop();
        }

        // chon lop
        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaLop.SelectedIndex == -1) return;

            string maLop = cbMaLop.SelectedItem.ToString().Trim();
            HienThiDSSinhVienTheoLop(maLop);
        }

        // chon sv trong ds
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;

            ListViewItem lvi = lsvDanhSach.SelectedItems[0];

            txtMaSV.Text = lvi.SubItems[0].Text;
            txtTenSV.Text = lvi.SubItems[1].Text;
            cbGioiTinh.Text = lvi.SubItems[2].Text;

            try
            {
                DateTime ns;
                if (DateTime.TryParseExact(lvi.SubItems[3].Text, "dd/MM/yyyy", null,
                    System.Globalization.DateTimeStyles.None, out ns))
                    dtpNgaySinh.Value = ns;
            }
            catch
            {
                dtpNgaySinh.Value = DateTime.Now;
            }

            txtQueQuan.Text = lvi.SubItems[4].Text;
            txtMaLop.Text = lvi.SubItems[5].Text;
        }

        // Btn sua thong tin
        /*Khong su dung Parameter
                 private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                MoKetNoi();

                // Lấy dữ liệu từ control
                string maSV = txtMaSV.Text.Trim();
                string tenSV = txtTenSV.Text.Trim();
                string gioiTinh = cbGioiTinh.Text;
                string ngaySinh = dtpNgaySinh.Value.ToString("yyyy/MM/dd");
                string queQuan = txtQueQuan.Text.Trim();
                string maLop = txtMaLop.Text.Trim();

                // Câu lệnh UPDATE không dùng Parameter
                string sql = "UPDATE SinhVien SET " +
                             "TenSV='" + tenSV + "', " +
                             "GioiTinh='" + gioiTinh + "', " +
                             "NgaySinh=CAST('" + ngaySinh + "' AS DATETIME), " +
                             "QueQuan='" + queQuan + "', " +
                             "MaLop='" + maLop + "' " +
                             "WHERE MaSV='" + maSV + "'";

                SqlCommand sqlCmd = new SqlCommand(sql, sqlCon);
                int kq = sqlCmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    HienThiDSSinhVienTheoLop(maLop);
                }
                else
                {
                    MessageBox.Show("Không có bản ghi nào được cập nhật.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }

            // Xóa dữ liệu trên các ô nhập
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            cbGioiTinh.Text = "";
            txtQueQuan.Text = "";
            txtMaLop.Text = "";
        }
       */
        // Co su dung Parameter
        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu chưa chọn sinh viên nào
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MoKetNoi();

                // Câu lệnh SQL có dùng Parameter
                string sql = @"UPDATE SinhVien 
                       SET TenSV = @TenSV, 
                           GioiTinh = @GioiTinh, 
                           NgaySinh = @NgaySinh, 
                           QueQuan = @QueQuan, 
                           MaLop = @MaLop 
                       WHERE MaSV = @MaSV";

                // Tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand(sql, sqlCon);

                // Gán giá trị cho các Parameter
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text.Trim());
                cmd.Parameters.AddWithValue("@TenSV", txtTenSV.Text.Trim());
                cmd.Parameters.AddWithValue("@GioiTinh", cbGioiTinh.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value); // dùng kiểu DateTime
                cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text.Trim());
                cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());

                // Thực thi câu lệnh
                int kq = cmd.ExecuteNonQuery();

                // Kiểm tra kết quả
                if (kq > 0)
                {
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công (dùng Parameter)!", "Thông báo");
                    HienThiDSSinhVienTheoLop(txtMaLop.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Không có bản ghi nào được cập nhật!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }
    }
}
