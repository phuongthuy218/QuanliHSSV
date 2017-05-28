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
    public partial class phanconggiangday : Form
    {
        public phanconggiangday()
        {
            InitializeComponent();
        }
 
        private void dgvphancong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxma.Text = dgvphancong.CurrentRow.Cells["magv"].Value.ToString();
            cbxten.Text = dgvphancong.CurrentRow.Cells["tengv"].Value.ToString();
            datetn.Text = dgvphancong.CurrentRow.Cells["tungay"].Value.ToString();
            datedn.Text = dgvphancong.CurrentRow.Cells["denngay"].Value.ToString();
            txtct.Text = dgvphancong.CurrentRow.Cells["congtac"].Value.ToString();
            txtghichu.Text = dgvphancong.CurrentRow.Cells["ghichu"].Value.ToString();
        }

        private void phanconggiangday_Load(object sender, EventArgs e)
        {
            dgvphancong.DataSource = Bus.Getlistphancong();
            cbxma.DataSource = Bus.Getlistgiaovien();
            cbxma.ValueMember = "magv";
            cbxten.DataSource = Bus.Getlistgiaovien();
            cbxten.ValueMember = "tengv";
            cbxtimkiem.DataSource = Bus.Getlistgiaovien();
            cbxtimkiem.ValueMember = "magv";
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            cbxma.Text = string.Empty;
            cbxten.Text = string.Empty;
            datetn.Value = DateTime.Now;
            datedn.Value = DateTime.Now;
            txtct.Text = string.Empty;
            txtghichu.Text = string.Empty;

        }

        private void butluu_Click(object sender, EventArgs e)
        {
            if (cbxma.Text == ""||cbxten.Text=="")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            phancong c = new phancong();
            c.magv = cbxma.Text;
            c.tengv = cbxten.Text;
            c.tungay = datetn.Value;
            c.denngay = datedn.Value;
            c.congtac = txtct.Text;
            c.ghichu = txtghichu.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn lưu lịch công tác  mmới không?"),
               "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(c) > 0)
                {
                    MessageBox.Show("lưu thành công!");
                    phanconggiangday_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }

        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if (cbxma.Text == "" || cbxten.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            phancong c = new phancong();
            c.magv = cbxma.Text;
            c.tengv = cbxten.Text;
            c.tungay = datetn.Value;
            c.denngay = datedn.Value;
            c.congtac = txtct.Text;
            c.ghichu = txtghichu.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn sửa lịch công tác  mmới không?"),
               "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(c) > 0)
                {
                    MessageBox.Show("sửa thành công!");
                    phanconggiangday_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }


        }

        private void butxoa_Click(object sender, EventArgs e)
        {
             if (cbxma.Text == "" || cbxten.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            phancong c = new phancong();
            c.magv = cbxma.Text;
            c.tengv = cbxten.Text;
            c.tungay = datetn.Value;
            c.denngay = datedn.Value;
            c.congtac = txtct.Text;
            c.ghichu = txtghichu.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn xóa lịch công tác  mmới không?"),
               "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(c) > 0)
                {
                    MessageBox.Show("xóa thành công!");
                    phanconggiangday_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }

        }
        public void Hienthi(string magv)
        {
            dgvphancong.DataSource = Bus.Timkiemlichphancong(magv);
        }

        private void buttimkiem_Click(object sender, EventArgs e)
        {
            Hienthi(" Where magv  like '%" + cbxtimkiem.Text + "'");
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
