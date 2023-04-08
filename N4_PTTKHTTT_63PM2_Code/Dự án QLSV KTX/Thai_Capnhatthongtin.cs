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
using Dự_án_QLSV_KTX;

namespace Sinhhoatphi
{
    public partial class Thai_Capnhatthongtin : Form
    {
        private string formcha;
        public Thai_Capnhatthongtin()
        {
            InitializeComponent();
        }
        public Thai_Capnhatthongtin(string formcha)
        {
            InitializeComponent();
            this.formcha = formcha;
        }
        string chuoiketnoi = "Data Source=LEQUAN-3012\\SQLEXPRESS;Initial Catalog=BTL_nhom4;Integrated Security=True";
        SqlConnection conn = null;
        DataTable dtshp = new DataTable();
        SqlDataAdapter dashp = new SqlDataAdapter();
        
        private void button6_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string chen = "insert into sinhhoatphi\r\nvalues ('"+bttenphong.Text+"',"+comboBox1.Text+","+tbtiendien.Text+","+tbtiennuoc.Text+","+tbtienwifi.Text+","+tbtienphong.Text + ",0)";
            SqlCommand cmd = new SqlCommand(chen, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            this.Hide();
            Thai_Thongtinshp add = new Thai_Thongtinshp(formcha);
            add.ShowDialog();
            this.Close();
        }

        private void Thai_Capnhatthongtin_Load(object sender, EventArgs e)
        {
            bttenphong.Text = formcha;
            conn = new SqlConnection(chuoiketnoi);
            DataTable dtshp1 = new DataTable();
            conn.Open();
            string truyvan = "select maphong,tiendien, tiennuoc, tienwifi, tienphong, sum(tiendien +tiennuoc+tienwifi+tienphong)as tongtien\r\nfrom sinhhoatphi \r\nwhere maphong ='" + bttenphong.Text + "'\r\ngroup by maphong ,tiendien, tiennuoc, tienwifi, tienphong;";
            SqlDataAdapter dashp = new SqlDataAdapter(truyvan, conn);
            dashp.Fill(dtshp);
            if (dtshp.Rows.Count > 0)
            {
                tbtiendien.Text = dtshp.Rows[0][1].ToString();
                tbtiennuoc.Text = dtshp.Rows[0][2].ToString();
                tbtienwifi.Text = dtshp.Rows[0][3].ToString();
                tbtienphong.Text = dtshp.Rows[0][4].ToString();
            }
            


        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string chuoisua = "update sinhhoatphi\r\nset tiendien=" + tbtiendien.Text + ", tiennuoc=" + tbtiennuoc.Text + ",tienwifi=" + tbtienwifi.Text + ",tienphong=6" + tbtienphong.Text + "\r\nwhere maphong ='" + bttenphong.Text + "'";

                SqlCommand sua = new SqlCommand(chuoisua, conn);
                sua.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                this.Hide();
                Thai_Thongtinshp add = new Thai_Thongtinshp(formcha);
                add.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

            }
            this.Close();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string chuoixoa = "DELETE FROM sinhhoatphi WHERE maphong='" + bttenphong.Text + "'";
                SqlCommand xoa = new SqlCommand(chuoixoa, conn);
                xoa.ExecuteNonQuery();
                tbtiendien.Text = "";
                tbtiennuoc.Text = "";
                tbtienwifi.Text = "";
                tbtienphong.Text = "";
                MessageBox.Show("Xóa thành công");
                
            }
            catch (Exception) { }
            this.Close();
            Thai_Thongtinshp add = new Thai_Thongtinshp(formcha);
            add.ShowDialog();
            this.Close();



        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thai_Form1 add = new Thai_Form1();
            add.ShowDialog(this);
            this.Close();

        }
    }
}
