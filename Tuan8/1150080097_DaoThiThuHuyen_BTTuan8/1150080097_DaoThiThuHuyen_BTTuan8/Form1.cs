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

namespace _1150080097_DaoThiThuHuyen_BTTuan8
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBConnect.mdf;Integrated Security=True";

        SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        // mở kết nối
        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);

            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        // đóng kết nối
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        // hiển thị danh sách nhà xuất bản
        private void HienThiDanhSachNXB()
        {
            MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "HienThiNXB"; // thủ tục đã tạo trong SQL
            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            lsvDanhSach.Items.Clear();

            while (reader.Read())
            {
                string maXB = reader.GetString(0);
                string tenXB = reader.GetString(1);
                string diaChi = reader.GetString(2);

                ListViewItem lvi = new ListViewItem(maXB);
                lvi.SubItems.Add(tenXB);
                lvi.SubItems.Add(diaChi);
                lsvDanhSach.Items.Add(lvi);
            }

            reader.Close();
            DongKetNoi();
        }

        // Khi form load -> hiển thị danh sách
        private void Form1_Load(object sender, EventArgs e)
        {
            lsvDanhSach.Columns.Add("Mã NXB", 100);
            lsvDanhSach.Columns.Add("Tên NXB", 200);
            lsvDanhSach.Columns.Add("Địa chỉ", 250);

            HienThiDanhSachNXB();
        }

        // Khi chọn 1 dòng trong ListView -> hiển thị chi tiết
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;

            ListViewItem lvi = lsvDanhSach.SelectedItems[0];
            string maXB = lvi.SubItems[0].Text;

            HienThiThongTinNXBTheoMa(maXB);
        }

        // hiển thị chi tiết NXB theo mã
        private void HienThiThongTinNXBTheoMa(string maXB)
        {
            MoKetNoi();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "HienThiChiTietNXB";
            sqlCmd.Connection = sqlCon;

            SqlParameter parMaXB = new SqlParameter("@maNXB", SqlDbType.Char);
            parMaXB.Value = maXB;
            sqlCmd.Parameters.Add(parMaXB);

            SqlDataReader reader = sqlCmd.ExecuteReader();
            txtMaXB.Text = txtTenXB.Text = txtDiaChi.Text = "";

            if (reader.Read())
            {
                txtMaXB.Text = reader.GetString(0);
                txtTenXB.Text = reader.GetString(1);
                txtDiaChi.Text = reader.GetString(2);
            }

            reader.Close();
            DongKetNoi();
        }

        // làm mới danh sách
        private void btnReload_Click(object sender, EventArgs e)
        {
            HienThiDanhSachNXB();
        }
    }
}
