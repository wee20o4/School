using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiTapTuan6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string conectionString = "Data Source=DESKTOP-VLPSTGN;Initial Catalog=QLThuVien;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"SELECT COUNT(*)
                            FROM DANGNHAP
                            WHERE TenDn=@TenDn AND MatKhau=@MatKhau";
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command)
                }
            }
        }
    }
}
