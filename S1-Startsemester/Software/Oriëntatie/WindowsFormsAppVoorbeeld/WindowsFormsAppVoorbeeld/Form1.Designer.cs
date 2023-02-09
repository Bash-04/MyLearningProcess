namespace WindowsFormsAppVoorbeeld
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
            this.tbGetal1 = new System.Windows.Forms.TextBox();
            this.rbPlus = new System.Windows.Forms.RadioButton();
            this.rbMin = new System.Windows.Forms.RadioButton();
            this.rbKeer = new System.Windows.Forms.RadioButton();
            this.tbGetal2 = new System.Windows.Forms.TextBox();
            this.lbUitkomsten = new System.Windows.Forms.ListBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbGetal1
            // 
            this.tbGetal1.Location = new System.Drawing.Point(20, 48);
            this.tbGetal1.Name = "tbGetal1";
            this.tbGetal1.Size = new System.Drawing.Size(178, 22);
            this.tbGetal1.TabIndex = 0;
            this.tbGetal1.TextChanged += new System.EventHandler(this.tbGetal1_TextChanged);
            // 
            // rbPlus
            // 
            this.rbPlus.AutoSize = true;
            this.rbPlus.Location = new System.Drawing.Point(204, 24);
            this.rbPlus.Name = "rbPlus";
            this.rbPlus.Size = new System.Drawing.Size(35, 20);
            this.rbPlus.TabIndex = 1;
            this.rbPlus.TabStop = true;
            this.rbPlus.Text = "+";
            this.rbPlus.UseVisualStyleBackColor = true;
            this.rbPlus.CheckedChanged += new System.EventHandler(this.rbPlus_CheckedChanged);
            // 
            // rbMin
            // 
            this.rbMin.AutoSize = true;
            this.rbMin.Location = new System.Drawing.Point(204, 50);
            this.rbMin.Name = "rbMin";
            this.rbMin.Size = new System.Drawing.Size(32, 20);
            this.rbMin.TabIndex = 2;
            this.rbMin.TabStop = true;
            this.rbMin.Text = "-";
            this.rbMin.UseVisualStyleBackColor = true;
            this.rbMin.CheckedChanged += new System.EventHandler(this.rbMin_CheckedChanged);
            // 
            // rbKeer
            // 
            this.rbKeer.AutoSize = true;
            this.rbKeer.Location = new System.Drawing.Point(204, 76);
            this.rbKeer.Name = "rbKeer";
            this.rbKeer.Size = new System.Drawing.Size(33, 20);
            this.rbKeer.TabIndex = 3;
            this.rbKeer.TabStop = true;
            this.rbKeer.Text = "*";
            this.rbKeer.UseVisualStyleBackColor = true;
            this.rbKeer.CheckedChanged += new System.EventHandler(this.rbKeer_CheckedChanged);
            // 
            // tbGetal2
            // 
            this.tbGetal2.Location = new System.Drawing.Point(242, 50);
            this.tbGetal2.Name = "tbGetal2";
            this.tbGetal2.Size = new System.Drawing.Size(178, 22);
            this.tbGetal2.TabIndex = 4;
            this.tbGetal2.TextChanged += new System.EventHandler(this.tbGetal2_TextChanged);
            // 
            // lbUitkomsten
            // 
            this.lbUitkomsten.FormattingEnabled = true;
            this.lbUitkomsten.ItemHeight = 16;
            this.lbUitkomsten.Location = new System.Drawing.Point(426, 19);
            this.lbUitkomsten.Name = "lbUitkomsten";
            this.lbUitkomsten.Size = new System.Drawing.Size(161, 196);
            this.lbUitkomsten.TabIndex = 5;
            this.lbUitkomsten.SelectedIndexChanged += new System.EventHandler(this.lbUitkomsten_SelectedIndexChanged);
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(20, 102);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(400, 54);
            this.btnBereken.TabIndex = 6;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Location = new System.Drawing.Point(423, 218);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(52, 16);
            this.lblTotaal.TabIndex = 7;
            this.lblTotaal.Text = "Totaal: ";
            this.lblTotaal.Click += new System.EventHandler(this.lblTotaal_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(426, 248);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 74);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Sluiten";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 336);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.lbUitkomsten);
            this.Controls.Add(this.tbGetal2);
            this.Controls.Add(this.rbKeer);
            this.Controls.Add(this.rbMin);
            this.Controls.Add(this.rbPlus);
            this.Controls.Add(this.tbGetal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGetal1;
        private System.Windows.Forms.RadioButton rbPlus;
        private System.Windows.Forms.RadioButton rbMin;
        private System.Windows.Forms.RadioButton rbKeer;
        private System.Windows.Forms.TextBox tbGetal2;
        private System.Windows.Forms.ListBox lbUitkomsten;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.Button btnClose;
    }
}

