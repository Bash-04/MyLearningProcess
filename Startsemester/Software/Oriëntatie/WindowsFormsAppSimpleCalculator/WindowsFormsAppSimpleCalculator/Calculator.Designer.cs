namespace WindowsFormsAppSimpleCalculator
{
    partial class Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxGetal1 = new System.Windows.Forms.TextBox();
            this.txtbxGetal2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPLUS = new System.Windows.Forms.Button();
            this.btnMIN = new System.Windows.Forms.Button();
            this.btnDELEN = new System.Windows.Forms.Button();
            this.btnKEER = new System.Windows.Forms.Button();
            this.lblANS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getal 1:";
            // 
            // txtbxGetal1
            // 
            this.txtbxGetal1.Location = new System.Drawing.Point(13, 34);
            this.txtbxGetal1.Name = "txtbxGetal1";
            this.txtbxGetal1.Size = new System.Drawing.Size(100, 22);
            this.txtbxGetal1.TabIndex = 1;
            this.txtbxGetal1.TextChanged += new System.EventHandler(this.txtbxGetal1_TextChanged);
            // 
            // txtbxGetal2
            // 
            this.txtbxGetal2.Location = new System.Drawing.Point(123, 34);
            this.txtbxGetal2.Name = "txtbxGetal2";
            this.txtbxGetal2.Size = new System.Drawing.Size(100, 22);
            this.txtbxGetal2.TabIndex = 3;
            this.txtbxGetal2.TextChanged += new System.EventHandler(this.txtbxGetal2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Getal 2:";
            // 
            // btnPLUS
            // 
            this.btnPLUS.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPLUS.Location = new System.Drawing.Point(13, 61);
            this.btnPLUS.Name = "btnPLUS";
            this.btnPLUS.Size = new System.Drawing.Size(48, 48);
            this.btnPLUS.TabIndex = 4;
            this.btnPLUS.Text = "+";
            this.btnPLUS.UseVisualStyleBackColor = true;
            this.btnPLUS.Click += new System.EventHandler(this.btnPLUS_Click);
            // 
            // btnMIN
            // 
            this.btnMIN.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMIN.Location = new System.Drawing.Point(67, 62);
            this.btnMIN.Name = "btnMIN";
            this.btnMIN.Size = new System.Drawing.Size(48, 48);
            this.btnMIN.TabIndex = 5;
            this.btnMIN.Text = "-";
            this.btnMIN.UseVisualStyleBackColor = true;
            this.btnMIN.Click += new System.EventHandler(this.btnMIN_Click);
            // 
            // btnDELEN
            // 
            this.btnDELEN.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELEN.Location = new System.Drawing.Point(121, 61);
            this.btnDELEN.Name = "btnDELEN";
            this.btnDELEN.Size = new System.Drawing.Size(48, 48);
            this.btnDELEN.TabIndex = 6;
            this.btnDELEN.Text = "/";
            this.btnDELEN.UseVisualStyleBackColor = true;
            this.btnDELEN.Click += new System.EventHandler(this.btnDELEN_Click);
            // 
            // btnKEER
            // 
            this.btnKEER.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKEER.Location = new System.Drawing.Point(175, 62);
            this.btnKEER.Name = "btnKEER";
            this.btnKEER.Size = new System.Drawing.Size(48, 48);
            this.btnKEER.TabIndex = 7;
            this.btnKEER.Text = "x";
            this.btnKEER.UseVisualStyleBackColor = true;
            this.btnKEER.Click += new System.EventHandler(this.btnKEER_Click);
            // 
            // lblANS
            // 
            this.lblANS.AutoSize = true;
            this.lblANS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblANS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblANS.Location = new System.Drawing.Point(13, 122);
            this.lblANS.MinimumSize = new System.Drawing.Size(205, 65);
            this.lblANS.Name = "lblANS";
            this.lblANS.Size = new System.Drawing.Size(205, 65);
            this.lblANS.TabIndex = 9;
            this.lblANS.Text = "Uitkomst: 0";
            this.lblANS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblANS.Click += new System.EventHandler(this.lblANS_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 198);
            this.Controls.Add(this.lblANS);
            this.Controls.Add(this.btnKEER);
            this.Controls.Add(this.btnDELEN);
            this.Controls.Add(this.btnMIN);
            this.Controls.Add(this.btnPLUS);
            this.Controls.Add(this.txtbxGetal2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxGetal1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 245);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 245);
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxGetal1;
        private System.Windows.Forms.TextBox txtbxGetal2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPLUS;
        private System.Windows.Forms.Button btnMIN;
        private System.Windows.Forms.Button btnDELEN;
        private System.Windows.Forms.Button btnKEER;
        private System.Windows.Forms.Label lblANS;
    }
}

