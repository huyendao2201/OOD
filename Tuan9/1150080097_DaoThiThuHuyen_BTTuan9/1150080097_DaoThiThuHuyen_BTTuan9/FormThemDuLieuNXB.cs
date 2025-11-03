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
    public partial class FormThemDuLieuNXB : Form
    {
        // Chuỗi kết nối
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBConnect.mdf;Integrated Security=True";


        // Đối tượng kết nối & dữ liệu
        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;

        public FormThemDuLieuNXB()
        {
            InitializeComponent();
        }

        //  Mở kết nối
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

        //Đóng kết nối
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

        // Hiển thị dữ liệu lên DataGridView
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

        // Form Load 
        private void FormThemDuLieuNXB_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            XoaDuLieuForm();
        }

        // Nút Thêm Dữ Liệu
        private void btnThemDL_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo dòng dữ liệu mới
                DataRow row = ds.Tables["tblNhaXuatBan"].NewRow();
                row["MaXB"] = txtMaXB.Text.Trim();
                row["TenXB"] = txtTenXB.Text.Trim();
                row["DiaChi"] = txtDiaChi.Text.Trim();

                // Thêm vào dataset
                ds.Tables["tblNhaXuatBan"].Rows.Add(row);

                // Cập nhật vào DB
                int kq = adapter.Update(ds.Tables["tblNhaXuatBan"]);

                if (kq > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!");
                    HienThiDuLieu();
                    XoaDuLieuForm();
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
        }
    }
}
