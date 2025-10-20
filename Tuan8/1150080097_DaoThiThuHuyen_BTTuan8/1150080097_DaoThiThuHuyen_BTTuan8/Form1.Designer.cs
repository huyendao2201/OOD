namespace _1150080097_DaoThiThuHuyen_BTTuan8
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
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.colMaXB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenXB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMaXB = new System.Windows.Forms.Label();
            this.lblTenXB = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtMaXB = new System.Windows.Forms.TextBox();
            this.txtTenXB = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(105, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(313, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH SÁCH NHÀ XUẤT BẢN";
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
            this.lsvDanhSach.Location = new System.Drawing.Point(38, 52);
            this.lsvDanhSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(451, 131);
            this.lsvDanhSach.TabIndex = 1;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);
            // 
            // colMaXB
            // 
            this.colMaXB.Text = "Mã NXB";
            this.colMaXB.Width = 100;
            // 
            // colTenXB
            // 
            this.colTenXB.Text = "Tên NXB";
            this.colTenXB.Width = 200;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.Width = 280;
            // 
            // lblMaXB
            // 
            this.lblMaXB.AutoSize = true;
            this.lblMaXB.Location = new System.Drawing.Point(38, 202);
            this.lblMaXB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaXB.Name = "lblMaXB";
            this.lblMaXB.Size = new System.Drawing.Size(50, 13);
            this.lblMaXB.TabIndex = 2;
            this.lblMaXB.Text = "Mã NXB:";
            // 
            // lblTenXB
            // 
            this.lblTenXB.AutoSize = true;
            this.lblTenXB.Location = new System.Drawing.Point(38, 227);
            this.lblTenXB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenXB.Name = "lblTenXB";
            this.lblTenXB.Size = new System.Drawing.Size(54, 13);
            this.lblTenXB.TabIndex = 3;
            this.lblTenXB.Text = "Tên NXB:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(38, 253);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(43, 13);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtMaXB
            // 
            this.txtMaXB.Location = new System.Drawing.Point(98, 200);
            this.txtMaXB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaXB.Name = "txtMaXB";
            this.txtMaXB.Size = new System.Drawing.Size(301, 20);
            this.txtMaXB.TabIndex = 5;
            // 
            // txtTenXB
            // 
            this.txtTenXB.Location = new System.Drawing.Point(98, 226);
            this.txtTenXB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenXB.Name = "txtTenXB";
            this.txtTenXB.Size = new System.Drawing.Size(301, 20);
            this.txtTenXB.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(98, 252);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(301, 20);
            this.txtDiaChi.TabIndex = 7;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Location = new System.Drawing.Point(412, 202);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 8;
            this.btnReload.Text = "Làm mới";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 299);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenXB);
            this.Controls.Add(this.txtMaXB);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblTenXB);
            this.Controls.Add(this.lblMaXB);
            this.Controls.Add(this.lsvDanhSach);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Quản lý Nhà Xuất Bản";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.ColumnHeader colMaXB;
        private System.Windows.Forms.ColumnHeader colTenXB;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.Label lblMaXB;
        private System.Windows.Forms.Label lblTenXB;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtMaXB;
        private System.Windows.Forms.TextBox txtTenXB;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnReload;
    }
}

