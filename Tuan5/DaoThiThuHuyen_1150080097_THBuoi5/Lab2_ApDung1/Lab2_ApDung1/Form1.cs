using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_ApDung1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Hàm tính USCLN (Ước số chung lớn nhất)
        private int USCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return Math.Abs(a);
        }

        // Hàm tính BSCNN (Bội số chung nhỏ nhất)
        private int BSCNN(int a, int b)
        {
            return Math.Abs(a * b) / USCLN(a, b);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtA.Text.Trim());
                int b = Convert.ToInt32(txtB.Text.Trim());

                if (radUSCLN.Checked)
                {
                    txtKetQua.Text = USCLN(a, b).ToString();
                }
                else if (radBSCNN.Checked)
                {
                    txtKetQua.Text = BSCNN(a, b).ToString();
                }
                else
                {
                    MessageBox.Show("Vui long chon USCLN hoac BSCNN");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon thoat chuong trinh khong?",
                                                  "Xac nhan",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
