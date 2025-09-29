namespace Lab2_ApDung2
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblKeyboard = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnRing = new System.Windows.Forms.Button();
            this.lblLog = new System.Windows.Forms.Label();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 20);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(90, 17);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // lblKeyboard
            // 
            this.lblKeyboard.AutoSize = true;
            this.lblKeyboard.Location = new System.Drawing.Point(20, 60);
            this.lblKeyboard.Name = "lblKeyboard";
            this.lblKeyboard.Size = new System.Drawing.Size(53, 13);
            this.lblKeyboard.TabIndex = 2;
            this.lblKeyboard.Text = "Keyboard:";
            // 
            // Button Numbers
            // 
            this.btn1.Location = new System.Drawing.Point(40, 90);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 40);
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.ButtonNumber_Click);

            this.btn2.Location = new System.Drawing.Point(100, 90);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 40);
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.ButtonNumber_Click);

            this.btn3.Location = new System.Drawing.Point(160, 90);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 40);
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.ButtonNumber_Click);

            this.btn4.Location = new System.Drawing.Point(40, 140);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 40);
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.ButtonNumber_Click);

            this.btn5.Location = new System.Drawing.Point(100, 140);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 40);
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.ButtonNumber_Click);

            this.btn6.Location = new System.Drawing.Point(160, 140);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 40);
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.ButtonNumber_Click);

            this.btn7.Location = new System.Drawing.Point(40, 190);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 40);
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.ButtonNumber_Click);

            this.btn8.Location = new System.Drawing.Point(100, 190);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 40);
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.ButtonNumber_Click);

            this.btn9.Location = new System.Drawing.Point(160, 190);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 40);
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Location = new System.Drawing.Point(230, 90);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 40);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Lime;
            this.btnEnter.Location = new System.Drawing.Point(230, 140);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 40);
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnRing
            // 
            this.btnRing.BackColor = System.Drawing.Color.Red;
            this.btnRing.Location = new System.Drawing.Point(230, 190);
            this.btnRing.Name = "btnRing";
            this.btnRing.Size = new System.Drawing.Size(75, 40);
            this.btnRing.Text = "RING";
            this.btnRing.UseVisualStyleBackColor = false;
            this.btnRing.Click += new System.EventHandler(this.btnRing_Click);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(20, 250);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(55, 13);
            this.lblLog.TabIndex = 20;
            this.lblLog.Text = "Login Log:";
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.Add("NgayGio", "Ngay gio");
            this.dgvLog.Columns.Add("Nhom", "Nhom");
            this.dgvLog.Columns.Add("KetQua", "Ket qua");
            this.dgvLog.Location = new System.Drawing.Point(20, 270);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.Size = new System.Drawing.Size(400, 150);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.dgvLog);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.btnRing);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblKeyboard);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Name = "Form1";
            this.Text = "Security Panel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblKeyboard;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnRing;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.DataGridView dgvLog;
    }
}

