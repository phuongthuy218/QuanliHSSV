namespace quanlyhocsinhgiaovien
{
    partial class loginfrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textmatkhau = new System.Windows.Forms.TextBox();
            this.textnguoidung = new System.Windows.Forms.TextBox();
            this.lblthongbao = new System.Windows.Forms.Label();
            this.butlogin = new System.Windows.Forms.Button();
            this.butexit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " Đăng Nhập Hệ Thống ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Tag = " ";
            this.label2.Text = " Tên Đăng Nhập ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu ";
            // 
            // textmatkhau
            // 
            this.textmatkhau.Location = new System.Drawing.Point(147, 129);
            this.textmatkhau.Name = "textmatkhau";
            this.textmatkhau.PasswordChar = '*';
            this.textmatkhau.Size = new System.Drawing.Size(178, 20);
            this.textmatkhau.TabIndex = 3;
            // 
            // textnguoidung
            // 
            this.textnguoidung.Location = new System.Drawing.Point(147, 87);
            this.textnguoidung.Name = "textnguoidung";
            this.textnguoidung.Size = new System.Drawing.Size(178, 20);
            this.textnguoidung.TabIndex = 4;
            // 
            // lblthongbao
            // 
            this.lblthongbao.AutoSize = true;
            this.lblthongbao.Location = new System.Drawing.Point(41, 45);
            this.lblthongbao.Name = "lblthongbao";
            this.lblthongbao.Size = new System.Drawing.Size(69, 13);
            this.lblthongbao.TabIndex = 8;
            this.lblthongbao.Tag = " ";
            this.lblthongbao.Text = "  Thông Báo:";
            this.lblthongbao.Visible = false;
            // 
            // butlogin
            // 
            this.butlogin.ForeColor = System.Drawing.Color.Maroon;
            this.butlogin.Image = global::quanlyhocsinhgiaovien.Properties.Resources.uy1;
            this.butlogin.Location = new System.Drawing.Point(147, 177);
            this.butlogin.Name = "butlogin";
            this.butlogin.Size = new System.Drawing.Size(56, 32);
            this.butlogin.TabIndex = 5;
            this.butlogin.Text = " ";
            this.butlogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butlogin.UseVisualStyleBackColor = true;
            this.butlogin.Click += new System.EventHandler(this.butlogin_Click);
            // 
            // butexit
            // 
            this.butexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butexit.Image = global::quanlyhocsinhgiaovien.Properties.Resources.remove1;
            this.butexit.Location = new System.Drawing.Point(276, 177);
            this.butexit.Name = "butexit";
            this.butexit.Size = new System.Drawing.Size(49, 32);
            this.butexit.TabIndex = 6;
            this.butexit.Text = " ";
            this.butexit.UseVisualStyleBackColor = true;
            this.butexit.Click += new System.EventHandler(this.butexit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::quanlyhocsinhgiaovien.Properties.Resources.management_key;
            this.pictureBox1.Location = new System.Drawing.Point(347, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(144, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "đăng nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(282, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "thoát \r\n";
            // 
            // loginfrm
            // 
            this.AcceptButton = this.butlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.butexit;
            this.ClientSize = new System.Drawing.Size(497, 237);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblthongbao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butexit);
            this.Controls.Add(this.butlogin);
            this.Controls.Add(this.textnguoidung);
            this.Controls.Add(this.textmatkhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "loginfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.loginfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textmatkhau;
        private System.Windows.Forms.TextBox textnguoidung;
        private System.Windows.Forms.Button butlogin;
        private System.Windows.Forms.Button butexit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblthongbao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

