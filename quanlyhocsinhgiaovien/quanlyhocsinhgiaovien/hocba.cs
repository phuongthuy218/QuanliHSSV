using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlyhocsinhgiaovien.BusinessLogicLayer;
using quanlyhocsinhgiaovien.ValueObject;
using quanlyhocsinhgiaovien.DataAccessLayer;

namespace quanlyhocsinhgiaovien
{
    public partial class Hocba : Form
    {
        public Hocba()
        {
            InitializeComponent();
        }

        private void Hocba_Load(object sender, EventArgs e)
        {
            dgvhocba.DataSource = Bus.Getlisthocba();
            cbxmahs.DataSource = Bus.Getlisthocsinh();
            cbxmahs.ValueMember = "mahs";
            cbxtimkiem.DataSource = Bus.Getlisthocsinh();
            cbxtimkiem.ValueMember = "mahs";
            cbxmagv.DataSource = Bus.Getlistgiaovien();
            cbxmagv.ValueMember = "magv";
        }

         

        private void dgvhocba_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma.Text = dgvhocba.CurrentRow.Cells["mahb"].Value.ToString();
            cbxmahs.Text = dgvhocba.CurrentRow.Cells["mahs"].Value.ToString();
            cbxmagv.Text = dgvhocba.CurrentRow.Cells["magv"].Value.ToString();
            txttb.Text = dgvhocba.CurrentRow.Cells["diemtb"].Value.ToString();
            txthl.Text = dgvhocba.CurrentRow.Cells["hocluc"].Value.ToString();
            txthk.Text = dgvhocba.CurrentRow.Cells["hanhkiem"].Value.ToString();
            txtvp.Text = dgvhocba.CurrentRow.Cells["thongtinvipham"].Value.ToString();
            txtkl.Text = dgvhocba.CurrentRow.Cells["kyluat"].Value.ToString(); 
            txtkt.Text = dgvhocba.CurrentRow.Cells["khenthuong"].Value.ToString();
            txtdg.Text = dgvhocba.CurrentRow.Cells["danhgiagv"].Value.ToString(); 
            txtghichu.Text = dgvhocba.CurrentRow.Cells["ghichu"].Value.ToString(); 
            txthocky.Text = dgvhocba.CurrentRow.Cells["hocky"].Value.ToString();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            txtma.Text = string.Empty;
            cbxmahs.Text = string.Empty;
            cbxmagv.Text = string.Empty;
            txttb.Text = string.Empty;
            txthl.Text = string.Empty;
            txthk.Text = string.Empty;
            txtvp.Text = string.Empty;
            txtkl.Text = string.Empty;
            txtkt.Text = string.Empty;
            txtdg.Text = string.Empty;
            txtghichu.Text = string.Empty;
            txthocky.Text = string.Empty;

        }
        private void butluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            hocba hb = new hocba();
            hb.mahb = txtma.Text;
            hb.mahs = cbxmahs.Text;
            hb.magv = cbxmagv.Text;
            hb.diemtb = txttb.Text;
            hb.hocluc = txthl.Text;
            hb.hanhkiem = txthk.Text;
            hb.thongtinvipham = txtvp.Text;
            hb.kyluat = txtkl.Text;
            hb.khenthuong = txtkt.Text;
            hb.danggiagv = txtdg.Text;
            hb.ghichu = txtghichu.Text;
            hb.hocky = txthocky.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn lưu học bạ của  học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(hb) > 0)
                {
                    MessageBox.Show("lưu thành công!");
                    Hocba_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }

        }

        private void butsua_Click_1(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            hocba hb = new hocba();
            hb.mahb = txtma.Text;
            hb.mahs = cbxmahs.Text;
            hb.magv = cbxmagv.Text;
            hb.diemtb = txttb.Text;
            hb.hocluc = txthl.Text;
            hb.hanhkiem = txthk.Text;
            hb.thongtinvipham = txtvp.Text;
            hb.kyluat = txtkl.Text;
            hb.khenthuong = txtkt.Text;
            hb.danggiagv = txtdg.Text;
            hb.ghichu = txtghichu.Text;
            hb.hocky = txthocky.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn sửa học bạ của  học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(hb) > 0)
                {
                    MessageBox.Show("sửa học bạ thành công!");
                    Hocba_Load(sender, e);
                }
                else MessageBox.Show("đang bị lỗi@");
            }

        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            hocba hb = new hocba();
            hb.mahb = txtma.Text;
            hb.mahs = cbxmahs.Text;
            hb.magv = cbxmagv.Text;
            hb.diemtb = txttb.Text;
            hb.hocluc = txthl.Text;
            hb.hanhkiem = txthk.Text;
            hb.thongtinvipham = txtvp.Text;
            hb.kyluat = txtkl.Text;
            hb.khenthuong = txtkt.Text;
            hb.danggiagv = txtdg.Text;
            hb.ghichu = txtghichu.Text;
            hb.hocky = txthocky.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn xóa học bạ của  học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(hb) > 0)
                {
                    MessageBox.Show("xóa thành công!");
                    Hocba_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi xóa !");
            }

        }
        public void Hienthi(string mahs)
        {
           dgvhocba.DataSource = Bus.Timkiemhocba(mahs);
        }
        private void buttimkiem_Click(object sender, EventArgs e)
        {
            Hienthi(" Where mahs  like '%" + cbxtimkiem.Text + "'");
        }

        private void cbxtimkiem_Click(object sender, EventArgs e)
        {
            cbxtimkiem.Text = string.Empty;
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
