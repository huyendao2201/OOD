namespace _1150080097_DaoThiThuHuyen_BTTuan9
{
    partial class FormCapNhatDuLieuNXB
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.groupChinhSua = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenXB = new System.Windows.Forms.TextBox();
            this.txtMaXB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChinhSuaThongTin = new System.Windows.Forms.Button();
            this.groupDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.groupChinhSua.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(154, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(257, 26);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Chỉnh sửa thông tin dữ liệu";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupDanhSach
            // 
            this.groupDanhSach.Controls.Add(this.dgvDanhSach);
            this.groupDanhSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupDanhSach.Location = new System.Drawing.Point(10, 39);
            this.groupDanhSach.Name = "groupDanhSach";
            this.groupDanhSach.Size = new System.Drawing.Size(257, 277);
            this.groupDanhSach.TabIndex = 1;
            this.groupDanhSach.TabStop = false;
            this.groupDanhSach.Text = "Danh sách nhà xuất bản:";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(3, 19);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.RowTemplate.Height = 25;
            this.dgvDanhSach.Size = new System.Drawing.Size(251, 255);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // groupChinhSua
            // 
            this.groupChinhSua.Controls.Add(this.txtDiaChi);
            this.groupChinhSua.Controls.Add(this.txtTenXB);
            this.groupChinhSua.Controls.Add(this.txtMaXB);
            this.groupChinhSua.Controls.Add(this.label3);
            this.groupChinhSua.Controls.Add(this.label2);
            this.groupChinhSua.Controls.Add(this.label1);
            this.groupChinhSua.Controls.Add(this.btnChinhSuaThongTin);
            this.groupChinhSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupChinhSua.Location = new System.Drawing.Point(283, 39);
            this.groupChinhSua.Name = "groupChinhSua";
            this.groupChinhSua.Size = new System.Drawing.Size(223, 277);
            this.groupChinhSua.TabIndex = 2;
            this.groupChinhSua.TabStop = false;
            this.groupChinhSua.Text = "Chỉnh sửa thông tin:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(69, 121);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(138, 23);
            this.txtDiaChi.TabIndex = 6;
            // 
            // txtTenXB
            // 
            this.txtTenXB.Location = new System.Drawing.Point(69, 87);
            this.txtTenXB.Name = "txtTenXB";
            this.txtTenXB.Size = new System.Drawing.Size(138, 23);
            this.txtTenXB.TabIndex = 5;
            // 
            // txtMaXB
            // 
            this.txtMaXB.Location = new System.Drawing.Point(69, 52);
            this.txtMaXB.Name = "txtMaXB";
            this.txtMaXB.Size = new System.Drawing.Size(138, 23);
            this.txtMaXB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên NXB:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã NXB:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChinhSuaThongTin
            // 
            this.btnChinhSuaThongTin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnChinhSuaThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChinhSuaThongTin.Location = new System.Drawing.Point(43, 191);
            this.btnChinhSuaThongTin.Name = "btnChinhSuaThongTin";
            this.btnChinhSuaThongTin.Size = new System.Drawing.Size(164, 35);
            this.btnChinhSuaThongTin.TabIndex = 0;
            this.btnChinhSuaThongTin.Text = "Chỉnh sửa thông tin";
            this.btnChinhSuaThongTin.UseVisualStyleBackColor = false;
            this.btnChinhSuaThongTin.Click += new System.EventHandler(this.btnChinhSuaThongTin_Click);
            // 
            // FormCapNhatDuLieuNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 329);
            this.Controls.Add(this.groupChinhSua);
            this.Controls.Add(this.groupDanhSach);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormCapNhatDuLieuNXB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa dữ liệu Nhà Xuất Bản";
            this.Load += new System.EventHandler(this.FormCapNhatDuLieuNXB_Load);
            this.groupDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.groupChinhSua.ResumeLayout(false);
            this.groupChinhSua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupDanhSach;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox groupChinhSua;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenXB;
        private System.Windows.Forms.TextBox txtMaXB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChinhSuaThongTin;
    }
}