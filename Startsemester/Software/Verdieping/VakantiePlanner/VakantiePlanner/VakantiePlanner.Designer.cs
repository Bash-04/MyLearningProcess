namespace VakantiePlanner
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
            this.lblOfficeChoice = new System.Windows.Forms.Label();
            this.cbOffice = new System.Windows.Forms.ComboBox();
            this.Calender = new System.Windows.Forms.MonthCalendar();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.tbEmployeeName = new System.Windows.Forms.TextBox();
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.cbOfficeEmployee = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDepartmentEmployee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDepartment = new System.Windows.Forms.GroupBox();
            this.btnNewDepartment = new System.Windows.Forms.Button();
            this.cbOfficeDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDepartmentName = new System.Windows.Forms.TextBox();
            this.groupBoxOffice = new System.Windows.Forms.GroupBox();
            this.btnNewOffice = new System.Windows.Forms.Button();
            this.tbOfficeName = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOfficeSolicitor = new System.Windows.Forms.TextBox();
            this.lblDepartmentChoice = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.lblEmployeeChoice = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBoxEmployee.SuspendLayout();
            this.groupBoxDepartment.SuspendLayout();
            this.groupBoxOffice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOfficeChoice
            // 
            this.lblOfficeChoice.AutoSize = true;
            this.lblOfficeChoice.Location = new System.Drawing.Point(15, 18);
            this.lblOfficeChoice.Name = "lblOfficeChoice";
            this.lblOfficeChoice.Size = new System.Drawing.Size(56, 16);
            this.lblOfficeChoice.TabIndex = 5;
            this.lblOfficeChoice.Text = "Kantoor:";
            // 
            // cbOffice
            // 
            this.cbOffice.FormattingEnabled = true;
            this.cbOffice.Location = new System.Drawing.Point(77, 15);
            this.cbOffice.Name = "cbOffice";
            this.cbOffice.Size = new System.Drawing.Size(140, 24);
            this.cbOffice.TabIndex = 4;
            // 
            // Calender
            // 
            this.Calender.Location = new System.Drawing.Point(18, 225);
            this.Calender.Name = "Calender";
            this.Calender.TabIndex = 3;
            this.Calender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calender_DateChanged);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(6, 84);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(47, 16);
            this.lblEmployeeName.TabIndex = 6;
            this.lblEmployeeName.Text = "Naam:";
            // 
            // tbEmployeeName
            // 
            this.tbEmployeeName.Location = new System.Drawing.Point(59, 81);
            this.tbEmployeeName.Name = "tbEmployeeName";
            this.tbEmployeeName.Size = new System.Drawing.Size(133, 22);
            this.tbEmployeeName.TabIndex = 7;
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.Controls.Add(this.btnNewEmployee);
            this.groupBoxEmployee.Controls.Add(this.cbOfficeEmployee);
            this.groupBoxEmployee.Controls.Add(this.label5);
            this.groupBoxEmployee.Controls.Add(this.cbDepartmentEmployee);
            this.groupBoxEmployee.Controls.Add(this.label2);
            this.groupBoxEmployee.Controls.Add(this.lblEmployeeName);
            this.groupBoxEmployee.Controls.Add(this.tbEmployeeName);
            this.groupBoxEmployee.Location = new System.Drawing.Point(590, 297);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Size = new System.Drawing.Size(198, 141);
            this.groupBoxEmployee.TabIndex = 8;
            this.groupBoxEmployee.TabStop = false;
            this.groupBoxEmployee.Text = "Nieuwe Medewerker";
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Location = new System.Drawing.Point(9, 109);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(183, 26);
            this.btnNewEmployee.TabIndex = 12;
            this.btnNewEmployee.Text = "Voeg medewerker toe";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // cbOfficeEmployee
            // 
            this.cbOfficeEmployee.FormattingEnabled = true;
            this.cbOfficeEmployee.Location = new System.Drawing.Point(68, 21);
            this.cbOfficeEmployee.Name = "cbOfficeEmployee";
            this.cbOfficeEmployee.Size = new System.Drawing.Size(124, 24);
            this.cbOfficeEmployee.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kantoor:";
            // 
            // cbDepartmentEmployee
            // 
            this.cbDepartmentEmployee.FormattingEnabled = true;
            this.cbDepartmentEmployee.Location = new System.Drawing.Point(71, 51);
            this.cbDepartmentEmployee.Name = "cbDepartmentEmployee";
            this.cbDepartmentEmployee.Size = new System.Drawing.Size(121, 24);
            this.cbDepartmentEmployee.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Afdeling:";
            // 
            // groupBoxDepartment
            // 
            this.groupBoxDepartment.Controls.Add(this.btnNewDepartment);
            this.groupBoxDepartment.Controls.Add(this.cbOfficeDepartment);
            this.groupBoxDepartment.Controls.Add(this.label3);
            this.groupBoxDepartment.Controls.Add(this.label4);
            this.groupBoxDepartment.Controls.Add(this.tbDepartmentName);
            this.groupBoxDepartment.Location = new System.Drawing.Point(590, 154);
            this.groupBoxDepartment.Name = "groupBoxDepartment";
            this.groupBoxDepartment.Size = new System.Drawing.Size(198, 111);
            this.groupBoxDepartment.TabIndex = 10;
            this.groupBoxDepartment.TabStop = false;
            this.groupBoxDepartment.Text = "Nieuwe Afdeling";
            // 
            // btnNewDepartment
            // 
            this.btnNewDepartment.Location = new System.Drawing.Point(9, 79);
            this.btnNewDepartment.Name = "btnNewDepartment";
            this.btnNewDepartment.Size = new System.Drawing.Size(183, 26);
            this.btnNewDepartment.TabIndex = 11;
            this.btnNewDepartment.Text = "Voeg nieuwe afdeling toe";
            this.btnNewDepartment.UseVisualStyleBackColor = true;
            this.btnNewDepartment.Click += new System.EventHandler(this.btnNewDepartment_Click);
            // 
            // cbOfficeDepartment
            // 
            this.cbOfficeDepartment.FormattingEnabled = true;
            this.cbOfficeDepartment.Location = new System.Drawing.Point(68, 21);
            this.cbOfficeDepartment.Name = "cbOfficeDepartment";
            this.cbOfficeDepartment.Size = new System.Drawing.Size(124, 24);
            this.cbOfficeDepartment.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kantoor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Naam:";
            // 
            // tbDepartmentName
            // 
            this.tbDepartmentName.Location = new System.Drawing.Point(59, 51);
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(133, 22);
            this.tbDepartmentName.TabIndex = 7;
            // 
            // groupBoxOffice
            // 
            this.groupBoxOffice.Controls.Add(this.btnNewOffice);
            this.groupBoxOffice.Controls.Add(this.tbOfficeName);
            this.groupBoxOffice.Controls.Add(this.lblLocation);
            this.groupBoxOffice.Controls.Add(this.label7);
            this.groupBoxOffice.Controls.Add(this.tbOfficeSolicitor);
            this.groupBoxOffice.Location = new System.Drawing.Point(590, 12);
            this.groupBoxOffice.Name = "groupBoxOffice";
            this.groupBoxOffice.Size = new System.Drawing.Size(198, 111);
            this.groupBoxOffice.TabIndex = 11;
            this.groupBoxOffice.TabStop = false;
            this.groupBoxOffice.Text = "Nieuw Kantoor";
            // 
            // btnNewOffice
            // 
            this.btnNewOffice.Location = new System.Drawing.Point(9, 79);
            this.btnNewOffice.Name = "btnNewOffice";
            this.btnNewOffice.Size = new System.Drawing.Size(183, 26);
            this.btnNewOffice.TabIndex = 10;
            this.btnNewOffice.Text = "Voeg nieuw kantoor toe";
            this.btnNewOffice.UseVisualStyleBackColor = true;
            this.btnNewOffice.Click += new System.EventHandler(this.btnNewOffice_Click);
            // 
            // tbOfficeName
            // 
            this.tbOfficeName.Location = new System.Drawing.Point(62, 21);
            this.tbOfficeName.Name = "tbOfficeName";
            this.tbOfficeName.Size = new System.Drawing.Size(130, 22);
            this.tbOfficeName.TabIndex = 9;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(6, 24);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(57, 16);
            this.lblLocation.TabIndex = 8;
            this.lblLocation.Text = "Locatie: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Notaris:";
            // 
            // tbOfficeSolicitor
            // 
            this.tbOfficeSolicitor.Location = new System.Drawing.Point(59, 51);
            this.tbOfficeSolicitor.Name = "tbOfficeSolicitor";
            this.tbOfficeSolicitor.Size = new System.Drawing.Size(133, 22);
            this.tbOfficeSolicitor.TabIndex = 7;
            // 
            // lblDepartmentChoice
            // 
            this.lblDepartmentChoice.AutoSize = true;
            this.lblDepartmentChoice.Location = new System.Drawing.Point(15, 48);
            this.lblDepartmentChoice.Name = "lblDepartmentChoice";
            this.lblDepartmentChoice.Size = new System.Drawing.Size(59, 16);
            this.lblDepartmentChoice.TabIndex = 13;
            this.lblDepartmentChoice.Text = "Afdeling:";
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(80, 45);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(137, 24);
            this.cbDepartment.TabIndex = 12;
            // 
            // lblEmployeeChoice
            // 
            this.lblEmployeeChoice.AutoSize = true;
            this.lblEmployeeChoice.Location = new System.Drawing.Point(15, 78);
            this.lblEmployeeChoice.Name = "lblEmployeeChoice";
            this.lblEmployeeChoice.Size = new System.Drawing.Size(85, 16);
            this.lblEmployeeChoice.TabIndex = 15;
            this.lblEmployeeChoice.Text = "Medewerker:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(106, 75);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(111, 24);
            this.comboBox2.TabIndex = 14;
            // 
            // VakantiePlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEmployeeChoice);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblDepartmentChoice);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.groupBoxOffice);
            this.Controls.Add(this.groupBoxDepartment);
            this.Controls.Add(this.groupBoxEmployee);
            this.Controls.Add(this.lblOfficeChoice);
            this.Controls.Add(this.cbOffice);
            this.Controls.Add(this.Calender);
            this.Name = "VakantiePlanner";
            this.Text = "Vakantie Planner";
            this.Load += new System.EventHandler(this.VakantiePlanner_Load);
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            this.groupBoxDepartment.ResumeLayout(false);
            this.groupBoxDepartment.PerformLayout();
            this.groupBoxOffice.ResumeLayout(false);
            this.groupBoxOffice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOfficeChoice;
        private System.Windows.Forms.ComboBox cbOffice;
        private System.Windows.Forms.MonthCalendar Calender;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.GroupBox groupBoxEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDepartmentEmployee;
        private System.Windows.Forms.GroupBox groupBoxDepartment;
        private System.Windows.Forms.ComboBox cbOfficeDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDepartmentName;
        private System.Windows.Forms.ComboBox cbOfficeEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxOffice;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOfficeSolicitor;
        private System.Windows.Forms.TextBox tbOfficeName;
        private System.Windows.Forms.Button btnNewOffice;
        private System.Windows.Forms.Button btnNewDepartment;
        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.Label lblDepartmentChoice;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lblEmployeeChoice;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

