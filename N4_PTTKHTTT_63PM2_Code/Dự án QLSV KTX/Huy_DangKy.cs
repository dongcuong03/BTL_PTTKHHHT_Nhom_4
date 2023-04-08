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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Dự_án_QLSV_KTX
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        string ketnoi = "Data Source=LEQUAN-3012\\SQLEXPRESS;Initial Catalog=BTL_nhom4;Integrated Security=True";
        SqlConnection conn = null;


        private void Thoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không? ", "Thoát đăng ký", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmDangNhap fDangNhap = new frmDangNhap();
                this.Close();
                fDangNhap.Show();
            }

        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
           conn = new SqlConnection(ketnoi);
        }

        private void btnDangKyTK_Click(object sender, EventArgs e)
        {
           try
           {
               conn.Open();
               string username = txtTenDangKy.Text;
               string passWord = txtMKDangKy.Text;
               string SDT = txtSDT.Text;
               string VaiTroDK="";
               if(rdbQLKTX.Checked)
                   VaiTroDK = "3";
               else if(rdbQLSV.Checked)
                   VaiTroDK = "2";
               string sql = "Select * from TaiKhoan where TenDangNhap = '" + username + "' and MatKhau = '" + passWord + "'";
               SqlCommand cmd = new SqlCommand(sql, conn);
               SqlDataReader data = cmd.ExecuteReader();
           
               if (data.Read() == true)
               {
                   MessageBox.Show("Tài khoản đã tồn tại, vui lòng chọn tài khoản khác", "Warn", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                   conn.Close();
               }
               else if(txtMKDangKy.Text != txtXacNhanMK.Text) 
               {
                   MessageBox.Show("Mật khẩu nhập vào chưa đúng. Vui lòng nhập lại!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                   conn.Close();
               }
           
               else
               {
                   conn.Close();
                   conn.Open();
                   sql = @"Insert Into TaiKhoan(TenDangNhap, MatKhau, VaiTro, SoDienThoai)
                   VALUES (N'" + txtTenDangKy.Text + @"', N'" + txtMKDangKy.Text + @"', N'"+VaiTroDK+@"', N'" + txtSDT.Text + @"') ";
                   SqlCommand excute = new SqlCommand(sql, conn);
                   excute.ExecuteNonQuery();
                   conn.Close();
                   MessageBox.Show("Đăng ký thành công!", "Đăng ký tài khoản ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   frmDangNhap fDangNhap = new frmDangNhap();
                   this.Close();
                   fDangNhap.Show();
           
               }
              
           }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối", "Connect to SQL", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
    }
        
    }
}
