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
    public partial class Cuong_Thong_Tin_Phong : Form
    {
        private string form_cha;
        SqlConnection conn = new SqlConnection();
        string chuoi_ket_noi = "Data Source=LEQUAN-3012\\SQLEXPRESS;Initial Catalog=BTL_nhom4;Integrated Security=True";
        SqlDataAdapter da;
        DataTable dt;

        int dong_dang_chon;
        public Cuong_Thong_Tin_Phong()
        {
            InitializeComponent();
        }
        public Cuong_Thong_Tin_Phong(string form_cha)
        {
            InitializeComponent();
            this.form_cha = form_cha;
        }


        private void Thong_Tin_Phong_Load(object sender, EventArgs e)
        {
            bt_ma_phong.Text = form_cha;
            bt_ma_phong_2.Text = form_cha;
            conn = new SqlConnection(chuoi_ket_noi);
            conn.Open();
            string sql = "select msv as\"Mã Sinh Viên\", maphong as\"Mã Phòng\", hoten as \"Họ Tên\", ngaysinh as \"Ngày Sinh\", gioitinh as\"Giới Tính\", cccd as\"CCCD\", quequan as\"Quê Quán\", lop as \"Lớp\" from themsinhvien where maphong = \'"+bt_ma_phong_2.Text+"\' ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dtg_tap1.DataSource = dt;
            hienthi();
            if (dtg_tap1.Rows.Count >= 8)
                lb_hien_trang.Text = lb_hien_trang.Text + "Phòng đã đầy";
            else
                lb_hien_trang.Text = lb_hien_trang.Text + "Phòng còn chỗ";
            

        }
        public void hienthi()
        {
            string sqlselect = "select maphong as\"Mã Phòng\", cua as\"Hệ Thống Cửa\", den as\"Hệ thống đèn điện\", tbvs as\"Trang thiết bị vệ sinh\", giuong as \"Giường\", tu as\"Tủ\", dieuhoa as\"Điều Hòa\", wifi as \"Wifi\"from csvc where maphong ='"+ bt_ma_phong_2.Text+"'";
            SqlCommand cmd = new SqlCommand(sqlselect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtg_tap2.DataSource = dt;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {


      

            string sql_insert = "Insert into csvc values('" + bt_ma_phong_2.Text + "','" + tb_ht_cua.Text + "','" + tb_ht_den_dien.Text + "', '" + tb_ttb_vs.Text + "','" + tb_giuong.Text + "','" + tb_tu.Text + "','" + tb_dieu_hoa.Text + "','" + tb_wifi.Text + "')";
            SqlCommand cmd = new SqlCommand(sql_insert, conn);
            cmd.ExecuteNonQuery();

            hienthi();

        }

        private void dtg_tap2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong_dang_chon = e.RowIndex;

            tb_ht_cua.Text = dtg_tap2.Rows[dong_dang_chon].Cells[1].Value.ToString();
            tb_ht_den_dien.Text = dtg_tap2.Rows[dong_dang_chon].Cells[2].Value.ToString();
            tb_ttb_vs.Text = dtg_tap2.Rows[dong_dang_chon].Cells[3].Value.ToString();
            tb_giuong.Text = dtg_tap2.Rows[dong_dang_chon].Cells[4].Value.ToString();
            tb_tu.Text = dtg_tap2.Rows[dong_dang_chon].Cells[5].Value.ToString();
            tb_dieu_hoa.Text = dtg_tap2.Rows[dong_dang_chon].Cells[6].Value.ToString();
            tb_wifi.Text = dtg_tap2.Rows[dong_dang_chon].Cells[7].Value.ToString();

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
  
            string sql_delete = "Delete csvc where maphong = '"+bt_ma_phong_2.Text+"'";
            SqlCommand cmd = new SqlCommand(sql_delete, conn);
            cmd.ExecuteNonQuery();
            hienthi();

        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
         

            string sql_update = " Update csvc set cua = '"+tb_ht_cua.Text+"', den = '"+tb_ht_den_dien.Text+"', tbvs = '"+tb_ttb_vs.Text+"', giuong = '"+tb_giuong.Text+"', tu = '"+tb_tu.Text+"', dieuhoa = '"+tb_dieu_hoa.Text+"', wifi = '"+tb_wifi.Text+"' where maphong = '"+bt_ma_phong_2.Text+"'";

            SqlCommand cmd = new SqlCommand(sql_update, conn);
            cmd.ExecuteNonQuery();
            hienthi();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void tb_ht_cua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(tb_ht_cua.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                tb_ht_cua.Text= "";
            }
            
        }

        private void tb_ht_den_dien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(tb_ht_den_dien.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                tb_ht_den_dien.Text = "";
            }
        }

        private void tb_ttb_vs_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(tb_ttb_vs.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                tb_ttb_vs.Text = "";
            }
        }

        private void tb_giuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(tb_giuong.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                tb_giuong.Text = "";
            }
        }

        private void tb_tu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(tb_tu.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                tb_tu.Text = "";
            }
        }

        private void tb_dieu_hoa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(tb_dieu_hoa.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                tb_dieu_hoa.Text = "";
            }
        }

        private void tb_wifi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(tb_wifi.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                tb_wifi.Text = "";
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Qly_Phong add = new Qly_Phong();
            add.ShowDialog();
            this.Close();
        }
    }
}
