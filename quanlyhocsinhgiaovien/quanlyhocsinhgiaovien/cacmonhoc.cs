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
    public partial class cacmonhoc : Form
    {
        public cacmonhoc()
        {
            InitializeComponent();
        }

        private void cacmonhoc_Load(object sender, EventArgs e)
        {
            dgvmonhoc.DataSource = Bus.Getlistmonhoc();
        }

        private void dgvmonhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma.Text = dgvmonhoc.CurrentRow.Cells["mamh"].Value.ToString();
            txtten.Text = dgvmonhoc.CurrentRow.Cells["tenmonhoc"].Value.ToString();

        }

        private void butthem_Click(object sender, EventArgs e)
        {
            txtma.Text = String.Empty;
            txtten.Text = String.Empty;
        }

        private void butluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "" || txtten.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            monhoc m = new monhoc();
            m.mamh = txtma.Text;
            m.tenmonhoc = txtten.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn lưu thêm môn học này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(m) > 0)
                {
                    MessageBox.Show("lưu thành công!");
                    cacmonhoc_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "" || txtten.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            monhoc m = new monhoc();
            m.mamh = txtma.Text;
            m.tenmonhoc = txtten.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn sửa môn học này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(m) > 0)
                {
                    MessageBox.Show("sửa thành công!");
                    cacmonhoc_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "" || txtten.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            monhoc m = new monhoc();
            m.mamh = txtma.Text;
            m.tenmonhoc = txtten.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn xóa  môn học này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(m) > 0)
                {
                    MessageBox.Show("xóa thành công!");
                    cacmonhoc_Load(sender, e);
                }
                else MessageBox.Show("chưa xóa được! ");
            }
        }
        public void Hienthi(string tenmonhoc)
        {
            dgvmonhoc.DataSource = Bus.Timkiemmonhoc(tenmonhoc);
        }
        private void buttimkiem_Click(object sender, EventArgs e)
        {
            Hienthi(" Where tenmonhoc  like N'%" + txttimkiem.Text + "%'");
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
