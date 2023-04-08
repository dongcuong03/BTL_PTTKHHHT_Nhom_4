using Sinhhoatphi;
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
using System.Data.SqlClient;

namespace Dự_án_QLSV_KTX
{
    public partial class Thai_Thongtinshp : Form
    {
        private string formcha;
        public Thai_Thongtinshp()
        {
            InitializeComponent();
        }
        string chuoiketnoi = "Data Source=LEQUAN-3012\\SQLEXPRESS;Initial Catalog=BTL_nhom4;Integrated Security=True";
        SqlConnection conn = null;
        public Thai_Thongtinshp(string formcha)
        {
            InitializeComponent();
            this.formcha = formcha;
        }

        private void Thai_Thongtinshp_Load(object sender, EventArgs e)
        {
            bttenphong.Text = formcha;
            conn = new SqlConnection(chuoiketnoi);
            DataTable dtshp = new DataTable();
            conn.Open();
            string truyvan = "select maphong as \"Mã Phòng\",thang as \"Tháng\",tiendien as \"Tiền điện\", tiennuoc as \"Tiền nước\", tienwifi as \"Tiền Wifi\", tienphong as \"Tiền phòng \", sum(tiendien +tiennuoc+tienwifi+tienphong)as \"Tổng tiền\"\r\nfrom sinhhoatphi \r\nwhere maphong ='" + bttenphong.Text + "'\r\ngroup by maphong ,thang,tiendien, tiennuoc, tienwifi, tienphong";
            SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
            dtshp.Rows.Clear();
            da.Fill(dtshp);
            dataGridView1.DataSource = dtshp;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string formcha = bttenphong.Text;
            this.Hide();
            Thai_DSSVphong add = new Thai_DSSVphong(formcha);            
            add.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thai_Capnhatthongtin them = new Thai_Capnhatthongtin(formcha);
            them.ShowDialog();
            this.Close();

        }

        private void bttenphong_Click(object sender, EventArgs e)
        {

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thai_Form1 add = new Thai_Form1();
            add.ShowDialog();
            this.Close();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
