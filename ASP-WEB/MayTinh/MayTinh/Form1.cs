using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinh
{
    public partial class Caculator : Form
    {
        public Caculator()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (rad_trangthai.Checked == false)
            {
                MessageBox.Show("Vui lòng mở máy tính lên!");
                return;
            }
            if (!string.IsNullOrEmpty(lbl_pheptinh.Text))
            {
                lbl_pheptinh.Text = lbl_pheptinh.Text.Substring(0, lbl_pheptinh.Text.Length - 1);//giữ lại từ đầu đến ptu kế cuối
                lbl_ketqua.Text = "";
                lbl_duongthag.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (rad_trangthai.Checked == false)
            {
                MessageBox.Show("Vui lòng mở máy tính lên!");
                return;
            }
            if (!string.IsNullOrEmpty(lbl_pheptinh.Text))
            {
                lbl_pheptinh.Text = "";
                lbl_ketqua.Text = "";
                lbl_duongthag.Visible=false;
            }
        }
        private void LamMoi()
        {
            if (rad_trangthai.Checked == false)
            {
                MessageBox.Show("Vui lòng mở máy tính lên!");
                return;
            }
            if (lbl_ketqua.Text != "")
            {
                lbl_ketqua.Text = "";
                lbl_duongthag.Visible = false;
                lbl_pheptinh.Text = "";
            }
        }
        private void btn_0_Click(object sender, EventArgs e)
        {
            if (rad_trangthai.Checked == false)
            {
                MessageBox.Show("Vui lòng mở máy tính lên!");
                return;
            }
            LamMoi();
            lbl_pheptinh.Text += btn_0.Text;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (rad_trangthai.Checked == false)
            {
                MessageBox.Show("Vui lòng mở máy tính lên!");
                return;
            }
            LamMoi();
            lbl_pheptinh.Text += btn_1.Text;
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            if (rad_trangthai.Checked == false)
            {
                MessageBox.Show("Vui lòng mở máy tính lên!");
                return;
            }
            LamMoi();
            lbl_pheptinh.Text += btn_2.Text;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (rad_trangthai.Checked == false)
            {
                MessageBox.Show("Vui lòng mở máy tính lên!");
                return;
            }
            LamMoi();
            lbl_pheptinh.Text += btn_3.Text;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (rad_trangthai.Checked == false)
            {
                MessageBox.Show("Vui lòng mở máy tính lên!");
                return;
            }
            LamMoi();
            lbl_pheptinh.Text += btn_4.Text;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (rad_trangthai.Checked == false)
            {
                MessageBox.Show("Vui lòng mở máy tính lên!");
                return;
            }
            LamMoi();
            lbl_pheptinh.Text += btn_5.Text;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (rad_trangthai.Checked == false)
            {
                MessageBox.Show("Vui lòng mở máy tính lên!");
                return;
            }
            LamMoi();
            lbl_pheptinh.Text += btn_6.Text;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (rad_trangthai.Checked == false)
            {
                MessageBox.Show("Vui lòng mở máy tính lên!");
                return;
            }
            LamMoi();
            lbl_pheptinh.Text += btn_7.Text;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (rad_trangthai.Checked == false)
            {
                MessageBox.Show("Vui lòng mở máy tính lên!");
                return;
            }
            LamMoi();
            lbl_pheptinh.Text += btn_8.Text;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (rad_trangthai.Checked == false)
            {
                MessageBox.Show("Vui lòng mở máy tính lên!");
                return;
            }
            LamMoi();
            lbl_pheptinh.Text += btn_9.Text;
        }



        private void btn_tru_Click(object sender, EventArgs e)
        {
            if (rad_trangthai.Checked == false)
            {
                MessageBox.Show("Vui lòng mở máy tính lên!");
                return;
            }
            if (lbl_ketqua.Text != "")
            {
                HideKQ();
            }
            lbl_pheptinh.Text += "-";
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            if (rad_trangthai.Checked == false)
            {
                MessageBox.Show("Vui lòng mở máy tính lên!");
                return;
            }
            if (lbl_ketqua.Text != "")
            {
                HideKQ();
            }
            lbl_pheptinh.Text += "*";
            
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            if (rad_trangthai.Checked == false)
            {
                MessageBox.Show("Vui lòng mở máy tính lên!");
                return;
            }
            if (lbl_ketqua.Text != "")
            {
                HideKQ();
            }
            lbl_pheptinh.Text += "/";
        }
        private void HideKQ()
        {
            lbl_duongthag.Visible=false;
            lbl_pheptinh.Text=lbl_ketqua.Text;
            lbl_ketqua.Text = "";
        }
        private void TinhToan()
        {
            if (!string.IsNullOrEmpty(lbl_pheptinh.Text))
            {
                try
                {
                    var expression = lbl_pheptinh.Text;

                    // Check for division by zero
                    if (expression.Contains("/0"))
                    {
                        lbl_ketqua.Text = "Error: Mẫu phải khác 0";
                        return;
                    }

                    var result = new DataTable().Compute(expression, null); // Calculate the expression
                    lbl_ketqua.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    lbl_ketqua.Text = "Error: " + ex.Message;
                }
            }
            if(lbl_ketqua.Text != "")
            {
                lbl_duongthag.Visible = true;
            }
        }

        private void btn_bang_Click(object sender, EventArgs e)
        {
            TinhToan();
        }

        private void Caculator_Load(object sender, EventArgs e)//click vào form chính để hiện phương thức này
        {
            rad_trangthai.Checked = true;  //Mặc định sẽ là check tức là máy tính đang mở
        }
        private void rad_trangthai_CheckedChanged(object sender, EventArgs e)
        {
            if(rad_trangthai.Checked)
            {
                lbl_trangthaion.Visible=true; //hiện màu xanh
                lbl_trangthaioff.Visible=false; // ẩn màu đỏ
            }
            else
            {
                lbl_trangthaioff.Visible = true; //hiện màu đỏ
                lbl_trangthaion.Visible = false; //ẩn màu xanh
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btn_turnon_Click(object sender, EventArgs e)
        {
            rad_trangthai.Checked=true;
            btn_turnon.Enabled=false;
            btn_turnoff.Enabled = true;
        }

        private void btn_turnoff_Click(object sender, EventArgs e)
        {
            lbl_duongthag.Visible = false;  //ẩn đường thẳng đen phân cách
            lbl_ketqua.Text = "";  
            lbl_pheptinh.Text = "";
            rad_trangthai.Checked = false;
            btn_turnoff.Enabled = false;
            btn_turnon.Enabled = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void grp_pheptinh_Enter(object sender, EventArgs e)
        {

        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            if (rad_trangthai.Checked == false)
            {
                MessageBox.Show("Vui lòng mở máy tính lên!");
                return;
            }
            if (lbl_ketqua.Text != "")
            {
                HideKQ();
            }

            lbl_pheptinh.Text += "+";
        }
    }
}
