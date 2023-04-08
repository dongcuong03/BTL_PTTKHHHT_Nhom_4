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
    public partial class frmDangNhap : Form
    {
        //Khoi tao cac form
        public frmDangNhap()
        {
            InitializeComponent();
        }

        //Tao ket noi toi SQL
        string chuoiKetNoi = "Data Source=LEQUAN-3012\\SQLEXPRESS;Initial Catalog=BTL_nhom4;Integrated Security=True";
        SqlConnection conn = null;
        private void DangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangKy add = new frmDangKy();
            add.ShowDialog();
            
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiKetNoi);
        }

        private void DangNhap_Click(object sender, EventArgs e)
        {
            string VaiTroDN;

            try
            {
                conn.Open();
                string username = txtTenDangNhap.Text;
                string passWord = txtMatKhauDangNhap.Text;
                if (rdbQTHT.Checked)
                {
                    VaiTroDN = "1";
                }
                else if (rdbQLSV.Checked)
                {
                    VaiTroDN = "2";
                }
                else
                {
                    VaiTroDN = "3";
                }
                string sql = "Select * from TaiKhoan where TenDangNhap = '" + username + "' and MatKhau = '" + passWord + "' and VaiTro = '" + VaiTroDN + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    if (VaiTroDN == "1")
                    {
                        this.Hide();
                        frmQT_HeThong add = new frmQT_HeThong();
                        add.ShowDialog();
                        this.Close();
                    }

                    else if (VaiTroDN == "2")
                    {
                        this.Hide();
                        frmQL_SinhVien add = new frmQL_SinhVien();
                        add.ShowDialog();
                        this.Close();
                    }
                    else if (VaiTroDN == "3")
                    {
                        this.Hide();
                        frmQL_KTX add = new frmQL_KTX();
                        add.ShowDialog();
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng đăng nhập lại!", "Warn", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch(Exception ex){
                MessageBox.Show("Lỗi kết nối", "Connect to SQL", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

    }
    } }
