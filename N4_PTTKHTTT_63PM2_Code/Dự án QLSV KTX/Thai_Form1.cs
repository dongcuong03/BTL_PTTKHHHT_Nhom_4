using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dự_án_QLSV_KTX
{
    public partial class Thai_Form1 : Form
    {
        private string VaiTroDN;
        public Thai_Form1()
        {
            InitializeComponent();
        }
        public Thai_Form1(string VaiTroDN)
        {
            InitializeComponent();
            this.VaiTroDN = VaiTroDN;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string formcha = ((Button)sender).Text;
            this.Hide();
            Thai_Thongtinshp add = new Thai_Thongtinshp(formcha);
            add.ShowDialog();
            this.Hide();
        }

        private void Thai_Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VaiTroDN == "1")
            {
                this.Hide();
                frmQT_HeThong add = new frmQT_HeThong();
                add.ShowDialog();
                this.Close();
            }
        }
    }
}
