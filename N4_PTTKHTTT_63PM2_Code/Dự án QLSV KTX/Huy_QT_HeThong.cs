using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dự_án_QLSV_KTX
{
    public partial class frmQT_HeThong : Form
    {
        public frmQT_HeThong()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Thai_Form1 add = new Thai_Form1();
            add.ShowDialog();
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Bạn có muốn đăng xuất không? ", "Đăng xuất tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
               this.Hide();
               frmDangNhap fDangNhap = new frmDangNhap();
               this.Close();
               fDangNhap.ShowDialog();
           }
            
        }


        private void btnQLSVimg_Click(object sender, EventArgs e)
        {
            Ha1_qlsv add = new Ha1_qlsv();
            add.ShowDialog();
        }

        private void btnQLTKimg_Click(object sender, EventArgs e)
        {
            Quan_QLTK add = new Quan_QLTK();
            add.ShowDialog();
            
        }

        private void btnQLPimg_Click(object sender, EventArgs e)
        {
            Qly_Phong add = new Qly_Phong();
            add.ShowDialog(this);
        }

        private void btnBCTKimg_Click(object sender, EventArgs e)
        {
            Quan_TK_BC add = new Quan_TK_BC();
            add.ShowDialog(this);
        }

    }
}
