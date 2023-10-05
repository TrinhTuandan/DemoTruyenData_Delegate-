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
    public partial class fmMain : Form
    {
        // Tạo Biến chứa tham số
        private string username, password;
        public fmMain()
        {
            InitializeComponent();
        }
        // Tạo Biến Truyền Tham Số Mới
        public fmMain(string user , string pass)
        {
            InitializeComponent();
            this.username = user;
            this.password = pass;
        }

        // Bắt sự kiện from load
        private void fmMain_Load(object sender, EventArgs e)
        {
            lbUser.Text = username;
            lbPass.Text = password;
        }
    }
}
