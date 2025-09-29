namespace Lab2_ThucHanh2
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxDichVu = new System.Windows.Forms.GroupBox();
            this.numBocRang = new System.Windows.Forms.NumericUpDown();
            this.numBeRang = new System.Windows.Forms.NumericUpDown();
            this.numHanRang = new System.Windows.Forms.NumericUpDown();
            this.chkBocRang = new System.Windows.Forms.CheckBox();
            this.chkBeRang = new System.Windows.Forms.CheckBox();
            this.chkHanRang = new System.Windows.Forms.CheckBox();
            this.chkTayTrang = new System.Windows.Forms.CheckBox();
            this.chkCaoRang = new System.Windows.Forms.CheckBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBoxDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBocRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHanRang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Green;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHÒNG KHÁM NHA KHOA HẢI ÂU";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(20, 60);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(84, 13);
            this.lblTenKH.TabIndex = 1;
            this.lblTenKH.Text = "Tên khách hàng:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(120, 57);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(250, 20);
            this.txtTenKH.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBoxDichVu
            // 
            this.groupBoxDichVu.Controls.Add(this.numBocRang);
            this.groupBoxDichVu.Controls.Add(this.numBeRang);
            this.groupBoxDichVu.Controls.Add(this.numHanRang);
            this.groupBoxDichVu.Controls.Add(this.chkBocRang);
            this.groupBoxDichVu.Controls.Add(this.chkBeRang);
            this.groupBoxDichVu.Controls.Add(this.chkHanRang);
            this.groupBoxDichVu.Controls.Add(this.chkTayTrang);
            this.groupBoxDichVu.Controls.Add(this.chkCaoRang);
            this.groupBoxDichVu.Location = new System.Drawing.Point(20, 90);
            this.groupBoxDichVu.Name = "groupBoxDichVu";
            this.groupBoxDichVu.Size = new System.Drawing.Size(460, 160);
            this.groupBoxDichVu.TabIndex = 3;
            this.groupBoxDichVu.TabStop = false;
            this.groupBoxDichVu.Text = "Dịch vụ tại phòng khám";
            // 
            // numBocRang
            // 
            this.numBocRang.Location = new System.Drawing.Point(380, 120);
            this.numBocRang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numBocRang.Name = "numBocRang";
            this.numBocRang.Size = new System.Drawing.Size(50, 20);
            this.numBocRang.TabIndex = 7;
            this.numBocRang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numBeRang
            // 
            this.numBeRang.Location = new System.Drawing.Point(380, 90);
            this.numBeRang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numBeRang.Name = "numBeRang";
            this.numBeRang.Size = new System.Drawing.Size(50, 20);
            this.numBeRang.TabIndex = 6;
            this.numBeRang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numHanRang
            // 
            this.numHanRang.Location = new System.Drawing.Point(380, 60);
            this.numHanRang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numHanRang.Name = "numHanRang";
            this.numHanRang.Size = new System.Drawing.Size(50, 20);
            this.numHanRang.TabIndex = 5;
            this.numHanRang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chkBocRang
            // 
            this.chkBocRang.AutoSize = true;
            this.chkBocRang.Location = new System.Drawing.Point(20, 120);
            this.chkBocRang.Name = "chkBocRang";
            this.chkBocRang.Size = new System.Drawing.Size(139, 17);
            this.chkBocRang.TabIndex = 4;
            this.chkBocRang.Text = "Bọc răng (1.000.000đ)";
            this.chkBocRang.UseVisualStyleBackColor = true;
            // 
            // chkBeRang
            // 
            this.chkBeRang.AutoSize = true;
            this.chkBeRang.Location = new System.Drawing.Point(20, 90);
            this.chkBeRang.Name = "chkBeRang";
            this.chkBeRang.Size = new System.Drawing.Size(117, 17);
            this.chkBeRang.TabIndex = 3;
            this.chkBeRang.Text = "Bẻ răng (10.000đ)";
            this.chkBeRang.UseVisualStyleBackColor = true;
            // 
            // chkHanRang
            // 
            this.chkHanRang.AutoSize = true;
            this.chkHanRang.Location = new System.Drawing.Point(20, 60);
            this.chkHanRang.Name = "chkHanRang";
            this.chkHanRang.Size = new System.Drawing.Size(134, 17);
            this.chkHanRang.TabIndex = 2;
            this.chkHanRang.Text = "Hàn răng (100.000đ)";
            this.chkHanRang.UseVisualStyleBackColor = true;
            // 
            // chkTayTrang
            // 
            this.chkTayTrang.AutoSize = true;
            this.chkTayTrang.Location = new System.Drawing.Point(20, 40);
            this.chkTayTrang.Name = "chkTayTrang";
            this.chkTayTrang.Size = new System.Drawing.Size(158, 17);
            this.chkTayTrang.TabIndex = 1;
            this.chkTayTrang.Text = "Tẩy trắng răng (100.000đ)";
            this.chkTayTrang.UseVisualStyleBackColor = true;
            // 
            // chkCaoRang
            // 
            this.chkCaoRang.AutoSize = true;
            this.chkCaoRang.Location = new System.Drawing.Point(20, 20);
            this.chkCaoRang.Name = "chkCaoRang";
            this.chkCaoRang.Size = new System.Drawing.Size(152, 17);
            this.chkCaoRang.TabIndex = 0;
            this.chkCaoRang.Text = "Lấy cao răng (50.000đ)";
            this.chkCaoRang.UseVisualStyleBackColor = true;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(20, 270);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(55, 13);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(100, 267);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(200, 20);
            this.txtTongTien.TabIndex = 5;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(320, 265);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTien.TabIndex = 6;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(405, 265);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(500, 320);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.groupBoxDichVu);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Phòng khám nha khoa";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBoxDichVu.ResumeLayout(false);
            this.groupBoxDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBocRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHanRang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBoxDichVu;
        private System.Windows.Forms.CheckBox chkCaoRang;
        private System.Windows.Forms.CheckBox chkTayTrang;
        private System.Windows.Forms.CheckBox chkHanRang;
        private System.Windows.Forms.CheckBox chkBeRang;
        private System.Windows.Forms.CheckBox chkBocRang;
        private System.Windows.Forms.NumericUpDown numHanRang;
        private System.Windows.Forms.NumericUpDown numBeRang;
        private System.Windows.Forms.NumericUpDown numBocRang;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnThoat;
    }
}

