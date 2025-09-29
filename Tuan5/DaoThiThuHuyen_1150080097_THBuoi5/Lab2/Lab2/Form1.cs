using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());
                double tong = a + b;
                txtKetQua.Text = tong.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao loi!", MessageBoxButtons.OKCancel);
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());
                double hieu = a - b;
                txtKetQua.Text = hieu.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao loi!", MessageBoxButtons.OKCancel);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());
                double tich = a * b;
                txtKetQua.Text = tich.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao loi!", MessageBoxButtons.OKCancel);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());
                if (b == 0)
                {
                    MessageBox.Show("Mau so khong duoc phep bang 0. Nhap lai!");
                    txtB.Text = "";
                    txtB.Focus();
                    return;
                }
                double thuong = a / b;
                txtKetQua.Text = thuong.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao loi!", MessageBoxButtons.OKCancel);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtKetQua.Text = "";
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co thuc su muon thoat khong?",
                                                  "Xac nhan thoat",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
