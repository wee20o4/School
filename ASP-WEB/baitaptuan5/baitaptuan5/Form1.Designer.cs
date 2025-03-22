namespace baitaptuan5
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
            this.grp_ttchung = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.grp_btn = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_ttnv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grp_ttchung.SuspendLayout();
            this.grp_btn.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_ttchung
            // 
            this.grp_ttchung.Controls.Add(this.label5);
            this.grp_ttchung.Controls.Add(this.date_ngaysinh);
            this.grp_ttchung.Controls.Add(this.txt_diachi);
            this.grp_ttchung.Controls.Add(this.label4);
            this.grp_ttchung.Controls.Add(this.txt_phone);
            this.grp_ttchung.Controls.Add(this.label3);
            this.grp_ttchung.Controls.Add(this.txt_ten);
            this.grp_ttchung.Controls.Add(this.label2);
            this.grp_ttchung.Location = new System.Drawing.Point(18, 148);
            this.grp_ttchung.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grp_ttchung.Name = "grp_ttchung";
            this.grp_ttchung.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grp_ttchung.Size = new System.Drawing.Size(1056, 173);
            this.grp_ttchung.TabIndex = 0;
            this.grp_ttchung.TabStop = false;
            this.grp_ttchung.Text = "Thông tin chi tiết";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1092, 124);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Mục Nhân Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên:";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(128, 53);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(375, 30);
            this.txt_ten.TabIndex = 1;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(651, 53);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(375, 30);
            this.txt_phone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điện thoại:";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(651, 116);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(375, 30);
            this.txt_diachi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ:";
            // 
            // date_ngaysinh
            // 
            this.date_ngaysinh.Location = new System.Drawing.Point(128, 116);
            this.date_ngaysinh.Name = "date_ngaysinh";
            this.date_ngaysinh.Size = new System.Drawing.Size(375, 30);
            this.date_ngaysinh.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày sinh:";
            // 
            // grp_btn
            // 
            this.grp_btn.Controls.Add(this.btn_close);
            this.grp_btn.Controls.Add(this.btn_remove);
            this.grp_btn.Controls.Add(this.btn_edit);
            this.grp_btn.Controls.Add(this.btn_add);
            this.grp_btn.Location = new System.Drawing.Point(350, 329);
            this.grp_btn.Name = "grp_btn";
            this.grp_btn.Size = new System.Drawing.Size(724, 138);
            this.grp_btn.TabIndex = 2;
            this.grp_btn.TabStop = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(27, 29);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(164, 84);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_edit.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit.Location = new System.Drawing.Point(197, 29);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(164, 84);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.Brown;
            this.btn_remove.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_remove.Location = new System.Drawing.Point(367, 29);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(164, 84);
            this.btn_remove.TabIndex = 2;
            this.btn_remove.Text = "Xóa";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_close.Location = new System.Drawing.Point(537, 29);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(164, 84);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Thoát";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_ttnv);
            this.groupBox1.Location = new System.Drawing.Point(18, 473);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 310);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chính";
            // 
            // lv_ttnv
            // 
            this.lv_ttnv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_ttnv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_ttnv.FullRowSelect = true;
            this.lv_ttnv.GridLines = true;
            this.lv_ttnv.HideSelection = false;
            this.lv_ttnv.Location = new System.Drawing.Point(3, 26);
            this.lv_ttnv.Name = "lv_ttnv";
            this.lv_ttnv.Size = new System.Drawing.Size(1050, 281);
            this.lv_ttnv.TabIndex = 0;
            this.lv_ttnv.UseCompatibleStateImageBehavior = false;
            this.lv_ttnv.View = System.Windows.Forms.View.Details;
            this.lv_ttnv.SelectedIndexChanged += new System.EventHandler(this.lv_ttnv_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ Tên";
            this.columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày Sinh";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Địa chỉ";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Điện thoại";
            this.columnHeader4.Width = 180;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1092, 795);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_ttchung);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grp_ttchung.ResumeLayout(false);
            this.grp_ttchung.PerformLayout();
            this.grp_btn.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_ttchung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date_ngaysinh;
        private System.Windows.Forms.GroupBox grp_btn;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lv_ttnv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

