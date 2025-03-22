namespace QuanLySinhVien
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
            btn_ShowThongTin = new Button();
            dtgv_Monhoc = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_MaMonHoc = new TextBox();
            txt_TenMonHoc = new TextBox();
            txt_SoTinChi = new TextBox();
            label4 = new Label();
            cb_TimMa = new ComboBox();
            btn_TimMonCombo = new Button();
            cb_ShowMa = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            btn_TimTheoTuKhoa = new Button();
            groupBox1 = new GroupBox();
            txt_NhapKeyW = new TextBox();
            btn_add = new Button();
            btn_save = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            btn_showdssv = new Button();
            btn_showDssvTheoKhoa = new Button();
            btn_ShowDiem = new Button();
            btn_ShowDiemTheoMon = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgv_Monhoc).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_ShowThongTin
            // 
            btn_ShowThongTin.Font = new Font("Segoe UI", 12F);
            btn_ShowThongTin.Location = new Point(12, 253);
            btn_ShowThongTin.Name = "btn_ShowThongTin";
            btn_ShowThongTin.Size = new Size(187, 47);
            btn_ShowThongTin.TabIndex = 0;
            btn_ShowThongTin.Text = "Hiển thị tất cả";
            btn_ShowThongTin.UseVisualStyleBackColor = true;
            btn_ShowThongTin.Click += button1_Click;
            // 
            // dtgv_Monhoc
            // 
            dtgv_Monhoc.AllowUserToAddRows = false;
            dtgv_Monhoc.AllowUserToDeleteRows = false;
            dtgv_Monhoc.AllowUserToOrderColumns = true;
            dtgv_Monhoc.AllowUserToResizeColumns = false;
            dtgv_Monhoc.AllowUserToResizeRows = false;
            dtgv_Monhoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_Monhoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_Monhoc.Location = new Point(0, 324);
            dtgv_Monhoc.Name = "dtgv_Monhoc";
            dtgv_Monhoc.ReadOnly = true;
            dtgv_Monhoc.RowHeadersWidth = 51;
            dtgv_Monhoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_Monhoc.Size = new Size(1154, 298);
            dtgv_Monhoc.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(20, 23);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 2;
            label1.Text = "Mã môn học:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(20, 78);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 3;
            label2.Text = "Tên môn học:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(20, 136);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 4;
            label3.Text = "Số tín chỉ:";
            // 
            // txt_MaMonHoc
            // 
            txt_MaMonHoc.Enabled = false;
            txt_MaMonHoc.Font = new Font("Segoe UI", 12F);
            txt_MaMonHoc.Location = new Point(168, 20);
            txt_MaMonHoc.Name = "txt_MaMonHoc";
            txt_MaMonHoc.Size = new Size(206, 34);
            txt_MaMonHoc.TabIndex = 5;
            // 
            // txt_TenMonHoc
            // 
            txt_TenMonHoc.Enabled = false;
            txt_TenMonHoc.Font = new Font("Segoe UI", 12F);
            txt_TenMonHoc.Location = new Point(168, 75);
            txt_TenMonHoc.Name = "txt_TenMonHoc";
            txt_TenMonHoc.Size = new Size(206, 34);
            txt_TenMonHoc.TabIndex = 6;
            // 
            // txt_SoTinChi
            // 
            txt_SoTinChi.Enabled = false;
            txt_SoTinChi.Font = new Font("Segoe UI", 12F);
            txt_SoTinChi.Location = new Point(168, 133);
            txt_SoTinChi.Name = "txt_SoTinChi";
            txt_SoTinChi.Size = new Size(206, 34);
            txt_SoTinChi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(418, 23);
            label4.Name = "label4";
            label4.Size = new Size(245, 28);
            label4.TabIndex = 2;
            label4.Text = "Chọn mã môn học cần tìm:";
            // 
            // cb_TimMa
            // 
            cb_TimMa.Font = new Font("Segoe UI", 12F);
            cb_TimMa.FormattingEnabled = true;
            cb_TimMa.Location = new Point(418, 74);
            cb_TimMa.Name = "cb_TimMa";
            cb_TimMa.Size = new Size(186, 36);
            cb_TimMa.TabIndex = 8;
            // 
            // btn_TimMonCombo
            // 
            btn_TimMonCombo.Font = new Font("Segoe UI", 12F);
            btn_TimMonCombo.Location = new Point(625, 131);
            btn_TimMonCombo.Name = "btn_TimMonCombo";
            btn_TimMonCombo.Size = new Size(128, 38);
            btn_TimMonCombo.TabIndex = 0;
            btn_TimMonCombo.Text = "Tìm kiếm";
            btn_TimMonCombo.UseVisualStyleBackColor = true;
            // 
            // cb_ShowMa
            // 
            cb_ShowMa.Font = new Font("Segoe UI", 12F);
            cb_ShowMa.FormattingEnabled = true;
            cb_ShowMa.Location = new Point(418, 132);
            cb_ShowMa.Name = "cb_ShowMa";
            cb_ShowMa.Size = new Size(186, 36);
            cb_ShowMa.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(846, 23);
            label5.Name = "label5";
            label5.Size = new Size(177, 28);
            label5.TabIndex = 2;
            label5.Text = "Tìm kiếm thông tin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(675, 78);
            label6.Name = "label6";
            label6.Size = new Size(136, 28);
            label6.TabIndex = 2;
            label6.Text = "Nhập từ khóa:";
            // 
            // btn_TimTheoTuKhoa
            // 
            btn_TimTheoTuKhoa.Font = new Font("Segoe UI", 12F);
            btn_TimTheoTuKhoa.Location = new Point(871, 131);
            btn_TimTheoTuKhoa.Name = "btn_TimTheoTuKhoa";
            btn_TimTheoTuKhoa.Size = new Size(128, 38);
            btn_TimTheoTuKhoa.TabIndex = 0;
            btn_TimTheoTuKhoa.Text = "Tìm kiếm";
            btn_TimTheoTuKhoa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cb_ShowMa);
            groupBox1.Controls.Add(btn_TimMonCombo);
            groupBox1.Controls.Add(btn_TimTheoTuKhoa);
            groupBox1.Controls.Add(cb_TimMa);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_SoTinChi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_NhapKeyW);
            groupBox1.Controls.Add(txt_TenMonHoc);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_MaMonHoc);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1130, 212);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // txt_NhapKeyW
            // 
            txt_NhapKeyW.Font = new Font("Segoe UI", 12F);
            txt_NhapKeyW.Location = new Point(837, 78);
            txt_NhapKeyW.Name = "txt_NhapKeyW";
            txt_NhapKeyW.Size = new Size(206, 34);
            txt_NhapKeyW.TabIndex = 6;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 12F);
            btn_add.Location = new Point(12, 637);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(103, 38);
            btn_add.TabIndex = 0;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_save
            // 
            btn_save.Enabled = false;
            btn_save.Font = new Font("Segoe UI", 12F);
            btn_save.Location = new Point(121, 637);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(103, 38);
            btn_save.TabIndex = 0;
            btn_save.Text = "Lưu";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_edit
            // 
            btn_edit.Enabled = false;
            btn_edit.Font = new Font("Segoe UI", 12F);
            btn_edit.Location = new Point(230, 637);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(103, 38);
            btn_edit.TabIndex = 0;
            btn_edit.Text = "Sửa";
            btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.Enabled = false;
            btn_delete.Font = new Font("Segoe UI", 12F);
            btn_delete.Location = new Point(339, 637);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(103, 38);
            btn_delete.TabIndex = 0;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_showdssv
            // 
            btn_showdssv.Font = new Font("Segoe UI", 12F);
            btn_showdssv.Location = new Point(448, 637);
            btn_showdssv.Name = "btn_showdssv";
            btn_showdssv.Size = new Size(127, 38);
            btn_showdssv.TabIndex = 0;
            btn_showdssv.Text = "Xem DSSV";
            btn_showdssv.UseVisualStyleBackColor = true;
            // 
            // btn_showDssvTheoKhoa
            // 
            btn_showDssvTheoKhoa.Font = new Font("Segoe UI", 12F);
            btn_showDssvTheoKhoa.Location = new Point(581, 637);
            btn_showDssvTheoKhoa.Name = "btn_showDssvTheoKhoa";
            btn_showDssvTheoKhoa.Size = new Size(212, 38);
            btn_showDssvTheoKhoa.TabIndex = 0;
            btn_showDssvTheoKhoa.Text = "Xem DSSV theo khoa";
            btn_showDssvTheoKhoa.UseVisualStyleBackColor = true;
            // 
            // btn_ShowDiem
            // 
            btn_ShowDiem.Font = new Font("Segoe UI", 12F);
            btn_ShowDiem.Location = new Point(799, 637);
            btn_ShowDiem.Name = "btn_ShowDiem";
            btn_ShowDiem.Size = new Size(128, 38);
            btn_ShowDiem.TabIndex = 0;
            btn_ShowDiem.Text = "Xem điểm";
            btn_ShowDiem.UseVisualStyleBackColor = true;
            // 
            // btn_ShowDiemTheoMon
            // 
            btn_ShowDiemTheoMon.Font = new Font("Segoe UI", 12F);
            btn_ShowDiemTheoMon.Location = new Point(933, 637);
            btn_ShowDiemTheoMon.Name = "btn_ShowDiemTheoMon";
            btn_ShowDiemTheoMon.Size = new Size(212, 38);
            btn_ShowDiemTheoMon.TabIndex = 0;
            btn_ShowDiemTheoMon.Text = "Xem điểm theo môn";
            btn_ShowDiemTheoMon.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 687);
            Controls.Add(groupBox1);
            Controls.Add(dtgv_Monhoc);
            Controls.Add(btn_ShowThongTin);
            Controls.Add(btn_ShowDiemTheoMon);
            Controls.Add(btn_showDssvTheoKhoa);
            Controls.Add(btn_ShowDiem);
            Controls.Add(btn_showdssv);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_save);
            Controls.Add(btn_add);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_Monhoc).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_ShowThongTin;
        private DataGridView dtgv_Monhoc;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_MaMonHoc;
        private TextBox txt_TenMonHoc;
        private TextBox txt_SoTinChi;
        private Label label4;
        private ComboBox cb_TimMa;
        private Button btn_TimMonCombo;
        private ComboBox cb_ShowMa;
        private Label label5;
        private Label label6;
        private Button btn_TimTheoTuKhoa;
        private GroupBox groupBox1;
        private Button btn_add;
        private Button btn_save;
        private Button btn_edit;
        private Button btn_delete;
        private Button btn_showdssv;
        private Button btn_showDssvTheoKhoa;
        private Button btn_ShowDiem;
        private Button btn_ShowDiemTheoMon;
        private TextBox txt_NhapKeyW;
    }
}