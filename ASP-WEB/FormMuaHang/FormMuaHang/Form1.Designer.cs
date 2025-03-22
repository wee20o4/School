namespace FormMuaHang
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Mua = new System.Windows.Forms.Button();
            this.cb_Huyen = new System.Windows.Forms.ComboBox();
            this.cb_Tinh = new System.Windows.Forms.ComboBox();
            this.txt_Phuong = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.cb_Mau = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Ten = new System.Windows.Forms.Label();
            this.lbl_ChonMau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.nbr_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.lbl_NamePhone = new System.Windows.Forms.Label();
            this.pic_DienThoai = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pn_ttm = new System.Windows.Forms.Panel();
            this.lbl_ttm_tensp = new System.Windows.Forms.Label();
            this.lbl_ttm_thanhtien = new System.Windows.Forms.Label();
            this.lbl_ttm_phuong = new System.Windows.Forms.Label();
            this.lbl_title_ttnv = new System.Windows.Forms.Label();
            this.lbl_ttm_quan = new System.Windows.Forms.Label();
            this.lbl_ttm_sdt = new System.Windows.Forms.Label();
            this.lbl_ttm_tinh = new System.Windows.Forms.Label();
            this.lbl_ttm_mausac = new System.Windows.Forms.Label();
            this.lbl_ttm_ten = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_SoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DienThoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.pn_ttm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Title.Font = new System.Drawing.Font("JetBrains Mono", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(1034, 86);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Form Mua Hàng";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Title.Click += new System.EventHandler(this.lbl_Title_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Huy);
            this.panel1.Controls.Add(this.btn_Mua);
            this.panel1.Controls.Add(this.cb_Huyen);
            this.panel1.Controls.Add(this.cb_Tinh);
            this.panel1.Controls.Add(this.txt_Phuong);
            this.panel1.Controls.Add(this.txt_phone);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.cb_Mau);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_Ten);
            this.panel1.Controls.Add(this.lbl_ChonMau);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_ThanhTien);
            this.panel1.Controls.Add(this.nbr_SoLuong);
            this.panel1.Controls.Add(this.lbl_NamePhone);
            this.panel1.Controls.Add(this.pic_DienThoai);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 563);
            this.panel1.TabIndex = 1;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(409, 483);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(166, 74);
            this.btn_Huy.TabIndex = 22;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Mua
            // 
            this.btn_Mua.Location = new System.Drawing.Point(237, 483);
            this.btn_Mua.Name = "btn_Mua";
            this.btn_Mua.Size = new System.Drawing.Size(166, 74);
            this.btn_Mua.TabIndex = 21;
            this.btn_Mua.Text = "Mua Hàng";
            this.btn_Mua.UseVisualStyleBackColor = true;
            this.btn_Mua.Click += new System.EventHandler(this.btn_Mua_Click);
            // 
            // cb_Huyen
            // 
            this.cb_Huyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Huyen.FormattingEnabled = true;
            this.cb_Huyen.Location = new System.Drawing.Point(355, 347);
            this.cb_Huyen.Name = "cb_Huyen";
            this.cb_Huyen.Size = new System.Drawing.Size(158, 30);
            this.cb_Huyen.TabIndex = 20;
            // 
            // cb_Tinh
            // 
            this.cb_Tinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Tinh.FormattingEnabled = true;
            this.cb_Tinh.Items.AddRange(new object[] {
            "Thành Phố HCM",
            "Hà Nội"});
            this.cb_Tinh.Location = new System.Drawing.Point(355, 282);
            this.cb_Tinh.Name = "cb_Tinh";
            this.cb_Tinh.Size = new System.Drawing.Size(158, 30);
            this.cb_Tinh.TabIndex = 19;
            this.cb_Tinh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // txt_Phuong
            // 
            this.txt_Phuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phuong.Location = new System.Drawing.Point(355, 410);
            this.txt_Phuong.Name = "txt_Phuong";
            this.txt_Phuong.Size = new System.Drawing.Size(158, 30);
            this.txt_Phuong.TabIndex = 18;
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(355, 221);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(158, 30);
            this.txt_phone.TabIndex = 17;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(355, 169);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(158, 30);
            this.txt_name.TabIndex = 16;
            // 
            // cb_Mau
            // 
            this.cb_Mau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Mau.FormattingEnabled = true;
            this.cb_Mau.Items.AddRange(new object[] {
            "Màu Đen",
            "Màu Xanh",
            "Màu Xanh Nước"});
            this.cb_Mau.Location = new System.Drawing.Point(355, 109);
            this.cb_Mau.Name = "cb_Mau";
            this.cb_Mau.Size = new System.Drawing.Size(158, 30);
            this.cb_Mau.TabIndex = 15;
            this.cb_Mau.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(233, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Phường:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(233, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quận/Huyện:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tỉnh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(233, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số điện thoại:";
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ten.Location = new System.Drawing.Point(233, 173);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(45, 19);
            this.lbl_Ten.TabIndex = 10;
            this.lbl_Ten.Text = "Tên:";
            // 
            // lbl_ChonMau
            // 
            this.lbl_ChonMau.AutoSize = true;
            this.lbl_ChonMau.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChonMau.Location = new System.Drawing.Point(233, 116);
            this.lbl_ChonMau.Name = "lbl_ChonMau";
            this.lbl_ChonMau.Size = new System.Drawing.Size(82, 19);
            this.lbl_ChonMau.TabIndex = 9;
            this.lbl_ChonMau.Text = "Chọn màu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Số Lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "13tr/1cái";
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.BackColor = System.Drawing.Color.White;
            this.lbl_ThanhTien.Font = new System.Drawing.Font("JetBrains Mono", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThanhTien.ForeColor = System.Drawing.Color.Red;
            this.lbl_ThanhTien.Location = new System.Drawing.Point(10, 431);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(197, 49);
            this.lbl_ThanhTien.TabIndex = 6;
            this.lbl_ThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nbr_SoLuong
            // 
            this.nbr_SoLuong.Font = new System.Drawing.Font("JetBrains Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbr_SoLuong.Location = new System.Drawing.Point(102, 496);
            this.nbr_SoLuong.Name = "nbr_SoLuong";
            this.nbr_SoLuong.Size = new System.Drawing.Size(105, 36);
            this.nbr_SoLuong.TabIndex = 5;
            this.nbr_SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbr_SoLuong.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.nbr_SoLuong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nbr_SoLuong_KeyDown);
            this.nbr_SoLuong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nbr_SoLuong_KeyUp);
            // 
            // lbl_NamePhone
            // 
            this.lbl_NamePhone.AutoSize = true;
            this.lbl_NamePhone.Font = new System.Drawing.Font("JetBrains Mono", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NamePhone.Location = new System.Drawing.Point(220, 26);
            this.lbl_NamePhone.Name = "lbl_NamePhone";
            this.lbl_NamePhone.Size = new System.Drawing.Size(287, 35);
            this.lbl_NamePhone.TabIndex = 4;
            this.lbl_NamePhone.Text = "Iphone 16 ProMax";
            // 
            // pic_DienThoai
            // 
            this.pic_DienThoai.BackColor = System.Drawing.Color.White;
            this.pic_DienThoai.Location = new System.Drawing.Point(10, 116);
            this.pic_DienThoai.Name = "pic_DienThoai";
            this.pic_DienThoai.Size = new System.Drawing.Size(197, 255);
            this.pic_DienThoai.TabIndex = 3;
            this.pic_DienThoai.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(674, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 563);
            this.panel2.TabIndex = 2;
            // 
            // pn_ttm
            // 
            this.pn_ttm.BackColor = System.Drawing.Color.White;
            this.pn_ttm.Controls.Add(this.lbl_ttm_tensp);
            this.pn_ttm.Controls.Add(this.lbl_ttm_thanhtien);
            this.pn_ttm.Controls.Add(this.lbl_ttm_phuong);
            this.pn_ttm.Controls.Add(this.lbl_title_ttnv);
            this.pn_ttm.Controls.Add(this.lbl_ttm_quan);
            this.pn_ttm.Controls.Add(this.lbl_ttm_sdt);
            this.pn_ttm.Controls.Add(this.lbl_ttm_tinh);
            this.pn_ttm.Controls.Add(this.lbl_ttm_mausac);
            this.pn_ttm.Controls.Add(this.lbl_ttm_ten);
            this.pn_ttm.Location = new System.Drawing.Point(601, 89);
            this.pn_ttm.Name = "pn_ttm";
            this.pn_ttm.Size = new System.Drawing.Size(421, 559);
            this.pn_ttm.TabIndex = 2;
            this.pn_ttm.Visible = false;
            // 
            // lbl_ttm_tensp
            // 
            this.lbl_ttm_tensp.AutoSize = true;
            this.lbl_ttm_tensp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ttm_tensp.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ttm_tensp.Location = new System.Drawing.Point(33, 99);
            this.lbl_ttm_tensp.Name = "lbl_ttm_tensp";
            this.lbl_ttm_tensp.Size = new System.Drawing.Size(135, 19);
            this.lbl_ttm_tensp.TabIndex = 29;
            this.lbl_ttm_tensp.Text = "Tên sản phẩm: ";
            // 
            // lbl_ttm_thanhtien
            // 
            this.lbl_ttm_thanhtien.AutoSize = true;
            this.lbl_ttm_thanhtien.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ttm_thanhtien.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ttm_thanhtien.Location = new System.Drawing.Point(263, 460);
            this.lbl_ttm_thanhtien.Name = "lbl_ttm_thanhtien";
            this.lbl_ttm_thanhtien.Size = new System.Drawing.Size(99, 19);
            this.lbl_ttm_thanhtien.TabIndex = 28;
            this.lbl_ttm_thanhtien.Text = "Thành Tiền";
            // 
            // lbl_ttm_phuong
            // 
            this.lbl_ttm_phuong.AutoSize = true;
            this.lbl_ttm_phuong.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ttm_phuong.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ttm_phuong.Location = new System.Drawing.Point(33, 401);
            this.lbl_ttm_phuong.Name = "lbl_ttm_phuong";
            this.lbl_ttm_phuong.Size = new System.Drawing.Size(82, 19);
            this.lbl_ttm_phuong.TabIndex = 27;
            this.lbl_ttm_phuong.Text = "Phường: ";
            // 
            // lbl_title_ttnv
            // 
            this.lbl_title_ttnv.AutoSize = true;
            this.lbl_title_ttnv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title_ttnv.Location = new System.Drawing.Point(124, 25);
            this.lbl_title_ttnv.Name = "lbl_title_ttnv";
            this.lbl_title_ttnv.Size = new System.Drawing.Size(170, 25);
            this.lbl_title_ttnv.TabIndex = 0;
            this.lbl_title_ttnv.Text = "Thông Tin Mua";
            // 
            // lbl_ttm_quan
            // 
            this.lbl_ttm_quan.AutoSize = true;
            this.lbl_ttm_quan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ttm_quan.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ttm_quan.Location = new System.Drawing.Point(33, 347);
            this.lbl_ttm_quan.Name = "lbl_ttm_quan";
            this.lbl_ttm_quan.Size = new System.Drawing.Size(117, 19);
            this.lbl_ttm_quan.TabIndex = 26;
            this.lbl_ttm_quan.Text = "Quận/Huyện: ";
            // 
            // lbl_ttm_sdt
            // 
            this.lbl_ttm_sdt.AutoSize = true;
            this.lbl_ttm_sdt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ttm_sdt.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ttm_sdt.Location = new System.Drawing.Point(33, 251);
            this.lbl_ttm_sdt.Name = "lbl_ttm_sdt";
            this.lbl_ttm_sdt.Size = new System.Drawing.Size(145, 19);
            this.lbl_ttm_sdt.TabIndex = 24;
            this.lbl_ttm_sdt.Text = "Số điện thoại: ";
            // 
            // lbl_ttm_tinh
            // 
            this.lbl_ttm_tinh.AutoSize = true;
            this.lbl_ttm_tinh.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ttm_tinh.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ttm_tinh.Location = new System.Drawing.Point(33, 300);
            this.lbl_ttm_tinh.Name = "lbl_ttm_tinh";
            this.lbl_ttm_tinh.Size = new System.Drawing.Size(58, 19);
            this.lbl_ttm_tinh.TabIndex = 25;
            this.lbl_ttm_tinh.Text = "Tỉnh: ";
            // 
            // lbl_ttm_mausac
            // 
            this.lbl_ttm_mausac.AutoSize = true;
            this.lbl_ttm_mausac.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ttm_mausac.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ttm_mausac.Location = new System.Drawing.Point(33, 153);
            this.lbl_ttm_mausac.Name = "lbl_ttm_mausac";
            this.lbl_ttm_mausac.Size = new System.Drawing.Size(90, 19);
            this.lbl_ttm_mausac.TabIndex = 22;
            this.lbl_ttm_mausac.Text = "Màu Sắc: ";
            // 
            // lbl_ttm_ten
            // 
            this.lbl_ttm_ten.AutoSize = true;
            this.lbl_ttm_ten.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ttm_ten.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ttm_ten.Location = new System.Drawing.Point(33, 197);
            this.lbl_ttm_ten.Name = "lbl_ttm_ten";
            this.lbl_ttm_ten.Size = new System.Drawing.Size(153, 19);
            this.lbl_ttm_ten.TabIndex = 23;
            this.lbl_ttm_ten.Text = "Tên khách hàng: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(158)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(1034, 657);
            this.Controls.Add(this.pn_ttm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Title);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_SoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DienThoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.pn_ttm.ResumeLayout(false);
            this.pn_ttm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_DienThoai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_ThanhTien;
        private System.Windows.Forms.NumericUpDown nbr_SoLuong;
        private System.Windows.Forms.Label lbl_NamePhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox cb_Mau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Ten;
        private System.Windows.Forms.Label lbl_ChonMau;
        private System.Windows.Forms.ComboBox cb_Huyen;
        private System.Windows.Forms.ComboBox cb_Tinh;
        private System.Windows.Forms.TextBox txt_Phuong;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_Mua;
        private System.Windows.Forms.Panel pn_ttm;
        private System.Windows.Forms.Label lbl_ttm_phuong;
        private System.Windows.Forms.Label lbl_title_ttnv;
        private System.Windows.Forms.Label lbl_ttm_quan;
        private System.Windows.Forms.Label lbl_ttm_sdt;
        private System.Windows.Forms.Label lbl_ttm_tinh;
        private System.Windows.Forms.Label lbl_ttm_mausac;
        private System.Windows.Forms.Label lbl_ttm_ten;
        private System.Windows.Forms.Label lbl_ttm_tensp;
        private System.Windows.Forms.Label lbl_ttm_thanhtien;
        private System.Windows.Forms.Button btn_Huy;
    }
}

