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
    public partial class ThucHanh3 : Form
    {
        // Khai báo chuỗi kết nối và đối tượng kết nối
        SqlConnection sqlCon = null;
        string strCon = @"Data Source=LAPTOP-A17NR9K5;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        public ThucHanh3()
        {
            InitializeComponent();
        }

        private void btnListView_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở kết nối
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                // Xóa dữ liệu cũ
                lsvList.Items.Clear();

                // Tạo đối tượng truy vấn
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT * FROM SinhVien";
                sqlCmd.Connection = sqlCon;

                SqlDataReader reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    string maSV = reader.GetString(0);
                    string tenSV = reader.GetString(1);
                    string gioiTinh = reader.GetString(2);
                    string ngaySinh = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                    string queQuan = reader.GetString(4);
                    string maLop = reader.GetString(5);

                    // Thêm vào ListView
                    ListViewItem lvi = new ListViewItem(maSV);
                    lvi.SubItems.Add(tenSV);
                    lvi.SubItems.Add(gioiTinh);
                    lvi.SubItems.Add(ngaySinh);
                    lvi.SubItems.Add(queQuan);
                    lvi.SubItems.Add(maLop);

                    lsvList.Items.Add(lvi);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
