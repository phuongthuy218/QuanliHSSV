namespace quanlyhocsinhgiaovien
{
    partial class Kỷ_Luật
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
            this.grpkl = new System.Windows.Forms.GroupBox();
            this.dgvkyluat = new System.Windows.Forms.DataGridView();
            this.grpthongtinkl = new System.Windows.Forms.GroupBox();
            this.datenkl = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxhs = new System.Windows.Forms.ComboBox();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.txthinhthuc = new System.Windows.Forms.TextBox();
            this.txtlydo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.butthem = new System.Windows.Forms.ToolStripButton();
            this.butluu = new System.Windows.Forms.ToolStripButton();
            this.butsua = new System.Windows.Forms.ToolStripButton();
            this.butthoat = new System.Windows.Forms.ToolStripButton();
            this.butxoa = new System.Windows.Forms.ToolStripButton();
            this.grpkl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkyluat)).BeginInit();
            this.grpthongtinkl.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpkl
            // 
            this.grpkl.Controls.Add(this.dgvkyluat);
            this.grpkl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpkl.Location = new System.Drawing.Point(0, 183);
            this.grpkl.Name = "grpkl";
            this.grpkl.Size = new System.Drawing.Size(561, 189);
            this.grpkl.TabIndex = 14;
            this.grpkl.TabStop = false;
            this.grpkl.Text = "Danh Sách Bị Kỷ Luật";
            // 
            // dgvkyluat
            // 
            this.dgvkyluat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkyluat.Location = new System.Drawing.Point(12, 20);
            this.dgvkyluat.Name = "dgvkyluat";
            this.dgvkyluat.Size = new System.Drawing.Size(524, 150);
            this.dgvkyluat.TabIndex = 4;
            this.dgvkyluat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkyluat_CellContentClick);
            // 
            // grpthongtinkl
            // 
            this.grpthongtinkl.Controls.Add(this.datenkl);
            this.grpthongtinkl.Controls.Add(this.label3);
            this.grpthongtinkl.Controls.Add(this.cbxhs);
            this.grpthongtinkl.Controls.Add(this.txtghichu);
            this.grpthongtinkl.Controls.Add(this.txthinhthuc);
            this.grpthongtinkl.Controls.Add(this.txtlydo);
            this.grpthongtinkl.Controls.Add(this.label5);
            this.grpthongtinkl.Controls.Add(this.label4);
            this.grpthongtinkl.Controls.Add(this.label2);
            this.grpthongtinkl.Controls.Add(this.label1);
            this.grpthongtinkl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpthongtinkl.Location = new System.Drawing.Point(0, 28);
            this.grpthongtinkl.Name = "grpthongtinkl";
            this.grpthongtinkl.Size = new System.Drawing.Size(561, 140);
            this.grpthongtinkl.TabIndex = 13;
            this.grpthongtinkl.TabStop = false;
            this.grpthongtinkl.Text = "Thông Tin Kỷ Luật ";
            // 
            // datenkl
            // 
            this.datenkl.Location = new System.Drawing.Point(386, 34);
            this.datenkl.Name = "datenkl";
            this.datenkl.Size = new System.Drawing.Size(150, 22);
            this.datenkl.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Kỷ Luật";
            // 
            // cbxhs
            // 
            this.cbxhs.FormattingEnabled = true;
            this.cbxhs.Location = new System.Drawing.Point(103, 28);
            this.cbxhs.Name = "cbxhs";
            this.cbxhs.Size = new System.Drawing.Size(140, 24);
            this.cbxhs.TabIndex = 9;
            this.cbxhs.SelectedIndexChanged += new System.EventHandler(this.cbxhs_SelectedIndexChanged);
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(386, 66);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(150, 65);
            this.txtghichu.TabIndex = 6;
            // 
            // txthinhthuc
            // 
            this.txthinhthuc.Location = new System.Drawing.Point(103, 66);
            this.txthinhthuc.Name = "txthinhthuc";
            this.txthinhthuc.Size = new System.Drawing.Size(140, 22);
            this.txthinhthuc.TabIndex = 8;
            // 
            // txtlydo
            // 
            this.txtlydo.Location = new System.Drawing.Point(103, 101);
            this.txtlydo.Name = "txtlydo";
            this.txtlydo.Size = new System.Drawing.Size(140, 22);
            this.txtlydo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ghi Chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "lý Do";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Học Sinh";
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
            this.toolStrip1.Size = new System.Drawing.Size(603, 25);
            this.toolStrip1.TabIndex = 12;
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
            // butthoat
            // 
            this.butthoat.Image = global::quanlyhocsinhgiaovien.Properties.Resources.images__5_;
            this.butthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(58, 22);
            this.butthoat.Text = "Thoát";
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // butxoa
            // 
            this.butxoa.Image = global::quanlyhocsinhgiaovien.Properties.Resources.window_remove;
            this.butxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(47, 22);
            this.butxoa.Text = "Xóa";
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // Kỷ_Luật
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 384);
            this.Controls.Add(this.grpkl);
            this.Controls.Add(this.grpthongtinkl);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Kỷ_Luật";
            this.Text = "Kỷ_Luật";
            this.Load += new System.EventHandler(this.Kỷ_Luật_Load);
            this.grpkl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkyluat)).EndInit();
            this.grpthongtinkl.ResumeLayout(false);
            this.grpthongtinkl.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpkl;
        private System.Windows.Forms.DataGridView dgvkyluat;
        private System.Windows.Forms.GroupBox grpthongtinkl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxhs;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.TextBox txthinhthuc;
        private System.Windows.Forms.TextBox txtlydo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton butthem;
        private System.Windows.Forms.ToolStripButton butluu;
        private System.Windows.Forms.ToolStripButton butsua;
        private System.Windows.Forms.DateTimePicker datenkl;
        private System.Windows.Forms.ToolStripButton butthoat;
        private System.Windows.Forms.ToolStripButton butxoa;
    }
}