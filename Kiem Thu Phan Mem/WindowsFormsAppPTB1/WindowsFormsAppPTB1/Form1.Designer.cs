namespace WindowsFormsAppPTB1
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
            this.labelll = new System.Windows.Forms.Label();
            this.lablllll = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.btn_tinh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelll
            // 
            this.labelll.AutoSize = true;
            this.labelll.Location = new System.Drawing.Point(78, 58);
            this.labelll.Name = "labelll";
            this.labelll.Size = new System.Drawing.Size(33, 13);
            this.labelll.TabIndex = 0;
            this.labelll.Text = "Số A:";
            // 
            // lablllll
            // 
            this.lablllll.AutoSize = true;
            this.lablllll.Location = new System.Drawing.Point(78, 98);
            this.lablllll.Name = "lablllll";
            this.lablllll.Size = new System.Drawing.Size(33, 13);
            this.lablllll.TabIndex = 0;
            this.lablllll.Text = "Số B:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kết quả:";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(151, 58);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(226, 20);
            this.txt_a.TabIndex = 1;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(151, 98);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(226, 20);
            this.txt_b.TabIndex = 1;
            // 
            // txt_kq
            // 
            this.txt_kq.Location = new System.Drawing.Point(151, 143);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(226, 20);
            this.txt_kq.TabIndex = 1;
            // 
            // btn_tinh
            // 
            this.btn_tinh.Location = new System.Drawing.Point(167, 203);
            this.btn_tinh.Name = "btn_tinh";
            this.btn_tinh.Size = new System.Drawing.Size(89, 35);
            this.btn_tinh.TabIndex = 2;
            this.btn_tinh.Text = "Tính";
            this.btn_tinh.UseVisualStyleBackColor = true;
            this.btn_tinh.Click += new System.EventHandler(this.btn_tinh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giải phương trình bật nhất";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 264);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_tinh);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lablllll);
            this.Controls.Add(this.labelll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelll;
        private System.Windows.Forms.Label lablllll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_kq;
        private System.Windows.Forms.Button btn_tinh;
        private System.Windows.Forms.Label label1;
    }
}

