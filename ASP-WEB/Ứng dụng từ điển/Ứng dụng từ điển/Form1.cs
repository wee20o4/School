using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Translate.V3;


namespace Ứng_dụng_từ_điển
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Dictionary Application";
            //btnTranslate.Text = "Translate";
        }
        private string Translate(string input)
        {
            // Sample return, replace with actual translation code
            return "Translated text for: " + input;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Perform translation or dictionary lookup when button is clicked
            string inputText = txt_vn.Text;

            if (!string.IsNullOrWhiteSpace(inputText))
            {
                string translatedText = Translate(inputText); // Placeholder for a translation method
                txt_eng.Text = translatedText;
            }
        }
    }
}
