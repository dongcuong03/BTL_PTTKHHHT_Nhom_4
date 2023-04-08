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
using Excel = Microsoft.Office.Interop.Excel;

namespace Dự_án_QLSV_KTX
{
    
    public partial class Quan_TKSHP : Form
    {
        public Quan_TKSHP()
        {
            InitializeComponent();
        }
        string chuoiketnoi = "Data Source=LEQUAN-3012\\SQLEXPRESS;Initial Catalog=BTL_nhom4;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter datkshp = new SqlDataAdapter();
        DataTable dttkshp = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            int sumdien = 0, sumnuoc = 0, sumwifi = 0;
            double sumtong = 0;

            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string truyvan3 = "select maphong as \"Mã Phòng\",thang as \"Tháng\",tiendien as \"Tiền điện\", tiennuoc as \"Tiền nước\", tienwifi as \"Tiền Wifi\", tienphong as \"Tiền phòng \", sum(tiendien +tiennuoc+tienwifi+tienphong)as \"Tổng tiền\"\r\nfrom sinhhoatphi \r\ngroup by maphong,thang ,tiendien, tiennuoc, tienwifi, tienphong";
            datkshp = new SqlDataAdapter(truyvan3, conn);
            datkshp.Fill(dttkshp);
            dgvshp.DataSource = dttkshp;
            for (int i = 0; i < dttkshp.Rows.Count; i++)
            {
                sumdien += (int)dttkshp.Rows[i][1];
                sumnuoc += (int)dttkshp.Rows[i][2];
                sumwifi += (int)dttkshp.Rows[i][3];
            }
            bttongdien.Text = "Tổng tiền điện KTX: " + sumdien.ToString();
            bttongnuoc.Text = "Tổng tiền nước KTX: " + sumnuoc.ToString();
            bttongwifi.Text = "Tổng tiền wifi KTX: " + sumwifi.ToString();
            bttongshp.Text = "Tổng tiền SHP KTX: " + (sumdien + sumnuoc + sumwifi).ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quan_TK_BC add = new Quan_TK_BC();
            add.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != 12)
            {
                int sumdien = 0, sumnuoc = 0, sumwifi = 0;
                double sumtong = 0;
                string truyvan3 = "select maphong as \"Mã Phòng\",thang as \"Tháng\",tiendien as \"Tiền điện\", tiennuoc as \"Tiền nước\", tienwifi as \"Tiền Wifi\", tienphong as \"Tiền phòng \", sum(tiendien +tiennuoc+tienwifi+tienphong)as \"Tổng tiền\"\r\nfrom sinhhoatphi where thang=" + comboBox1.Text + " \r\ngroup by maphong,thang,tiendien, tiennuoc, tienwifi, tienphong";
                datkshp = new SqlDataAdapter(truyvan3, conn);
                dttkshp.Rows.Clear();
                datkshp.Fill(dttkshp);
                for (int i = 0; i < dttkshp.Rows.Count; i++)
                {
                    sumdien += (int)dttkshp.Rows[i][1];
                    sumnuoc += (int)dttkshp.Rows[i][2];
                    sumwifi += (int)dttkshp.Rows[i][3];
                }
                bttongdien.Text = "Tổng tiền điện KTX: " + sumdien.ToString();
                bttongnuoc.Text = "Tổng tiền nước KTX: " + sumnuoc.ToString();
                bttongwifi.Text = "Tổng tiền wifi KTX: " + sumwifi.ToString();
                bttongshp.Text = "Tổng tiền SHP KTX: " + (sumdien + sumnuoc + sumwifi).ToString();
            }
            else
                Form1_Load(this, EventArgs.Empty);
            

        }

    }
}
