namespace Lab2_ApDung1
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
            this.groupBoxNhap = new System.Windows.Forms.GroupBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.groupBoxTuyChon = new System.Windows.Forms.GroupBox();
            this.radBSCNN = new System.Windows.Forms.RadioButton();
            this.radUSCLN = new System.Windows.Forms.RadioButton();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBoxNhap.SuspendLayout();
            this.groupBoxTuyChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNhap
            // 
            this.groupBoxNhap.BackColor = System.Drawing.Color.Honeydew;
            this.groupBoxNhap.Controls.Add(this.txtB);
            this.groupBoxNhap.Controls.Add(this.txtA);
            this.groupBoxNhap.Controls.Add(this.lblB);
            this.groupBoxNhap.Controls.Add(this.lblA);
            this.groupBoxNhap.Location = new System.Drawing.Point(20, 20);
            this.groupBoxNhap.Name = "groupBoxNhap";
            this.groupBoxNhap.Size = new System.Drawing.Size(240, 100);
            this.groupBoxNhap.TabIndex = 0;
            this.groupBoxNhap.TabStop = false;
            this.groupBoxNhap.Text = "Nhap du lieu";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(100, 60);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 3;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(100, 30);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 2;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(20, 63);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(62, 13);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "So nguyen b:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(20, 33);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(62, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "So nguyen a:";
            // 
            // groupBoxTuyChon
            // 
            this.groupBoxTuyChon.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxTuyChon.Controls.Add(this.radBSCNN);
            this.groupBoxTuyChon.Controls.Add(this.radUSCLN);
            this.groupBoxTuyChon.Location = new System.Drawing.Point(280, 20);
            this.groupBoxTuyChon.Name = "groupBoxTuyChon";
            this.groupBoxTuyChon.Size = new System.Drawing.Size(120, 100);
            this.groupBoxTuyChon.TabIndex = 1;
            this.groupBoxTuyChon.TabStop = false;
            this.groupBoxTuyChon.Text = "Tuy chon";
            // 
            // radBSCNN
            // 
            this.radBSCNN.AutoSize = true;
            this.radBSCNN.Location = new System.Drawing.Point(20, 60);
            this.radBSCNN.Name = "radBSCNN";
            this.radBSCNN.Size = new System.Drawing.Size(61, 17);
            this.radBSCNN.TabIndex = 1;
            this.radBSCNN.TabStop = true;
            this.radBSCNN.Text = "BSCNN";
            this.radBSCNN.UseVisualStyleBackColor = true;
            // 
            // radUSCLN
            // 
            this.radUSCLN.AutoSize = true;
            this.radUSCLN.Location = new System.Drawing.Point(20, 30);
            this.radUSCLN.Name = "radUSCLN";
            this.radUSCLN.Size = new System.Drawing.Size(61, 17);
            this.radUSCLN.TabIndex = 0;
            this.radUSCLN.TabStop = true;
            this.radUSCLN.Text = "USCLN";
            this.radUSCLN.UseVisualStyleBackColor = true;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(20, 140);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(46, 13);
            this.lblKetQua.TabIndex = 2;
            this.lblKetQua.Text = "Ket qua:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(100, 137);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(160, 20);
            this.txtKetQua.TabIndex = 3;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(280, 135);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tim";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(280, 175);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(420, 220);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.groupBoxTuyChon);
            this.Controls.Add(this.groupBoxNhap);
            this.Name = "Form1";
            this.Text = "Tim USCLN va BSCNN cua so nguyen a va b";
            this.groupBoxNhap.ResumeLayout(false);
            this.groupBoxNhap.PerformLayout();
            this.groupBoxTuyChon.ResumeLayout(false);
            this.groupBoxTuyChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNhap;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.GroupBox groupBoxTuyChon;
        private System.Windows.Forms.RadioButton radBSCNN;
        private System.Windows.Forms.RadioButton radUSCLN;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
    }

}


