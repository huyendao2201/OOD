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
    public partial class FormThemDuLieuNXB : Form
    {
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBConnect.mdf;Integrated Security=True";
        SqlConnection sqlCon = null;

        public FormThemDuLieuNXB()
        {
            InitializeComponent();
        }

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

        private void HienThiDanhSachNXB()
        {
            MoKetNoi();
            SqlCommand cmd = new SqlCommand("HienThiNXB", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();

            lsvDanhSach.Items.Clear();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetString(0));
                lvi.SubItems.Add(reader.GetString(1));
                lvi.SubItems.Add(reader.GetString(2));
                lsvDanhSach.Items.Add(lvi);
            }
            reader.Close();
            DongKetNoi();
        }

        private void FormThemDuLieuNXB_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNXB();
            txtMaXB.Focus();
        }

        private void btnThemDL_Click(object sender, EventArgs e)
        {
            if (txtMaXB.Text.Trim() == "" || txtTenXB.Text.Trim() == "" || txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            MoKetNoi();
            SqlCommand cmd = new SqlCommand("ThemDuLieu", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@maNXB", txtMaXB.Text.Trim());
            cmd.Parameters.AddWithValue("@tenNXB", txtTenXB.Text.Trim());
            cmd.Parameters.AddWithValue("@diaChi", txtDiaChi.Text.Trim());

            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");
                HienThiDanhSachNXB();
                txtMaXB.Text = txtTenXB.Text = txtDiaChi.Text = "";
            }

            DongKetNoi();
        }
    }
}
