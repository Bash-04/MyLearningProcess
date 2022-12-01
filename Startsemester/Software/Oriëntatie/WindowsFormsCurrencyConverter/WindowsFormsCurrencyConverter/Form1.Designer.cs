namespace WindowsFormsCurrencyConverter
{
    partial class CurrencyConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyConverter));
            this.tbEuro = new System.Windows.Forms.TextBox();
            this.Euro = new System.Windows.Forms.Label();
            this.tbDollar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConv2Euro = new System.Windows.Forms.Button();
            this.btnConv2Dollar = new System.Windows.Forms.Button();
            this.lblConverted = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEuro
            // 
            this.tbEuro.Location = new System.Drawing.Point(18, 47);
            this.tbEuro.Name = "tbEuro";
            this.tbEuro.Size = new System.Drawing.Size(111, 22);
            this.tbEuro.TabIndex = 0;
            this.tbEuro.TextChanged += new System.EventHandler(this.tbEuro_TextChanged);
            // 
            // Euro
            // 
            this.Euro.AutoSize = true;
            this.Euro.Font = new System.Drawing.Font("Arial", 18F);
            this.Euro.Location = new System.Drawing.Point(57, 9);
            this.Euro.Name = "Euro";
            this.Euro.Size = new System.Drawing.Size(32, 35);
            this.Euro.TabIndex = 1;
            this.Euro.Text = "€";
            // 
            // tbDollar
            // 
            this.tbDollar.Location = new System.Drawing.Point(181, 47);
            this.tbDollar.Name = "tbDollar";
            this.tbDollar.Size = new System.Drawing.Size(111, 22);
            this.tbDollar.TabIndex = 0;
            this.tbDollar.TextChanged += new System.EventHandler(this.tbDollar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F);
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "$";
            // 
            // btnConv2Euro
            // 
            this.btnConv2Euro.Font = new System.Drawing.Font("Arial", 14F);
            this.btnConv2Euro.Location = new System.Drawing.Point(122, 75);
            this.btnConv2Euro.Name = "btnConv2Euro";
            this.btnConv2Euro.Size = new System.Drawing.Size(30, 30);
            this.btnConv2Euro.TabIndex = 2;
            this.btnConv2Euro.Text = "<";
            this.btnConv2Euro.UseVisualStyleBackColor = true;
            this.btnConv2Euro.Click += new System.EventHandler(this.btnConv2Euro_Click);
            // 
            // btnConv2Dollar
            // 
            this.btnConv2Dollar.Font = new System.Drawing.Font("Arial", 14F);
            this.btnConv2Dollar.Location = new System.Drawing.Point(158, 75);
            this.btnConv2Dollar.Name = "btnConv2Dollar";
            this.btnConv2Dollar.Size = new System.Drawing.Size(30, 30);
            this.btnConv2Dollar.TabIndex = 2;
            this.btnConv2Dollar.Text = ">";
            this.btnConv2Dollar.UseVisualStyleBackColor = true;
            this.btnConv2Dollar.Click += new System.EventHandler(this.btnConv2Dollar_Click);
            // 
            // lblConverted
            // 
            this.lblConverted.AutoSize = true;
            this.lblConverted.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConverted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConverted.Font = new System.Drawing.Font("Arial", 11F);
            this.lblConverted.Location = new System.Drawing.Point(18, 116);
            this.lblConverted.MaximumSize = new System.Drawing.Size(120, 24);
            this.lblConverted.MinimumSize = new System.Drawing.Size(80, 24);
            this.lblConverted.Name = "lblConverted";
            this.lblConverted.Size = new System.Drawing.Size(106, 24);
            this.lblConverted.TabIndex = 3;
            this.lblConverted.Text = "€Koers = 1";
            this.lblConverted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConverted.Click += new System.EventHandler(this.lblConverted_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(235, 118);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 22);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 112);
            this.label2.MaximumSize = new System.Drawing.Size(80, 32);
            this.label2.MinimumSize = new System.Drawing.Size(80, 32);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Conversion Rate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 175);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblConverted);
            this.Controls.Add(this.btnConv2Dollar);
            this.Controls.Add(this.btnConv2Euro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDollar);
            this.Controls.Add(this.Euro);
            this.Controls.Add(this.tbEuro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CurrencyConverter";
            this.Text = "Currency Converter";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEuro;
        private System.Windows.Forms.Label Euro;
        private System.Windows.Forms.TextBox tbDollar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConv2Euro;
        private System.Windows.Forms.Button btnConv2Dollar;
        private System.Windows.Forms.Label lblConverted;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
    }
}

