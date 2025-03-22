using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = @"select * from DangNhap";
            DataTable dt = DataProvider.LoadCSDL(sql);
            cb_Quyen.DataSource = dt;
            cb_Quyen.DisplayMember = "Quyen";
            cb_Quyen.ValueMember = "TenDN";
            cb_Quyen.SelectedIndex = 1;
        }

        public static string HoTenNV;
        public static string Quyen;
        int dem = 0;

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string tk = txt_tendn.Text;
            string mk = txt_pass.Text;
            string quyen = cb_Quyen.Text.Trim();
            string sql = @"select * from DangNhap
                            where TenDn= '"+tk+"' and MatKhau= '"+mk+"' and Quyen = N'"+quyen+"'";
            DataTable dt = DataProvider.LoadCSDL(sql);

            if (dt.Rows.Count > 0)
            {
                HoTenNV = dt.Rows[0]["HoTen"].ToString();
                Quyen = dt.Rows[0]["Quyen"].ToString();
                MessageBox.Show("Đăng nhập thành công");
                QuanLyThongTinMuonTra ql = new QuanLyThongTinMuonTra();
                ql.Show();
                this.Hide();
                ql.FormClosed += (s, args) => this.Show();

            }
            else
            {
                dem++;
                MessageBox.Show("Đăng nhập không thành công");
                if (dem == 3)
                {
                    MessageBox.Show("Bạn đã nhập sai 3 lần. Vui lòng thử lại vào lúc khác");
                    btn_dangnhap.Enabled = false;
                }
            }
        }
    }
}
