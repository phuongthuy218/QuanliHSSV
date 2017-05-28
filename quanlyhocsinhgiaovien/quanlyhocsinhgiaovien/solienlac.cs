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
    public partial class solienlac : Form
    {
        public solienlac()
        {
            InitializeComponent();
        }

        private void solienlac_Load(object sender, EventArgs e)
        {
            dgvthannhan.DataSource = Bus.Getlistthannhan();
            cbxma.DataSource = Bus.Getlisthocsinh();
            cbxma.ValueMember = "mahs";
            cbxtimkiem.DataSource = Bus.Getlisthocsinh();
            cbxtimkiem.ValueMember = "mahs";
        }

        private void dgvthannhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxma.Text = dgvthannhan.CurrentRow.Cells["mahs"].Value.ToString();
            txttenbo.Text = dgvthannhan.CurrentRow.Cells["hotenbo"].Value.ToString();
            txtdcbo.Text = dgvthannhan.CurrentRow.Cells["diachi"].Value.ToString();
            datensbo.Text = dgvthannhan.CurrentRow.Cells["ngaysinh"].Value.ToString();
            txtnnbo.Text = dgvthannhan.CurrentRow.Cells["nghenghiep"].Value.ToString();
            txttenme.Text = dgvthannhan.CurrentRow.Cells["hotenme"].Value.ToString();
            txtdcme.Text = dgvthannhan.CurrentRow.Cells["diachime"].Value.ToString();
            datensme.Text = dgvthannhan.CurrentRow.Cells["ngaysinhme"].Value.ToString();
            txtnnme.Text = dgvthannhan.CurrentRow.Cells["nghenghiepme"].Value.ToString();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            cbxma.Text = string.Empty;
            txttenbo.Text = string.Empty;
            txtdcbo.Text = string.Empty;
            datensbo.Value = DateTime.Now;
            txtnnbo.Text = string.Empty;
            txttenme.Text = string.Empty;
            txtdcme.Text = string.Empty;
            datensme.Value = DateTime.Now;
            txtnnme.Text = string.Empty;

        }

        private void butluu_Click(object sender, EventArgs e)
        {
            if (cbxma.Text == ""  )
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            thannhan t = new thannhan();
            t.mahs = cbxma.Text;
            t.hotenbo = txttenbo.Text;
            t.diachi = txtdcbo.Text;
            t.ngaysinh = datensbo.Value;
            t.nghenghiep = txtnnbo.Text;
            t.hotenme = txttenme.Text;
            t.diachime = txtdcme.Text;
            t.ngaysinhme = datensme.Value;
            t.nghenghiepme = txtnnme.Text;
          
            if (MessageBox.Show(string.Format("Bạn có muốn lưu liên lạc của  học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(t) > 0)
                {
                    MessageBox.Show("lưu thành công!");
                    solienlac_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if (cbxma.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            thannhan t = new thannhan();
            t.mahs = cbxma.Text;
            t.hotenbo = txttenbo.Text;
            t.diachi = txtdcbo.Text;
            t.ngaysinh = datensbo.Value;
            t.nghenghiep = txtnnbo.Text;
            t.hotenme = txttenme.Text;
            t.diachime = txtdcme.Text;
            t.ngaysinhme = datensme.Value;
            t.nghenghiepme = txtnnme.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn sửa liên lạc của  học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(t) > 0)
                {
                    MessageBox.Show("sửa thông tin  thành công!");
                    solienlac_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (cbxma.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            thannhan t = new thannhan();
            t.mahs = cbxma.Text;
            t.hotenbo = txttenbo.Text;
            t.diachi = txtdcbo.Text;
            t.ngaysinh = datensbo.Value;
            t.nghenghiep = txtnnbo.Text;
            t.hotenme = txttenme.Text;
            t.diachime = txtdcme.Text;
            t.ngaysinhme = datensme.Value;
            t.nghenghiepme = txtnnme.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn xóa liên lạc của  học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(t) > 0)
                {
                    MessageBox.Show("xóa thông tin  thành công!");
                    solienlac_Load(sender, e);
                }
                else MessageBox.Show("không xóa được! ");
            }
        }
        public void Hienthi(string mahs)
        {
            dgvthannhan.DataSource = Bus.Timkiemthannhan(mahs);
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
