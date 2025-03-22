namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string ten = "Trong";
        string sdt = "12345";
        private void mnu_muahang_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            MuaHang mua = new MuaHang(ten, sdt);
            mua.Show();
            mua.FormClosed += (s, args) => this.Show();
        }
        private void mayTinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MayTinh maytinh = new MayTinh();
            maytinh.Show();
            maytinh.FormClosed += (s, args) => this.Show();
        }
    }
}
