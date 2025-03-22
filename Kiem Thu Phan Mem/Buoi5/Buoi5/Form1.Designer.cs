namespace Buoi5
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
            this.btn_openURL = new System.Windows.Forms.Button();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_openURL
            // 
            this.btn_openURL.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_openURL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_openURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openURL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_openURL.Location = new System.Drawing.Point(225, 251);
            this.btn_openURL.Name = "btn_openURL";
            this.btn_openURL.Size = new System.Drawing.Size(391, 120);
            this.btn_openURL.TabIndex = 0;
            this.btn_openURL.Text = "Open URL";
            this.btn_openURL.UseVisualStyleBackColor = false;
            this.btn_openURL.Click += new System.EventHandler(this.btn_openURL_Click);
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(258, 111);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(394, 20);
            this.txt_url.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập URL:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.btn_openURL);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_openURL;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Label label1;
    }
}

