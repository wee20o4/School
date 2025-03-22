using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Buoi5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_openURL_Click(object sender, EventArgs e)
        {
            string url = txt_url.Text; 
            if (!string.IsNullOrWhiteSpace(url))
            {
                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url); 
            }
            else
            {
                MessageBox.Show("Vui lòng nhập URL hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
