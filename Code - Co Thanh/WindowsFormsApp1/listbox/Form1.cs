using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            
           DialogResult result= MessageBox.Show("Ban co muon thoat khong?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int songuyen;
            bool isCorrect=true;
            errorProvider1.Clear();
            if(int.TryParse(txtnhapso.Text, out songuyen)==false) 
            {
                errorProvider1.SetError(txtnhapso, "Hay nhap dung dinh dang");
                isCorrect = false;
            }
            if (isCorrect == true)
            {
                int x=int.Parse(txtnhapso.Text);
                lstdanhsach.Items.Add(x);
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int Tong=0;
            foreach (int i in lstdanhsach.Items)
            {
                Tong += i;
            }
            MessageBox.Show("Tong cua danh sach la: " + Tong);
        }

        private void btnxoadauvacuoi_Click(object sender, EventArgs e)
        {
            lstdanhsach.Items.RemoveAt(0);
            lstdanhsach.Items.RemoveAt(lstdanhsach.Items.Count-1);
        }

        private void btnxoaptdangchon_Click(object sender, EventArgs e)
        {
            while (lstdanhsach.SelectedIndex != -1)
            {
                lstdanhsach.Items.RemoveAt(lstdanhsach.SelectedIndex);
            }
        }

        private void btntangmoiptlen2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstdanhsach.Items.Count; i++)
            {
                int k = (int)lstdanhsach.Items[i] + 2;
                lstdanhsach.Items[i] = k;
            }
        }

        private void btnbinhphuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstdanhsach.Items.Count; i++)
            {
                int k = (int)lstdanhsach.Items[i] * (int)lstdanhsach.Items[i];
                lstdanhsach.Items[i] = k;
            }
        }

        private void btnchonsochan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstdanhsach.Items.Count; i++)
            {
                if ((int)lstdanhsach.Items[i] % 2 == 0)
                {
                    lstdanhsach.SelectedIndex=i;
                }
            }
        }

        private void btnchonsole_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstdanhsach.Items.Count; i++)
            {
                if ((int)lstdanhsach.Items[i] % 2 ==1)
                {
                    lstdanhsach.SelectedIndex = i;
                }
            }
        }
    }
}
