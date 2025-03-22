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
    public partial class Home : Form
    {
        float thanhTien = 0;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void ThanhTien()
        {
            thanhTien = 0;
            if(ckb_caovoi.Checked)
            {
                thanhTien += 120000;
            } 
            if(ckb_taytrang.Checked)
            {
                thanhTien += 1300000;
            }
            if(ckb_chuphỉnhang.Checked)
            {
                thanhTien += 250000;
            }
            thanhTien += (int)nbr_tramrang.Value * 100000;
            lbl_thanhtien.Text = "$"+thanhTien.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ckb_caovoi_CheckedChanged(object sender, EventArgs e)
        {
            ThanhTien();
        }

        private void ckb_taytrang_CheckedChanged(object sender, EventArgs e)
        {
            ThanhTien();
        }

        private void ckb_chuphỉnhang_CheckedChanged(object sender, EventArgs e)
        {
            ThanhTien();
        }

        private void nbr_tramrang_ValueChanged(object sender, EventArgs e)
        {
            ThanhTien();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            string thanhtoan = "";
            thanhtoan +="\nHọ tên nhân viên: "+ lbl_thanhtien.Text;
            thanhtoan += "\nTên khách hàng: " + txt_tenkhachhang.Text;
            thanhtoan += "\nSố điện thoại: " + txt_sodienthoai.Text;
            thanhtoan += "\nĐịa chỉ: " + txt_diachi.Text+"\n\n===========================\nCác dịch vụ đã sử dụng:\n\n";
            if (ckb_caovoi.Checked)
            {
                thanhtoan+="Cạo vôi: $"+120000;
            }
            if (ckb_taytrang.Checked)
            {
                thanhtoan +="\nTẩy trắng răng: $"+ 1300000;
            }
            if (ckb_chuphỉnhang.Checked)
            {
                thanhtoan +="\nChụp hình răng: $"+ 250000;
            }
            if ((int)nbr_tramrang.Value>0)
            {
                thanhtoan += "\nTrám răng: $" + (int)nbr_tramrang.Value * 100000 + " - " + nbr_tramrang.Value + "Cái";
            }

            thanhtoan += "\n\n\t\tTổng tiền: " + lbl_thanhtien.Text;


            MessageBox.Show(">>>>>>>>Hóa đơn<<<<<<<<\n\n"+thanhtoan);
        }
    }
}
