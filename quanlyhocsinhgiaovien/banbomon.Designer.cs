namespace quanlyhocsinhgiaovien
{
    partial class banbomon
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
            this.dgvphongban = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsogv = new System.Windows.Forms.TextBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.txttb = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.buttimkiem = new System.Windows.Forms.Button();
            this.tôltrip = new System.Windows.Forms.ToolStrip();
            this.butthem = new System.Windows.Forms.ToolStripButton();
            this.butluu = new System.Windows.Forms.ToolStripButton();
            this.butsua = new System.Windows.Forms.ToolStripButton();
            this.butxoa = new System.Windows.Forms.ToolStripButton();
            this.butthoat = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphongban)).BeginInit();
            this.tôltrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvphongban
            // 
            this.dgvphongban.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvphongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphongban.Location = new System.Drawing.Point(14, 138);
            this.dgvphongban.Name = "dgvphongban";
            this.dgvphongban.Size = new System.Drawing.Size(518, 266);
            this.dgvphongban.TabIndex = 0;
            this.dgvphongban.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphongban_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "tên ban:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "trưởng phòng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "số giáo viên :";
            // 
            // txtsogv
            // 
            this.txtsogv.Location = new System.Drawing.Point(119, 86);
            this.txtsogv.Name = "txtsogv";
            this.txtsogv.Size = new System.Drawing.Size(137, 20);
            this.txtsogv.TabIndex = 5;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(395, 83);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(137, 27);
            this.txttimkiem.TabIndex = 6;
            this.txttimkiem.Click += new System.EventHandler(this.txttimkiem_Click);
            // 
            // txttb
            // 
            this.txttb.Location = new System.Drawing.Point(119, 45);
            this.txttb.Name = "txttb";
            this.txttb.Size = new System.Drawing.Size(137, 20);
            this.txttb.TabIndex = 7;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(395, 40);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(137, 20);
            this.txtten.TabIndex = 8;
            // 
            // buttimkiem
            // 
            this.buttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttimkiem.Image = global::quanlyhocsinhgiaovien.Properties.Resources.search;
            this.buttimkiem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttimkiem.Location = new System.Drawing.Point(299, 73);
            this.buttimkiem.Name = "buttimkiem";
            this.buttimkiem.Size = new System.Drawing.Size(63, 44);
            this.buttimkiem.TabIndex = 9;
            this.buttimkiem.Text = "tìm kiếm";
            this.buttimkiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttimkiem.UseVisualStyleBackColor = true;
            this.buttimkiem.Click += new System.EventHandler(this.buttimkiem_Click);
            // 
            // tôltrip
            // 
            this.tôltrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butthem,
            this.butluu,
            this.butsua,
            this.butxoa,
            this.butthoat});
            this.tôltrip.Location = new System.Drawing.Point(0, 0);
            this.tôltrip.Name = "tôltrip";
            this.tôltrip.Size = new System.Drawing.Size(550, 25);
            this.tôltrip.TabIndex = 15;
            this.tôltrip.Text = "Lưu";
            // 
            // butthem
            // 
            this.butthem.Image = global::quanlyhocsinhgiaovien.Properties.Resources.add;
            this.butthem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(58, 22);
            this.butthem.Text = "Thêm";
            this.butthem.Click += new System.EventHandler(this.butthem_Click_1);
            // 
            // butluu
            // 
            this.butluu.Image = global::quanlyhocsinhgiaovien.Properties.Resources.accept1;
            this.butluu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butluu.Name = "butluu";
            this.butluu.Size = new System.Drawing.Size(47, 22);
            this.butluu.Text = "Lưu";
            this.butluu.Click += new System.EventHandler(this.butluu_Click);
            // 
            // butsua
            // 
            this.butsua.Image = global::quanlyhocsinhgiaovien.Properties.Resources.window_edit;
            this.butsua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(46, 22);
            this.butsua.Text = "Sửa";
            this.butsua.Click += new System.EventHandler(this.butsua_Click_1);
            // 
            // butxoa
            // 
            this.butxoa.Image = global::quanlyhocsinhgiaovien.Properties.Resources.window_remove;
            this.butxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(47, 22);
            this.butxoa.Text = "Xóa";
            // 
            // butthoat
            // 
            this.butthoat.Image = global::quanlyhocsinhgiaovien.Properties.Resources.remove3;
            this.butthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(58, 22);
            this.butthoat.Text = "Thoát";
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click_1);
            // 
            // banbomon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(550, 416);
            this.Controls.Add(this.tôltrip);
            this.Controls.Add(this.buttimkiem);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txttb);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.txtsogv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvphongban);
            this.Name = "banbomon";
            this.Text = "banbomon";
            this.Load += new System.EventHandler(this.banbomon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvphongban)).EndInit();
            this.tôltrip.ResumeLayout(false);
            this.tôltrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvphongban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsogv;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.TextBox txttb;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Button buttimkiem;
        private System.Windows.Forms.ToolStrip tôltrip;
        private System.Windows.Forms.ToolStripButton butthem;
        private System.Windows.Forms.ToolStripButton butluu;
        private System.Windows.Forms.ToolStripButton butsua;
        private System.Windows.Forms.ToolStripButton butxoa;
        private System.Windows.Forms.ToolStripButton butthoat;
    }
}