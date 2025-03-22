namespace Timer
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
            this.lbl__DongHo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn__Start = new System.Windows.Forms.Button();
            this.btn__Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl__DongHo
            // 
            this.lbl__DongHo.AutoSize = true;
            this.lbl__DongHo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl__DongHo.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__DongHo.Location = new System.Drawing.Point(312, 164);
            this.lbl__DongHo.Name = "lbl__DongHo";
            this.lbl__DongHo.Size = new System.Drawing.Size(145, 58);
            this.lbl__DongHo.TabIndex = 0;
            this.lbl__DongHo.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn__Start
            // 
            this.btn__Start.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn__Start.Location = new System.Drawing.Point(178, 297);
            this.btn__Start.Name = "btn__Start";
            this.btn__Start.Size = new System.Drawing.Size(139, 55);
            this.btn__Start.TabIndex = 1;
            this.btn__Start.Text = "Start";
            this.btn__Start.UseVisualStyleBackColor = false;
            this.btn__Start.Click += new System.EventHandler(this.btn__Start_Click);
            // 
            // btn__Stop
            // 
            this.btn__Stop.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn__Stop.Location = new System.Drawing.Point(457, 297);
            this.btn__Stop.Name = "btn__Stop";
            this.btn__Stop.Size = new System.Drawing.Size(139, 55);
            this.btn__Stop.TabIndex = 2;
            this.btn__Stop.Text = "Stop";
            this.btn__Stop.UseVisualStyleBackColor = false;
            this.btn__Stop.Click += new System.EventHandler(this.btn__Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn__Stop);
            this.Controls.Add(this.btn__Start);
            this.Controls.Add(this.lbl__DongHo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl__DongHo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn__Start;
        private System.Windows.Forms.Button btn__Stop;
    }
}

