namespace WindowsFormsAppBloeddruk
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
            this.tbAge = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rbGenderMale = new System.Windows.Forms.RadioButton();
            this.rbGenderFemale = new System.Windows.Forms.RadioButton();
            this.tbBovendruk = new System.Windows.Forms.TextBox();
            this.tbOnderdruk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResNaam = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblResLeeftijd = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblResBloeddruk = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblResBloeddrukWaarde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(96, 85);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(126, 22);
            this.tbAge.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // rbGenderMale
            // 
            this.rbGenderMale.AutoSize = true;
            this.rbGenderMale.Location = new System.Drawing.Point(97, 113);
            this.rbGenderMale.Name = "rbGenderMale";
            this.rbGenderMale.Size = new System.Drawing.Size(54, 20);
            this.rbGenderMale.TabIndex = 2;
            this.rbGenderMale.TabStop = true;
            this.rbGenderMale.Text = "Man";
            this.rbGenderMale.UseVisualStyleBackColor = true;
            this.rbGenderMale.CheckedChanged += new System.EventHandler(this.rbGenderMale_CheckedChanged);
            // 
            // rbGenderFemale
            // 
            this.rbGenderFemale.AutoSize = true;
            this.rbGenderFemale.Location = new System.Drawing.Point(157, 113);
            this.rbGenderFemale.Name = "rbGenderFemale";
            this.rbGenderFemale.Size = new System.Drawing.Size(65, 20);
            this.rbGenderFemale.TabIndex = 3;
            this.rbGenderFemale.TabStop = true;
            this.rbGenderFemale.Text = "Vrouw";
            this.rbGenderFemale.UseVisualStyleBackColor = true;
            this.rbGenderFemale.CheckedChanged += new System.EventHandler(this.rbGenderFemale_CheckedChanged);
            // 
            // tbBovendruk
            // 
            this.tbBovendruk.Location = new System.Drawing.Point(96, 139);
            this.tbBovendruk.Name = "tbBovendruk";
            this.tbBovendruk.Size = new System.Drawing.Size(126, 22);
            this.tbBovendruk.TabIndex = 4;
            this.tbBovendruk.TextChanged += new System.EventHandler(this.tbBovendruk_TextChanged);
            // 
            // tbOnderdruk
            // 
            this.tbOnderdruk.Location = new System.Drawing.Point(96, 167);
            this.tbOnderdruk.Name = "tbOnderdruk";
            this.tbOnderdruk.Size = new System.Drawing.Size(126, 22);
            this.tbOnderdruk.TabIndex = 5;
            this.tbOnderdruk.TextChanged += new System.EventHandler(this.tbOnderdruk_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bovendruk:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Onderdruk:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Leeftijd:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Naam:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(96, 54);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(126, 22);
            this.tbName.TabIndex = 10;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(18, 195);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(204, 55);
            this.btnCalc.TabIndex = 11;
            this.btnCalc.Text = "Meet bloeddruk";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "Resultaat";
            // 
            // lblResNaam
            // 
            this.lblResNaam.BackColor = System.Drawing.SystemColors.Control;
            this.lblResNaam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResNaam.Location = new System.Drawing.Point(377, 56);
            this.lblResNaam.Name = "lblResNaam";
            this.lblResNaam.Size = new System.Drawing.Size(126, 22);
            this.lblResNaam.TabIndex = 13;
            this.lblResNaam.Click += new System.EventHandler(this.lblResNaam_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 34);
            this.label7.TabIndex = 14;
            this.label7.Text = "Uw gegevens";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Naam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Leeftijd";
            // 
            // lblResLeeftijd
            // 
            this.lblResLeeftijd.BackColor = System.Drawing.SystemColors.Control;
            this.lblResLeeftijd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResLeeftijd.Location = new System.Drawing.Point(377, 82);
            this.lblResLeeftijd.Name = "lblResLeeftijd";
            this.lblResLeeftijd.Size = new System.Drawing.Size(126, 22);
            this.lblResLeeftijd.TabIndex = 16;
            this.lblResLeeftijd.Click += new System.EventHandler(this.lblResLeeftijd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Gem. Bloeddruk";
            // 
            // lblResBloeddruk
            // 
            this.lblResBloeddruk.BackColor = System.Drawing.SystemColors.Control;
            this.lblResBloeddruk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResBloeddruk.Location = new System.Drawing.Point(377, 111);
            this.lblResBloeddruk.Name = "lblResBloeddruk";
            this.lblResBloeddruk.Size = new System.Drawing.Size(126, 22);
            this.lblResBloeddruk.TabIndex = 18;
            this.lblResBloeddruk.Click += new System.EventHandler(this.lblResBloeddruk_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(267, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "BloedD. waarde";
            // 
            // lblResBloeddrukWaarde
            // 
            this.lblResBloeddrukWaarde.BackColor = System.Drawing.SystemColors.Control;
            this.lblResBloeddrukWaarde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResBloeddrukWaarde.Location = new System.Drawing.Point(377, 139);
            this.lblResBloeddrukWaarde.Name = "lblResBloeddrukWaarde";
            this.lblResBloeddrukWaarde.Size = new System.Drawing.Size(126, 22);
            this.lblResBloeddrukWaarde.TabIndex = 20;
            this.lblResBloeddrukWaarde.Click += new System.EventHandler(this.lblResBloeddrukWaarde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 265);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblResBloeddrukWaarde);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblResBloeddruk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblResLeeftijd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblResNaam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOnderdruk);
            this.Controls.Add(this.tbBovendruk);
            this.Controls.Add(this.rbGenderFemale);
            this.Controls.Add(this.rbGenderMale);
            this.Controls.Add(this.tbAge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton rbGenderMale;
        private System.Windows.Forms.RadioButton rbGenderFemale;
        private System.Windows.Forms.TextBox tbBovendruk;
        private System.Windows.Forms.TextBox tbOnderdruk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResNaam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblResLeeftijd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblResBloeddruk;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblResBloeddrukWaarde;
    }
}

