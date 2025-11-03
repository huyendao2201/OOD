namespace _1150080097_DaoThiThuHuyen_BTTuan9_P4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.cboTenSP = new System.Windows.Forms.ComboBox();
            this.txtMaSP_Tim = new System.Windows.Forms.TextBox();
            this.lblTenSP_Tim = new System.Windows.Forms.Label();
            this.lblMaSP_Tim = new System.Windows.Forms.Label();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.dtpNgayHH = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaySX = new System.Windows.Forms.DateTimePicker();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.lblNgayHH = new System.Windows.Forms.Label();
            this.lblNgaySX = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.grpChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.LightCoral;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(780, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý mặt hàng";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.cboTenSP);
            this.grpTimKiem.Controls.Add(this.txtMaSP_Tim);
            this.grpTimKiem.Controls.Add(this.lblTenSP_Tim);
            this.grpTimKiem.Controls.Add(this.lblMaSP_Tim);
            this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpTimKiem.Location = new System.Drawing.Point(12, 50);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(440, 70);
            this.grpTimKiem.TabIndex = 1;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm";
            // 
            // cboTenSP
            // 
            this.cboTenSP.FormattingEnabled = true;
            this.cboTenSP.Location = new System.Drawing.Point(265, 30);
            this.cboTenSP.Name = "cboTenSP";
            this.cboTenSP.Size = new System.Drawing.Size(160, 23);
            this.cboTenSP.TabIndex = 3;
            // 
            // txtMaSP_Tim
            // 
            this.txtMaSP_Tim.Location = new System.Drawing.Point(70, 30);
            this.txtMaSP_Tim.Name = "txtMaSP_Tim";
            this.txtMaSP_Tim.Size = new System.Drawing.Size(110, 23);
            this.txtMaSP_Tim.TabIndex = 2;
            // 
            // lblTenSP_Tim
            // 
            this.lblTenSP_Tim.AutoSize = true;
            this.lblTenSP_Tim.Location = new System.Drawing.Point(200, 33);
            this.lblTenSP_Tim.Name = "lblTenSP_Tim";
            this.lblTenSP_Tim.Size = new System.Drawing.Size(46, 15);
            this.lblTenSP_Tim.TabIndex = 1;
            this.lblTenSP_Tim.Text = "Tên SP:";
            // 
            // lblMaSP_Tim
            // 
            this.lblMaSP_Tim.AutoSize = true;
            this.lblMaSP_Tim.Location = new System.Drawing.Point(15, 33);
            this.lblMaSP_Tim.Name = "lblMaSP_Tim";
            this.lblMaSP_Tim.Size = new System.Drawing.Size(43, 15);
            this.lblMaSP_Tim.TabIndex = 0;
            this.lblMaSP_Tim.Text = "Mã SP:";
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(12, 135);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.RowHeadersVisible = false;
            this.dgvKetQua.RowTemplate.Height = 25;
            this.dgvKetQua.Size = new System.Drawing.Size(440, 250);
            this.dgvKetQua.TabIndex = 2;
            // 
            // grpChiTiet
            // 
            this.grpChiTiet.Controls.Add(this.dtpNgayHH);
            this.grpChiTiet.Controls.Add(this.dtpNgaySX);
            this.grpChiTiet.Controls.Add(this.txtGhiChu);
            this.grpChiTiet.Controls.Add(this.txtDonGia);
            this.grpChiTiet.Controls.Add(this.txtDonVi);
            this.grpChiTiet.Controls.Add(this.txtTenSP);
            this.grpChiTiet.Controls.Add(this.txtMaSP);
            this.grpChiTiet.Controls.Add(this.lblGhiChu);
            this.grpChiTiet.Controls.Add(this.lblDonGia);
            this.grpChiTiet.Controls.Add(this.lblDonVi);
            this.grpChiTiet.Controls.Add(this.lblNgayHH);
            this.grpChiTiet.Controls.Add(this.lblNgaySX);
            this.grpChiTiet.Controls.Add(this.lblTenSP);
            this.grpChiTiet.Controls.Add(this.lblMaSP);
            this.grpChiTiet.Controls.Add(this.btnLuu);
            this.grpChiTiet.Controls.Add(this.btnHuy);
            this.grpChiTiet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpChiTiet.Location = new System.Drawing.Point(470, 50);
            this.grpChiTiet.Name = "grpChiTiet";
            this.grpChiTiet.Size = new System.Drawing.Size(290, 335);
            this.grpChiTiet.TabIndex = 3;
            this.grpChiTiet.TabStop = false;
            this.grpChiTiet.Text = "Chi tiết";
            // 
            // Các Label & TextBox trong groupChiTiet
            this.lblMaSP.Text = "Mã SP:"; this.lblTenSP.Text = "Tên SP:";
            this.lblNgaySX.Text = "Ngày SX:"; this.lblNgayHH.Text = "Ngày HH:";
            this.lblDonVi.Text = "Đơn vị:"; this.lblDonGia.Text = "Đơn giá:";
            this.lblGhiChu.Text = "Ghi chú:";
            // Đặt vị trí và size tương tự theo hình (các bạn có thể kéo chỉnh trong Designer)
            // 
            // Các Button dưới cùng
            // 
            this.btnTimKiem.Text = "Tìm kiếm"; this.btnThem.Text = "Thêm";
            this.btnSua.Text = "Sửa"; this.btnXoa.Text = "Xóa";
            this.btnThoat.Text = "Thoát";
            this.btnTimKiem.Location = new System.Drawing.Point(15, 400);
            this.btnThem.Location = new System.Drawing.Point(120, 400);
            this.btnSua.Location = new System.Drawing.Point(225, 400);
            this.btnXoa.Location = new System.Drawing.Point(330, 400);
            this.btnThoat.Location = new System.Drawing.Point(435, 400);
            this.btnTimKiem.Size = new System.Drawing.Size(90, 35);
            this.btnThem.Size = new System.Drawing.Size(90, 35); 
            this.btnSua.Size = new System.Drawing.Size(90, 35); 
            this.btnXoa.Size = new System.Drawing.Size(90, 35); 
            this.btnThoat.Size = new System.Drawing.Size(90, 35);
            // 
            // FormMatHang
            // 
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.grpChiTiet);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý mặt hàng";
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.grpChiTiet.ResumeLayout(false);
            this.grpChiTiet.PerformLayout();
            this.ResumeLayout(false);
            this.Load += new System.EventHandler(this.Form1_Load);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.ComboBox cboTenSP;
        private System.Windows.Forms.TextBox txtMaSP_Tim;
        private System.Windows.Forms.Label lblTenSP_Tim;
        private System.Windows.Forms.Label lblMaSP_Tim;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.Label lblNgayHH;
        private System.Windows.Forms.Label lblNgaySX;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.DateTimePicker dtpNgayHH;
        private System.Windows.Forms.DateTimePicker dtpNgaySX;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}

