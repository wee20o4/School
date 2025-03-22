using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitaptext2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn__GoRight_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items =cklb__Left.CheckedItems;
            foreach(var item in items)
            {
                cklb__Right.Items.Add(item);
            }
            foreach(var item in cklb__Right.Items)
            {
                cklb__Left.Items.Remove(item);
            }
        }

        private void btn__GoLeft_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items = cklb__Right.CheckedItems;
            foreach (var item in items)
            {
                cklb__Left.Items.Add(item);
            }
            foreach (var item in cklb__Left.Items)
            {
                cklb__Right.Items.Remove(item);
            }
        }

        private void btn__GoAllRight_Click(object sender, EventArgs e)
        {
            cklb__Right.Items.AddRange(cklb__Left.Items);
            cklb__Left.Items.Clear();
        }

        private void btn__GoAllLeft_Click(object sender, EventArgs e)
        {
            cklb__Left.Items.AddRange(cklb__Right.Items);
            cklb__Right.Items.Clear();
        }
    }
}
