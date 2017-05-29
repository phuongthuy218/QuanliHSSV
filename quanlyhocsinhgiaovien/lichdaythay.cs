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
    public partial class lichdaythay : Form
    {
        public lichdaythay()
        {
            InitializeComponent();
        }
        public string mesage
        {
            get { return cbxgvn.Text; }
            set { cbxgvn.Text = value; }
        }
        private void lichdaythay_Load(object sender, EventArgs e)
        {
            dgvlichdaythay.DataSource = Bus.Getlistlichdaythay();

            cbxgvd.DataSource = Bus.Getlistgiaovien();
            cbxgvd.ValueMember = "magv";
            cbxlop.DataSource = Bus.Getlistlophoc();
            cbxlop.ValueMember = "malh";
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            txtthu.Text = string.Empty;
            txttuan.Text = string.Empty;
            txtbuoi.Text = string.Empty;
            txttiet.Text = string.Empty;
            cbxlop.Text = string.Empty;
            cbxgvn.Text = string.Empty;
        }

        private void dgvlichdaythay_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            txtthu.Text = dgvlichdaythay.CurrentRow.Cells["thu"].Value.ToString();
            txttuan.Text = dgvlichdaythay.CurrentRow.Cells["tuan"].Value.ToString();
            txtbuoi.Text = dgvlichdaythay.CurrentRow.Cells["buoi"].Value.ToString();
            txttiet.Text = dgvlichdaythay.CurrentRow.Cells["tiet"].Value.ToString();
            cbxlop.Text = dgvlichdaythay.CurrentRow.Cells["lop"].Value.ToString();
            cbxgvn.Text = dgvlichdaythay.CurrentRow.Cells["magiaoviennghi"].Value.ToString();
            cbxgvd.Text = dgvlichdaythay.CurrentRow.Cells["magiaoviendaythay"].Value.ToString();
        }

        private void butluu_Click(object sender, EventArgs e)
        {

            if (txtthu.Text == "" || txttuan.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            daythay dt = new daythay();
            dt.thu = txtthu.Text;
            dt.tuan = txttuan.Text;
            dt.buoi = txtbuoi.Text;
            dt.tiet = txttiet.Text;
            dt.lop = cbxlop.Text;
            dt.magiaoviennghi = cbxgvn.Text;
            dt.magiaoviendaythay = cbxgvd.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn lưu lịch dạy thay mmới không?"),
               "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(dt) > 0)
                {
                    MessageBox.Show("lưu thành công!");
                    lichdaythay_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }

        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if (txtthu.Text == "" || txttuan.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }

            daythay dt = new daythay();
            dt.thu = txtthu.Text;
            dt.tuan = txttuan.Text;
            dt.buoi = txtbuoi.Text;
            dt.tiet = txttiet.Text;
            dt.lop = cbxlop.Text;
            dt.magiaoviennghi = cbxgvn.Text;
            dt.magiaoviendaythay = cbxgvd.Text;
            if (MessageBox.Show(string.Format("sửa thồng tin dạy thay của giáo viên này không?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(dt) > 0)
                {
                    MessageBox.Show("Đã sửa");
                    lichdaythay_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được sửa");
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (txtthu.Text == "" || txttuan.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }

            daythay dt = new daythay();
            dt.thu = txtthu.Text;
            dt.tuan = txttuan.Text;
            dt.buoi = txtbuoi.Text;
            dt.tiet = txttiet.Text;
            dt.lop = cbxlop.Text;
            dt.magiaoviennghi = cbxgvn.Text;
            dt.magiaoviendaythay = cbxgvd.Text;
            if (MessageBox.Show(string.Format("bạn chắc muốn xóa thồng tin dạy thay của giáo viên này? "), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(dt) > 0)
                {
                    MessageBox.Show("đã xóa");
                    lichdaythay_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được xóa");
            }
        }
        public void Hienthi(string magiaoviendaythay)
        {
            dgvlichdaythay.DataSource = Bus.Timkiemlichdaythay(magiaoviendaythay);
        } 
        private void txttimkiem_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = string.Empty;
        }


        private void buttimkiem_Click(object sender, EventArgs e)
        {
            Hienthi(" Where magiaoviendaythay  like '%" + txttimkiem.Text + "'");
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        
    }




}