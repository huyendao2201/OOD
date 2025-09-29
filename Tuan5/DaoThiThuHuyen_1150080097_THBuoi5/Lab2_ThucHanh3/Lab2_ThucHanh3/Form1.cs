using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_ThucHanh3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Nhập số vào ListBox
        private void btnNhap_Click(object sender, EventArgs e)
        {
            ThemSo();
        }

        private void txtNhapSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ThemSo();
                e.SuppressKeyPress = true; // bỏ tiếng beep
            }
        }

        private void ThemSo()
        {
            if (int.TryParse(txtNhapSo.Text.Trim(), out int so))
            {
                lsbDaySo.Items.Add(so);
                txtNhapSo.Clear();
                txtNhapSo.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                txtNhapSo.SelectAll();
                txtNhapSo.Focus();
            }
        }

        // Tăng mỗi phần tử lên 2
        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                int so = Convert.ToInt32(lsbDaySo.Items[i]);
                lsbDaySo.Items[i] = so + 2;
            }
        }

        // Chọn số chẵn đầu
        private void btnChonSoChan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                int so = Convert.ToInt32(lsbDaySo.Items[i]);
                if (so % 2 == 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Không có số chẵn trong dãy!");
        }

        // Chọn số lẻ cuối
        private void btnChonSoLe_Click(object sender, EventArgs e)
        {
            for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
            {
                int so = Convert.ToInt32(lsbDaySo.Items[i]);
                if (so % 2 != 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Không có số lẻ trong dãy!");
        }

        // Xóa phần tử đang chọn
        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.SelectedIndex != -1)
            {
                lsbDaySo.Items.RemoveAt(lsbDaySo.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phần tử để xóa!");
            }
        }

        // Xóa phần tử đầu
        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
                lsbDaySo.Items.RemoveAt(0);
        }

        // Xóa phần tử cuối
        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
                lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
        }

        // Xóa dãy số
        private void btnXoaDay_Click(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
        }

        // Kết thúc ứng dụng
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
