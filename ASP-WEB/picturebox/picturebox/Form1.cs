using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picturebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        string[] chuoianh = new string[]
        {
            "E:\\Tài Liệu Của Cường\\New folder\\picturebox\\pic\\anh1.png",
            "E:\\Tài Liệu Của Cường\\New folder\\picturebox\\pic\\anh2.jpg",
            "E:\\Tài Liệu Của Cường\\New folder\\picturebox\\pic\\anh3.jpg",
            "E:\\Tài Liệu Của Cường\\New folder\\picturebox\\pic\\anh4.jpg",
            "E:\\Tài Liệu Của Cường\\New folder\\picturebox\\pic\\anh5.jpg"
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get the base directory of the current executable
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            // Common path part
            string commonPath = "E:\\Tài Liệu Của Cường\\New folder\\picturebox\\pic\\";

            // File names
            string[] fileNames = new string[]
            {
            "anh1.png",
            "anh2.jpg",
            "anh3.jpg",
            "anh4.jpg",
            "anh5.jpg"
            };

            // Construct absolute paths
            string[] absolutePaths = new string[fileNames.Length];
            for (int i = 0; i < fileNames.Length; i++)
            {
                absolutePaths[i] = Path.Combine(commonPath, fileNames[i]);
            }

            string[] relativePaths = new string[absolutePaths.Length];

            for (int i = 0; i < absolutePaths.Length; i++)
            {
                Uri baseUri = new Uri(basePath);
                Uri absoluteUri = new Uri(absolutePaths[i]);
                Uri relativeUri = baseUri.MakeRelativeUri(absoluteUri);
                relativePaths[i] = Uri.UnescapeDataString(relativeUri.ToString()).Replace('/', Path.DirectorySeparatorChar);
            }

            foreach (string path in relativePaths)
            {
                Console.WriteLine(path);
            }
        }
    }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (i == 0)
                i = 4;
            else
                i--;
            pic_Anh.BackgroundImage = Image.FromFile(chuoianh[i]);
            pic_Anh.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox5.BorderStyle = BorderStyle.None;

            switch(i)
            {
                case 0:
                {
                    pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                    break;
                }
                case 1:
                {
                    pictureBox2.BorderStyle = BorderStyle.Fixed3D;
                    break;
                }
                case 2:
                {
                    pictureBox3.BorderStyle = BorderStyle.Fixed3D;
                    break;
                }
                case 3:
                {
                    pictureBox4.BorderStyle = BorderStyle.Fixed3D;
                    break;
                }
                default:
                {
                    pictureBox5.BorderStyle = BorderStyle.Fixed3D;
                    break;
                }
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (i == 4)
                i= 0;
            else
                i++;

            pic_Anh.BackgroundImage = Image.FromFile(chuoianh[i]);
            pic_Anh.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox5.BorderStyle = BorderStyle.None;

            switch (i)
            {
                case 0:
                    {
                        pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                        break;
                    }
                case 1:
                    {
                        pictureBox2.BorderStyle = BorderStyle.Fixed3D;
                        break;
                    }
                case 2:
                    {
                        pictureBox3.BorderStyle = BorderStyle.Fixed3D;
                        break;
                    }
                case 3:
                    {
                        pictureBox4.BorderStyle = BorderStyle.Fixed3D;
                        break;
                    }
                default:
                    {
                        pictureBox5.BorderStyle = BorderStyle.Fixed3D;
                        break;
                    }
            }
        }

        private void btn_Random_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            i=random.Next(0,5);
            pic_Anh.BackgroundImage = Image.FromFile(chuoianh[i]);
            pic_Anh.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox5.BorderStyle = BorderStyle.None;

            switch (i)
            {
                case 0:
                    {
                        pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                        break;
                    }
                case 1:
                    {
                        pictureBox2.BorderStyle = BorderStyle.Fixed3D;
                        break;
                    }
                case 2:
                    {
                        pictureBox3.BorderStyle = BorderStyle.Fixed3D;
                        break;
                    }
                case 3:
                    {
                        pictureBox4.BorderStyle = BorderStyle.Fixed3D;
                        break;
                    }
                default:
                    {
                        pictureBox5.BorderStyle = BorderStyle.Fixed3D;
                        break;
                    }
            }
        }
    }
}
