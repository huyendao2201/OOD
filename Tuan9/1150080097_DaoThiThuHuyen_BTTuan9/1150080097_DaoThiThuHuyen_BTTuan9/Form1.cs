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

namespace _1150080097_DaoThiThuHuyen_BTTuan9
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBConnect.mdf;Integrated Security=True";

        // Đối tượng kết nối
        SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        // Hàm mở kết nối
        private void MoKetNoi()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }

        // Hàm đóng kết nối
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

        // Sự kiện click nút "Hiển thị danh sách"
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                MoKetNoi();

                string sql = "SELECT * FROM NhaXuatBan";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlCon);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tblNhaXuatBan");

                dgvDanhSach.DataSource = ds.Tables["tblNhaXuatBan"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị dữ liệu: " + ex.Message,
                                "Thông báo lỗi", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                DongKetNoi();
            }
        }
    }
}
