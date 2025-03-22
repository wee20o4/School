using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTinhDiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool TinhDiem(double a, double b, double c, int renLuyen)
        {
            try
            {

                if (a > 5 && b > 5 && c > 5 && ((a + b + c) / 3) >= 7 && renLuyen >= 70)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void txt_tinhdiem_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt_a.Text);
            double b = double.Parse(txt_b.Text);
            double c = double.Parse(txt_c.Text);
            int renLuyen = int.Parse(txt_renluyen.Text);

            if (TinhDiem(a, b, c, renLuyen))
            {
                txt_kq.Text = "Dat";
                txt_kq.ForeColor = Color.Green;
            }
            else
            {
                txt_kq.Text = "KhongDat";
                txt_kq.ForeColor = Color.Red;
            }
        }
    }
}
