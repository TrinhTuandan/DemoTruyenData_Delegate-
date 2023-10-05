using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoTruyenData
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "TuanDan" && txtPass.Text == "12356") 
            {
                MessageBox.Show("Đăng Nhập Thành Công");
                // Khởi Tạo hàm Main
                fmMain f = new fmMain(txtUser.Text,txtPass.Text);
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất bại"); ;
            }
        }
    }
}
