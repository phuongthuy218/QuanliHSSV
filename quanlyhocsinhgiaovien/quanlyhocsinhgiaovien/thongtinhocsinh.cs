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
        public thongtinhocsinh()
        {
            InitializeComponent();
        }

        private void thongtinhocsinh_Load(object sender, EventArgs e)
        {
            dgvhocsinh.DataSource = Bus.Getlisthocsinh();
            cbxmalp.DataSource = Bus.Getlistlophoc();
            cbxmalp.ValueMember = "malh";
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
            if (txtma.Text == ""  )
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

        
        
    }
}
