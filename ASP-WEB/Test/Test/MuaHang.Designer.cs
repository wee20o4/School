namespace Test
{
    partial class MuaHang
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
            lbl_ten = new Label();
            lbl_sdt = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // lbl_ten
            // 
            lbl_ten.BackColor = SystemColors.ControlLightLight;
            lbl_ten.Location = new Point(246, 138);
            lbl_ten.Name = "lbl_ten";
            lbl_ten.Size = new Size(324, 56);
            lbl_ten.TabIndex = 0;
            lbl_ten.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_sdt
            // 
            lbl_sdt.BackColor = SystemColors.ControlLightLight;
            lbl_sdt.Location = new Point(246, 242);
            lbl_sdt.Name = "lbl_sdt";
            lbl_sdt.Size = new Size(324, 56);
            lbl_sdt.TabIndex = 1;
            lbl_sdt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(179, 9);
            label3.Name = "label3";
            label3.Size = new Size(450, 98);
            label3.TabIndex = 2;
            label3.Text = "Mua Hang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(142, 156);
            label4.Name = "label4";
            label4.Size = new Size(60, 38);
            label4.TabIndex = 3;
            label4.Text = "Ten";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(142, 257);
            label5.Name = "label5";
            label5.Size = new Size(66, 38);
            label5.TabIndex = 4;
            label5.Text = "SDT";
            // 
            // MuaHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbl_sdt);
            Controls.Add(lbl_ten);
            Name = "MuaHang";
            Text = "MuaHang";
            Load += MuaHang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ten;
        private Label lbl_sdt;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}