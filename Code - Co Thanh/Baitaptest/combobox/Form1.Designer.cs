namespace combobox
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
            this.components = new System.ComponentModel.Container();
            this.cbo__Tinh = new System.Windows.Forms.ComboBox();
            this.lbl__TenTinhChon = new System.Windows.Forms.Label();
            this.lbl__KetQua = new System.Windows.Forms.Label();
            this.btn__HienThi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn__Add = new System.Windows.Forms.Button();
            this.txt__Add = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo__Tinh
            // 
            this.cbo__Tinh.FormattingEnabled = true;
            this.cbo__Tinh.Items.AddRange(new object[] {
            "Thanh Pho HCM",
            "Ba Ria Vung Tau",
            "Ha Noi",
            "Hue",
            "Nam Dinh",
            "Nghe An"});
            this.cbo__Tinh.Location = new System.Drawing.Point(286, 72);
            this.cbo__Tinh.Name = "cbo__Tinh";
            this.cbo__Tinh.Size = new System.Drawing.Size(121, 24);
            this.cbo__Tinh.TabIndex = 0;
            // 
            // lbl__TenTinhChon
            // 
            this.lbl__TenTinhChon.AutoSize = true;
            this.lbl__TenTinhChon.Location = new System.Drawing.Point(101, 133);
            this.lbl__TenTinhChon.Name = "lbl__TenTinhChon";
            this.lbl__TenTinhChon.Size = new System.Drawing.Size(127, 16);
            this.lbl__TenTinhChon.TabIndex = 1;
            this.lbl__TenTinhChon.Text = "Ten Tinh Ban Chon: ";
            // 
            // lbl__KetQua
            // 
            this.lbl__KetQua.AutoSize = true;
            this.lbl__KetQua.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl__KetQua.Location = new System.Drawing.Point(310, 133);
            this.lbl__KetQua.Name = "lbl__KetQua";
            this.lbl__KetQua.Size = new System.Drawing.Size(0, 16);
            this.lbl__KetQua.TabIndex = 2;
            // 
            // btn__HienThi
            // 
            this.btn__HienThi.Location = new System.Drawing.Point(476, 66);
            this.btn__HienThi.Name = "btn__HienThi";
            this.btn__HienThi.Size = new System.Drawing.Size(99, 35);
            this.btn__HienThi.TabIndex = 3;
            this.btn__HienThi.Text = "HienThi";
            this.btn__HienThi.UseVisualStyleBackColor = true;
            this.btn__HienThi.Click += new System.EventHandler(this.btn__HienThi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhap Ten Tinh Muon Them Vao:";
            // 
            // btn__Add
            // 
            this.btn__Add.Location = new System.Drawing.Point(476, 203);
            this.btn__Add.Name = "btn__Add";
            this.btn__Add.Size = new System.Drawing.Size(99, 35);
            this.btn__Add.TabIndex = 6;
            this.btn__Add.Text = "Them";
            this.btn__Add.UseVisualStyleBackColor = true;
            this.btn__Add.Click += new System.EventHandler(this.btn__Add_Click);
            // 
            // txt__Add
            // 
            this.txt__Add.Location = new System.Drawing.Point(324, 209);
            this.txt__Add.Name = "txt__Add";
            this.txt__Add.Size = new System.Drawing.Size(100, 22);
            this.txt__Add.TabIndex = 7;
            this.txt__Add.TextChanged += new System.EventHandler(this.txt__Add_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt__Add);
            this.Controls.Add(this.btn__Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn__HienThi);
            this.Controls.Add(this.lbl__KetQua);
            this.Controls.Add(this.lbl__TenTinhChon);
            this.Controls.Add(this.cbo__Tinh);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo__Tinh;
        private System.Windows.Forms.Label lbl__TenTinhChon;
        private System.Windows.Forms.Label lbl__KetQua;
        private System.Windows.Forms.Button btn__HienThi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txt__Add;
        private System.Windows.Forms.Button btn__Add;
        private System.Windows.Forms.Label label1;
    }
}

