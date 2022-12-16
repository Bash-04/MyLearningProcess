namespace WindowsFormsAppVakantiePlanner
{
    partial class VakantiePlanner
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
            this.Calender = new System.Windows.Forms.MonthCalendar();
            this.cbOffice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calender
            // 
            this.Calender.Location = new System.Drawing.Point(583, 225);
            this.Calender.Name = "Calender";
            this.Calender.TabIndex = 0;
            this.Calender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calender_DateChanged);
            // 
            // cbOffice
            // 
            this.cbOffice.FormattingEnabled = true;
            this.cbOffice.Location = new System.Drawing.Point(74, 12);
            this.cbOffice.Name = "cbOffice";
            this.cbOffice.Size = new System.Drawing.Size(121, 24);
            this.cbOffice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kantoor:";
            // 
            // VakantiePlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOffice);
            this.Controls.Add(this.Calender);
            this.Name = "VakantiePlanner";
            this.Text = "Vakantie Planner";
            this.Load += new System.EventHandler(this.VakantiePlanner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calender;
        private System.Windows.Forms.ComboBox cbOffice;
        private System.Windows.Forms.Label label1;
    }
}

