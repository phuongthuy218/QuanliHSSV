using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlyhocsinhgiaovien
{
    public partial class loginfrm : Form
    {
        public loginfrm()
        {
            InitializeComponent();
        }


        private void butlogin_Click(object sender, EventArgs e)

        {

            SqlConnection cn = new SqlConnection(@"Data Source=ADMINS\SQLEXPRESS;Initial Catalog=QuanLyHSGV;Integrated Security=True"); 
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from admin where tendangnhap = '" + textnguoidung.Text + "' and  matkhau ='" + textmatkhau.Text + " '  ", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                frmqlhsgv fr = new frmqlhsgv();
                fr.Show();
            }
            else
            {
                MessageBox.Show("sai mật khẩu hoặc tên đăng nhập ");

            }
            textmatkhau.Clear();
            textnguoidung.Clear();

        }
        private void butexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void loginfrm_Load(object sender, EventArgs e)
        {

        }

    }
}

        
    