using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaptuan5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lv_ttnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_ttnv.SelectedItems.Count > 0)
            {
                ListViewItem lv = lv_ttnv.SelectedItems[0];
                txt_ten.Text = lv.SubItems[0].Text;
                date_ngaysinh.Text = lv.SubItems[1].Text; ;
                txt_diachi.Text = lv.SubItems[2].Text; ;
                txt_phone.Text = lv.SubItems[3].Text;
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ListViewItem lv = lv_ttnv.Items.Add(txt_ten.Text);
            lv.SubItems.Add(date_ngaysinh.Text);
            lv.SubItems.Add(txt_diachi.Text);
            lv.SubItems.Add(txt_phone.Text);
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (lv_ttnv.SelectedItems.Count > 0)
            {
                ListViewItem lv = lv_ttnv.SelectedItems[0];
                lv.SubItems[0].Text= txt_ten.Text;
                lv.SubItems[1].Text=date_ngaysinh.Text;
                lv.SubItems[2].Text=txt_diachi.Text;
                lv.SubItems[3].Text=txt_phone.Text;
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (lv_ttnv.SelectedItems.Count > 0)
            {
                lv_ttnv.Items.RemoveAt(lv_ttnv.SelectedItems[0].Index);
            }
        }
    }
}
