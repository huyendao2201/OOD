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
    public partial class FormXoaDuLieuNXB : Form
    {
        // Chuỗi kết nối
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBConnect.mdf;Integrated Security=True";


        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        int vt = -1; // vị trí hàng chọn trong DataGridView

        public FormXoaDuLieuNXB()
        {
            InitializeComponent();
        }

        //Mở kết nối
        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        //Đóng kết nối
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        //Hiển thị dữ liệu
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

        //Sự kiện Load Form
        private void FormXoaDuLieuNXB_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        //Khi click chọn một hàng
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
        }

        //Nút Xóa dữ liệu
        private void btnXoaDuLieu_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có thực sự muốn xóa hay không?",
                "Cảnh báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                XoaDuLieu();
                HienThiDuLieu();
            }
        }

        // Hàm thực hiện xóa dữ liệu 
        private void XoaDuLieu()
        {
            DataRow row = ds.Tables["tblNhaXuatBan"].Rows[vt];
            row.Delete();
            int kq = adapter.Update(ds.Tables["tblNhaXuatBan"]);
            if (kq > 0)
            {
                MessageBox.Show("Xóa dữ liệu thành công!");
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu không thành công!");
            }
        }
    }
}
