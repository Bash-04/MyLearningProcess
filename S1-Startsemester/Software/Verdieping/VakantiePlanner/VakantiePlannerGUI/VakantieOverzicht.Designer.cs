namespace VakantiePlannerGUI
{
    partial class VakantieOverzicht
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEmployeeDepartment = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHolidayEmployee = new System.Windows.Forms.ListBox();
            this.lbHolidayStartDate = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbHolidayEndDate = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbHolidayDescription = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSelectedDepartment = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(20, 51);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbEmployeeDepartment);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbHolidayEmployee);
            this.groupBox1.Controls.Add(this.lbHolidayStartDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lbHolidayEndDate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbHolidayDescription);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(258, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 258);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geplande vakanties";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Department";
            // 
            // lbEmployeeDepartment
            // 
            this.lbEmployeeDepartment.FormattingEnabled = true;
            this.lbEmployeeDepartment.ItemHeight = 16;
            this.lbEmployeeDepartment.Location = new System.Drawing.Point(142, 37);
            this.lbEmployeeDepartment.Name = "lbEmployeeDepartment";
            this.lbEmployeeDepartment.Size = new System.Drawing.Size(127, 212);
            this.lbEmployeeDepartment.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Medewerker";
            // 
            // lbHolidayEmployee
            // 
            this.lbHolidayEmployee.FormattingEnabled = true;
            this.lbHolidayEmployee.ItemHeight = 16;
            this.lbHolidayEmployee.Location = new System.Drawing.Point(9, 37);
            this.lbHolidayEmployee.Name = "lbHolidayEmployee";
            this.lbHolidayEmployee.Size = new System.Drawing.Size(127, 212);
            this.lbHolidayEmployee.TabIndex = 42;
            // 
            // lbHolidayStartDate
            // 
            this.lbHolidayStartDate.FormattingEnabled = true;
            this.lbHolidayStartDate.ItemHeight = 16;
            this.lbHolidayStartDate.Location = new System.Drawing.Point(275, 37);
            this.lbHolidayStartDate.Name = "lbHolidayStartDate";
            this.lbHolidayStartDate.Size = new System.Drawing.Size(83, 212);
            this.lbHolidayStartDate.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(450, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 41;
            this.label11.Text = "Beschrijving";
            // 
            // lbHolidayEndDate
            // 
            this.lbHolidayEndDate.FormattingEnabled = true;
            this.lbHolidayEndDate.ItemHeight = 16;
            this.lbHolidayEndDate.Location = new System.Drawing.Point(364, 37);
            this.lbHolidayEndDate.Name = "lbHolidayEndDate";
            this.lbHolidayEndDate.Size = new System.Drawing.Size(83, 212);
            this.lbHolidayEndDate.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Eind datum";
            // 
            // lbHolidayDescription
            // 
            this.lbHolidayDescription.FormattingEnabled = true;
            this.lbHolidayDescription.ItemHeight = 16;
            this.lbHolidayDescription.Location = new System.Drawing.Point(453, 37);
            this.lbHolidayDescription.Name = "lbHolidayDescription";
            this.lbHolidayDescription.Size = new System.Drawing.Size(133, 212);
            this.lbHolidayDescription.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Start datum";
            // 
            // lblSelectedDepartment
            // 
            this.lblSelectedDepartment.AutoSize = true;
            this.lblSelectedDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedDepartment.Location = new System.Drawing.Point(15, 13);
            this.lblSelectedDepartment.Name = "lblSelectedDepartment";
            this.lblSelectedDepartment.Size = new System.Drawing.Size(230, 29);
            this.lblSelectedDepartment.TabIndex = 44;
            this.lblSelectedDepartment.Text = "selectedDepartment";
            // 
            // VakantieOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 315);
            this.Controls.Add(this.lblSelectedDepartment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "VakantieOverzicht";
            this.Text = "VakantiePlannerAgenda";
            this.Load += new System.EventHandler(this.VakantieOverzicht_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbHolidayStartDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbHolidayEndDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbHolidayDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbHolidayEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbEmployeeDepartment;
        private System.Windows.Forms.Label lblSelectedDepartment;
    }
}