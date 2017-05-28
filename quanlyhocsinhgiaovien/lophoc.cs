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
    public partial class lophoc : Form
    {
        public lophoc()
        {
            InitializeComponent();
        }
         
        private void lophoc_Load(object sender, EventArgs e)
        {
            dgvlophoc.DataSource = Bus.Getlistlophoc();
            cbxbh.DataSource = Bus.Getlistphongban();
            cbxbh.ValueMember = "tenban";
            cbxmagv.DataSource = Bus.Getlistgiaovien();
            cbxmagv.ValueMember = "magv"; 
        }

        

        private void dgvlophoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma.Text = dgvlophoc.CurrentRow.Cells["malh"].Value.ToString();
            cbxmagv.Text = dgvlophoc.CurrentRow.Cells["magvcn"].Value.ToString();
            txtsiso.Text = dgvlophoc.CurrentRow.Cells["siso"].Value.ToString();
            datenh.Text = dgvlophoc.CurrentRow.Cells["namnhaphoc"].Value.ToString();
            datekt.Text = dgvlophoc.CurrentRow.Cells["namketthuc"].Value.ToString();
            cbxbh.Text = dgvlophoc.CurrentRow.Cells["tenban"].Value.ToString();
             
        }
        private void butthem_Click_1(object sender, EventArgs e)
        {
            txtma.Text = String.Empty;
            cbxmagv.Text = String.Empty;
            txtsiso.Text = String.Empty;
            datenh.Value = DateTime.Now;
            datekt.Value = DateTime.Now;
            cbxbh.Text = String.Empty;
        }
 
        private void butluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text == ""||  cbxmagv.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

           lop  l=new lop ();
           l.malh = txtma.Text;
           l.magvcn=cbxmagv.Text ;
           l.siso = txtsiso.Text;
           l.namnhaphoc= datenh.Value;
           l.namketthuc=datekt.Value;
           l.tenban = cbxbh.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn lưu thêm lớp học này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(l) > 0)
                {
                    MessageBox.Show("lưu thành công!");
                    lophoc_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }
        }

        private void butsua_Click(object sender, EventArgs e)
        {
        
       
            if (txtma.Text == ""||  cbxmagv.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

           lop  l=new lop ();
           l.malh = txtma.Text;
           l.magvcn=cbxmagv.Text ;
           l.siso = txtsiso.Text;
           l.namnhaphoc= datenh.Value;
           l.namketthuc=datekt.Value;
           l.tenban = cbxbh.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn sửa lớp học này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(l) > 0)
                {
                    MessageBox.Show("sửa thành công lớp học !");
                    lophoc_Load(sender, e);
                }
                else MessageBox.Show("sửa bị Lỗi");
            }
        }

        private void butxoa_Click_1(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            lop l = new lop();
            l.malh = txtma.Text;
            l.magvcn = cbxmagv.Text;
            l.siso = txtsiso.Text;
            l.namnhaphoc = datenh.Value;
            l.namketthuc = datekt.Value;
            l.tenban = cbxbh.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn xóa lớp học này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(l) > 0)
                {
                    MessageBox.Show("xóa thành công   !");
                    lophoc_Load(sender, e);
                }
                else MessageBox.Show("không xóa được");
            }
        }

        public void Hienthi(string malh)
        {
            dgvlophoc.DataSource = Bus.Timkiemlophoc(malh);
        }

        private void buttimkiem_Click(object sender, EventArgs e)
        {
            Hienthi(" Where malh  like '%" + txttimkiem.Text + "'");
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
    
 
