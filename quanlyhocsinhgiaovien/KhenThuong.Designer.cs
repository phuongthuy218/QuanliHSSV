namespace quanlyhocsinhgiaovien
{
    partial class KhenThuong
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.butthem = new System.Windows.Forms.ToolStripButton();
            this.butluu = new System.Windows.Forms.ToolStripButton();
            this.butsua = new System.Windows.Forms.ToolStripButton();
            this.butxoa = new System.Windows.Forms.ToolStripButton();
            this.butthoat = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datenkt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxhs = new System.Windows.Forms.ComboBox();
            this.txthinhthuc = new System.Windows.Forms.TextBox();
            this.txtlydo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvkhenthuong = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhenthuong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butthem,
            this.butluu,
            this.butsua,
            this.butxoa,
            this.butthoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(726, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // butthem
            // 
            this.butthem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butthem.Image = global::quanlyhocsinhgiaovien.Properties.Resources.add;
            this.butthem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(58, 22);
            this.butthem.Text = "Thêm";
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // butluu
            // 
            this.butluu.Image = global::quanlyhocsinhgiaovien.Properties.Resources.uy;
            this.butluu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butluu.Name = "butluu";
            this.butluu.Size = new System.Drawing.Size(47, 22);
            this.butluu.Text = "Lưu";
            this.butluu.Click += new System.EventHandler(this.butluu_Click);
            // 
            // butsua
            // 
            this.butsua.Image = global::quanlyhocsinhgiaovien.Properties.Resources.window_edit1;
            this.butsua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(46, 22);
            this.butsua.Text = "Sửa";
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butxoa
            // 
            this.butxoa.Image = global::quanlyhocsinhgiaovien.Properties.Resources.window_remove;
            this.butxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(45, 22);
            this.butxoa.Text = "xóa";
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butthoat
            // 
            this.butthoat.Image = global::quanlyhocsinhgiaovien.Properties.Resources.delete;
            this.butthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(55, 22);
            this.butthoat.Text = "thoát";
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Học Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hình Thức";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datenkt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxhs);
            this.groupBox1.Controls.Add(this.txthinhthuc);
            this.groupBox1.Controls.Add(this.txtlydo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 140);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khen Thưởng";
            // 
            // datenkt
            // 
            this.datenkt.Location = new System.Drawing.Point(508, 30);
            this.datenkt.Name = "datenkt";
            this.datenkt.Size = new System.Drawing.Size(180, 22);
            this.datenkt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Khen Thưởng";
            // 
            // cbxhs
            // 
            this.cbxhs.FormattingEnabled = true;
            this.cbxhs.Location = new System.Drawing.Point(104, 33);
            this.cbxhs.Name = "cbxhs";
            this.cbxhs.Size = new System.Drawing.Size(193, 24);
            this.cbxhs.TabIndex = 9;
            // 
            // txthinhthuc
            // 
            this.txthinhthuc.Location = new System.Drawing.Point(104, 72);
            this.txthinhthuc.Name = "txthinhthuc";
            this.txthinhthuc.Size = new System.Drawing.Size(193, 22);
            this.txthinhthuc.TabIndex = 8;
            // 
            // txtlydo
            // 
            this.txtlydo.Location = new System.Drawing.Point(508, 78);
            this.txtlydo.Name = "txtlydo";
            this.txtlydo.Size = new System.Drawing.Size(180, 22);
            this.txtlydo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "lý Do";
            // 
            // dgvkhenthuong
            // 
            this.dgvkhenthuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhenthuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvkhenthuong.Location = new System.Drawing.Point(3, 17);
            this.dgvkhenthuong.Name = "dgvkhenthuong";
            this.dgvkhenthuong.Size = new System.Drawing.Size(708, 169);
            this.dgvkhenthuong.TabIndex = 4;
            this.dgvkhenthuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhenthuong_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvkhenthuong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 189);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Được Khen Thưởng";
            // 
            // KhenThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 371);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "KhenThuong";
            this.Text = "KhenThuong";
            this.Load += new System.EventHandler(this.KhenThuong_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhenthuong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton butthem;
        private System.Windows.Forms.ToolStripButton butluu;
        private System.Windows.Forms.ToolStripButton butsua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxhs;
        private System.Windows.Forms.TextBox txthinhthuc;
        private System.Windows.Forms.TextBox txtlydo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvkhenthuong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker datenkt;
        private System.Windows.Forms.ToolStripButton butxoa;
        private System.Windows.Forms.ToolStripButton butthoat;
    }
}