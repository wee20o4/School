using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class MainForm : Form
    {
        DataTable dt = new DataTable();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadTableMonHoc();
        }
        private void LoadTableMonHoc()
        {
            string sql = "select * from MonHoc";
            dt.Clear();
            dt = DataProvider.LoadCSDL(sql);
            dtgv_Monhoc.DataSource = dt;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            EnableControls(new List<Control> { txt_MaMonHoc, txt_TenMonHoc, txt_SoTinChi,btn_save });
            UnEnableControls(new List<Control> { btn_add });
            RefreshText(new List<Control> { txt_MaMonHoc, txt_TenMonHoc, txt_SoTinChi });
            txt_MaMonHoc.Focus();
        }

        private void EnableControls(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = true;
            }
        }

        private void UnEnableControls(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = false;
            }
        }

        private void RefreshText(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Text = string.Empty;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string maMH = txt_MaMonHoc.Text;
            string tenMH = txt_TenMonHoc.Text;
            string soTinChi=txt_SoTinChi.Text;

            string sql = $"insert into MonHoc values ('{maMH}',N'{tenMH}',{soTinChi})";

            int kq=DataProvider.ThaoTacCSDL(sql);
            if (kq>0)
            {
                MessageBox.Show("Thêm môn học thành công");
                LoadTableMonHoc();
                UnEnableControls(new List<Control> { txt_MaMonHoc, txt_TenMonHoc, txt_SoTinChi,btn_save });
                RefreshText(new List<Control> { txt_MaMonHoc, txt_TenMonHoc, txt_SoTinChi});
                btn_add.Enabled = true;
            }
            else
            {
                MessageBox.Show("Không thể thêm môn học vui lòng thử lại!");
            }



           
        }
    }
}
