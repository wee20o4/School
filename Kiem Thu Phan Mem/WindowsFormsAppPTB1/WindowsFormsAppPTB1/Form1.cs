using System;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsAppPTB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string GiaiPTB1(int v1, int v2)
        {
            return GiaiPTB1((double)v1, (double)v2);
        }

        private string GiaiPTB1(double a, double b)
        {
            if (a == 0)
            {
                return (b == 0) ? "VSN" : "VN";
            }
            double x = -b / a;
            return "x = " + x.ToString("0.00", CultureInfo.InvariantCulture);
        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            double a, b;
            if (!double.TryParse(txt_a.Text, out a) || !double.TryParse(txt_b.Text, out b))
            {
                MessageBox.Show("Vui lòng nhập số cho hệ số a và b!");
                return;
            }
            txt_kq.Text = GiaiPTB1(a, b);
        }
    }
}