﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaKhoa
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
