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
    public partial class FormCapNhatDuLieuNXB : Form
    {
        // Chuỗi kết nối
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBConnect.mdf;Integrated Security=True";


        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        int vt = -1; // vị trí dòng được chọn

        public FormCapNhatDuLieuNXB()
        {
            InitializeComponent();
        }

        // Mở kết nối
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

        // Đóng kết nối
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

        // Xóa dữ liệu form
        private void XoaDuLieuForm()
        {
            txtMaXB.Text = "";
            txtTenXB.Text = "";
            txtDiaChi.Text = "";
        }

        // Hiển thị dữ liệu
        private void HienThiDuLieu()
        {
            MoKetNoi();
            string query = "SELECT * FROM NhaXuatBan";
            adapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "tblNhaXuatBan");
            dgvDanhSach.DataSource = ds.Tables["tblNhaXuatBan"];
            DongKetNoi();
        }

        // Khi form load
        private void FormCapNhatDuLieuNXB_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            XoaDuLieuForm();
        }

        // Khi click vào 1 dòng trên DataGridView
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;

            DataRow row = ds.Tables["tblNhaXuatBan"].Rows[vt];
            txtMaXB.Text = row["MaXB"].ToString().Trim();
            txtTenXB.Text = row["TenXB"].ToString().Trim();
            txtDiaChi.Text = row["DiaChi"].ToString().Trim();
        }

        // Nút chỉnh sửa thông tin
        private void btnChinhSuaThongTin_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu để chỉnh sửa!");
                return;
            }

            DataRow row = ds.Tables["tblNhaXuatBan"].Rows[vt];
            row.BeginEdit();
            row["MaXB"] = txtMaXB.Text.Trim();
            row["TenXB"] = txtTenXB.Text.Trim();
            row["DiaChi"] = txtDiaChi.Text.Trim();
            row.EndEdit();

            int kq = adapter.Update(ds.Tables["tblNhaXuatBan"]);
            if (kq > 0)
            {
                MessageBox.Show("Chỉnh sửa dữ liệu thành công!");
                HienThiDuLieu();
                XoaDuLieuForm();
            }
            else
            {
                MessageBox.Show("Chỉnh sửa dữ liệu không thành công!");
            }
        }
    }
}
