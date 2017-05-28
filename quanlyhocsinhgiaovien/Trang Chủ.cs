using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyhocsinhgiaovien
{
    public partial class frmqlhsgv : Form
    {
        public frmqlhsgv()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void qlhsgv_Load(object sender, EventArgs e)
        { 
        }

        private void hồSơGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgiaovien giaovien = new frmgiaovien();
            giaovien.Show();
        }

        private void banBộMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banbomon bm = new banbomon();
            bm.Show();
        }
 

        private void thôngTinLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lophoc l = new lophoc();
            l.Show();
        }
 
 
         
        private void thôngTinMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cacmonhoc m = new cacmonhoc();
            m.Show();

        }

        private void hồSơHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtinhocsinh hs = new thongtinhocsinh();
            hs.Show();
        }

       
        private void họcBạToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hocba hb = new Hocba();
            hb.Show();
        }

        private void bảngĐiêrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bangdiem b = new Bangdiem();
            b.Show();
        }

        

        private void chiTiếtĐiểmTừngMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chitietdiem ct = new chitietdiem();
            ct.Show();
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formthongtin tt = new Formthongtin();
            tt.Show();
        }
    }
}
