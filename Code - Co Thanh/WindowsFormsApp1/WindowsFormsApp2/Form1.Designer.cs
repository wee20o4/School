namespace WindowsFormsApp2
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
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblsonguyen1 = new System.Windows.Forms.Label();
            this.lblsonguyen2 = new System.Windows.Forms.Label();
            this.btntinhtong = new System.Windows.Forms.Button();
            this.btntinhthuong = new System.Windows.Forms.Button();
            this.btntinhtich = new System.Windows.Forms.Button();
            this.btntichhieu = new System.Windows.Forms.Button();
            this.lblketqua = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.White;
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(328, 141);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(286, 34);
            this.txtB.TabIndex = 10;
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.White;
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(328, 70);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(286, 34);
            this.txtA.TabIndex = 9;
            // 
            // lblsonguyen1
            // 
            this.lblsonguyen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.lblsonguyen1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsonguyen1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblsonguyen1.Location = new System.Drawing.Point(85, 65);
            this.lblsonguyen1.Name = "lblsonguyen1";
            this.lblsonguyen1.Size = new System.Drawing.Size(200, 46);
            this.lblsonguyen1.TabIndex = 15;
            this.lblsonguyen1.Text = "Số nguyên 1:";
            this.lblsonguyen1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsonguyen2
            // 
            this.lblsonguyen2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.lblsonguyen2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsonguyen2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblsonguyen2.Location = new System.Drawing.Point(85, 137);
            this.lblsonguyen2.Name = "lblsonguyen2";
            this.lblsonguyen2.Size = new System.Drawing.Size(200, 45);
            this.lblsonguyen2.TabIndex = 16;
            this.lblsonguyen2.Text = "Số nguyên 2:";
            this.lblsonguyen2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btntinhtong
            // 
            this.btntinhtong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(221)))));
            this.btntinhtong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinhtong.Location = new System.Drawing.Point(46, 328);
            this.btntinhtong.Name = "btntinhtong";
            this.btntinhtong.Size = new System.Drawing.Size(127, 45);
            this.btntinhtong.TabIndex = 17;
            this.btntinhtong.Text = "Tính Tổng";
            this.btntinhtong.UseVisualStyleBackColor = false;
            this.btntinhtong.Click += new System.EventHandler(this.btntinhtong_Click);
            // 
            // btntinhthuong
            // 
            this.btntinhthuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(142)))), ((int)(((byte)(131)))));
            this.btntinhthuong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinhthuong.Location = new System.Drawing.Point(619, 328);
            this.btntinhthuong.Name = "btntinhthuong";
            this.btntinhthuong.Size = new System.Drawing.Size(138, 45);
            this.btntinhthuong.TabIndex = 18;
            this.btntinhthuong.Text = "Tính Thương";
            this.btntinhthuong.UseVisualStyleBackColor = false;
            this.btntinhthuong.Click += new System.EventHandler(this.btntinhthuong_Click);
            // 
            // btntinhtich
            // 
            this.btntinhtich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(102)))), ((int)(((byte)(121)))));
            this.btntinhtich.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinhtich.Location = new System.Drawing.Point(428, 328);
            this.btntinhtich.Name = "btntinhtich";
            this.btntinhtich.Size = new System.Drawing.Size(127, 45);
            this.btntinhtich.TabIndex = 19;
            this.btntinhtich.Text = "Tính Tích";
            this.btntinhtich.UseVisualStyleBackColor = false;
            this.btntinhtich.Click += new System.EventHandler(this.btntinhtich_Click);
            // 
            // btntichhieu
            // 
            this.btntichhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(122)))), ((int)(((byte)(221)))));
            this.btntichhieu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntichhieu.Location = new System.Drawing.Point(235, 328);
            this.btntichhieu.Name = "btntichhieu";
            this.btntichhieu.Size = new System.Drawing.Size(127, 45);
            this.btntichhieu.TabIndex = 20;
            this.btntichhieu.Text = "Tính Hiệu";
            this.btntichhieu.UseVisualStyleBackColor = false;
            this.btntichhieu.Click += new System.EventHandler(this.btntichhieu_Click);
            // 
            // lblketqua
            // 
            this.lblketqua.BackColor = System.Drawing.Color.White;
            this.lblketqua.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblketqua.Location = new System.Drawing.Point(275, 231);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(293, 59);
            this.lblketqua.TabIndex = 21;
            this.lblketqua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(111)))), ((int)(((byte)(101)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(57, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 46);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kết quả:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Red;
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(406, 393);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(127, 45);
            this.btnthoat.TabIndex = 23;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnreset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnreset.Location = new System.Drawing.Point(259, 393);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(127, 45);
            this.btnreset.TabIndex = 24;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(173)))), ((int)(((byte)(193)))));
            this.CancelButton = this.btnthoat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.btntichhieu);
            this.Controls.Add(this.btntinhtich);
            this.Controls.Add(this.btntinhthuong);
            this.Controls.Add(this.btntinhtong);
            this.Controls.Add(this.lblsonguyen2);
            this.Controls.Add(this.lblsonguyen1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblsonguyen1;
        private System.Windows.Forms.Label lblsonguyen2;
        private System.Windows.Forms.Button btntinhtong;
        private System.Windows.Forms.Button btntinhthuong;
        private System.Windows.Forms.Button btntinhtich;
        private System.Windows.Forms.Button btntichhieu;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnreset;
    }
}

