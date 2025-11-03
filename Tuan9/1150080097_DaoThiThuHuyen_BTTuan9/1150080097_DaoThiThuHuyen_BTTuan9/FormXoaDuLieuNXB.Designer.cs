namespace _1150080097_DaoThiThuHuyen_BTTuan9
{
    partial class FormXoaDuLieuNXB
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
            this.btnXoaDuLieu = new System.Windows.Forms.Button();
            this.groupDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(160, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(300, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Xóa dữ liệu trong database";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupDanhSach
            // 
            this.groupDanhSach.Controls.Add(this.dgvDanhSach);
            this.groupDanhSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupDanhSach.Location = new System.Drawing.Point(12, 45);
            this.groupDanhSach.Name = "groupDanhSach";
            this.groupDanhSach.Size = new System.Drawing.Size(580, 320);
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
            this.dgvDanhSach.Size = new System.Drawing.Size(574, 298);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // btnXoaDuLieu
            // 
            this.btnXoaDuLieu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnXoaDuLieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaDuLieu.Location = new System.Drawing.Point(210, 375);
            this.btnXoaDuLieu.Name = "btnXoaDuLieu";
            this.btnXoaDuLieu.Size = new System.Drawing.Size(180, 40);
            this.btnXoaDuLieu.TabIndex = 2;
            this.btnXoaDuLieu.Text = "Xóa dữ liệu";
            this.btnXoaDuLieu.UseVisualStyleBackColor = false;
            this.btnXoaDuLieu.Click += new System.EventHandler(this.btnXoaDuLieu_Click);
            // 
            // FormXoaDuLieuNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 431);
            this.Controls.Add(this.btnXoaDuLieu);
            this.Controls.Add(this.groupDanhSach);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormXoaDuLieuNXB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa dữ liệu Nhà Xuất Bản";
            this.Load += new System.EventHandler(this.FormXoaDuLieuNXB_Load);
            this.groupDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupDanhSach;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnXoaDuLieu;
    }
}