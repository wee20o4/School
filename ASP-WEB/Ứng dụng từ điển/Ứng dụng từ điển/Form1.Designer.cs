namespace Ứng_dụng_từ_điển
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
            this.txt_vn = new System.Windows.Forms.TextBox();
            this.txt_eng = new System.Windows.Forms.TextBox();
            this.lbl_vn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_vn
            // 
            this.txt_vn.Location = new System.Drawing.Point(294, 165);
            this.txt_vn.Name = "txt_vn";
            this.txt_vn.Size = new System.Drawing.Size(372, 20);
            this.txt_vn.TabIndex = 0;
            this.txt_vn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txt_eng
            // 
            this.txt_eng.Location = new System.Drawing.Point(294, 232);
            this.txt_eng.Name = "txt_eng";
            this.txt_eng.Size = new System.Drawing.Size(372, 20);
            this.txt_eng.TabIndex = 0;
            // 
            // lbl_vn
            // 
            this.lbl_vn.AutoSize = true;
            this.lbl_vn.Location = new System.Drawing.Point(181, 172);
            this.lbl_vn.Name = "lbl_vn";
            this.lbl_vn.Size = new System.Drawing.Size(55, 13);
            this.lbl_vn.TabIndex = 1;
            this.lbl_vn.Text = "Tiếng Việt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiếng Anh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_vn);
            this.Controls.Add(this.txt_eng);
            this.Controls.Add(this.txt_vn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_vn;
        private System.Windows.Forms.TextBox txt_eng;
        private System.Windows.Forms.Label lbl_vn;
        private System.Windows.Forms.Label label1;
    }
}

