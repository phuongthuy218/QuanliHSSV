using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlyhocsinhgiaovien.ValueObject;
using quanlyhocsinhgiaovien.BusinessLogicLayer;

namespace quanlyhocsinhgiaovien
{
    public partial class KhenThuong : Form
    {
        public KhenThuong()
        {
            InitializeComponent();
        }

        public string mesage
        {
            get { return cbxhs.Text; }
            set { cbxhs.Text = value; }
        }
        private void KhenThuong_Load(object sender, EventArgs e)
        {
            dgvkhenthuong.DataSource = Bus.Getlistkhenthuong();

            cbxhs.Text = mesage;
            butluu.Enabled = true;
            butsua.Enabled = true;
            butthem.Enabled = true;
            butthoat.Enabled = true;

        }

        private void dgvkhenthuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                cbxhs.Text = dgvkhenthuong.CurrentRow.Cells["mahs"].Value.ToString();
                txthinhthuc.Text = dgvkhenthuong.CurrentRow.Cells["hinhthuc"].Value.ToString();
                txtlydo.Text = dgvkhenthuong.CurrentRow.Cells["lydo"].Value.ToString();
                datenkt.Text = dgvkhenthuong.CurrentRow.Cells["ngaykhenthuong"].Value.ToString();
 
            }
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            cbxhs.Text = string.Empty;
            txthinhthuc.Text = string.Empty;
            datenkt.Text = string.Empty;
            txtlydo.Text = string.Empty;
           

            butsua.Enabled = false;
            butxoa.Enabled = false;
        }

        private void butluu_Click(object sender, EventArgs e)
        {
            if (cbxhs.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            khenthuong kt = new khenthuong();

            kt.mahs = cbxhs.Text;
            kt.hinhthuc = txthinhthuc.Text;
            kt.ngaykhenthuong = datenkt.Value;
            kt.lydo = txtlydo.Text;

            butthem.Enabled = false;

            if (MessageBox.Show(string.Format("Bạn có muốn lưu  khen thưởng của  học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(kt) > 0)
                {
                    MessageBox.Show("lưu thành công!");
                    KhenThuong_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if (cbxhs.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            khenthuong kt = new khenthuong();

            kt.mahs = cbxhs.Text;
            kt.hinhthuc = txthinhthuc.Text;
            kt.ngaykhenthuong = datenkt.Value;
            kt.lydo = txtlydo.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn sửa kỷ luật của  học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(kt) > 0)
                {
                    MessageBox.Show("sửa thành công!");
                    KhenThuong_Load(sender, e);
                }
                else MessageBox.Show("đang bị lỗi@");
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (cbxhs.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            khenthuong kt = new khenthuong(); 
            kt.mahs = cbxhs.Text;
            kt.hinhthuc = txthinhthuc.Text;
            kt.ngaykhenthuong = datenkt.Value;
            kt.lydo = txtlydo.Text;
           


            if (MessageBox.Show(string.Format("Bạn có muốn xóa khen thưởng đối với học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(kt) > 0)
                {
                    MessageBox.Show("xóa thông tin thành công!");
                    KhenThuong_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi   !");
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

