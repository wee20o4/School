using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            try
            {
                a = int.Parse(txt_so1.Text);
                b = int.Parse(txt_so2.Text);
                Calculation c = new Calculation(a, b); 
                ketqua = c.Execute("+");
                txt_kq.Text = ketqua.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            try
            {
                a = int.Parse(txt_so1.Text);
                b = int.Parse(txt_so2.Text);
                Calculation c = new Calculation(a, b); 
                ketqua = c.Execute("-");
                txt_kq.Text = ketqua.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            try
            {
                a = int.Parse(txt_so1.Text);
                b = int.Parse(txt_so2.Text);
                Calculation c = new Calculation(a, b); 
                ketqua = c.Execute("*");
                txt_kq.Text = ketqua.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            try
            {
                a = int.Parse(txt_so1.Text);
                b = int.Parse(txt_so2.Text);
                Calculation c = new Calculation(a, b); 
                ketqua = c.Execute("/");
                txt_kq.Text = ketqua.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
