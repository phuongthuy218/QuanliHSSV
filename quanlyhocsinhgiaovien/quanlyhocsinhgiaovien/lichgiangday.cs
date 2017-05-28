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
    public partial class lichgiangday : Form
    {
        public lichgiangday()
        {
            InitializeComponent();
        }

         
        private void lichgiangday_Load(object sender, EventArgs e)
        {
            dgvlichgiangday.DataSource = Bus.Getlistlichgiangday();
            cbxma.DataSource = Bus.Getlistgiaovien();
            cbxma.ValueMember = "magv";
            cbxtimkiem.DataSource = Bus.Getlistgiaovien();
            cbxtimkiem.ValueMember = "magv";
            cbxten.DataSource = Bus.Getlistgiaovien();
            cbxten.ValueMember = "tengv";
            cbxmalh.DataSource = Bus.Getlistlophoc();
            cbxmalh.ValueMember = "malh";

        }

        private void dgvlichgiangday_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxma.Text = dgvlichgiangday.CurrentRow.Cells["magv"].Value.ToString();
            cbxten.Text = dgvlichgiangday.CurrentRow.Cells["tengv"].Value.ToString();
            txtcm.Text = dgvlichgiangday.CurrentRow.Cells["chuyenmon"].Value.ToString();
            txtgt.Text = dgvlichgiangday.CurrentRow.Cells["gioitinh"].Value.ToString();
            txtthu.Text = dgvlichgiangday.CurrentRow.Cells["thu"].Value.ToString();
            txtbuoi.Text = dgvlichgiangday.CurrentRow.Cells["buoi"].Value.ToString();
            txttiet.Text = dgvlichgiangday.CurrentRow.Cells["tiet"].Value.ToString();
            cbxmalh.Text = dgvlichgiangday.CurrentRow.Cells["malop"].Value.ToString();
            txttuan.Text = dgvlichgiangday.CurrentRow.Cells["tuan"].Value.ToString();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            cbxma.Text = String.Empty;
            cbxten.Text = string.Empty;
            txtcm.Text = string.Empty;
            txtgt.Text = string.Empty;
            txtthu.Text = string.Empty;
            txtbuoi.Text = string.Empty;
            txttiet.Text = string.Empty;
            cbxmalh.Text = string.Empty;
            txttuan.Text = string.Empty;
        }

        private void butluu_Click(object sender, EventArgs e)
        { 
            if (txtbuoi.Text == ""  )
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            giangday d = new giangday();
            d.magv = cbxma.Text;
            d.tengv = cbxten.Text;
            d.chuyenmon = txtcm.Text;
            d.gioitinh = txtgt.Text;
            d.thu = txtthu.Text;
            d.buoi = txtbuoi.Text;
            d.tiet = txttiet.Text;
            d.malop = cbxmalh.Text; 
            d.tuan = txttuan.Text; 

            if (MessageBox.Show(string.Format("Bạn có muốn lưu lịch dạy  mmới không?"),
               "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(d) > 0)
                {
                    MessageBox.Show("lưu thành công!");
                    lichgiangday_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }

        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if ( txtbuoi.Text == ""|| cbxma.Text=="")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            giangday d = new giangday();
            d.magv = cbxma.Text;
            d.tengv = cbxten.Text;
            d.chuyenmon = txtcm.Text;
            d.gioitinh = txtgt.Text;
            d.thu = txtthu.Text;
            d.buoi = txtbuoi.Text;
            d.tiet = txttiet.Text;
            d.malop = cbxmalh.Text;
            d.tuan = txttuan.Text;
            d.malop = cbxmalh.Text;
              
            if (MessageBox.Show(string.Format("Bạn có chắc muốn sửa lịch dạy này không?"),
               "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(d) > 0)
                {
                    MessageBox.Show("sửa  thành công!");
                    lichgiangday_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }
        }
       
        private void butxoa_Click(object sender, EventArgs e)
        {
            if (cbxma.Text == " ")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
           
            giangday d = new giangday();
            d.magv = cbxma.Text;
            d.tengv = cbxten.Text;
            d.chuyenmon = txtcm.Text;
            d.gioitinh = txtgt.Text;
            d.thu = txtthu.Text;
            d.buoi = txtbuoi.Text;
            d.tiet = txttiet.Text;
            d.malop = cbxmalh.Text;
            d.tuan = txttuan.Text;  
            d.malop = cbxmalh.Text;
             
            if (MessageBox.Show(string.Format("Bạn có chắc muốn xóa lịch dạy này không?"),
               "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(d) > 0)
                {
                    MessageBox.Show("xóa  thành công!");
                    lichgiangday_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }

        }
        public void Hienthi(string magv)
        {
            dgvlichgiangday.DataSource = Bus.Timkiemlichgiangday(magv);
        }
 
        private void buttimkiem_Click(object sender, EventArgs e)
        {
            Hienthi(" Where magv  like '%" + cbxtimkiem.Text + "'");
        }

       
        private void cbxtimkiem_Click_1(object sender, EventArgs e)
        {
            cbxtimkiem.Text = string.Empty;
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }
  
    }
}