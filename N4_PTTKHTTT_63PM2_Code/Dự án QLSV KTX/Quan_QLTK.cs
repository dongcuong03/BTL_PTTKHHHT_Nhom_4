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
    public partial class Quan_QLTK : Form
    {
        public Quan_QLTK()
        {
            InitializeComponent();
        }
        string chuoiketnoi = "Data Source=LEQUAN-3012\\SQLEXPRESS;Initial Catalog=BTL_nhom4;Integrated Security=True";
        SqlConnection conn = null;
        DataTable dtdstk = new DataTable();
        SqlDataAdapter dadstk = new SqlDataAdapter();
        private void Quan_QLTK_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string truyvan6 = "select TenDangNhap as \"Tên đăng nhập\", MatKhau as \"Mật Khẩu\", VaiTro as \"Vai trò\", SoDienThoai as \"Số điện thoại\"  from TaiKhoan where VaiTro!= '1'";
            string truyvan7 = "select TenDangNhap as \"Tên đăng nhập\", MatKhau as \"Mật Khẩu\", VaiTro as \"Vai trò\", SoDienThoai as \"Số điện thoại\" from TaiKhoan where VaiTro = '1'";
            dadstk = new SqlDataAdapter(truyvan6, conn);
            dtdstk.Rows.Clear();
            dadstk.Fill(dtdstk);
            dgvtdstaikhoan.DataSource = dtdstk;
            bttongtaikhoan.Text = "Tổng tài khoản khách: " + dtdstk.Rows.Count.ToString();


            DataTable bangtkht = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(truyvan7, conn);         
            da.Fill(bangtkht);
            dataGridView1.DataSource = bangtkht;


            
        }
        int dongdangchon;

        private void dgvtdstaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dongdangchon = e.RowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string a = dtdstk.Rows[dongdangchon][0].ToString();
                string xoa = "delete from TaiKhoan where TenDangNhap ='" + a + "'";
                SqlCommand cmd = new SqlCommand(xoa, conn);
                cmd.ExecuteNonQuery();
                dtdstk.Rows.Clear();
                dadstk.Fill(dtdstk);
                dgvtdstaikhoan.DataSource = dtdstk;
            }
            catch (Exception)
            {

            }
            
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
