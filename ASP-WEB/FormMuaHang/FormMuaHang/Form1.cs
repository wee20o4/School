using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace FormMuaHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_Title_Click(object sender, EventArgs e)
        {

        }
        string[] chuoianh = new string[]
        {
            "\\pic\\MauDen.jpg",
            "\\pic\\MauXanh.jpg",
            "\\pic\\MauXanhNuoc.jpg",
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            nbr_SoLuong.Minimum = 1;
            // Lấy thư mục cha của thư mục hiện tại
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo currentDirInfo = new DirectoryInfo(currentDirectory);
            DirectoryInfo parentDirInfo = currentDirInfo.Parent;
            string projectDirectory = parentDirInfo.Parent.FullName;


            //pic_DienThoai.BackgroundImage = Image.FromFile(projectDirectory + "\\pic\\MauDen.jpg");
            //pic_DienThoai.BackgroundImageLayout = ImageLayout.Zoom;


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (nbr_SoLuong.Value == 0)
            {
                nbr_SoLuong.Value = 1; 
            }
            lbl_ThanhTien.Text = ((int)nbr_SoLuong.Value * 13)+"tr";
        }

        private void nbr_SoLuong_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void nbr_SoLuong_KeyUp(object sender, KeyEventArgs e)
        {
            lbl_ThanhTien.Text = ((int)nbr_SoLuong.Value * 13) + "tr";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo currentDirInfo = new DirectoryInfo(currentDirectory);
            DirectoryInfo parentDirInfo = currentDirInfo.Parent;
            string projectDirectory = parentDirInfo.Parent.FullName;
            for (int i = 0; i <= chuoianh.Length; i++)
            {
                if (cb_Mau.SelectedIndex == i)
                {
                    pic_DienThoai.BackgroundImage = Image.FromFile(projectDirectory + chuoianh[i]);
                    pic_DienThoai.BackgroundImageLayout = ImageLayout.Zoom;
                    return;
                }
            }

        }
        string[][] tinh = new string[][]
        {
            new string[] // Mảng con cho thành phố HCM
            {
                "Quận 1",
                "Quận 2",
                "Quận 3",
                "Quận 4",
                "Quận 5",
                "Quận 6",
                "Quận 7",
                "Quận 8",
                "Quận 9",
                "Quận 10",
                "Quận 11",
                "Quận 12",
                "Quận Bình Tân",
                "Quận Bình Thạnh",
                "Quận Gò Vấp",
                "Quận Phú Nhuận",
                "Quận Tân Bình",
                "Quận Tân Phú",
                "Quận Thủ Đức",
                "Huyện Bình Chánh",
                "Huyện Cần Giờ",
                "Huyện Củ Chi",
                "Huyện Hóc Môn",
                "Huyện Nhà Bè"
            },

            new string[] // Mảng con cho thành phố Hà Nội
            {
                "Quận Ba Đình",
                "Quận Cầu Giấy",
                "Quận Hoàn Kiếm",
                "Quận Hai Bà Trưng",
                "Quận Hoàng Mai",
                "Quận Đống Đa",
                "Quận Tây Hồ",
                "Quận Thanh Xuân",
                "Quận Bắc Từ Liêm",
                "Quận Hà Đông",
                "Quận Long Biên",
                "Quận Nam Từ Liêm",
                "Huyện Ba Vì",
                "Huyện Chương Mỹ",
                "Huyện Đan Phượng",
                "Huyện Đông Anh",
                "Huyện Gia Lâm",
                "Huyện Hoài Đức",
                "Huyện Mê Linh",
                "Huyện Mỹ Đức",
                "Huyện Phú Xuyên",
                "Huyện Phúc Thọ",
                "Huyện Quốc Oai",
                "Huyện Sóc Sơn",
                "Huyện Thạch Thất",
                "Huyện Thanh Oai",
                "Huyện Thanh Trì",
                "Huyện Thường Tín",
                "Huyện Ứng Hòa",
                "Thị xã Sơn Tây"
            }
        };
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cb_Huyen.Items.Clear();
            for (int i = 0; i < cb_Tinh.Items.Count; i++)
            {
                if (cb_Tinh.SelectedIndex == i)
                {
                    for (int j=0; j<tinh[i].Length; j++)
                    {
                        cb_Huyen.Items.Add(tinh[i][j]);
                    }
                    return;
                }
            }
        }

        private void btn_Mua_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_phone.Text == "" || cb_Huyen.SelectedIndex == -1 || cb_Tinh.SelectedIndex == -1 || cb_Mau.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cho tất cả các trường!");
                return;
            }
            pn_ttm.Visible = true;
            lbl_ttm_tensp.Text += lbl_NamePhone.Text;
            lbl_ttm_mausac.Text += cb_Mau.Text;
            lbl_ttm_ten.Text += txt_name.Text;
            lbl_ttm_sdt.Text += txt_phone.Text;
            lbl_ttm_tinh.Text += cb_Tinh.Text;
            lbl_ttm_quan.Text += cb_Huyen.Text;
            lbl_ttm_phuong.Text += txt_Phuong.Text;
            lbl_ttm_thanhtien.Text += "\n\n   " + lbl_ThanhTien.Text;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn hủy đơn này?","Xác nhân",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {
                pn_ttm.Visible = false;
                cb_Mau.Text = "";
                txt_name.Text = "";
                txt_phone.Text = "";
                txt_Phuong.Text = "";
                cb_Tinh.Text = "";
                cb_Huyen.Text = "";
                nbr_SoLuong.Value = 1;
            }


        }
    }
}
