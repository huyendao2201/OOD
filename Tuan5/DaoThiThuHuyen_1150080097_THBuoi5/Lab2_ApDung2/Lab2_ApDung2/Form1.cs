using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Lab2_ApDung2
{
    public partial class Form1 : Form
    {
        // Danh sách password hợp lệ
        private Dictionary<string, List<string>> passwords = new Dictionary<string, List<string>>()
        {
            { "Phat trien cong nghe", new List<string>{ "1496", "2673" } },
            { "Nghien cuu vien", new List<string>{ "7462" } },
            { "Thiet ke mo hinh", new List<string>{ "8884", "3842", "3383" } }
        };

        public Form1()
        {
            InitializeComponent();
        }
        // Xử lý khi nhấn nút số
        private void ButtonNumber_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtPassword.Text += btn.Text;
        }

        // Nút Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        // Nút Enter
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string pass = txtPassword.Text.Trim();
            string nhom = "Khong co";
            string ketQua = "Tu choi!";

            foreach (var kvp in passwords)
            {
                if (kvp.Value.Contains(pass))
                {
                    nhom = kvp.Key;
                    ketQua = "Chap nhan";
                    break;
                }
            }

            // Ghi log
            dgvLog.Rows.Add(DateTime.Now.ToString(), nhom, ketQua);

            // Reset password sau khi nhập
            txtPassword.Text = "";
        }

        // Nút RING (báo động)
        private void btnRing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bao dong! Co nguoi truy cap trai phep", "RING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
