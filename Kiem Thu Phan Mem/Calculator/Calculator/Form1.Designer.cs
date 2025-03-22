namespace Calculator
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_so1 = new System.Windows.Forms.TextBox();
            this.txt_so2 = new System.Windows.Forms.TextBox();
            this.txt_kq = new System.Windows.Forms.Label();
            this.btn_cong = new System.Windows.Forms.Button();
            this.btn_tru = new System.Windows.Forms.Button();
            this.btn_nhan = new System.Windows.Forms.Button();
            this.btn_chia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 1;
            this.label3.Tag = "";
            this.label3.Text = "KQ";
            // 
            // txt_so1
            // 
            this.txt_so1.Location = new System.Drawing.Point(187, 65);
            this.txt_so1.Name = "txt_so1";
            this.txt_so1.Size = new System.Drawing.Size(100, 20);
            this.txt_so1.TabIndex = 2;
            // 
            // txt_so2
            // 
            this.txt_so2.Location = new System.Drawing.Point(187, 106);
            this.txt_so2.Name = "txt_so2";
            this.txt_so2.Size = new System.Drawing.Size(100, 20);
            this.txt_so2.TabIndex = 2;
            // 
            // txt_kq
            // 
            this.txt_kq.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_kq.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_kq.Location = new System.Drawing.Point(184, 151);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(103, 24);
            this.txt_kq.TabIndex = 1;
            this.txt_kq.Tag = "";
            this.txt_kq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cong
            // 
            this.btn_cong.Location = new System.Drawing.Point(20, 217);
            this.btn_cong.Name = "btn_cong";
            this.btn_cong.Size = new System.Drawing.Size(75, 23);
            this.btn_cong.TabIndex = 3;
            this.btn_cong.Text = "Cộng";
            this.btn_cong.UseVisualStyleBackColor = true;
            this.btn_cong.Click += new System.EventHandler(this.btn_cong_Click);
            // 
            // btn_tru
            // 
            this.btn_tru.Location = new System.Drawing.Point(114, 217);
            this.btn_tru.Name = "btn_tru";
            this.btn_tru.Size = new System.Drawing.Size(75, 23);
            this.btn_tru.TabIndex = 3;
            this.btn_tru.Text = "Trừ";
            this.btn_tru.UseVisualStyleBackColor = true;
            this.btn_tru.Click += new System.EventHandler(this.btn_tru_Click);
            // 
            // btn_nhan
            // 
            this.btn_nhan.Location = new System.Drawing.Point(210, 217);
            this.btn_nhan.Name = "btn_nhan";
            this.btn_nhan.Size = new System.Drawing.Size(75, 23);
            this.btn_nhan.TabIndex = 3;
            this.btn_nhan.Text = "Nhân";
            this.btn_nhan.UseVisualStyleBackColor = true;
            this.btn_nhan.Click += new System.EventHandler(this.btn_nhan_Click);
            // 
            // btn_chia
            // 
            this.btn_chia.Location = new System.Drawing.Point(302, 217);
            this.btn_chia.Name = "btn_chia";
            this.btn_chia.Size = new System.Drawing.Size(75, 23);
            this.btn_chia.TabIndex = 3;
            this.btn_chia.Text = "Chia";
            this.btn_chia.UseVisualStyleBackColor = true;
            this.btn_chia.Click += new System.EventHandler(this.btn_chia_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 298);
            this.Controls.Add(this.btn_chia);
            this.Controls.Add(this.btn_nhan);
            this.Controls.Add(this.btn_tru);
            this.Controls.Add(this.btn_cong);
            this.Controls.Add(this.txt_so2);
            this.Controls.Add(this.txt_so1);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_so1;
        private System.Windows.Forms.TextBox txt_so2;
        private System.Windows.Forms.Label txt_kq;
        private System.Windows.Forms.Button btn_cong;
        private System.Windows.Forms.Button btn_tru;
        private System.Windows.Forms.Button btn_nhan;
        private System.Windows.Forms.Button btn_chia;
    }
}

