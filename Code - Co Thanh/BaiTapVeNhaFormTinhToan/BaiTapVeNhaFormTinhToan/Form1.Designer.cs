namespace BaiTapVeNhaFormTinhToan
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
            this.lblSoA = new System.Windows.Forms.Label();
            this.btnTinhToan = new System.Windows.Forms.Button();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.lblSoB = new System.Windows.Forms.Label();
            this.txtBieuThuc = new System.Windows.Forms.TextBox();
            this.lblBieuThuc = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblHienKetQua = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSoA
            // 
            this.lblSoA.AutoSize = true;
            this.lblSoA.BackColor = System.Drawing.Color.Transparent;
            this.lblSoA.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoA.Location = new System.Drawing.Point(26, 178);
            this.lblSoA.Name = "lblSoA";
            this.lblSoA.Size = new System.Drawing.Size(115, 28);
            this.lblSoA.TabIndex = 0;
            this.lblSoA.Text = "Nhập Số A:";
            // 
            // btnTinhToan
            // 
            this.btnTinhToan.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTinhToan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhToan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTinhToan.Location = new System.Drawing.Point(422, 387);
            this.btnTinhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTinhToan.Name = "btnTinhToan";
            this.btnTinhToan.Size = new System.Drawing.Size(160, 75);
            this.btnTinhToan.TabIndex = 1;
            this.btnTinhToan.Text = "Tính Toán";
            this.btnTinhToan.UseVisualStyleBackColor = false;
            this.btnTinhToan.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSoA
            // 
            this.txtSoA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoA.Location = new System.Drawing.Point(169, 178);
            this.txtSoA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(124, 32);
            this.txtSoA.TabIndex = 2;
            // 
            // txtSoB
            // 
            this.txtSoB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoB.Location = new System.Drawing.Point(791, 181);
            this.txtSoB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(124, 32);
            this.txtSoB.TabIndex = 3;
            // 
            // lblSoB
            // 
            this.lblSoB.AutoSize = true;
            this.lblSoB.BackColor = System.Drawing.Color.Transparent;
            this.lblSoB.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoB.Location = new System.Drawing.Point(636, 181);
            this.lblSoB.Name = "lblSoB";
            this.lblSoB.Size = new System.Drawing.Size(114, 28);
            this.lblSoB.TabIndex = 4;
            this.lblSoB.Text = "Nhập Số B:";
            // 
            // txtBieuThuc
            // 
            this.txtBieuThuc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBieuThuc.Location = new System.Drawing.Point(459, 177);
            this.txtBieuThuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBieuThuc.Name = "txtBieuThuc";
            this.txtBieuThuc.Size = new System.Drawing.Size(68, 32);
            this.txtBieuThuc.TabIndex = 5;
            // 
            // lblBieuThuc
            // 
            this.lblBieuThuc.AutoSize = true;
            this.lblBieuThuc.BackColor = System.Drawing.Color.Transparent;
            this.lblBieuThuc.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBieuThuc.Location = new System.Drawing.Point(404, 119);
            this.lblBieuThuc.Name = "lblBieuThuc";
            this.lblBieuThuc.Size = new System.Drawing.Size(190, 28);
            this.lblBieuThuc.TabIndex = 6;
            this.lblBieuThuc.Text = "Biểu Thức(+, -, x, :)";
            this.lblBieuThuc.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Silver;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(207, 498);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(160, 75);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(626, 498);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 75);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.BackColor = System.Drawing.Color.Transparent;
            this.lblKetQua.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(245, 289);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(91, 28);
            this.lblKetQua.TabIndex = 9;
            this.lblKetQua.Text = "Kết quả:";
            // 
            // lblHienKetQua
            // 
            this.lblHienKetQua.BackColor = System.Drawing.Color.White;
            this.lblHienKetQua.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienKetQua.Location = new System.Drawing.Point(360, 276);
            this.lblHienKetQua.Name = "lblHienKetQua";
            this.lblHienKetQua.Size = new System.Drawing.Size(315, 55);
            this.lblHienKetQua.TabIndex = 10;
            this.lblHienKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.DeepPink;
            this.lblTieuDe.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(-4, -5);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1021, 86);
            this.lblTieuDe.TabIndex = 11;
            this.lblTieuDe.Text = "Chương Trình Tính Toán";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::BaiTapVeNhaFormTinhToan.Properties.Resources.z5573173196029_cc20d1de410452ee255479e09f7c3fe6;
            this.ClientSize = new System.Drawing.Size(1014, 608);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblHienKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblBieuThuc);
            this.Controls.Add(this.txtBieuThuc);
            this.Controls.Add(this.lblSoB);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.btnTinhToan);
            this.Controls.Add(this.lblSoA);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương Trình Tính Toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoA;
        private System.Windows.Forms.Button btnTinhToan;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Label lblSoB;
        private System.Windows.Forms.TextBox txtBieuThuc;
        private System.Windows.Forms.Label lblBieuThuc;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblHienKetQua;
        private System.Windows.Forms.Label lblTieuDe;
    }
}

