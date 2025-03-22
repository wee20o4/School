using System;
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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pic_image.BackgroundImage = Image.FromFile(@"../../pic/anh1.png");
            pic_image.BackgroundImageLayout=ImageLayout.Stretch;
            pic_lock.BackgroundImage = Image.FromFile(@"../../pic/lock.png");
            pic_lock.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangKy dangKy = new DangKy();
            dangKy.FormClosed += (s, args) => Show();
            dangKy.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.FormClosed += (s, args) => Application.Exit();
            home.Show();
        }
    }
}
