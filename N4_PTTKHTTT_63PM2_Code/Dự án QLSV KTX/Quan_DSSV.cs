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
    public partial class Quan_DSSV : Form
    {
        public Quan_DSSV()
        {
            InitializeComponent();
        }
        string chuoiketnoi = "Data Source=LEQUAN-3012\\SQLEXPRESS;Initial Catalog=BTL_nhom4;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter dadssv = new SqlDataAdapter();
        DataTable dtdssv = new DataTable();
        private void Quan_DSSV_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string truyvan5 = "select msv as \"Mã sinh viên\", maphong as \"Mã phòng\", hoten as \"Họ tên\", ngaysinh as \"Ngày sinh\", gioitinh as \"Giới tính\", cccd as\" số CCCD\" , quequan as\" Quê quán\", lop as\" Lớp\" from themsinhvien";
            dadssv = new SqlDataAdapter(truyvan5, conn);
            dadssv.Fill(dtdssv);
            dgvdssv.DataSource = dtdssv;
            bttongsv.Text = "Tổng sinh viên: " + (dtdssv.Rows.Count).ToString();
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
