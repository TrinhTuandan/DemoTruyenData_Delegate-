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
    public partial class fmCon : Form
    {
        //Tạo delegate 
        public delegate void TruyenChoCha(string text);
        public TruyenChoCha truyenData;
        //---------------------------------
        public fmCon()
        {
            InitializeComponent();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            if (txtData.Text.Length > 0 ) 
            {
                //gọi ra delegate hàm chứa là truyendata để sử dụng
                if(truyenData != null)
                    truyenData(txtData.Text);
            }
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {               
                //gọi ra delegate hàm chứa là truyendata để sử dụng
                if (truyenData != null)
                    truyenData(txtData.Text);
                // Gửi dữ liệu ngay lập tức
        }
    }
}
