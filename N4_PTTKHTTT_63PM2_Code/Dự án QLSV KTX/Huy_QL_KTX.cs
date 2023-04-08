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
    public partial class frmQL_KTX : Form
    {
        public frmQL_KTX()
        {
            InitializeComponent();
        }
        private void DangXuat_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Bạn có muốn đăng xuất không? ", "Đăng xuất tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
                this.Hide();
                frmDangNhap fDangNhap = new frmDangNhap();
                this.Close();
               fDangNhap.Show();
           }
        }


        private void btnQLSHPimg_Click(object sender, EventArgs e)
        {
            Thai_Form1 add = new Thai_Form1();
            add.ShowDialog();
        }

        private void btnBCTKimg_Click(object sender, EventArgs e)
        {
            Quan_TK_BC add = new Quan_TK_BC();
            add.ShowDialog(this);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Qly_Phong add = new Qly_Phong();
            add.ShowDialog();
        }
    }
}
