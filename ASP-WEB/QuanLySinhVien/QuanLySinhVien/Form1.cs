namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tendn = txt_tendangnhap.Text;
            string pass = txt_pass.Text;
            bool isCorrect = false;
            foreach (var items in DataProvider.dangNhaps)
            {
                if (items.TenDangNhap == tendn && items.MatKhau == pass)
                {
                    isCorrect = true;
                    break;
                }
            }

            if (isCorrect)
            {
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataProvider.GetAllDangNhap();
        }
    }
}
