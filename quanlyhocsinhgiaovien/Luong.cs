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
    public partial class Luong : Form
    {
        public Luong()
        {
            InitializeComponent();
        }

        public string mesage
        {
            get { return cbxmagv.Text; }
            set { cbxmagv.Text = value; }
        }
        private void Luong_Load(object sender, EventArgs e)
        {
            dgvluong.DataSource = Bus.Getlistbangluong();
           
            butsua.Enabled = true;
            butthem.Enabled = true;
            butluu.Enabled = true;
            butthoat.Enabled = true;
            butthoat.Enabled = true;
            buttimkiem.Enabled = true;
            txttimkiem.Enabled = true;
           
        }
        private void dgvluong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxmagv.Text = dgvluong.CurrentRow.Cells["magv"].Value.ToString();
            txtlcb.Text = dgvluong.CurrentRow.Cells["luongcoban"].Value.ToString();
            txthsl.Text = dgvluong.CurrentRow.Cells["hesoluong"].Value.ToString();
            txtlpc.Text = dgvluong.CurrentRow.Cells["luongphucap"].Value.ToString();
            txtbhyt.Text = dgvluong.CurrentRow.Cells["BaoHiemYTe"].Value.ToString();
            txttl.Text = dgvluong.CurrentRow.Cells["TongLuong"].Value.ToString();
             
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            cbxmagv.Text = string.Empty;
            txtlcb.Text = string.Empty;
            txthsl.Text = string.Empty;
            txtlpc.Text = string.Empty;
            txtbhyt.Text = string.Empty;
            txttl.Text = string.Empty;

            butsua.Enabled = false;
            butthem.Enabled = true;
            butluu.Enabled = true;
            butthoat.Enabled = true; 
            buttimkiem.Enabled = true;
            txttimkiem.Enabled = true;
        }

        private void butluu_Click(object sender, EventArgs e)
        {
            if (cbxmagv.Text == "" )
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            bangluong bl = new bangluong();

            bl.magv = cbxmagv.Text;
            bl.luongcoban = txtlcb.Text;
            bl.hesoluong = txthsl.Text;
            bl.luongphucap = txtlpc.Text;
            bl.BaoHiemYTe = txtbhyt.Text;
            bl.TongLuong = txttl.Text;

            butthem.Enabled = false;

 

            if (MessageBox.Show(string.Format("Bạn có muốn lưu lương giáo viên không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(bl) > 0)
                {
                    MessageBox.Show("lưu thành công!");
                    Luong_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }
        }

        private void butsua_Click(object sender, EventArgs e)
        {

            if (cbxmagv.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            bangluong bl = new bangluong();
            bl.magv = cbxmagv.Text;
            bl.luongcoban = txtlcb.Text;
            bl.hesoluong = txthsl.Text;
            bl.luongphucap = txtlpc.Text;
            bl.BaoHiemYTe = txtbhyt.Text;
            bl.TongLuong = txttl.Text;

            butthem.Enabled = false;
 

            if (MessageBox.Show(string.Format("sửa thồng tin Lương giáo viên"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(bl) > 0)
                {
                    MessageBox.Show("Đã sửa");
                    Luong_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được sửa");
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }
   
        private void buttinh_Click(object sender, EventArgs e)
        {
            if (txthsl.Text != "" || txtlcb.Text != "")
                this.txttl.Text = ((float.Parse(txtlcb.Text) * float.Parse(txthsl.Text)) + (float.Parse(txtlpc.Text) * float.Parse(txthsl.Text)) - float.Parse(txtbhyt.Text)).ToString();

        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (cbxmagv.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            bangluong bl = new bangluong();
            bl.magv = cbxmagv.Text;
            bl.luongcoban = txtlcb.Text;
            bl.hesoluong = txthsl.Text;
            bl.luongphucap = txtlpc.Text;
            bl.BaoHiemYTe = txtbhyt.Text;
            bl.TongLuong = txttl.Text;

            if (MessageBox.Show(string.Format("Bạn có chắc muốn xóa lương giáo viên này không này không?"),
               "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(bl) > 0)
                {
                    MessageBox.Show("xóa  thành công!");
                    Luong_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }
        }
    }
}
