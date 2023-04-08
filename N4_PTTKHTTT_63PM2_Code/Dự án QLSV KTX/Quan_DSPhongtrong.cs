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
    public partial class Quan_DSPhongtrong : Form
    {
        public Quan_DSPhongtrong()
        {
            InitializeComponent();
        }
        string chuoiketnoi = "Data Source=LEQUAN-3012\\SQLEXPRESS;Initial Catalog=BTL_nhom4;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter dadsphongtrong = new SqlDataAdapter();
        DataTable dtdsphongtrong = new DataTable();
        private void Quan_Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string truyvan2 = "select maphong as \"Mã phòng\", count(*) as \"Số SV đang ở\",(8-count(*)) as \"Số chỗ trống\"\r\nfrom themsinhvien\r\ngroup by maphong";
            dadsphongtrong = new SqlDataAdapter(truyvan2, conn);
            dadsphongtrong.Fill(dtdsphongtrong);
            dgvdsphongtrong.DataSource = dtdsphongtrong;
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
