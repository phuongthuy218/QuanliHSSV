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
    public partial class thongtinhocsinh : Form
    {
       

        public string ReturnedValue { get; private set; }

        public thongtinhocsinh()
        {
            InitializeComponent();
        }

        private void thongtinhocsinh_Load(object sender, EventArgs e)
        {

            dgvthannhan.DataSource = Bus.Getlistthannhan();
            dgvhocsinh.DataSource = Bus.Getlisthocsinh();
            cbxmalp.DataSource = Bus.Getlistlophoc();
            cbxmalp.ValueMember = "malh";
            cbxma.DataSource = Bus.Getlistthannhan();
            cbxma.ValueMember = "mahs";
            dgvthannhan.Enabled = false;
            grpthannhan.Enabled = false;
            butluu.Enabled = true;
            butsua.Enabled = true;
            butthem.Enabled = true;
            butthoat.Enabled = true;
            butxoa.Enabled = true;
            buttonsua.Enabled = true;
            buttonthem.Enabled = true;
            buttonluu.Enabled = true;
        }



        private void dgvhocsinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma.Text = dgvhocsinh.CurrentRow.Cells["mahs"].Value.ToString();
            cbxmalp.Text = dgvhocsinh.CurrentRow.Cells["malh"].Value.ToString();
            txtten.Text = dgvhocsinh.CurrentRow.Cells["tenhs"].Value.ToString();
            txtdc.Text = dgvhocsinh.CurrentRow.Cells["diachi"].Value.ToString();
            txtdt.Text = dgvhocsinh.CurrentRow.Cells["dantoc"].Value.ToString();
            datens.Text = dgvhocsinh.CurrentRow.Cells["ngaysinh"].Value.ToString();
            txtgt.Text = dgvhocsinh.CurrentRow.Cells["gioitinh"].Value.ToString();
            txtghichu.Text = dgvhocsinh.CurrentRow.Cells["ghichu"].Value.ToString();
            datenh.Text = dgvhocsinh.CurrentRow.Cells["ngaynhaptruong"].Value.ToString();
            datert.Text = dgvhocsinh.CurrentRow.Cells["ngayratruong"].Value.ToString();
            txtsk.Text = dgvhocsinh.CurrentRow.Cells["suckhoe"].Value.ToString();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            txtma.Text = string.Empty;
            cbxmalp.Text = string.Empty;
            txtten.Text = string.Empty;
            txtdc.Text = string.Empty;
            txtdt.Text = string.Empty;
            datens.Value = DateTime.Now;
            txtgt.Text = string.Empty;
            txtghichu.Text = string.Empty;
            datenh.Value = DateTime.Now;
            datert.Value = DateTime.Now;
            txtsk.Text = string.Empty;

            butsua.Enabled = false;
            butxoa.Enabled = false;
            butluu.Enabled = true;
            butthoat.Enabled=true;
             


        }

        private void butluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "" || txtten.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            hocsinh h = new hocsinh();
            h.mahs = txtma.Text;
            h.malh = cbxmalp.Text;
            h.tenhs = txtten.Text;
            h.diachi = txtdc.Text;
            h.dantoc = txtdt.Text;
            h.ngaysinh = datens.Value;
            h.gioitinh = txtgt.Text;
            h.ghichu = txtghichu.Text;
            h.ngaynhaphoc = datenh.Value;
            h.ngayratruong = datert.Value;
            h.suckhoe = txtsk.Text;


            if (MessageBox.Show(string.Format("Bạn có muốn lưu học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(h) > 0)
                {
                    MessageBox.Show("lưu thành công!");
                    thongtinhocsinh_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            hocsinh h = new hocsinh();
            h.mahs = txtma.Text;
            h.malh = cbxmalp.Text;
            h.tenhs = txtten.Text;
            h.diachi = txtdc.Text;
            h.dantoc = txtdt.Text;
            h.ngaysinh = datens.Value;
            h.gioitinh = txtgt.Text;
            h.ghichu = txtghichu.Text;
            h.ngaynhaphoc = datenh.Value;
            h.ngayratruong = datert.Value;
            h.suckhoe = txtsk.Text;


            if (MessageBox.Show(string.Format("Bạn có muốn sửa học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(h) > 0)
                {
                    MessageBox.Show("sửa thông tin thành công!");
                    thongtinhocsinh_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi thông tin !");
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "" || txtten.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            hocsinh h = new hocsinh();
            h.mahs = txtma.Text;
            h.malh = cbxmalp.Text;
            h.tenhs = txtten.Text;
            h.diachi = txtdc.Text;
            h.dantoc = txtdt.Text;
            h.ngaysinh = datens.Value;
            h.gioitinh = txtgt.Text;
            h.ghichu = txtghichu.Text;
            h.ngaynhaphoc = datenh.Value;
            h.ngayratruong = datert.Value;
            h.suckhoe = txtsk.Text;


            if (MessageBox.Show(string.Format("Bạn có muốn xóa học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(h) > 0)
                {
                    MessageBox.Show("xóa thông tin thành công!");
                    thongtinhocsinh_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi   !");
            }
        }
        public void Hienthi(string mahs)
        {
            dgvhocsinh.DataSource = Bus.Timkiemhocsinh(mahs);
        }


        private void buttimkiem_Click(object sender, EventArgs e)
        {
            Hienthi(" Where mahs  like '%" + txttimkiem.Text + "'");
        }
        private void txttimkiem_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = string.Empty;
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thongtinhocsinh thongtin = new thongtinhocsinh();
            ReturnedValue = dgvhocsinh.SelectedCells[0].Value.ToString();
            ReturnedValue = dgvthannhan.SelectedCells[0].Value.ToString();
            cbxma.Text = txtma.Text;
            grpthannhan.Enabled = true;  
            dgvthannhan.Enabled = true;

        }
        private void grpthannhan_Enter(object sender, EventArgs e)
        {

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

        private void cbxma_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = cbxma.SelectedItem as DataRowView;
            if (row != null)
            {
               txttenbo.Text = row["hotenbo"].ToString();
                datensbo.Text= row["ngaysinh"].ToString();
                txtdcbo.Text= row["diachi"].ToString();
                txtnnbo.Text= row["nghenghiep"].ToString();
                txttenme.Text= row["hotenme"].ToString();
                datensme.Text= row["ngaysinhme"].ToString();
                txtdcme.Text= row["diachime"].ToString();
                txtnnme.Text= row["nghenghiepme"].ToString();


            }
        }

        private void buttonthem_Click(object sender, EventArgs e)
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

            buttonluu.Enabled = true;
            buttonsua.Enabled = false;
            butsua.Enabled = false;
            butxoa.Enabled = false;
            butluu.Enabled = false;
            butthoat.Enabled = true;
        }

        private void buttonluu_Click(object sender, EventArgs e)
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

            buttonthem.Enabled = true;
            buttonluu.Enabled = true;
            buttonsua.Enabled = true;
            butsua.Enabled = false;
            butxoa.Enabled = false;
            butluu.Enabled = false;
            butthoat.Enabled = true;
            grpthannhan.Enabled = true;


            if (MessageBox.Show(string.Format("Bạn có muốn thoong tin liên hệ của  học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(t) > 0)
                {
                    MessageBox.Show("lưu thành công!");
                    thongtinhocsinh_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }
        }

        private void buttonsua_Click(object sender, EventArgs e)
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

            buttonthem.Enabled = true;
            buttonluu.Enabled = true;
            buttonsua.Enabled = true;
            butsua.Enabled = false;
            butxoa.Enabled = false;
            butluu.Enabled = false;
            butthoat.Enabled = true;
            grpthannhan.Enabled = true;

            if (MessageBox.Show(string.Format("Bạn có muốn sửa liên lạc của  học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(t) > 0)
                {
                    MessageBox.Show("sửa thông tin  thành công!");
                    thongtinhocsinh_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }
        }

        private void buttonchuyen_Click(object sender, EventArgs e)
        {
            thongtinhocsinh thongtin = new thongtinhocsinh();
            ReturnedValue = dgvhocsinh.SelectedCells[0].Value.ToString();
            ReturnedValue = dgvthannhan.SelectedCells[0].Value.ToString();
            txtma.Text = cbxma.Text;
            grpthannhan.Enabled = true;
            dgvthannhan.Enabled = true;
             
            }
        }
    }
 