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
    public partial class Bangdiem : Form
    {
        public Bangdiem()
        {
            InitializeComponent();
        }

        
        private void Bangdiem_Load(object sender, EventArgs e)
        {
            dgvbangdiem.DataSource = Bus.Getlistbangdiem();
            cbxmahs.DataSource = Bus.Getlisthocsinh();
            cbxmahs.ValueMember = "mahs"; 
            cbxgv.DataSource = Bus.Getlistgiaovien();
            cbxgv.ValueMember = "magv";
        }

        private void dgvbangdiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtma.Text = dgvbangdiem.CurrentRow.Cells["mabd"].Value.ToString();
            cbxmahs.Text = dgvbangdiem.CurrentRow.Cells["mahs"].Value.ToString();
            txttb.Text = dgvbangdiem.CurrentRow.Cells["diemtb"].Value.ToString();
            txttoan.Text = dgvbangdiem.CurrentRow.Cells["diemtoan"].Value.ToString();
            txtvan.Text = dgvbangdiem.CurrentRow.Cells["diemvan"].Value.ToString();
            txtanh.Text = dgvbangdiem.CurrentRow.Cells["diemanh"].Value.ToString();
            txthoa.Text = dgvbangdiem.CurrentRow.Cells["diemhoa"].Value.ToString();
            txtly.Text = dgvbangdiem.CurrentRow.Cells["diemly"].Value.ToString();
            txtsinh.Text = dgvbangdiem.CurrentRow.Cells["diemsinh"].Value.ToString();
            txtsu.Text = dgvbangdiem.CurrentRow.Cells["diemsu"].Value.ToString();
            txtdia.Text = dgvbangdiem.CurrentRow.Cells["diemdia"].Value.ToString();
            cbxgv.Text = dgvbangdiem.CurrentRow.Cells["giaovienquanly"].Value.ToString();

        }

        private void butthem_Click(object sender, EventArgs e)
        {
            txtma.Text = string.Empty;
            cbxmahs.Text = string.Empty;
            txttb.Text = string.Empty;
            txttoan.Text = string.Empty;
            txtvan.Text = string.Empty;
            txtanh.Text = string.Empty;
            txthoa.Text = string.Empty;
            txtly.Text = string.Empty;
            txtsinh.Text = string.Empty;
            txtsu.Text = string.Empty;
            txtdia.Text = string.Empty;
            cbxgv.Text = string.Empty;

        }
        
            private void butluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
              bangdiem b=new bangdiem();
                b.mabd=txtma.Text;
                b.mahs=cbxmahs.Text ;
                b.diemtb=txttb.Text;
                b.diemtoan=txttoan.Text;
                b.diemvan=txtvan.Text;
                b.diemanh=txtanh.Text;
                b.diemhoa=txthoa.Text;
                b.diemly=txtly.Text;
                b.diemsinh=txtsinh.Text;
                b.diemsu=txtsu.Text;
                b.diemdia=txtdia.Text;
                b.giaovienquanly=cbxgv.Text;


            if (MessageBox.Show(string.Format("Bạn có muốn lưu Bang diem của  học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(b) > 0)
                {
                    MessageBox.Show("lưu thành công!");
                    Bangdiem_Load(sender, e);
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
              bangdiem b=new bangdiem();
                b.mabd=txtma.Text;
                b.mahs=cbxmahs.Text ;
                b.diemtb=txttb.Text;
                b.diemtoan=txttoan.Text;
                b.diemvan=txtvan.Text;
                b.diemanh=txtanh.Text;
                b.diemhoa=txthoa.Text;
                b.diemly=txtly.Text;
                b.diemsinh=txtsinh.Text;
                b.diemsu=txtsu.Text;
                b.diemdia=txtdia.Text;
                b.giaovienquanly=cbxgv.Text;


            if (MessageBox.Show(string.Format("Bạn có muốn sửq Bang diem của  học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(b) > 0)
                {
                    MessageBox.Show("sửa điểm  thành công!");
                    Bangdiem_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
        if (txtma.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
              bangdiem b=new bangdiem();
                b.mabd=txtma.Text;
                b.mahs=cbxmahs.Text ;
                b.diemtb=txttb.Text;
                b.diemtoan=txttoan.Text;
                b.diemvan=txtvan.Text;
                b.diemanh=txtanh.Text;
                b.diemhoa=txthoa.Text;
                b.diemly=txtly.Text;
                b.diemsinh=txtsinh.Text;
                b.diemsu=txtsu.Text;
                b.diemdia=txtdia.Text;
                b.giaovienquanly=cbxgv.Text;


            if (MessageBox.Show(string.Format("Bạn có muốn xóa Bang diem của  học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(b) > 0)
                {
                    MessageBox.Show("xóa thành công!");
                    Bangdiem_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }
        }
         public void Hienthi(string mabd)
        {
           dgvbangdiem.DataSource = Bus.Timkiembangdiem(mabd);
        }
        private void buttimkiem_Click(object sender, EventArgs e)
        {
        Hienthi(" Where mabd  like '%" + txttimkiem.Text + "'");
        }

        private void txttimkiem_Click(object sender, EventArgs e)
        {
        txttimkiem.Text=string.Empty;
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
