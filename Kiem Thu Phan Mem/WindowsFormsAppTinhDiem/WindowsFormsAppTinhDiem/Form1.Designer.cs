namespace WindowsFormsAppTinhDiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_tinhdiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kq = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_renluyen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính điểm";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(128, 80);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(244, 20);
            this.txt_a.TabIndex = 1;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(128, 132);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(244, 20);
            this.txt_b.TabIndex = 1;
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(128, 186);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(244, 20);
            this.txt_c.TabIndex = 1;
            // 
            // txt_tinhdiem
            // 
            this.txt_tinhdiem.Location = new System.Drawing.Point(119, 368);
            this.txt_tinhdiem.Name = "txt_tinhdiem";
            this.txt_tinhdiem.Size = new System.Drawing.Size(170, 47);
            this.txt_tinhdiem.TabIndex = 2;
            this.txt_tinhdiem.Text = "Tính điểm";
            this.txt_tinhdiem.UseVisualStyleBackColor = true;
            this.txt_tinhdiem.Click += new System.EventHandler(this.txt_tinhdiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Điểm A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Điểm B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm C:";
            // 
            // txt_kq
            // 
            this.txt_kq.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_kq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kq.Location = new System.Drawing.Point(128, 298);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(244, 40);
            this.txt_kq.TabIndex = 3;
            this.txt_kq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kết quả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Điểm rèn luyện:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 20);
            this.textBox1.TabIndex = 1;
            // 
            // txt_renluyen
            // 
            this.txt_renluyen.Location = new System.Drawing.Point(128, 242);
            this.txt_renluyen.Name = "txt_renluyen";
            this.txt_renluyen.Size = new System.Drawing.Size(244, 20);
            this.txt_renluyen.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 437);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tinhdiem);
            this.Controls.Add(this.txt_renluyen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính điểm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Button txt_tinhdiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_kq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_renluyen;
    }
}

