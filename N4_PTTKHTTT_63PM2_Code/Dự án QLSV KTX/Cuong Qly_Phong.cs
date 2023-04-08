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
    public partial class Qly_Phong : Form
    {
       
        public Qly_Phong()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            string form_cha = ((Button)sender).Text;
            
            Cuong_Thong_Tin_Phong add = new Cuong_Thong_Tin_Phong(form_cha);
            this.Hide();
            add.ShowDialog();
            this.Close();
           
            
        }

        private void Qly_Phong_Load(object sender, EventArgs e)
        {
        
        }

        private void lb_ds_cac_phong_Click(object sender, EventArgs e)
        {

        }
    }
}
