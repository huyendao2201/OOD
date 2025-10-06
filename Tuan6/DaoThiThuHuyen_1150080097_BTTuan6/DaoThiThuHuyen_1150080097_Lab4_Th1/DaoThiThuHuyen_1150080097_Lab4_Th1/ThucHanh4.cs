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

namespace DaoThiThuHuyen_1150080097_Lab4_Th1
{
    public partial class ThucHanh4 : Form
    {
        // Khai báo chuỗi kết nối và đối tượng kết nối
        SqlConnection sqlCon = null;
        string strCon = @"Data Source=LAPTOP-A17NR9K5;Initial Catalog=QuanLySinhVien;Integrated Security=True";

        public ThucHanh4()
        {
            InitializeComponent();
        }

        private void FrmApDung_Load(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                // Xóa danh sách lớp cũ
                lsbDSLop.Items.Clear();

                // Lấy danh sách lớp
                SqlCommand cmd = new SqlCommand("SELECT MaLop FROM SinhVien", sqlCon);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string maLop = reader.GetString(0).Trim(); // loại bỏ khoảng trắng dư
                    lsbDSLop.Items.Add($"{maLop}");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách lớp: " + ex.Message);
            }
        }

        private void lsbDSLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbDSLop.SelectedIndex == -1) return;

            try
            {
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                // Xóa danh sách sinh viên cũ
                lsvDSSV.Items.Clear();

                // Lấy mã lớp được chọn
                string selectedItem = lsbDSLop.SelectedItem.ToString();
                string maLop = selectedItem.Split('-')[0].Trim();

                // Tạo truy vấn có tham số (dùng RTRIM để bỏ khoảng trắng trong DB)
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM SinhVien WHERE RTRIM(MaLop) = @maLop";
                cmd.Connection = sqlCon;

                // Sử dụng VarChar thay vì Char để tránh lỗi padding
                SqlParameter parMaLop = new SqlParameter("@maLop", SqlDbType.VarChar);
                parMaLop.Value = maLop;
                cmd.Parameters.Add(parMaLop);

                SqlDataReader reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    string maSV = reader.GetString(0);
                    string tenSV = reader.GetString(1);
                    string gioiTinh = reader.GetString(2);
                    string ngaySinh = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                    string queQuan = reader.GetString(4);
                    string lop = reader.GetString(5).Trim();

                    ListViewItem lvi = new ListViewItem(maSV);
                    lvi.SubItems.Add(tenSV);
                    lvi.SubItems.Add(gioiTinh);
                    lvi.SubItems.Add(ngaySinh);
                    lvi.SubItems.Add(queQuan);
                    lvi.SubItems.Add(lop);

                    lsvDSSV.Items.Add(lvi);
                    count++;
                }

                reader.Close();

                // Hiển thị tổng số sinh viên
                MessageBox.Show($"Lớp {maLop} có {count} sinh viên.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị sinh viên: " + ex.Message);
            }
        }
    }
}
