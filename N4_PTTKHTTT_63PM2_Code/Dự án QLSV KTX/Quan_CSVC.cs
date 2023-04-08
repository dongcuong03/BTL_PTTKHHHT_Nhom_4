using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dự_án_QLSV_KTX
{
    public partial class Quan_CSVC : Form
    {
        public Quan_CSVC()
        {
            InitializeComponent();
        }
        string chuoiketnoi = "Data Source=LEQUAN-3012\\SQLEXPRESS;Initial Catalog=BTL_nhom4;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter dacsvc = new SqlDataAdapter();
        DataTable dtcsvc = new DataTable();
        private void Quan_CSDV_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string truyvan1 = "select maphong as\"Mã Phòng\", cua as\"Hệ Thống Cửa\", den as\"Hệ thống đèn điện\", tbvs as\"Trang thiết bị vệ sinh\", giuong as \"Giường\", tu as\"Tủ\", dieuhoa as\"Điều Hòa\", wifi as \"Wifi\"from csvc";
            dacsvc = new SqlDataAdapter(truyvan1, conn);
            dacsvc.Fill(dtcsvc);
            dgvcsvc.DataSource = dtcsvc;
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quan_TK_BC add = new Quan_TK_BC();
            add.ShowDialog();
            this.Close();
            
        }

    }
}
