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
    public partial class Quan_TK_BC : Form
    {
        public Quan_TK_BC()
        {
            InitializeComponent();
        }

        string chuoiketnoi = "Data Source=LEQUAN-3012\\SQLEXPRESS;Initial Catalog=BTL_nhom4;Integrated Security=True";
        SqlConnection conn = null;

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quan_DSSV add = new Quan_DSSV();
            add.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quan_CSVC add =new Quan_CSVC();
            add.ShowDialog();this.Close();
        }

        private void Quan_TK_BC_Load(object sender, EventArgs e)
        {
        }

        private void bttkshp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quan_TKSHP add = new Quan_TKSHP();
            add.ShowDialog();
            this.Close();
        }

        private void btdsphongtrong_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quan_DSPhongtrong add = new Quan_DSPhongtrong();
            add.ShowDialog();
            this.Close();
        }

        private void Quan_TK_BC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
