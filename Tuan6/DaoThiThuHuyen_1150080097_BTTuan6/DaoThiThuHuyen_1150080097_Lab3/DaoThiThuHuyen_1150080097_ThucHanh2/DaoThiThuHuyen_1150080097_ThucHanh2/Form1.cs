using System;
using System.Windows.Forms;

namespace DaoThiThuHuyen_1150080097_ThucHanh2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gán sự kiện
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnThoat.Click += btnThoat_Click;
            lvSinhVien.SelectedIndexChanged += lvSinhVien_SelectedIndexChanged;
        }

        // Xóa trắng input
        private void ClearInput()
        {
            txtHoTen.Clear();
            txtLop.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtHoTen.Focus();
        }

        // Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = new ListViewItem(txtHoTen.Text);
            item.SubItems.Add(dtpNgaySinh.Value.ToShortDateString());
            item.SubItems.Add(txtLop.Text);
            item.SubItems.Add(txtDiaChi.Text);

            lvSinhVien.Items.Add(item);

            ClearInput();
        }

        // Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa!");
                return;
            }

            var item = lvSinhVien.SelectedItems[0];
            item.SubItems[0].Text = txtHoTen.Text;
            item.SubItems[1].Text = dtpNgaySinh.Value.ToShortDateString();
            item.SubItems[2].Text = txtLop.Text;
            item.SubItems[3].Text = txtDiaChi.Text;

            MessageBox.Show("Cập nhật thành công!");
            ClearInput();
        }

        // Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa dòng này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lvSinhVien.Items.Remove(lvSinhVien.SelectedItems[0]);
                ClearInput();
            }
        }

        // Khi chọn dòng ListView
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                var item = lvSinhVien.SelectedItems[0];
                txtHoTen.Text = item.SubItems[0].Text;
                dtpNgaySinh.Value = DateTime.Parse(item.SubItems[1].Text);
                txtLop.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;
            }
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
