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
    public partial class chitietdiem : Form
    {
        public chitietdiem()
        {
            InitializeComponent();
        }
         
        private void chitietdiem_Load(object sender, EventArgs e)
        {
            
            dgvchitietbangdiem.DataSource = Bus.Getlistchitietbangdiem(); 
            cbxmahs.DataSource = Bus.Getlisthocsinh();
            cbxmahs.ValueMember = "mahs"; 
            
            cbxmamh.DataSource = Bus.Getlistmonhoc();
            cbxmamh.ValueMember = "mamh";
            cbxtimkiem.DataSource = Bus.Getlisthocsinh();
            cbxtimkiem.ValueMember = "mahs";
            
        }
         
        private void dgvchitietbangdiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
            txtma.Text = dgvchitietbangdiem.CurrentRow.Cells["mactd"].Value.ToString();
            cbxmahs.Text = dgvchitietbangdiem.CurrentRow.Cells["mahs"].Value.ToString();
            cbxmamh.Text = dgvchitietbangdiem.CurrentRow.Cells["mamh"].Value.ToString();
            txtdm.Text = dgvchitietbangdiem.CurrentRow.Cells["diemmieng"].Value.ToString();
            txt15p1.Text = dgvchitietbangdiem.CurrentRow.Cells["diem15p1"].Value.ToString();
            txt15p2.Text = dgvchitietbangdiem.CurrentRow.Cells["diem15p2"].Value.ToString();
            txt45p1.Text = dgvchitietbangdiem.CurrentRow.Cells["diem45p1"].Value.ToString();
            txt45p2.Text = dgvchitietbangdiem.CurrentRow.Cells["diem45p2"].Value.ToString();
            txthk.Text = dgvchitietbangdiem.CurrentRow.Cells["diemhocky"].Value.ToString();
            txttb.Text = dgvchitietbangdiem.CurrentRow.Cells["diemtbmon"].Value.ToString();
            

        }

        private void butthem_Click(object sender, EventArgs e)
        {
            txtma.Text = string.Empty;
            cbxmahs.Text = string.Empty;
            cbxmamh.Text = string.Empty;
            txtdm.Text = string.Empty;
            txt15p1.Text = string.Empty;
            txt15p2.Text = string.Empty;
            txt45p1.Text = string.Empty;
            txt45p2.Text = string.Empty;
            txthk.Text = string.Empty;
            txttb.Text = string.Empty;
            cbxmabd.Text = string.Empty;

        }

        private void butluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            chitietbangdiem ct = new chitietbangdiem();
             ct.mactd  = txtma.Text;
             ct.mahs = cbxmahs.Text;
             ct.mamh =  cbxmamh.Text;
             ct.diemmieng = txtdm.Text;
             ct.diem15p1 = txt15p1.Text;
             ct.diem15p2 = txt15p2.Text;
             ct.diem45p1 = txt45p1.Text;
             ct.diem45p2 = txt45p2.Text;
             ct.diemhocky = txthk.Text;
             ct.diemtbmon = txttb.Text;
            

            if (MessageBox.Show(string.Format("Bạn có muốn lưu chi tiết Bang diem của  học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(ct) > 0)
                {
                    MessageBox.Show("lưu thành công!");
                    chitietdiem_Load(sender, e);
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
            chitietbangdiem ct = new chitietbangdiem();
            ct.mactd = txtma.Text;
            ct.mahs = cbxmahs.Text;
            ct.mamh = cbxmamh.Text;
            ct.diemmieng = txtdm.Text;
            ct.diem15p1 = txt15p1.Text;
            ct.diem15p2 = txt15p2.Text;
            ct.diem45p1 = txt45p1.Text;
            ct.diem45p2 = txt45p2.Text;
            ct.diemhocky = txthk.Text;
            ct.diemtbmon = txttb.Text;
           

            if (MessageBox.Show(string.Format("Bạn có muốn sửa chi tiết Bang diem của  học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(ct) > 0)
                {
                    MessageBox.Show("sửa điểm  thành công!");
                    chitietdiem_Load(sender, e);
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
            chitietbangdiem ct = new chitietbangdiem();
            ct.mactd = txtma.Text;
            ct.mahs = cbxmahs.Text; 
            ct.mamh = cbxmamh.Text;
            ct.diemmieng = txtdm.Text;
            ct.diem15p1 = txt15p1.Text;
            ct.diem15p2 = txt15p2.Text;
            ct.diem45p1 = txt45p1.Text;
            ct.diem45p2 = txt45p2.Text;
            ct.diemhocky = txthk.Text;
            ct.diemtbmon = txttb.Text;
            
            if (MessageBox.Show(string.Format("Bạn có muốn xóa chi tiết Bang diem của  học sinh này không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(ct) > 0)
                {
                    MessageBox.Show("xóa điểm  thành công!");
                    chitietdiem_Load(sender, e);
                }
                else MessageBox.Show("bị Lỗi");
            }
        }
        public void Hienthi(string mahs)
        {
            dgvchitietbangdiem.DataSource = Bus.Timkiemchitietbangdiem(mahs);
        }
        private void buttimkiem_Click(object sender, EventArgs e)
        {
            Hienthi(" Where mahs  like '%" + cbxtimkiem.Text + "'");
        }

        private void cbxtimkiem_Click(object sender, EventArgs e)
        {
            cbxtimkiem.Text = string.Empty;
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }
  

        private void buttinh_Click(object sender, EventArgs e)
        { 
            if (txtdm.Text != "" || txt15p1.Text != "")
                txttb.Text = (((float.Parse(txt15p1.Text) + float.Parse(txt15p2.Text)) / 2 + ((float.Parse(txt45p1.Text) + float.Parse(txt45p2.Text)) / 2) * 2 + (float.Parse(txthk.Text) * 3)) / 6).ToString();
        }
    }
    }

