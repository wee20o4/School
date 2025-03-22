using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btntinhtong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            tong=int.Parse(txtA.Text)+ int.Parse(txtB.Text);
            lblketqua.Text = txtA.Text + " + " + txtB.Text + " = " + tong + "";

        }

        private void btntichhieu_Click(object sender, EventArgs e)
        {
            int hieu = 0;
            hieu = int.Parse(txtA.Text) - int.Parse(txtB.Text);
            lblketqua.Text = txtA.Text + " - " + txtB.Text + " = " + hieu + "";
        }

        private void btntinhtich_Click(object sender, EventArgs e)
        {
            int tich = 1;
            tich = int.Parse(txtA.Text) * int.Parse(txtB.Text);
            lblketqua.Text = txtA.Text + " x " + txtB.Text + " = " + tich + "";
        }

        private void btntinhthuong_Click(object sender, EventArgs e)
        {
            float thuong = 0;
            thuong = float.Parse(txtA.Text) / float.Parse(txtB.Text);
            lblketqua.Text = txtA.Text + " : " + txtB.Text + " = " + thuong + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon reset?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lblketqua.Text = "";
                txtA.Text = "";
                txtB.Text = "";
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon thoat?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel=false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
