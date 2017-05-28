using quanlyhocsinhgiaovien.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlyhocsinhgiaovien.ValueObject;
namespace quanlyhocsinhgiaovien
{
    public partial class Kỷ_Luật : Form
    {
        
        public Kỷ_Luật()
        {
            InitializeComponent();


        }
        public string mesage
        {
            get { return cbxhs.Text; }
            set { cbxhs.Text = value; }
        }
        private void Kỷ_Luật_Load(object sender, EventArgs e)
        {
            dgvkyluat.DataSource = Bus.Getlistkyluat();
             
            cbxhs.Text = mesage;
            butluu.Enabled = true;
            butsua.Enabled = true;
            butthem.Enabled = true;
            butthoat.Enabled = true;


        }
        private void butthoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dgvkyluat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxhs.Text = dgvkyluat.CurrentRow.Cells["mahs"].Value.ToString();
            txthinhthuc.Text = dgvkyluat.CurrentRow.Cells["hinhthuc"].Value.ToString();
            txtlydo.Text = dgvkyluat.CurrentRow.Cells["lydo"].Value.ToString();
            datenkl.Text = dgvkyluat.CurrentRow.Cells["ngaykyluat"].Value.ToString();
            txtghichu.Text = dgvkyluat.CurrentRow.Cells["ghichu"].Value.ToString();
        }

        private void butluu_Click(object sender, EventArgs e)
        {
            if (cbxhs.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            kyluat kl = new kyluat();

            kl.mahs = cbxhs.Text;
            kl.hinhthuc = txthinhthuc.Text;
            kl.ngaykyluat = datenkl.Value;
            kl.lydo = txtlydo.Text;
            kl.ghichu = txtghichu.Text;


            if (MessageBox.Show(string.Format("Bạn có muốn thông tin kỷ luật của  học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(kl) > 0)
                {
                    MessageBox.Show("lưu thành công!");
                    Kỷ_Luật_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }

        }

        private void butthem_Click(object sender, EventArgs e)
        {
            cbxhs.Text = string.Empty;
            txthinhthuc.Text = string.Empty;
            datenkl.Text = string.Empty;
            txtlydo.Text = string.Empty;
            txtghichu.Text = String.Empty;

            butsua.Enabled = false;
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if (cbxhs.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            kyluat kl = new kyluat();

            kl.mahs = cbxhs.Text;
            kl.hinhthuc = txthinhthuc.Text;
            kl.ngaykyluat = datenkl.Value;
            kl.lydo = txtlydo.Text;
            kl.ghichu = txtghichu.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn sửa kỷ luật của  học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(kl) > 0)
                {
                    MessageBox.Show("sửa thành công!");
                    Kỷ_Luật_Load(sender, e);
                }
                else MessageBox.Show("đang bị lỗi@");
            }
        }

        private void cbxhs_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = cbxhs.SelectedItem as DataRowView;
            if (row != null)
            {
                txthinhthuc.Text = row[2].ToString();
                txtlydo.Text = row[3].ToString();
                datenkl.Text = row[4].ToString();
                txtghichu.Text = row[5].ToString();
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (cbxhs.Text == ""  )
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            kyluat kl = new kyluat();

            kl.mahs = cbxhs.Text;
            kl.hinhthuc = txthinhthuc.Text;
            kl.ngaykyluat = datenkl.Value;
            kl.lydo = txtlydo.Text;
            kl.ghichu = txtghichu.Text;


            if (MessageBox.Show(string.Format("Bạn có muốn xóa kỷ luật học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(kl) > 0)
                {
                    MessageBox.Show("xóa thông tin thành công!");
                    Kỷ_Luật_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi   !");
            }
        }
    }
}
