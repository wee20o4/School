namespace QuanLyNhaKhoa
{
    partial class DangNhap
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.pic_image = new System.Windows.Forms.PictureBox();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.lbl_tk = new System.Windows.Forms.Label();
            this.lbl_mk = new System.Windows.Forms.Label();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pic_lock = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lock)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Goldenrod;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(782, 89);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Đăng nhập";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_image
            // 
            this.pic_image.Location = new System.Drawing.Point(26, 121);
            this.pic_image.Name = "pic_image";
            this.pic_image.Size = new System.Drawing.Size(247, 266);
            this.pic_image.TabIndex = 1;
            this.pic_image.TabStop = false;
            // 
            // txt_tk
            // 
            this.txt_tk.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tk.Location = new System.Drawing.Point(486, 129);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(269, 45);
            this.txt_tk.TabIndex = 2;
            // 
            // lbl_tk
            // 
            this.lbl_tk.AutoSize = true;
            this.lbl_tk.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tk.Location = new System.Drawing.Point(312, 137);
            this.lbl_tk.Name = "lbl_tk";
            this.lbl_tk.Size = new System.Drawing.Size(145, 32);
            this.lbl_tk.TabIndex = 3;
            this.lbl_tk.Text = "Tài khoản:";
            // 
            // lbl_mk
            // 
            this.lbl_mk.AutoSize = true;
            this.lbl_mk.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_mk.Location = new System.Drawing.Point(312, 236);
            this.lbl_mk.Name = "lbl_mk";
            this.lbl_mk.Size = new System.Drawing.Size(140, 32);
            this.lbl_mk.TabIndex = 5;
            this.lbl_mk.Text = "Mật khẩu:";
            // 
            // txt_pw
            // 
            this.txt_pw.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pw.Location = new System.Drawing.Point(486, 228);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Size = new System.Drawing.Size(269, 45);
            this.txt_pw.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(443, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 66);
            this.button1.TabIndex = 6;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pic_lock
            // 
            this.pic_lock.Location = new System.Drawing.Point(364, 316);
            this.pic_lock.Name = "pic_lock";
            this.pic_lock.Size = new System.Drawing.Size(73, 71);
            this.pic_lock.TabIndex = 7;
            this.pic_lock.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(501, 402);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 32);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đăng kí";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pic_lock);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_mk);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.lbl_tk);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.pic_image);
            this.Controls.Add(this.lbl_title);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pic_image;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Label lbl_tk;
        private System.Windows.Forms.Label lbl_mk;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pic_lock;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

