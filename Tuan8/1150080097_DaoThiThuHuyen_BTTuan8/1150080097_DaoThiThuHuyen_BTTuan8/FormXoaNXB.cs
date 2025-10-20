using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1150080097_DaoThiThuHuyen_BTTuan8
{
    public partial class FormXoaNXB : Form
    {
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBConnect.mdf;Integrated Security=True";

        SqlConnection sqlCon = null;

        public FormXoaNXB()
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

        private void FormXoaNXB_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNXB();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản cần xóa!");
                return;
            }

            ListViewItem lvi = lsvDanhSach.SelectedItems[0];
            string maXB = lvi.SubItems[0].Text;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa Nhà Xuất Bản có mã: " + maXB + " không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand("XoaNXB", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maNXB", maXB);

                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!");
                    HienThiDanhSachNXB();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã NXB cần xóa!");
                }

                DongKetNoi();
            }
        }
    }
}
