namespace WindowsFormsAppTelevisie_v2
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
            this.btnVorige = new System.Windows.Forms.Button();
            this.btnVolgende = new System.Windows.Forms.Button();
            this.lblZender = new System.Windows.Forms.Label();
            this.tbNieuweZender = new System.Windows.Forms.TextBox();
            this.btnVoegZenderToe = new System.Windows.Forms.Button();
            this.lbZenders = new System.Windows.Forms.ListBox();
            this.rbUit = new System.Windows.Forms.RadioButton();
            this.rbAan = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pbTV = new System.Windows.Forms.PictureBox();
            this.lblUitAan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVorige
            // 
            this.btnVorige.Location = new System.Drawing.Point(99, 283);
            this.btnVorige.Name = "btnVorige";
            this.btnVorige.Size = new System.Drawing.Size(80, 39);
            this.btnVorige.TabIndex = 22;
            this.btnVorige.Text = "Vorige";
            this.btnVorige.UseVisualStyleBackColor = true;
            this.btnVorige.Click += new System.EventHandler(this.btnVorige_Click);
            // 
            // btnVolgende
            // 
            this.btnVolgende.Location = new System.Drawing.Point(185, 283);
            this.btnVolgende.Name = "btnVolgende";
            this.btnVolgende.Size = new System.Drawing.Size(80, 39);
            this.btnVolgende.TabIndex = 21;
            this.btnVolgende.Text = "Volgende";
            this.btnVolgende.UseVisualStyleBackColor = true;
            this.btnVolgende.Click += new System.EventHandler(this.btnVolgende_Click);
            // 
            // lblZender
            // 
            this.lblZender.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblZender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZender.Location = new System.Drawing.Point(114, 181);
            this.lblZender.Name = "lblZender";
            this.lblZender.Size = new System.Drawing.Size(114, 43);
            this.lblZender.TabIndex = 20;
            this.lblZender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblZender.Click += new System.EventHandler(this.lblZender_Click);
            // 
            // tbNieuweZender
            // 
            this.tbNieuweZender.Location = new System.Drawing.Point(371, 230);
            this.tbNieuweZender.Name = "tbNieuweZender";
            this.tbNieuweZender.Size = new System.Drawing.Size(154, 22);
            this.tbNieuweZender.TabIndex = 19;
            this.tbNieuweZender.TextChanged += new System.EventHandler(this.tbNieuweZender_TextChanged);
            // 
            // btnVoegZenderToe
            // 
            this.btnVoegZenderToe.Location = new System.Drawing.Point(371, 258);
            this.btnVoegZenderToe.Name = "btnVoegZenderToe";
            this.btnVoegZenderToe.Size = new System.Drawing.Size(154, 30);
            this.btnVoegZenderToe.TabIndex = 18;
            this.btnVoegZenderToe.Text = "voeg zenders toe";
            this.btnVoegZenderToe.UseVisualStyleBackColor = true;
            this.btnVoegZenderToe.Click += new System.EventHandler(this.btnVoegZenderToe_Click);
            // 
            // lbZenders
            // 
            this.lbZenders.FormattingEnabled = true;
            this.lbZenders.ItemHeight = 16;
            this.lbZenders.Location = new System.Drawing.Point(354, 12);
            this.lbZenders.Name = "lbZenders";
            this.lbZenders.Size = new System.Drawing.Size(191, 212);
            this.lbZenders.TabIndex = 17;
            this.lbZenders.SelectedIndexChanged += new System.EventHandler(this.lbZenders_SelectedIndexChanged);
            // 
            // rbUit
            // 
            this.rbUit.AutoSize = true;
            this.rbUit.Location = new System.Drawing.Point(17, 86);
            this.rbUit.Name = "rbUit";
            this.rbUit.Size = new System.Drawing.Size(44, 20);
            this.rbUit.TabIndex = 14;
            this.rbUit.TabStop = true;
            this.rbUit.Text = "Uit";
            this.rbUit.UseVisualStyleBackColor = true;
            this.rbUit.CheckedChanged += new System.EventHandler(this.rbUit_CheckedChanged);
            // 
            // rbAan
            // 
            this.rbAan.AutoSize = true;
            this.rbAan.Location = new System.Drawing.Point(17, 60);
            this.rbAan.Name = "rbAan";
            this.rbAan.Size = new System.Drawing.Size(52, 20);
            this.rbAan.TabIndex = 13;
            this.rbAan.TabStop = true;
            this.rbAan.Text = "Aan";
            this.rbAan.UseVisualStyleBackColor = true;
            this.rbAan.CheckedChanged += new System.EventHandler(this.rbAan_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "De Televisie van ...";
            // 
            // pbTV
            // 
            this.pbTV.Image = global::WindowsFormsAppTelevisie_v2.Properties.Resources.House_and_Appliances_Tv_icon;
            this.pbTV.Location = new System.Drawing.Point(33, 21);
            this.pbTV.Name = "pbTV";
            this.pbTV.Size = new System.Drawing.Size(331, 310);
            this.pbTV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTV.TabIndex = 15;
            this.pbTV.TabStop = false;
            // 
            // lblUitAan
            // 
            this.lblUitAan.BackColor = System.Drawing.Color.Red;
            this.lblUitAan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUitAan.Location = new System.Drawing.Point(131, 142);
            this.lblUitAan.Name = "lblUitAan";
            this.lblUitAan.Size = new System.Drawing.Size(80, 29);
            this.lblUitAan.TabIndex = 16;
            this.lblUitAan.Text = "UIT";
            this.lblUitAan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUitAan.Click += new System.EventHandler(this.lblUitAan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 327);
            this.Controls.Add(this.btnVorige);
            this.Controls.Add(this.btnVolgende);
            this.Controls.Add(this.lblZender);
            this.Controls.Add(this.tbNieuweZender);
            this.Controls.Add(this.btnVoegZenderToe);
            this.Controls.Add(this.lbZenders);
            this.Controls.Add(this.lblUitAan);
            this.Controls.Add(this.rbUit);
            this.Controls.Add(this.rbAan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbTV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVorige;
        private System.Windows.Forms.Button btnVolgende;
        private System.Windows.Forms.Label lblZender;
        private System.Windows.Forms.TextBox tbNieuweZender;
        private System.Windows.Forms.Button btnVoegZenderToe;
        private System.Windows.Forms.ListBox lbZenders;
        private System.Windows.Forms.RadioButton rbUit;
        private System.Windows.Forms.RadioButton rbAan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbTV;
        private System.Windows.Forms.Label lblUitAan;
    }
}

