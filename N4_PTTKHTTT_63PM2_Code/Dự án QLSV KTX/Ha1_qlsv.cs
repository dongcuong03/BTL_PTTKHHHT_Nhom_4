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
    public partial class Ha1_qlsv : Form
    {
       
        public Ha1_qlsv()
        {
            InitializeComponent();
        }
        string ketnoi = "Data Source=LEQUAN-3012\\SQLEXPRESS;Initial Catalog=BTL_nhom4;Integrated Security=True";
        SqlConnection conn = null;
        DataTable dtthemsinhvien = new DataTable();
        SqlDataAdapter dathemsinhvien = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        private void qlsv_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(ketnoi);
            conn.Open();
            string sql = "select  msv as \"Mã sinh viên\", maphong as \"Mã phòng\", hoten as \"Họ tên\", ngaysinh as \"Ngày sinh\", gioitinh as \"Giới tính\", cccd as\" số CCCD\" , quequan as\" Quê quán\", lop as\" Lớp\" from themsinhvien";
            dathemsinhvien = new SqlDataAdapter(sql, conn);        
            dathemsinhvien.Fill(dtthemsinhvien);
            dgvqlsv.DataSource = dtthemsinhvien;

            string sql1 = "select maphong from phong";
            SqlDataAdapter da = new SqlDataAdapter(sql1, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "maphong";
            comboBox1.ValueMember = "maphong";
            

        }

        string gioitinh;

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                string a = dtthemsinhvien.Rows[dongdangchon][0].ToString();
                if (rdnam1.Checked == true) gioitinh = "Nam";
                else gioitinh = "Nữ";
                string sql1 = "update themsinhvien set maphong = '" + comboBox1.Text + "', hoten = '" + tbhoten.Text + "', ngaysinh = '" + dtngaysinh.Value + "', gioitinh = N'" + gioitinh + "', cccd = '" + tbcccd.Text + "', quequan = '" + tbquequan.Text + "', lop = '" + tblop.Text + "'" + "where msv ='" + a + "'";
                cmd = new SqlCommand(sql1, conn);
                dtthemsinhvien.Rows.Clear();
                cmd.ExecuteNonQuery();
                tbmsvien.Text = "";
                comboBox1.Text = "";
                tbhoten.Text = "";
                tbcccd.Text = "";
                tbquequan.Text = "";
                tblop.Text = "";

                qlsv_Load(sender, e);
            }
            catch (Exception)
            {

            }
            
        }
        private void btxoa_Click(object sender, EventArgs e)
        {
            
            try
            {
                string chuoixoa = "DELETE FROM themsinhvien WHERE msv ='" + tbmsvien.Text + "'";
                cmd = new SqlCommand(chuoixoa, conn);
                cmd.ExecuteNonQuery();
                tbmsvien.Text = "";
                comboBox1.Text = "";
                tbhoten.Text = "";
                tbcccd.Text = "";
                tbquequan.Text = "";
                tblop.Text = "";
                dgvqlsv.Rows.RemoveAt(dongdangchon);
            }
            catch (Exception)
            {

            }
            
        }
        

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                string sql = "select msv as \"Mã sinh viên\", maphong as \"Mã phòng\", hoten as \"Họ tên\", ngaysinh as \"Ngày sinh\", gioitinh as \"Giới tính\", cccd as\" số CCCD\" , quequan as\" Quê quán\", lop as\" Lớp\" from themsinhvien where msv= @msv";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@msv", tbtimkiem.Text);
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                string sql = "select msv as \"Mã sinh viên\", maphong as \"Mã phòng\", hoten as \"Họ tên\", ngaysinh as \"Ngày sinh\", gioitinh as \"Giới tính\", cccd as\" số CCCD\" , quequan as\" Quê quán\", lop as\" Lớp\" from themsinhvien where lop= @lop";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@lop", tbtimkiem.Text);
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                string sql = "select msv as \"Mã sinh viên\", maphong as \"Mã phòng\", hoten as \"Họ tên\", ngaysinh as \"Ngày sinh\", gioitinh as \"Giới tính\", cccd as\" số CCCD\" , quequan as\" Quê quán\", lop as\" Lớp\" from themsinhvien where quequan= @quequan";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@quequan", tbtimkiem.Text);   
            }
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            dtthemsinhvien.Rows.Clear();
            dtthemsinhvien.Load(dr);
            dgvqlsv.DataSource = dtthemsinhvien;
        }
        int dongdangchon;

        private void dgvqlsv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dongdangchon = e.RowIndex;
            tbmsvien.Text = dgvqlsv.Rows[dongdangchon].Cells[0].Value.ToString();
            comboBox1.Text = dgvqlsv.Rows[dongdangchon].Cells[1].Value.ToString();
            tbhoten.Text = dgvqlsv.Rows[dongdangchon].Cells[2].Value.ToString();
            dtngaysinh.Text = dgvqlsv.Rows[dongdangchon].Cells[3].Value.ToString();
            if (dgvqlsv.Rows[dongdangchon].Cells[4].Value.ToString() == "Nam")
            {
                rdnam1.Checked = true;
            }
            else
                rdnu1.Checked = true;
            tbcccd.Text = dgvqlsv.Rows[dongdangchon].Cells[5].Value.ToString();
            tbquequan.Text = dgvqlsv.Rows[dongdangchon].Cells[6].Value.ToString();
            tblop.Text = dgvqlsv.Rows[dongdangchon].Cells[7].Value.ToString();
        }

        private void bthoattimkiem_Click(object sender, EventArgs e)
        {
            tbmsvien.Text = "";
            comboBox1.Text = "";
            tbhoten.Text = "";
            tbcccd.Text = "";
            tbquequan.Text = "";
            tblop.Text = "";
            dtthemsinhvien.Rows.Clear();
            qlsv_Load(sender, e);
            

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (rdnam1.Checked)
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";
            string them = "insert into themsinhvien values ('" + tbmsvien.Text + "','" + comboBox1.Text + "',N'" + tbhoten.Text +
                "','" + dtngaysinh.Text + "',N'" + gioitinh + "','" + tbcccd.Text + "','"+tbquequan.Text+"','" + tblop.Text + "')";
            cmd = new SqlCommand(them, conn);
            cmd.ExecuteNonQuery();
            tbmsvien.Text = "";
            comboBox1.Text = "";
            tbhoten.Text = "";
            tbcccd.Text = "";
            tbquequan.Text = "";
            tblop.Text = "";


        }

        private void rdnam1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex == 0)
            {
                label1.Text = "Nhập mã sinh viên";
                tbtimkiem.Text = "";
            }
            else if(comboBox2.SelectedIndex == 1)
            {
                label1.Text = "Nhập lớp";
                tbtimkiem.Text = "";
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                label1.Text = "Nhập quê quán";
                tbtimkiem.Text = "";
            }
        }
    }
}
