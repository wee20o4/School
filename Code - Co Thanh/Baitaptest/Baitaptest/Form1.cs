using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitaptest
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button button = contextMenuStrip1.SourceControl as Button;
            button.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button button = contextMenuStrip1.SourceControl as Button;
            button.BackColor = Color.Green;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button button = contextMenuStrip1.SourceControl as Button;
            button.BackColor = Color.Yellow;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button button = contextMenuStrip1.SourceControl as Button;
            button.BackColor = Color.Blue;
        }
        private void bntrandom_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtSoLuongNut.Text=="")
            {
                errorProvider1.SetError(txtSoLuongNut, "Ban chua nhap so luong nut");
            }
            int n = int.Parse(txtSoLuongNut.Text);
            pnCacnut.Controls.Clear();
            Random rd=new Random();
            for (int i = 0;i<n;i++)
            {
                Button btn=new Button();
                btn.Text = rd.Next(500).ToString();
                pnCacnut.Controls.Add(btn);
                btn.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon reset?","Confrim",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result==DialogResult.OK)
            {
                pnCacnut.Controls.Clear();
            }
        }

        private void errorProvider1_RightToLeftChanged(object sender, EventArgs e)
        {

        }
    }
}
