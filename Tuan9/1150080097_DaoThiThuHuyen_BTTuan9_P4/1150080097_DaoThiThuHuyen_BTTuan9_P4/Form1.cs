using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1150080097_DaoThiThuHuyen_BTTuan9_P4
{
    public partial class Form1 : Form
    {
        // Khai báo các biến toàn cục
        SqlConnection con;       // Kết nối CSDL
        SqlDataAdapter adapter;  // Dùng để truy vấn dữ liệu
        DataSet ds;              // Bộ nhớ tạm lưu dữ liệu

        // Chuỗi kết nối đến file .mdf
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBConnect.mdf;Integrated Security=True";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strCon);
                con.Open();
                HienThiDuLieu();

                MessageBox.Show("Kết nối cơ sở dữ liệu thành công!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL:\n" + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Hiển thị dữ liệu 
        private void HienThiDuLieu()
        {
            try
            {
                string sql = "SELECT * FROM tblMatHang";
                ds = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(ds);
                dgvKetQua.DataSource = ds.Tables[0];
                dgvKetQua.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị dữ liệu:\n" + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
