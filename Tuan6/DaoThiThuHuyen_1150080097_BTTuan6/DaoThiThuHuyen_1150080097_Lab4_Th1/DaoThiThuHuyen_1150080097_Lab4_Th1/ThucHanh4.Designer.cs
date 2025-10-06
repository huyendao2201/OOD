namespace DaoThiThuHuyen_1150080097_Lab4_Th1
{
    partial class ThucHanh4
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
            this.lblDSLop = new System.Windows.Forms.Label();
            this.lblDSSV = new System.Windows.Forms.Label();
            this.lsbDSLop = new System.Windows.Forms.ListBox();
            this.lsvDSSV = new System.Windows.Forms.ListView();
            this.colMaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQueQuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(10, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(480, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Áp dụng";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDSLop
            // 
            this.lblDSLop.AutoSize = true;
            this.lblDSLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDSLop.Location = new System.Drawing.Point(17, 39);
            this.lblDSLop.Name = "lblDSLop";
            this.lblDSLop.Size = new System.Drawing.Size(87, 15);
            this.lblDSLop.TabIndex = 1;
            this.lblDSLop.Text = "Danh sách lớp:";
            // 
            // lblDSSV
            // 
            this.lblDSSV.AutoSize = true;
            this.lblDSSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDSSV.Location = new System.Drawing.Point(197, 39);
            this.lblDSSV.Name = "lblDSSV";
            this.lblDSSV.Size = new System.Drawing.Size(118, 15);
            this.lblDSSV.TabIndex = 2;
            this.lblDSSV.Text = "Danh sách sinh viên:";
            // 
            // lsbDSLop
            // 
            this.lsbDSLop.FormattingEnabled = true;
            this.lsbDSLop.Location = new System.Drawing.Point(17, 56);
            this.lsbDSLop.Name = "lsbDSLop";
            this.lsbDSLop.Size = new System.Drawing.Size(155, 238);
            this.lsbDSLop.TabIndex = 3;
            this.lsbDSLop.SelectedIndexChanged += new System.EventHandler(this.lsbDSLop_SelectedIndexChanged);
            // 
            // lsvDSSV
            // 
            this.lsvDSSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSV,
            this.colTenSV,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colQueQuan,
            this.colMaLop});
            this.lsvDSSV.FullRowSelect = true;
            this.lsvDSSV.GridLines = true;
            this.lsvDSSV.HideSelection = false;
            this.lsvDSSV.Location = new System.Drawing.Point(197, 56);
            this.lsvDSSV.Name = "lsvDSSV";
            this.lsvDSSV.Size = new System.Drawing.Size(446, 238);
            this.lsvDSSV.TabIndex = 4;
            this.lsvDSSV.UseCompatibleStateImageBehavior = false;
            this.lsvDSSV.View = System.Windows.Forms.View.Details;
            // 
            // colMaSV
            // 
            this.colMaSV.Text = "Mã SV";
            this.colMaSV.Width = 80;
            // 
            // colTenSV
            // 
            this.colTenSV.Text = "Tên SV";
            this.colTenSV.Width = 120;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới tính";
            this.colGioiTinh.Width = 70;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 90;
            // 
            // colQueQuan
            // 
            this.colQueQuan.Text = "Quê quán";
            this.colQueQuan.Width = 100;
            // 
            // colMaLop
            // 
            this.colMaLop.Text = "Mã lớp";
            // 
            // ThucHanh4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 313);
            this.Controls.Add(this.lsvDSSV);
            this.Controls.Add(this.lsbDSLop);
            this.Controls.Add(this.lblDSSV);
            this.Controls.Add(this.lblDSLop);
            this.Controls.Add(this.lblTitle);
            this.Name = "ThucHanh4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hiển thị danh sách sinh viên theo mã lớp";
            this.Load += new System.EventHandler(this.FrmApDung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDSLop;
        private System.Windows.Forms.Label lblDSSV;
        private System.Windows.Forms.ListBox lsbDSLop;
        private System.Windows.Forms.ListView lsvDSSV;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colTenSV;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colQueQuan;
        private System.Windows.Forms.ColumnHeader colMaLop;
    }
}