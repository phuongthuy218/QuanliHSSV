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
    public partial class frmgiaovien : Form
    {

        public frmgiaovien()
        {
            InitializeComponent();
        }

        private void giaovien_Load(object sender, EventArgs e)
        {
            dgvgiaovien.DataSource = Bus.Getlistgiaovien();
            cbxpb.DataSource = Bus.Getlistphongban();
            cbxpb.ValueMember = "tenban";

        }
        private void dgvgiaovien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma.Text = dgvgiaovien.CurrentRow.Cells["magv"].Value.ToString();
            txtten.Text = dgvgiaovien.CurrentRow.Cells["tengv"].Value.ToString();
            cbxpb.Text = dgvgiaovien.CurrentRow.Cells["tenban"].Value.ToString();
            txtdt.Text = dgvgiaovien.CurrentRow.Cells["dantoc"].Value.ToString();
            txtgt.Text = dgvgiaovien.CurrentRow.Cells["gioitinh"].Value.ToString();
            txtnn.Text = dgvgiaovien.CurrentRow.Cells["ngoaingu"].Value.ToString();
            txttd.Text = dgvgiaovien.CurrentRow.Cells["trinhdo"].Value.ToString();
            txtghichu.Text = dgvgiaovien.CurrentRow.Cells["ghichu"].Value.ToString();
            txttg.Text = dgvgiaovien.CurrentRow.Cells["tongiao"].Value.ToString();
            datenl.Text = dgvgiaovien.CurrentRow.Cells["ngayvaolam"].Value.ToString();
            datens.Text = dgvgiaovien.CurrentRow.Cells["ngaysinh"].Value.ToString();
            txtque.Text = dgvgiaovien.CurrentRow.Cells["quequan"].Value.ToString();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            txtma.Text = string.Empty;
            txtten.Text = string.Empty;
            datens.Value = DateTime.Now;
            cbxpb.Text = string.Empty;
            txtghichu.Text = string.Empty;
            txtdt.Text = string.Empty;
            txtgt.Text = string.Empty;
            txtnn.Text = string.Empty;
            txtque.Text = string.Empty;
            txttg.Text = string.Empty;
            datenl.Value = DateTime.Now;
            txttd.Text = string.Empty;

        }

        private void butluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "" || txtten.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            giaovien gv = new giaovien();
            gv.magv = txtma.Text;
            gv.tengv = txtten.Text;
            gv.ngaysinh = datens.Value;
            gv.gioitinh = txtgt.Text;
            gv.dantoc = txtdt.Text;
            gv.tongiao = txttg.Text;
            gv.quequan = txtque.Text;
            gv.trinhdo = txttd.Text;
            gv.ngayvaolam = datenl.Value;
            gv.ngoaingu = txtnn.Text;
            gv.ghichu = txtghichu.Text;
            gv.tenban = cbxpb.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn lưu mã giáo viên không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(gv) > 0)
                {
                    MessageBox.Show("lưu thành công!");
                    giaovien_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }
        }



        private void butxoa_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("bạn chưa nhập thông tin!");
                return;
            }


            giaovien gv = new giaovien();
            gv.magv = txtma.Text;
            gv.ngayvaolam = datenl.Value;
            gv.ngaysinh = datens.Value;
            gv.tenban = cbxpb.Text;
            gv.tengv = txtten.Text;
            gv.tongiao = txttg.Text;
            gv.trinhdo = txttd.Text;
            gv.quequan = txtque.Text;
            gv.dantoc = txtdt.Text;
            gv.ngoaingu = txtnn.Text;
            gv.ghichu = txtghichu.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn xóa mã giáo viên này   không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(gv) > 0)
                {
                    MessageBox.Show(" Xóa thành công!");
                    giaovien_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi!");
            }
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "" || txtten.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            giaovien gv = new giaovien();
            gv.magv = txtma.Text;
            gv.ngayvaolam = datenl.Value;
            gv.ngaysinh = datens.Value;
            gv.tenban = cbxpb.Text;
            gv.tengv = txtten.Text;
            gv.tongiao = txttg.Text;
            gv.trinhdo = txttd.Text;
            gv.quequan = txtque.Text;
            gv.dantoc = txtdt.Text;
            gv.ngoaingu = txtnn.Text;
            gv.ghichu = txtghichu.Text;
            if (MessageBox.Show(string.Format("sửa thồng tin giáo viên"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(gv) > 0)
                {
                    MessageBox.Show("Đã sửa");
                    giaovien_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được sửa");
            }
        }
        public void Hienthi(string magv)
        {
            dgvgiaovien.DataSource = Bus.Timkiemgv(magv);
        }
        private void buttimkiem_Click(object sender, EventArgs e)
        {
            Hienthi(" Where magv  like '%" + txttimkiem.Text + "'");
        }

        private void txttimkiem_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = string.Empty;
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void datenl_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonphancong_Click(object sender, EventArgs e)
        {
            phanconggiangday phancong = new phanconggiangday();
            phancong.mesage = txtma.Text;
            phancong.Show();
        }

        private void lịchGiảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lichgiangday lgd = new lichgiangday();
            lgd.mesage  = txtma.Text;
            lgd.Show();
        }

        private void lịchGiạyThayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lichdaythay dt = new lichdaythay();
            dt.mesage = txtma.Text;
            dt.Show();
        }

        private void bảngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Luong luong = new Luong();
            luong.mesage = txtma.Text;
            luong.Show();
        }
    }


}