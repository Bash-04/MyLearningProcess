namespace WindowsFormsAppWorpengenerator
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
            this.GrBxInstellingen = new System.Windows.Forms.GroupBox();
            this.GooiDobbelsteen = new System.Windows.Forms.Button();
            this.numericUpDownOgen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWorpen = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrBxResultaat = new System.Windows.Forms.GroupBox();
            this.lblTotaalOgen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxWorpen = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GrBxInstellingen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOgen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorpen)).BeginInit();
            this.GrBxResultaat.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrBxInstellingen
            // 
            this.GrBxInstellingen.Controls.Add(this.GooiDobbelsteen);
            this.GrBxInstellingen.Controls.Add(this.numericUpDownOgen);
            this.GrBxInstellingen.Controls.Add(this.numericUpDownWorpen);
            this.GrBxInstellingen.Controls.Add(this.label2);
            this.GrBxInstellingen.Controls.Add(this.label1);
            this.GrBxInstellingen.Location = new System.Drawing.Point(12, 12);
            this.GrBxInstellingen.Name = "GrBxInstellingen";
            this.GrBxInstellingen.Size = new System.Drawing.Size(244, 114);
            this.GrBxInstellingen.TabIndex = 0;
            this.GrBxInstellingen.TabStop = false;
            this.GrBxInstellingen.Text = "Instellingen";
            // 
            // GooiDobbelsteen
            // 
            this.GooiDobbelsteen.Font = new System.Drawing.Font("Arial", 7.8F);
            this.GooiDobbelsteen.Location = new System.Drawing.Point(46, 83);
            this.GooiDobbelsteen.Name = "GooiDobbelsteen";
            this.GooiDobbelsteen.Size = new System.Drawing.Size(140, 25);
            this.GooiDobbelsteen.TabIndex = 4;
            this.GooiDobbelsteen.Text = "Gooi dobbelsteen!";
            this.GooiDobbelsteen.UseVisualStyleBackColor = true;
            this.GooiDobbelsteen.Click += new System.EventHandler(this.GooiDobbelsteen_Click);
            // 
            // numericUpDownOgen
            // 
            this.numericUpDownOgen.Location = new System.Drawing.Point(107, 49);
            this.numericUpDownOgen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOgen.Name = "numericUpDownOgen";
            this.numericUpDownOgen.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownOgen.TabIndex = 3;
            this.numericUpDownOgen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOgen.ValueChanged += new System.EventHandler(this.numericUpDownOgen_ValueChanged);
            // 
            // numericUpDownWorpen
            // 
            this.numericUpDownWorpen.Location = new System.Drawing.Point(107, 16);
            this.numericUpDownWorpen.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWorpen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWorpen.Name = "numericUpDownWorpen";
            this.numericUpDownWorpen.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownWorpen.TabIndex = 2;
            this.numericUpDownWorpen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWorpen.ValueChanged += new System.EventHandler(this.numericUpDownWorpen_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aantal ogen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aantal worpen:";
            // 
            // GrBxResultaat
            // 
            this.GrBxResultaat.Controls.Add(this.lblTotaalOgen);
            this.GrBxResultaat.Controls.Add(this.label4);
            this.GrBxResultaat.Controls.Add(this.listBoxWorpen);
            this.GrBxResultaat.Controls.Add(this.label3);
            this.GrBxResultaat.Location = new System.Drawing.Point(263, 12);
            this.GrBxResultaat.Name = "GrBxResultaat";
            this.GrBxResultaat.Size = new System.Drawing.Size(186, 236);
            this.GrBxResultaat.TabIndex = 1;
            this.GrBxResultaat.TabStop = false;
            this.GrBxResultaat.Text = "Resultaat";
            // 
            // lblTotaalOgen
            // 
            this.lblTotaalOgen.AutoSize = true;
            this.lblTotaalOgen.Location = new System.Drawing.Point(135, 188);
            this.lblTotaalOgen.Name = "lblTotaalOgen";
            this.lblTotaalOgen.Size = new System.Drawing.Size(14, 16);
            this.lblTotaalOgen.TabIndex = 3;
            this.lblTotaalOgen.Text = "0";
            this.lblTotaalOgen.Click += new System.EventHandler(this.lblTotaalOgen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Totaal aantal ogen:";
            // 
            // listBoxWorpen
            // 
            this.listBoxWorpen.Font = new System.Drawing.Font("Arial", 7.8F);
            this.listBoxWorpen.FormattingEnabled = true;
            this.listBoxWorpen.ItemHeight = 16;
            this.listBoxWorpen.Location = new System.Drawing.Point(9, 37);
            this.listBoxWorpen.Name = "listBoxWorpen";
            this.listBoxWorpen.Size = new System.Drawing.Size(158, 148);
            this.listBoxWorpen.TabIndex = 1;
            this.listBoxWorpen.SelectedIndexChanged += new System.EventHandler(this.listBoxWorpen_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Worpen:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 260);
            this.Controls.Add(this.GrBxResultaat);
            this.Controls.Add(this.GrBxInstellingen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GrBxInstellingen.ResumeLayout(false);
            this.GrBxInstellingen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOgen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorpen)).EndInit();
            this.GrBxResultaat.ResumeLayout(false);
            this.GrBxResultaat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrBxInstellingen;
        private System.Windows.Forms.Button GooiDobbelsteen;
        private System.Windows.Forms.NumericUpDown numericUpDownOgen;
        private System.Windows.Forms.NumericUpDown numericUpDownWorpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrBxResultaat;
        private System.Windows.Forms.Label lblTotaalOgen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxWorpen;
    }
}

