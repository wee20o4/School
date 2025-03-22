namespace listbox
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
            this.grpchucnang = new System.Windows.Forms.GroupBox();
            this.btnchonsole = new System.Windows.Forms.Button();
            this.btnchonsochan = new System.Windows.Forms.Button();
            this.btnbinhphuong = new System.Windows.Forms.Button();
            this.btnxoadauvacuoi = new System.Windows.Forms.Button();
            this.btnxoaptdangchon = new System.Windows.Forms.Button();
            this.btntangmoiptlen2 = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.lstdanhsach = new System.Windows.Forms.ListBox();
            this.grpds = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnhapso = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpchucnang.SuspendLayout();
            this.grpds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpchucnang
            // 
            this.grpchucnang.Controls.Add(this.btnchonsole);
            this.grpchucnang.Controls.Add(this.btnchonsochan);
            this.grpchucnang.Controls.Add(this.btnbinhphuong);
            this.grpchucnang.Controls.Add(this.btnxoadauvacuoi);
            this.grpchucnang.Controls.Add(this.btnxoaptdangchon);
            this.grpchucnang.Controls.Add(this.btntangmoiptlen2);
            this.grpchucnang.Controls.Add(this.btnTong);
            this.grpchucnang.Location = new System.Drawing.Point(487, 85);
            this.grpchucnang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpchucnang.Name = "grpchucnang";
            this.grpchucnang.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpchucnang.Size = new System.Drawing.Size(364, 399);
            this.grpchucnang.TabIndex = 0;
            this.grpchucnang.TabStop = false;
            this.grpchucnang.Text = "Chọn Chức Năng";
            // 
            // btnchonsole
            // 
            this.btnchonsole.Location = new System.Drawing.Point(7, 324);
            this.btnchonsole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnchonsole.Name = "btnchonsole";
            this.btnchonsole.Size = new System.Drawing.Size(351, 38);
            this.btnchonsole.TabIndex = 6;
            this.btnchonsole.Text = "Chọn Số Lẻ";
            this.btnchonsole.UseVisualStyleBackColor = true;
            this.btnchonsole.Click += new System.EventHandler(this.btnchonsole_Click);
            // 
            // btnchonsochan
            // 
            this.btnchonsochan.Location = new System.Drawing.Point(7, 278);
            this.btnchonsochan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnchonsochan.Name = "btnchonsochan";
            this.btnchonsochan.Size = new System.Drawing.Size(351, 38);
            this.btnchonsochan.TabIndex = 5;
            this.btnchonsochan.Text = "Chọn Số Chẳn";
            this.btnchonsochan.UseVisualStyleBackColor = true;
            this.btnchonsochan.Click += new System.EventHandler(this.btnchonsochan_Click);
            // 
            // btnbinhphuong
            // 
            this.btnbinhphuong.Location = new System.Drawing.Point(7, 231);
            this.btnbinhphuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnbinhphuong.Name = "btnbinhphuong";
            this.btnbinhphuong.Size = new System.Drawing.Size(351, 38);
            this.btnbinhphuong.TabIndex = 4;
            this.btnbinhphuong.Text = "Thay Bằng Bình Phương";
            this.btnbinhphuong.UseVisualStyleBackColor = true;
            this.btnbinhphuong.Click += new System.EventHandler(this.btnbinhphuong_Click);
            // 
            // btnxoadauvacuoi
            // 
            this.btnxoadauvacuoi.Location = new System.Drawing.Point(7, 91);
            this.btnxoadauvacuoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxoadauvacuoi.Name = "btnxoadauvacuoi";
            this.btnxoadauvacuoi.Size = new System.Drawing.Size(351, 38);
            this.btnxoadauvacuoi.TabIndex = 3;
            this.btnxoadauvacuoi.Text = "Xóa Phần Tử Đầu Và Cuối";
            this.btnxoadauvacuoi.UseVisualStyleBackColor = true;
            this.btnxoadauvacuoi.Click += new System.EventHandler(this.btnxoadauvacuoi_Click);
            // 
            // btnxoaptdangchon
            // 
            this.btnxoaptdangchon.Location = new System.Drawing.Point(7, 138);
            this.btnxoaptdangchon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxoaptdangchon.Name = "btnxoaptdangchon";
            this.btnxoaptdangchon.Size = new System.Drawing.Size(351, 38);
            this.btnxoaptdangchon.TabIndex = 2;
            this.btnxoaptdangchon.Text = "Xóa Phần Tử Đang Chọn";
            this.btnxoaptdangchon.UseVisualStyleBackColor = true;
            this.btnxoaptdangchon.Click += new System.EventHandler(this.btnxoaptdangchon_Click);
            // 
            // btntangmoiptlen2
            // 
            this.btntangmoiptlen2.Location = new System.Drawing.Point(7, 184);
            this.btntangmoiptlen2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btntangmoiptlen2.Name = "btntangmoiptlen2";
            this.btntangmoiptlen2.Size = new System.Drawing.Size(351, 38);
            this.btntangmoiptlen2.TabIndex = 1;
            this.btntangmoiptlen2.Text = "Tăng Mỗi Phần Tử Lên 2";
            this.btntangmoiptlen2.UseVisualStyleBackColor = true;
            this.btntangmoiptlen2.Click += new System.EventHandler(this.btntangmoiptlen2_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(7, 44);
            this.btnTong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(351, 38);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tính Tổng Danh Sách";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // lstdanhsach
            // 
            this.lstdanhsach.FormattingEnabled = true;
            this.lstdanhsach.ItemHeight = 22;
            this.lstdanhsach.Location = new System.Drawing.Point(7, 29);
            this.lstdanhsach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstdanhsach.Name = "lstdanhsach";
            this.lstdanhsach.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstdanhsach.Size = new System.Drawing.Size(350, 334);
            this.lstdanhsach.TabIndex = 1;
            this.lstdanhsach.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // grpds
            // 
            this.grpds.Controls.Add(this.lstdanhsach);
            this.grpds.Location = new System.Drawing.Point(29, 85);
            this.grpds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpds.Name = "grpds";
            this.grpds.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpds.Size = new System.Drawing.Size(364, 399);
            this.grpds.TabIndex = 1;
            this.grpds.TabStop = false;
            this.grpds.Text = "Danh Sách Số";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(35, 503);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(816, 56);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "Kết Thúc";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(542, 33);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(84, 32);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập số";
            // 
            // txtnhapso
            // 
            this.txtnhapso.Location = new System.Drawing.Point(127, 33);
            this.txtnhapso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnhapso.Name = "txtnhapso";
            this.txtnhapso.Size = new System.Drawing.Size(347, 29);
            this.txtnhapso.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 600);
            this.Controls.Add(this.txtnhapso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.grpds);
            this.Controls.Add(this.grpchucnang);
            this.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tuong Tac Voi List Box";
            this.grpchucnang.ResumeLayout(false);
            this.grpds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpchucnang;
        private System.Windows.Forms.ListBox lstdanhsach;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.GroupBox grpds;
        private System.Windows.Forms.Button btnchonsole;
        private System.Windows.Forms.Button btnchonsochan;
        private System.Windows.Forms.Button btnbinhphuong;
        private System.Windows.Forms.Button btnxoadauvacuoi;
        private System.Windows.Forms.Button btnxoaptdangchon;
        private System.Windows.Forms.Button btntangmoiptlen2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhapso;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

