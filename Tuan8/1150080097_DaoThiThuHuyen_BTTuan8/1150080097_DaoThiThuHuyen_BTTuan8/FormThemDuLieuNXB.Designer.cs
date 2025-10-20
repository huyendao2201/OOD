namespace _1150080097_DaoThiThuHuyen_BTTuan8
{
    partial class FormThemDuLieuNXB
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
            this.groupDanhSach = new System.Windows.Forms.GroupBox();
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.colMaXB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenXB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupNhapLieu = new System.Windows.Forms.GroupBox();
            this.btnThemDL = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenXB = new System.Windows.Forms.TextBox();
            this.txtMaXB = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenXB = new System.Windows.Forms.Label();
            this.lblMaXB = new System.Windows.Forms.Label();
            this.groupDanhSach.SuspendLayout();
            this.groupNhapLieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(250, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(179, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thêm dữ liệu";
            // 
            // groupDanhSach
            // 
            this.groupDanhSach.Controls.Add(this.lsvDanhSach);
            this.groupDanhSach.Location = new System.Drawing.Point(25, 70);
            this.groupDanhSach.Name = "groupDanhSach";
            this.groupDanhSach.Size = new System.Drawing.Size(350, 300);
            this.groupDanhSach.TabIndex = 1;
            this.groupDanhSach.TabStop = false;
            this.groupDanhSach.Text = "Danh sách nhà xuất bản:";
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaXB,
            this.colTenXB,
            this.colDiaChi});
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Location = new System.Drawing.Point(10, 25);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(330, 260);
            this.lsvDanhSach.TabIndex = 0;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            // 
            // colMaXB
            // 
            this.colMaXB.Text = "Mã NXB";
            this.colMaXB.Width = 70;
            // 
            // colTenXB
            // 
            this.colTenXB.Text = "Tên NXB";
            this.colTenXB.Width = 120;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.Width = 130;
            // 
            // groupNhapLieu
            // 
            this.groupNhapLieu.Controls.Add(this.btnThemDL);
            this.groupNhapLieu.Controls.Add(this.txtDiaChi);
            this.groupNhapLieu.Controls.Add(this.txtTenXB);
            this.groupNhapLieu.Controls.Add(this.txtMaXB);
            this.groupNhapLieu.Controls.Add(this.lblDiaChi);
            this.groupNhapLieu.Controls.Add(this.lblTenXB);
            this.groupNhapLieu.Controls.Add(this.lblMaXB);
            this.groupNhapLieu.Location = new System.Drawing.Point(390, 70);
            this.groupNhapLieu.Name = "groupNhapLieu";
            this.groupNhapLieu.Size = new System.Drawing.Size(300, 300);
            this.groupNhapLieu.TabIndex = 2;
            this.groupNhapLieu.TabStop = false;
            this.groupNhapLieu.Text = "Thông tin nhập liệu:";
            // 
            // btnThemDL
            // 
            this.btnThemDL.BackColor = System.Drawing.Color.PaleGreen;
            this.btnThemDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDL.Location = new System.Drawing.Point(70, 230);
            this.btnThemDL.Name = "btnThemDL";
            this.btnThemDL.Size = new System.Drawing.Size(170, 40);
            this.btnThemDL.TabIndex = 6;
            this.btnThemDL.Text = "Thêm nhà xuất bản";
            this.btnThemDL.UseVisualStyleBackColor = false;
            this.btnThemDL.Click += new System.EventHandler(this.btnThemDL_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(90, 160);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(180, 27);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtTenXB
            // 
            this.txtTenXB.Location = new System.Drawing.Point(90, 110);
            this.txtTenXB.Name = "txtTenXB";
            this.txtTenXB.Size = new System.Drawing.Size(180, 27);
            this.txtTenXB.TabIndex = 4;
            // 
            // txtMaXB
            // 
            this.txtMaXB.Location = new System.Drawing.Point(90, 60);
            this.txtMaXB.Name = "txtMaXB";
            this.txtMaXB.Size = new System.Drawing.Size(180, 27);
            this.txtMaXB.TabIndex = 3;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(20, 165);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(61, 20);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblTenXB
            // 
            this.lblTenXB.AutoSize = true;
            this.lblTenXB.Location = new System.Drawing.Point(20, 115);
            this.lblTenXB.Name = "lblTenXB";
            this.lblTenXB.Size = new System.Drawing.Size(68, 20);
            this.lblTenXB.TabIndex = 1;
            this.lblTenXB.Text = "Tên NXB:";
            // 
            // lblMaXB
            // 
            this.lblMaXB.AutoSize = true;
            this.lblMaXB.Location = new System.Drawing.Point(20, 65);
            this.lblMaXB.Name = "lblMaXB";
            this.lblMaXB.Size = new System.Drawing.Size(63, 20);
            this.lblMaXB.TabIndex = 0;
            this.lblMaXB.Text = "Mã NXB:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(720, 400);
            this.Controls.Add(this.groupNhapLieu);
            this.Controls.Add(this.groupDanhSach);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Thêm dữ liệu Nhà Xuất Bản";
            this.Load += new System.EventHandler(this.FormThemDuLieuNXB_Load);
            this.groupDanhSach.ResumeLayout(false);
            this.groupNhapLieu.ResumeLayout(false);
            this.groupNhapLieu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupDanhSach;
        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.ColumnHeader colMaXB;
        private System.Windows.Forms.ColumnHeader colTenXB;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.GroupBox groupNhapLieu;
        private System.Windows.Forms.Button btnThemDL;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenXB;
        private System.Windows.Forms.TextBox txtMaXB;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenXB;
        private System.Windows.Forms.Label lblMaXB;
    }
}