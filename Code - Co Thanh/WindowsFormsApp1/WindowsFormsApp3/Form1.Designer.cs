namespace WindowsFormsApp3
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
            this.btnthongbao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnthongbao
            // 
            this.btnthongbao.BackColor = System.Drawing.Color.Teal;
            this.btnthongbao.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongbao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthongbao.Location = new System.Drawing.Point(296, 241);
            this.btnthongbao.Name = "btnthongbao";
            this.btnthongbao.Size = new System.Drawing.Size(199, 74);
            this.btnthongbao.TabIndex = 0;
            this.btnthongbao.Text = "CLICK ME";
            this.btnthongbao.UseVisualStyleBackColor = false;
            this.btnthongbao.Click += new System.EventHandler(this.btnthongbao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthongbao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnthongbao;
    }
}

