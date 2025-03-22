using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class MuaHang : Form
    {
        string ten, sdt;
        public MuaHang(string ten,string sdt)
        {
            InitializeComponent();
            this.ten = ten;
            this.sdt = sdt;
        }

        private void MuaHang_Load(object sender, EventArgs e)
        {
            lbl_ten.Text = ten;
            lbl_sdt.Text = sdt;
        }
    }
}
