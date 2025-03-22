namespace QuanLySinhVien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_tendangnhap = new TextBox();
            txt_pass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 32);
            label1.Name = "label1";
            label1.Size = new Size(339, 69);
            label1.TabIndex = 0;
            label1.Text = "Đăng Nhập";
            // 
            // txt_tendangnhap
            // 
            txt_tendangnhap.Location = new Point(284, 159);
            txt_tendangnhap.Name = "txt_tendangnhap";
            txt_tendangnhap.Size = new Size(313, 34);
            txt_tendangnhap.TabIndex = 1;
            txt_tendangnhap.Text = "lethanh";
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(284, 231);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(313, 34);
            txt_pass.TabIndex = 2;
            txt_pass.Text = "lt123456";
            txt_pass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(116, 165);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 3;
            label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 237);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu:";
            // 
            // button1
            // 
            button1.Location = new Point(284, 322);
            button1.Name = "button1";
            button1.Size = new Size(216, 68);
            button1.TabIndex = 5;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 458);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_pass);
            Controls.Add(txt_tendangnhap);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_tendangnhap;
        private TextBox txt_pass;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
