namespace backgroundworker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn__TinhTong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn__Cancel = new System.Windows.Forms.Button();
            this.btn__KetQua = new System.Windows.Forms.Label();
            this.btn__TienTrinh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btn__TinhTong
            // 
            this.btn__TinhTong.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__TinhTong.Location = new System.Drawing.Point(175, 251);
            this.btn__TinhTong.Name = "btn__TinhTong";
            this.btn__TinhTong.Size = new System.Drawing.Size(178, 58);
            this.btn__TinhTong.TabIndex = 0;
            this.btn__TinhTong.Text = "Tinh Tong";
            this.btn__TinhTong.UseVisualStyleBackColor = true;
            this.btn__TinhTong.Click += new System.EventHandler(this.btn__TinhTong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tinh Tong Tu 1 Den 100";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(146, 147);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(476, 35);
            this.progressBar1.TabIndex = 2;
            // 
            // btn__Cancel
            // 
            this.btn__Cancel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__Cancel.Location = new System.Drawing.Point(413, 251);
            this.btn__Cancel.Name = "btn__Cancel";
            this.btn__Cancel.Size = new System.Drawing.Size(178, 58);
            this.btn__Cancel.TabIndex = 3;
            this.btn__Cancel.Text = "Cancel";
            this.btn__Cancel.UseVisualStyleBackColor = true;
            // 
            // btn__KetQua
            // 
            this.btn__KetQua.AutoSize = true;
            this.btn__KetQua.Location = new System.Drawing.Point(364, 365);
            this.btn__KetQua.Name = "btn__KetQua";
            this.btn__KetQua.Size = new System.Drawing.Size(44, 16);
            this.btn__KetQua.TabIndex = 4;
            this.btn__KetQua.Text = "label2";
            // 
            // btn__TienTrinh
            // 
            this.btn__TienTrinh.AutoSize = true;
            this.btn__TienTrinh.Location = new System.Drawing.Point(639, 157);
            this.btn__TienTrinh.Name = "btn__TienTrinh";
            this.btn__TienTrinh.Size = new System.Drawing.Size(44, 16);
            this.btn__TienTrinh.TabIndex = 5;
            this.btn__TienTrinh.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn__TienTrinh);
            this.Controls.Add(this.btn__KetQua);
            this.Controls.Add(this.btn__Cancel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn__TinhTong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn__TinhTong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn__Cancel;
        private System.Windows.Forms.Label btn__KetQua;
        private System.Windows.Forms.Label btn__TienTrinh;
    }
}

