namespace Lab2_ApDung4
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
            this.lstMatHang = new System.Windows.Forms.ListBox();
            this.lstDaChon = new System.Windows.Forms.ListBox();
            this.lblMatHang = new System.Windows.Forms.Label();
            this.lblDaChon = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnRightAll = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnLeftAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMatHang
            // 
            this.lstMatHang.FormattingEnabled = true;
            this.lstMatHang.Items.AddRange(new object[] {
            "CPU",
            "MainBoard",
            "RAM",
            "Keyboard",
            "Mouse",
            "NIC",
            "FAN"});
            this.lstMatHang.Location = new System.Drawing.Point(20, 40);
            this.lstMatHang.Name = "lstMatHang";
            this.lstMatHang.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstMatHang.Size = new System.Drawing.Size(150, 200);
            this.lstMatHang.TabIndex = 0;
            // 
            // lstDaChon
            // 
            this.lstDaChon.FormattingEnabled = true;
            this.lstDaChon.Location = new System.Drawing.Point(320, 40);
            this.lstDaChon.Name = "lstDaChon";
            this.lstDaChon.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDaChon.Size = new System.Drawing.Size(150, 200);
            this.lstDaChon.TabIndex = 1;
            // 
            // lblMatHang
            // 
            this.lblMatHang.AutoSize = true;
            this.lblMatHang.Location = new System.Drawing.Point(20, 20);
            this.lblMatHang.Name = "lblMatHang";
            this.lblMatHang.Size = new System.Drawing.Size(111, 13);
            this.lblMatHang.TabIndex = 2;
            this.lblMatHang.Text = "Danh sách các mặt hàng";
            // 
            // lblDaChon
            // 
            this.lblDaChon.AutoSize = true;
            this.lblDaChon.Location = new System.Drawing.Point(320, 20);
            this.lblDaChon.Name = "lblDaChon";
            this.lblDaChon.Size = new System.Drawing.Size(113, 13);
            this.lblDaChon.TabIndex = 3;
            this.lblDaChon.Text = "Các mặt hàng lựa chọn";
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(210, 60);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnRightAll
            // 
            this.btnRightAll.Location = new System.Drawing.Point(210, 100);
            this.btnRightAll.Name = "btnRightAll";
            this.btnRightAll.Size = new System.Drawing.Size(75, 23);
            this.btnRightAll.TabIndex = 5;
            this.btnRightAll.Text = ">>";
            this.btnRightAll.UseVisualStyleBackColor = true;
            this.btnRightAll.Click += new System.EventHandler(this.btnRightAll_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(210, 140);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnLeftAll
            // 
            this.btnLeftAll.Location = new System.Drawing.Point(210, 180);
            this.btnLeftAll.Name = "btnLeftAll";
            this.btnLeftAll.Size = new System.Drawing.Size(75, 23);
            this.btnLeftAll.TabIndex = 7;
            this.btnLeftAll.Text = "<<";
            this.btnLeftAll.UseVisualStyleBackColor = true;
            this.btnLeftAll.Click += new System.EventHandler(this.btnLeftAll_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(500, 270);
            this.Controls.Add(this.btnLeftAll);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRightAll);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.lblDaChon);
            this.Controls.Add(this.lblMatHang);
            this.Controls.Add(this.lstDaChon);
            this.Controls.Add(this.lstMatHang);
            this.Name = "Form1";
            this.Text = "Bài tập 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMatHang;
        private System.Windows.Forms.ListBox lstDaChon;
        private System.Windows.Forms.Label lblMatHang;
        private System.Windows.Forms.Label lblDaChon;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnRightAll;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnLeftAll;
    }
}

