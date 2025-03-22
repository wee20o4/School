namespace WindowsFormsApp1
{
    partial class frmbai1
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
            this.iputemail = new System.Windows.Forms.TextBox();
            this.inputpassword = new System.Windows.Forms.TextBox();
            this.lbldangnhap = new System.Windows.Forms.Label();
            this.btndangki = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.btnout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iputemail
            // 
            this.iputemail.BackColor = System.Drawing.Color.White;
            this.iputemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iputemail.Location = new System.Drawing.Point(259, 177);
            this.iputemail.Name = "iputemail";
            this.iputemail.Size = new System.Drawing.Size(286, 34);
            this.iputemail.TabIndex = 0;
            this.iputemail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputpassword
            // 
            this.inputpassword.BackColor = System.Drawing.Color.White;
            this.inputpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputpassword.Location = new System.Drawing.Point(259, 248);
            this.inputpassword.Name = "inputpassword";
            this.inputpassword.Size = new System.Drawing.Size(286, 34);
            this.inputpassword.TabIndex = 2;
            // 
            // lbldangnhap
            // 
            this.lbldangnhap.AutoSize = true;
            this.lbldangnhap.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldangnhap.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbldangnhap.Location = new System.Drawing.Point(246, 32);
            this.lbldangnhap.Name = "lbldangnhap";
            this.lbldangnhap.Size = new System.Drawing.Size(308, 73);
            this.lbldangnhap.TabIndex = 4;
            this.lbldangnhap.Text = "Đăng Nhập";
            this.lbldangnhap.Click += new System.EventHandler(this.label1_Click);
            // 
            // btndangki
            // 
            this.btndangki.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btndangki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.btndangki.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangki.ForeColor = System.Drawing.Color.White;
            this.btndangki.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndangki.Location = new System.Drawing.Point(409, 333);
            this.btndangki.Name = "btndangki";
            this.btndangki.Padding = new System.Windows.Forms.Padding(5);
            this.btndangki.Size = new System.Drawing.Size(164, 56);
            this.btndangki.TabIndex = 5;
            this.btndangki.Text = "Đăng Kí";
            this.btndangki.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(237, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(237, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "PassWord:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btndangnhap
            // 
            this.btndangnhap.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btndangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.btndangnhap.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.ForeColor = System.Drawing.Color.White;
            this.btndangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndangnhap.Location = new System.Drawing.Point(239, 333);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Padding = new System.Windows.Forms.Padding(5);
            this.btndangnhap.Size = new System.Drawing.Size(164, 56);
            this.btndangnhap.TabIndex = 8;
            this.btndangnhap.Text = "Đăng Nhập";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // btnout
            // 
            this.btnout.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.btnout.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnout.ForeColor = System.Drawing.Color.White;
            this.btnout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnout.Location = new System.Drawing.Point(31, 32);
            this.btnout.Name = "btnout";
            this.btnout.Padding = new System.Windows.Forms.Padding(5);
            this.btnout.Size = new System.Drawing.Size(85, 45);
            this.btnout.TabIndex = 9;
            this.btnout.Text = "Thoát";
            this.btnout.UseVisualStyleBackColor = false;
            // 
            // frmbai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(173)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnout);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndangki);
            this.Controls.Add(this.lbldangnhap);
            this.Controls.Add(this.inputpassword);
            this.Controls.Add(this.iputemail);
            this.Name = "frmbai1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmbai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox iputemail;
        private System.Windows.Forms.TextBox inputpassword;
        private System.Windows.Forms.Label lbldangnhap;
        private System.Windows.Forms.Button btndangki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Button btnout;
    }
}

