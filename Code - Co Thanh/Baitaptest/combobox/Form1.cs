using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn__HienThi_Click(object sender, EventArgs e)
        {
            if (cbo__Tinh.Text=="")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cbo__Tinh, "Ban Chua Chon Tinh!");
            }
            lbl__KetQua.Text= cbo__Tinh.SelectedItem.ToString();
        }

        private void txt__Add_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn__Add_Click(object sender, EventArgs e)
        {
            if (txt__Add.Text=="")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt__Add, "Chua Nhap Tinh Can Them");
            }
            else { 
                cbo__Tinh.Items.Add(txt__Add.Text);
            }
        }
    }
}
