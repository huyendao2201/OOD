namespace _1150080097_DaoThiThuHuyen_BTTuan8
{
    partial class FormCapNhatThongTin
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
            this.btnCapNhat = new System.Windows.Forms.Button();
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
            this.lblTitle.Location = new System.Drawing.Point(180, 13);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cập nhật dữ liệu";
            // 
            // groupDanhSach
            // 
            this.groupDanhSach.Controls.Add(this.lsvDanhSach);
            this.groupDanhSach.Location = new System.Drawing.Point(19, 46);
            this.groupDanhSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupDanhSach.Name = "groupDanhSach";
            this.groupDanhSach.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupDanhSach.Size = new System.Drawing.Size(418, 195);
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
            this.lsvDanhSach.Location = new System.Drawing.Point(8, 16);
            this.lsvDanhSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(406, 170);
            this.lsvDanhSach.TabIndex = 0;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);
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
            this.groupNhapLieu.Controls.Add(this.btnCapNhat);
            this.groupNhapLieu.Controls.Add(this.txtDiaChi);
            this.groupNhapLieu.Controls.Add(this.txtTenXB);
            this.groupNhapLieu.Controls.Add(this.txtMaXB);
            this.groupNhapLieu.Controls.Add(this.lblDiaChi);
            this.groupNhapLieu.Controls.Add(this.lblTenXB);
            this.groupNhapLieu.Controls.Add(this.lblMaXB);
            this.groupNhapLieu.Location = new System.Drawing.Point(441, 46);
            this.groupNhapLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupNhapLieu.Name = "groupNhapLieu";
            this.groupNhapLieu.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupNhapLieu.Size = new System.Drawing.Size(225, 195);
            this.groupNhapLieu.TabIndex = 2;
            this.groupNhapLieu.TabStop = false;
            this.groupNhapLieu.Text = "Thông tin nhập liệu:";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.LightGreen;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.Location = new System.Drawing.Point(45, 150);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(135, 26);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật thông tin";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(68, 104);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(136, 20);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtTenXB
            // 
            this.txtTenXB.Location = new System.Drawing.Point(68, 72);
            this.txtTenXB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenXB.Name = "txtTenXB";
            this.txtTenXB.Size = new System.Drawing.Size(136, 20);
            this.txtTenXB.TabIndex = 4;
            // 
            // txtMaXB
            // 
            this.txtMaXB.Location = new System.Drawing.Point(68, 39);
            this.txtMaXB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaXB.Name = "txtMaXB";
            this.txtMaXB.Size = new System.Drawing.Size(136, 20);
            this.txtMaXB.TabIndex = 3;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(15, 107);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(43, 13);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblTenXB
            // 
            this.lblTenXB.AutoSize = true;
            this.lblTenXB.Location = new System.Drawing.Point(15, 75);
            this.lblTenXB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenXB.Name = "lblTenXB";
            this.lblTenXB.Size = new System.Drawing.Size(54, 13);
            this.lblTenXB.TabIndex = 1;
            this.lblTenXB.Text = "Tên NXB:";
            // 
            // lblMaXB
            // 
            this.lblMaXB.AutoSize = true;
            this.lblMaXB.Location = new System.Drawing.Point(15, 42);
            this.lblMaXB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaXB.Name = "lblMaXB";
            this.lblMaXB.Size = new System.Drawing.Size(50, 13);
            this.lblMaXB.TabIndex = 0;
            this.lblMaXB.Text = "Mã NXB:";
            // 
            // FormCapNhatThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 273);
            this.Controls.Add(this.groupNhapLieu);
            this.Controls.Add(this.groupDanhSach);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCapNhatThongTin";
            this.Text = "Cập nhật dữ liệu Nhà Xuất Bản";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenXB;
        private System.Windows.Forms.TextBox txtMaXB;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenXB;
        private System.Windows.Forms.Label lblMaXB;
    }
}