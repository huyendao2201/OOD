using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_ThucHanh2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            // Kiểm tra tên khách hàng
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                errorProvider1.SetError(txtTenKH, "Tên khách hàng không được để trống");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            double tong = 0;

            if (chkCaoRang.Checked)
                tong += 50000; // lấy cao răng

            if (chkTayTrang.Checked)
                tong += 100000; // tẩy trắng

            if (chkHanRang.Checked)
                tong += 100000 * (int)numHanRang.Value;

            if (chkBeRang.Checked)
                tong += 10000 * (int)numBeRang.Value;

            if (chkBocRang.Checked)
                tong += 1000000 * (int)numBocRang.Value;

            txtTongTien.Text = tong.ToString("N0") + " VND";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
