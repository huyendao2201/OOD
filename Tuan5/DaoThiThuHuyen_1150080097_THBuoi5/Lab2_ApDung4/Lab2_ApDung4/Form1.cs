using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_ApDung4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Nút > : Chuyển các phần tử được chọn sang lstDaChon
        private void btnRight_Click(object sender, EventArgs e)
        {
            while (lstMatHang.SelectedItems.Count > 0)
            {
                object item = lstMatHang.SelectedItems[0];
                lstDaChon.Items.Add(item);
                lstMatHang.Items.Remove(item);
            }
        }

        // Nút >> : Chuyển toàn bộ sang lstDaChon
        private void btnRightAll_Click(object sender, EventArgs e)
        {
            foreach (object item in lstMatHang.Items)
            {
                lstDaChon.Items.Add(item);
            }
            lstMatHang.Items.Clear();
        }

        // Nút < : Chuyển các phần tử được chọn ngược lại lstMatHang
        private void btnLeft_Click(object sender, EventArgs e)
        {
            while (lstDaChon.SelectedItems.Count > 0)
            {
                object item = lstDaChon.SelectedItems[0];
                lstMatHang.Items.Add(item);
                lstDaChon.Items.Remove(item);
            }
        }

        // Nút << : Chuyển toàn bộ về lstMatHang
        private void btnLeftAll_Click(object sender, EventArgs e)
        {
            foreach (object item in lstDaChon.Items)
            {
                lstMatHang.Items.Add(item);
            }
            lstDaChon.Items.Clear();
        }
    }
}
