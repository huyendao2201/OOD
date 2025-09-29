namespace Lab2_ThucHanh3
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
            this.lblNhap = new System.Windows.Forms.Label();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lsbDaySo = new System.Windows.Forms.ListBox();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnChonSoChan = new System.Windows.Forms.Button();
            this.btnChonSoLe = new System.Windows.Forms.Button();
            this.btnXoaDangChon = new System.Windows.Forms.Button();
            this.btnXoaDau = new System.Windows.Forms.Button();
            this.btnXoaCuoi = new System.Windows.Forms.Button();
            this.btnXoaDay = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Teal;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ứng dụng xử lý dãy số";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Location = new System.Drawing.Point(20, 60);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(74, 13);
            this.lblNhap.TabIndex = 1;
            this.lblNhap.Text = "Nhập số nguyên:";
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(110, 57);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(120, 20);
            this.txtNhapSo.TabIndex = 2;
            this.txtNhapSo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhapSo_KeyDown);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(240, 55);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "Nhập số";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lsbDaySo
            // 
            this.lsbDaySo.FormattingEnabled = true;
            this.lsbDaySo.Location = new System.Drawing.Point(20, 100);
            this.lsbDaySo.Name = "lsbDaySo";
            this.lsbDaySo.Size = new System.Drawing.Size(220, 225);
            this.lsbDaySo.TabIndex = 4;
            // 
            // btnTang2
            // 
            this.btnTang2.Location = new System.Drawing.Point(280, 100);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(180, 23);
            this.btnTang2.TabIndex = 5;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnChonSoChan
            // 
            this.btnChonSoChan.Location = new System.Drawing.Point(280, 140);
            this.btnChonSoChan.Name = "btnChonSoChan";
            this.btnChonSoChan.Size = new System.Drawing.Size(180, 23);
            this.btnChonSoChan.TabIndex = 6;
            this.btnChonSoChan.Text = "Chọn số chẵn đầu";
            this.btnChonSoChan.UseVisualStyleBackColor = true;
            this.btnChonSoChan.Click += new System.EventHandler(this.btnChonSoChan_Click);
            // 
            // btnChonSoLe
            // 
            this.btnChonSoLe.Location = new System.Drawing.Point(280, 180);
            this.btnChonSoLe.Name = "btnChonSoLe";
            this.btnChonSoLe.Size = new System.Drawing.Size(180, 23);
            this.btnChonSoLe.TabIndex = 7;
            this.btnChonSoLe.Text = "Chọn số lẻ cuối";
            this.btnChonSoLe.UseVisualStyleBackColor = true;
            this.btnChonSoLe.Click += new System.EventHandler(this.btnChonSoLe_Click);
            // 
            // btnXoaDangChon
            // 
            this.btnXoaDangChon.Location = new System.Drawing.Point(280, 220);
            this.btnXoaDangChon.Name = "btnXoaDangChon";
            this.btnXoaDangChon.Size = new System.Drawing.Size(180, 23);
            this.btnXoaDangChon.TabIndex = 8;
            this.btnXoaDangChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaDangChon.UseVisualStyleBackColor = true;
            this.btnXoaDangChon.Click += new System.EventHandler(this.btnXoaDangChon_Click);
            // 
            // btnXoaDau
            // 
            this.btnXoaDau.Location = new System.Drawing.Point(280, 260);
            this.btnXoaDau.Name = "btnXoaDau";
            this.btnXoaDau.Size = new System.Drawing.Size(180, 23);
            this.btnXoaDau.TabIndex = 9;
            this.btnXoaDau.Text = "Xóa phần tử đầu";
            this.btnXoaDau.UseVisualStyleBackColor = true;
            this.btnXoaDau.Click += new System.EventHandler(this.btnXoaDau_Click);
            // 
            // btnXoaCuoi
            // 
            this.btnXoaCuoi.Location = new System.Drawing.Point(280, 300);
            this.btnXoaCuoi.Name = "btnXoaCuoi";
            this.btnXoaCuoi.Size = new System.Drawing.Size(180, 23);
            this.btnXoaCuoi.TabIndex = 10;
            this.btnXoaCuoi.Text = "Xóa phần tử cuối";
            this.btnXoaCuoi.UseVisualStyleBackColor = true;
            this.btnXoaCuoi.Click += new System.EventHandler(this.btnXoaCuoi_Click);
            // 
            // btnXoaDay
            // 
            this.btnXoaDay.BackColor = System.Drawing.Color.LightGray;
            this.btnXoaDay.Location = new System.Drawing.Point(280, 340);
            this.btnXoaDay.Name = "btnXoaDay";
            this.btnXoaDay.Size = new System.Drawing.Size(100, 30);
            this.btnXoaDay.TabIndex = 11;
            this.btnXoaDay.Text = "Xóa dãy số";
            this.btnXoaDay.UseVisualStyleBackColor = false;
            this.btnXoaDay.Click += new System.EventHandler(this.btnXoaDay_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.Color.Red;
            this.btnKetThuc.ForeColor = System.Drawing.Color.White;
            this.btnKetThuc.Location = new System.Drawing.Point(400, 340);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(120, 30);
            this.btnKetThuc.TabIndex = 12;
            this.btnKetThuc.Text = "Kết thúc ứng dụng";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnXoaDay);
            this.Controls.Add(this.btnXoaCuoi);
            this.Controls.Add(this.btnXoaDau);
            this.Controls.Add(this.btnXoaDangChon);
            this.Controls.Add(this.btnChonSoLe);
            this.Controls.Add(this.btnChonSoChan);
            this.Controls.Add(this.btnTang2);
            this.Controls.Add(this.lsbDaySo);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.lblNhap);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Ứng dụng xử lý dãy số";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ListBox lsbDaySo;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnChonSoChan;
        private System.Windows.Forms.Button btnChonSoLe;
        private System.Windows.Forms.Button btnXoaDangChon;
        private System.Windows.Forms.Button btnXoaDau;
        private System.Windows.Forms.Button btnXoaCuoi;
        private System.Windows.Forms.Button btnXoaDay;
        private System.Windows.Forms.Button btnKetThuc;
    }
}

