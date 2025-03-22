namespace Baitaptext2
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
            this.btn__GoLeft = new System.Windows.Forms.Button();
            this.btn__GoAllRight = new System.Windows.Forms.Button();
            this.btn__GoRight = new System.Windows.Forms.Button();
            this.btn__GoAllLeft = new System.Windows.Forms.Button();
            this.cklb__Left = new System.Windows.Forms.CheckedListBox();
            this.cklb__Right = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btn__GoLeft
            // 
            this.btn__GoLeft.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn__GoLeft.Location = new System.Drawing.Point(350, 213);
            this.btn__GoLeft.Name = "btn__GoLeft";
            this.btn__GoLeft.Size = new System.Drawing.Size(97, 49);
            this.btn__GoLeft.TabIndex = 2;
            this.btn__GoLeft.Text = "<";
            this.btn__GoLeft.UseVisualStyleBackColor = false;
            this.btn__GoLeft.Click += new System.EventHandler(this.btn__GoLeft_Click);
            // 
            // btn__GoAllRight
            // 
            this.btn__GoAllRight.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn__GoAllRight.Location = new System.Drawing.Point(350, 147);
            this.btn__GoAllRight.Name = "btn__GoAllRight";
            this.btn__GoAllRight.Size = new System.Drawing.Size(97, 49);
            this.btn__GoAllRight.TabIndex = 3;
            this.btn__GoAllRight.Text = ">>";
            this.btn__GoAllRight.UseVisualStyleBackColor = false;
            this.btn__GoAllRight.Click += new System.EventHandler(this.btn__GoAllRight_Click);
            // 
            // btn__GoRight
            // 
            this.btn__GoRight.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn__GoRight.Location = new System.Drawing.Point(350, 88);
            this.btn__GoRight.Name = "btn__GoRight";
            this.btn__GoRight.Size = new System.Drawing.Size(97, 49);
            this.btn__GoRight.TabIndex = 4;
            this.btn__GoRight.Text = ">";
            this.btn__GoRight.UseVisualStyleBackColor = false;
            this.btn__GoRight.Click += new System.EventHandler(this.btn__GoRight_Click);
            // 
            // btn__GoAllLeft
            // 
            this.btn__GoAllLeft.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn__GoAllLeft.Location = new System.Drawing.Point(350, 282);
            this.btn__GoAllLeft.Name = "btn__GoAllLeft";
            this.btn__GoAllLeft.Size = new System.Drawing.Size(97, 49);
            this.btn__GoAllLeft.TabIndex = 5;
            this.btn__GoAllLeft.Text = "<<";
            this.btn__GoAllLeft.UseVisualStyleBackColor = false;
            this.btn__GoAllLeft.Click += new System.EventHandler(this.btn__GoAllLeft_Click);
            // 
            // cklb__Left
            // 
            this.cklb__Left.FormattingEnabled = true;
            this.cklb__Left.Items.AddRange(new object[] {
            "Chuc Nang 1",
            "Chuc Nang 2",
            "Chuc Nang 3",
            "Chuc Nang 4",
            "Chuc Nang 5"});
            this.cklb__Left.Location = new System.Drawing.Point(46, 88);
            this.cklb__Left.Name = "cklb__Left";
            this.cklb__Left.Size = new System.Drawing.Size(238, 242);
            this.cklb__Left.TabIndex = 0;
            // 
            // cklb__Right
            // 
            this.cklb__Right.FormattingEnabled = true;
            this.cklb__Right.Location = new System.Drawing.Point(524, 88);
            this.cklb__Right.Name = "cklb__Right";
            this.cklb__Right.Size = new System.Drawing.Size(238, 242);
            this.cklb__Right.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cklb__Right);
            this.Controls.Add(this.cklb__Left);
            this.Controls.Add(this.btn__GoRight);
            this.Controls.Add(this.btn__GoAllLeft);
            this.Controls.Add(this.btn__GoAllRight);
            this.Controls.Add(this.btn__GoLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn__GoLeft;
        private System.Windows.Forms.Button btn__GoAllRight;
        private System.Windows.Forms.Button btn__GoRight;
        private System.Windows.Forms.Button btn__GoAllLeft;
        private System.Windows.Forms.CheckedListBox cklb__Left;
        private System.Windows.Forms.CheckedListBox cklb__Right;
    }
}

