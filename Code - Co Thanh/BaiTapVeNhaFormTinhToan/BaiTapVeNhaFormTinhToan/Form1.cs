using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapVeNhaFormTinhToan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHienKetQua.Text = "";
            double ketqua = 0;
            int num1, num2;
            bool isNum1Valid = int.TryParse(txtSoA.Text, out num1);
            bool isNum2Valid = int.TryParse(txtSoB.Text, out num2);
            if(isNum1Valid==true && isNum2Valid==true)
            {
                string bieuthuc = txtBieuThuc.Text;
                switch (bieuthuc)
                {
                    case "+":
                        {
                            ketqua = num1 + num2;
                            break;
                        }
                    case "-":
                        {
                            ketqua = num1 - num2;
                            break;
                        }
                    case "*":
                    case "x":
                    case "X":
                        {
                            ketqua = num1 * num2;
                            break;
                        }
                    case ":":
                    case "/":
                        {
                            ketqua = (double)num1 / num2;
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Vui lòng nhập đúng cú pháp: cộng, trừ, nhân, hoặc chia!");
                            break;
                        }
                }
                lblHienKetQua.Text =txtSoA.Text+" "+txtBieuThuc.Text+" "+txtSoB.Text+" = "+ ketqua.ToString();
            }
            else if(isNum1Valid==false && isNum2Valid == false)
            {
                MessageBox.Show("Vui lòng nhập số A và B là SỐ NGUYÊN","Cofirm",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtSoA.Clear();
                txtSoB.Clear();
                txtSoA.Focus();
            }
            else if(isNum1Valid== false && isNum2Valid == true)
            {
                MessageBox.Show("Vui lòng nhập số A là SỐ NGUYÊN", "Cofirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoA.Clear();
                txtSoA.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số B là SỐ NGUYÊN", "Cofirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoB.Clear();
                txtSoB.Focus();
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn reset lại các phép tính? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                txtSoA.Text = "";
                txtSoB.Text = "";
                txtBieuThuc.Text = "";
                lblHienKetQua.Text = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
