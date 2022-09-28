namespace WindowsFormsAppOriëntatie
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
            this.tbnaam = new System.Windows.Forms.TextBox();
            this.btnnaam = new System.Windows.Forms.Button();
            this.lblnaam = new System.Windows.Forms.Label();
            this.MathA = new System.Windows.Forms.TextBox();
            this.MathB = new System.Windows.Forms.TextBox();
            this.MathAns = new System.Windows.Forms.Label();
            this.PLUS = new System.Windows.Forms.Button();
            this.MULTIPLY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbnaam
            // 
            this.tbnaam.Location = new System.Drawing.Point(176, 43);
            this.tbnaam.Name = "tbnaam";
            this.tbnaam.Size = new System.Drawing.Size(89, 22);
            this.tbnaam.TabIndex = 0;
            this.tbnaam.TextChanged += new System.EventHandler(this.tbnaam_TextChanged);
            // 
            // btnnaam
            // 
            this.btnnaam.Location = new System.Drawing.Point(271, 33);
            this.btnnaam.Name = "btnnaam";
            this.btnnaam.Size = new System.Drawing.Size(72, 42);
            this.btnnaam.TabIndex = 1;
            this.btnnaam.Text = "Click";
            this.btnnaam.UseVisualStyleBackColor = true;
            this.btnnaam.Click += new System.EventHandler(this.btnnaam_Click);
            // 
            // lblnaam
            // 
            this.lblnaam.AutoSize = true;
            this.lblnaam.Location = new System.Drawing.Point(349, 49);
            this.lblnaam.Name = "lblnaam";
            this.lblnaam.Size = new System.Drawing.Size(41, 16);
            this.lblnaam.TabIndex = 2;
            this.lblnaam.Text = "naam";
            this.lblnaam.Click += new System.EventHandler(this.lblnaam_Click);
            // 
            // MathA
            // 
            this.MathA.Location = new System.Drawing.Point(196, 172);
            this.MathA.Name = "MathA";
            this.MathA.Size = new System.Drawing.Size(89, 22);
            this.MathA.TabIndex = 3;
            this.MathA.TextChanged += new System.EventHandler(this.MathA_TextChanged);
            // 
            // MathB
            // 
            this.MathB.Location = new System.Drawing.Point(313, 172);
            this.MathB.Name = "MathB";
            this.MathB.Size = new System.Drawing.Size(89, 22);
            this.MathB.TabIndex = 5;
            this.MathB.TextChanged += new System.EventHandler(this.MathB_TextChanged);
            // 
            // MathAns
            // 
            this.MathAns.AutoSize = true;
            this.MathAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MathAns.Location = new System.Drawing.Point(271, 209);
            this.MathAns.MinimumSize = new System.Drawing.Size(54, 18);
            this.MathAns.Name = "MathAns";
            this.MathAns.Size = new System.Drawing.Size(54, 18);
            this.MathAns.TabIndex = 4;
            this.MathAns.Text = "0";
            this.MathAns.Click += new System.EventHandler(this.MathAns_Click);
            // 
            // PLUS
            // 
            this.PLUS.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLUS.Location = new System.Drawing.Point(196, 209);
            this.PLUS.Name = "PLUS";
            this.PLUS.Size = new System.Drawing.Size(44, 43);
            this.PLUS.TabIndex = 7;
            this.PLUS.Text = "+";
            this.PLUS.UseVisualStyleBackColor = true;
            this.PLUS.Click += new System.EventHandler(this.PLUS_Click);
            // 
            // MULTIPLY
            // 
            this.MULTIPLY.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MULTIPLY.Location = new System.Drawing.Point(358, 209);
            this.MULTIPLY.Name = "MULTIPLY";
            this.MULTIPLY.Size = new System.Drawing.Size(44, 43);
            this.MULTIPLY.TabIndex = 8;
            this.MULTIPLY.Text = "x";
            this.MULTIPLY.UseVisualStyleBackColor = true;
            this.MULTIPLY.Click += new System.EventHandler(this.MULTIPLY_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 381);
            this.Controls.Add(this.MULTIPLY);
            this.Controls.Add(this.PLUS);
            this.Controls.Add(this.MathB);
            this.Controls.Add(this.MathAns);
            this.Controls.Add(this.MathA);
            this.Controls.Add(this.lblnaam);
            this.Controls.Add(this.btnnaam);
            this.Controls.Add(this.tbnaam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbnaam;
        private System.Windows.Forms.Button btnnaam;
        private System.Windows.Forms.Label lblnaam;
        private System.Windows.Forms.TextBox MathA;
        private System.Windows.Forms.TextBox MathB;
        private System.Windows.Forms.Label MathAns;
        private System.Windows.Forms.Button PLUS;
        private System.Windows.Forms.Button MULTIPLY;
    }
}

