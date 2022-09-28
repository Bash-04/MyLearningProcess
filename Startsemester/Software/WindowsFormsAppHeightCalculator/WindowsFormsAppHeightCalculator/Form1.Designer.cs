namespace WindowsFormsAppHeightCalculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Click = new System.Windows.Forms.Button();
            this.jouwLengte = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LengteInCM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Click
            // 
            this.Click.Location = new System.Drawing.Point(122, 78);
            this.Click.Name = "Click";
            this.Click.Size = new System.Drawing.Size(104, 47);
            this.Click.TabIndex = 1;
            this.Click.Text = "Click";
            this.Click.UseVisualStyleBackColor = true;
            this.Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // jouwLengte
            // 
            this.jouwLengte.AutoSize = true;
            this.jouwLengte.Location = new System.Drawing.Point(133, 31);
            this.jouwLengte.Name = "jouwLengte";
            this.jouwLengte.Size = new System.Drawing.Size(84, 16);
            this.jouwLengte.TabIndex = 2;
            this.jouwLengte.Text = "Jouw lengte :";
            this.jouwLengte.Click += new System.EventHandler(this.jouwLengte_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 3;
            // 
            // LengteInCM
            // 
            this.LengteInCM.AutoSize = true;
            this.LengteInCM.Location = new System.Drawing.Point(263, 53);
            this.LengteInCM.Name = "LengteInCM";
            this.LengteInCM.Size = new System.Drawing.Size(25, 16);
            this.LengteInCM.TabIndex = 3;
            this.LengteInCM.Text = "cm";
            this.LengteInCM.Click += new System.EventHandler(this.LengteInCM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 153);
            this.Controls.Add(this.LengteInCM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jouwLengte);
            this.Controls.Add(this.Click);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Click;
        private System.Windows.Forms.Label jouwLengte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LengteInCM;
    }
}

