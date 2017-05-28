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
            this.label4 = new System.Windows.Forms.Label();
            this.txtsogv = new System.Windows.Forms.TextBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.txttb = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.butluu = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.butthem = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.buttimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphongban)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvphongban
            // 
            this.dgvphongban.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvphongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphongban.Location = new System.Drawing.Point(-3, 196);
            this.dgvphongban.Name = "dgvphongban";
            this.dgvphongban.Size = new System.Drawing.Size(631, 266);
            this.dgvphongban.TabIndex = 0;
            this.dgvphongban.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphongban_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "tên ban:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "trưởng phòng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "số giáo viên :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(212, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ban Bộ Môn ";
            // 
            // txtsogv
            // 
            this.txtsogv.Location = new System.Drawing.Point(112, 141);
            this.txtsogv.Name = "txtsogv";
            this.txtsogv.Size = new System.Drawing.Size(137, 20);
            this.txtsogv.TabIndex = 5;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(388, 138);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(200, 27);
            this.txttimkiem.TabIndex = 6;
            this.txttimkiem.Click += new System.EventHandler(this.txttimkiem_Click);
            // 
            // txttb
            // 
            this.txttb.Location = new System.Drawing.Point(112, 100);
            this.txttb.Name = "txttb";
            this.txttb.Size = new System.Drawing.Size(137, 20);
            this.txttb.TabIndex = 7;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(112, 59);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(137, 20);
            this.txtten.TabIndex = 8;
            // 
            // butluu
            // 
            this.butluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butluu.Image = global::quanlyhocsinhgiaovien.Properties.Resources.uy1;
            this.butluu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butluu.Location = new System.Drawing.Point(352, 62);
            this.butluu.Name = "butluu";
            this.butluu.Size = new System.Drawing.Size(34, 34);
            this.butluu.TabIndex = 14;
            this.butluu.Text = "lưu";
            this.butluu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butluu.UseVisualStyleBackColor = true;
            this.butluu.Click += new System.EventHandler(this.butluu_Click);
            // 
            // butsua
            // 
            this.butsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsua.Image = global::quanlyhocsinhgiaovien.Properties.Resources.window_edit;
            this.butsua.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butsua.Location = new System.Drawing.Point(405, 62);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(39, 34);
            this.butsua.TabIndex = 13;
            this.butsua.Text = "sửa";
            this.butsua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butsua.UseVisualStyleBackColor = true;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butthem
            // 
            this.butthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butthem.Image = global::quanlyhocsinhgiaovien.Properties.Resources.add;
            this.butthem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butthem.Location = new System.Drawing.Point(291, 60);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(42, 36);
            this.butthem.TabIndex = 12;
            this.butthem.Text = "thêm ";
            this.butthem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butthem.UseVisualStyleBackColor = true;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // butthoat
            // 
            this.butthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butthoat.Image = global::quanlyhocsinhgiaovien.Properties.Resources.next;
            this.butthoat.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butthoat.Location = new System.Drawing.Point(530, 62);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(49, 35);
            this.butthoat.TabIndex = 11;
            this.butthoat.Text = "thoát";
            this.butthoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // butxoa
            // 
            this.butxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butxoa.Image = global::quanlyhocsinhgiaovien.Properties.Resources.remove4;
            this.butxoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butxoa.Location = new System.Drawing.Point(473, 62);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(40, 35);
            this.butxoa.TabIndex = 10;
            this.butxoa.Text = "xóa";
            this.butxoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // buttimkiem
            // 
            this.buttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttimkiem.Image = global::quanlyhocsinhgiaovien.Properties.Resources.search;
            this.buttimkiem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttimkiem.Location = new System.Drawing.Point(292, 128);
            this.buttimkiem.Name = "buttimkiem";
            this.buttimkiem.Size = new System.Drawing.Size(63, 44);
            this.buttimkiem.TabIndex = 9;
            this.buttimkiem.Text = "tìm kiếm";
            this.buttimkiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttimkiem.UseVisualStyleBackColor = true;
            this.buttimkiem.Click += new System.EventHandler(this.buttimkiem_Click);
            // 
            // banbomon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(626, 462);
            this.Controls.Add(this.butluu);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.buttimkiem);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txttb);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.txtsogv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvphongban);
            this.Name = "banbomon";
            this.Text = "banbomon";
            this.Load += new System.EventHandler(this.banbomon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvphongban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvphongban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsogv;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.TextBox txttb;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Button buttimkiem;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button butluu;
    }
}