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
    public partial class frmQL_SinhVien : Form
    {
        public frmQL_SinhVien()
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
                fDangNhap.ShowDialog();
            }
        }

        private void btnBCTKimg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quan_TK_BC add = new Quan_TK_BC();
            add.ShowDialog();
            this.Close();
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ha1_qlsv add = new Ha1_qlsv();
            add.ShowDialog(this);
            this.Close();
        }
    }
}
