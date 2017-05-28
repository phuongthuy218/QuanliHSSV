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
using System.Data.SqlClient;
using System.Collections;
namespace quanlyhocsinhgiaovien
{
    public partial class banbomon : Form  
    {
         
        public banbomon()
        {
            InitializeComponent();
        }

        private void banbomon_Load(object sender, EventArgs e)
        {
            dgvphongban.DataSource = Bus.Getlistphongban();
        }

        private void dgvphongban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtten.Text = dgvphongban.CurrentRow.Cells["tenban"].Value.ToString();
            txttb.Text = dgvphongban.CurrentRow.Cells["truongban"].Value.ToString();
            txtsogv.Text = dgvphongban.CurrentRow.Cells["sogvdg"].Value.ToString();

        } 
        private void butxoa_Click(object sender, EventArgs e)
        {
            if (txtten.Text == "")
            {
                MessageBox.Show("bạn chưa nhập thông tin!");
                return;
            }
            phongban bm = new phongban();
            bm.tenban = txtten.Text;
            bm.truongban = txttb.Text;
            bm.sogvdg = txtsogv.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn xóa tên ban này   không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(bm) > 0)
                {
                    MessageBox.Show(" Xóa thành công!");
                    banbomon_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi!");
            }
        }

        
        public void Hienthi(string tenban)
        {
            dgvphongban.DataSource = Bus.Timkiembm(tenban);
        }
        private void buttimkiem_Click(object sender, EventArgs e)
        {
            Hienthi(" where tenban like N'%" + txttimkiem.Text + "%'");
        }

        private void txttimkiem_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = string.Empty;
        }
 
        private void butthem_Click_1(object sender, EventArgs e)
        {
            txtten.Text = string.Empty;
            txttb.Text = string.Empty;
            txtsogv.Text = string.Empty;
        }
 
        private void butsua_Click_1(object sender, EventArgs e)
        {

            if (txtten.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            phongban bm = new phongban();
            bm.tenban = txtten.Text;
            bm.truongban = txttb.Text;
            bm.sogvdg = txtsogv.Text;
            if (MessageBox.Show(string.Format("sửa thồng tin ban bộ môn "), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(bm) > 0)
                {
                    MessageBox.Show("Đã sửa thành công ");
                    banbomon_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được sửa");
            }
        }

        private void butluu_Click(object sender, EventArgs e)
        {

            if (txtten.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            phongban bm = new phongban();
            bm.tenban = txtten.Text;
            bm.truongban = txttb.Text;
            bm.sogvdg = txtsogv.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn lưu tên ban bộ môn này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(bm) > 0)
                {
                    MessageBox.Show("lưu thành công rồi !");
                    banbomon_Load(sender, e);
                }
                else MessageBox.Show("thông tin bị Lỗi");
            }
        }

        private void butthoat_Click_1(object sender, EventArgs e)
        {

            Dispose();

        }
    }

    }


 
