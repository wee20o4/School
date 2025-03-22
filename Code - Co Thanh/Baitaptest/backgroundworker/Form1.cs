using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backgroundworker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < 101; i++) {
                sum+= i;
                backgroundWorker1.ReportProgress(i);
                if(backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }
            e.Result = sum;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value=e.ProgressPercentage;
            btn__TienTrinh.Text=e.ProgressPercentage.ToString()+"%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled==true)
            {
                btn__KetQua.Text = "Da Huy";
            }
            else if(e.Error!=null)
            {
                btn__KetQua.Text=e.Error.ToString();
            }
            else
            {
                btn__KetQua.Text="Ket qua la: "+e.Result.ToString();
            }
        }

        private void btn__TinhTong_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                btn__KetQua.Text = "Dang Ban";
            }
        }
    }
}
