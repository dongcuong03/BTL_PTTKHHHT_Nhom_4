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

namespace Dự_án_QLSV_KTX
{
    public partial class Thai_DSSVphong : Form
    {
        private string formcha;
        public Thai_DSSVphong()
        {
            InitializeComponent();
        }
        public Thai_DSSVphong(string formcha)
        {
            InitializeComponent();
            this.formcha = formcha;
        }
        string chuoiketnoi = "Data Source=LEQUAN-3012\\SQLEXPRESS;Initial Catalog=BTL_nhom4;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter dadssvphong = new SqlDataAdapter();
        DataTable dtdssvphong = new DataTable();
        private void Thai_DSSVphong_Load(object sender, EventArgs e)
        {
            bttenphong.Text = formcha;
            conn = new SqlConnection(chuoiketnoi);
            string truyvan = "select maphong as \"Mã phòng\", hoten as \"Họ tên\", lop as \"Lớp\" \r\nfrom themsinhvien\r\nwhere maphong ='" + bttenphong.Text + "'";
            dadssvphong = new SqlDataAdapter(truyvan, conn);
            dadssvphong.Fill(dtdssvphong);
            dgvdssvphong.DataSource = dtdssvphong;

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thai_Form1 add = new Thai_Form1();
            add.ShowDialog();
            this.Close();
        }
    }
}
