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
    public partial class fmCha : Form
    {
        public fmCha()
        {
            InitializeComponent();
        }

        // Đưa vào hàm có string trong đó
        private void LoadData(string data)
        {
            txtData.Text = "";
            txtData.Text = data;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //Khai báo biến đại diện cho from Con
            fmCon f = new fmCon();
            // Truyền Dữ Liệu cho From con Liên kết bằng 
            f.truyenData = new fmCon.TruyenChoCha(LoadData); //LoadData có tham số sting
            f.ShowDialog();
        }

        
    }
}
