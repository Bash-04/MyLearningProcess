namespace VakantiePlannerGUI
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
            this.btnGetAllHolidays = new System.Windows.Forms.Button();
            this.dgvHolidays = new System.Windows.Forms.DataGridView();
            this.btnNewHoliday = new System.Windows.Forms.Button();
            this.lblEmployeeChoice = new System.Windows.Forms.Label();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.lblDepartmentChoice = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.groupBoxDepartment = new System.Windows.Forms.GroupBox();
            this.cbDepartmentOffice = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewDepartment = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.tbDepartmentName = new System.Windows.Forms.TextBox();
            this.tbOfficeLocation = new System.Windows.Forms.TextBox();
            this.groupBoxOffice = new System.Windows.Forms.GroupBox();
            this.btnNewOffice = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmployeeEmail = new System.Windows.Forms.TextBox();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.cbEmployeeOffice = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEmployeeDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.tbEmployeeName = new System.Windows.Forms.TextBox();
            this.lblOfficeChoice = new System.Windows.Forms.Label();
            this.cbOffice = new System.Windows.Forms.ComboBox();
            this.Calender = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHolidays)).BeginInit();
            this.groupBoxDepartment.SuspendLayout();
            this.groupBoxOffice.SuspendLayout();
            this.groupBoxEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetAllHolidays
            // 
            this.btnGetAllHolidays.Location = new System.Drawing.Point(269, 22);
            this.btnGetAllHolidays.Name = "btnGetAllHolidays";
            this.btnGetAllHolidays.Size = new System.Drawing.Size(287, 52);
            this.btnGetAllHolidays.TabIndex = 6;
            this.btnGetAllHolidays.Text = "Haal alle vakanties op";
            this.btnGetAllHolidays.UseVisualStyleBackColor = true;
            // 
            // dgvHolidays
            // 
            this.dgvHolidays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHolidays.Location = new System.Drawing.Point(269, 81);
            this.dgvHolidays.Name = "dgvHolidays";
            this.dgvHolidays.RowHeadersWidth = 51;
            this.dgvHolidays.RowTemplate.Height = 24;
            this.dgvHolidays.Size = new System.Drawing.Size(287, 357);
            this.dgvHolidays.TabIndex = 17;
            // 
            // btnNewHoliday
            // 
            this.btnNewHoliday.Location = new System.Drawing.Point(18, 387);
            this.btnNewHoliday.Name = "btnNewHoliday";
            this.btnNewHoliday.Size = new System.Drawing.Size(199, 51);
            this.btnNewHoliday.TabIndex = 5;
            this.btnNewHoliday.Text = "Plan uw vakantie in";
            this.btnNewHoliday.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeChoice
            // 
            this.lblEmployeeChoice.AutoSize = true;
            this.lblEmployeeChoice.Location = new System.Drawing.Point(15, 78);
            this.lblEmployeeChoice.Name = "lblEmployeeChoice";
            this.lblEmployeeChoice.Size = new System.Drawing.Size(85, 16);
            this.lblEmployeeChoice.TabIndex = 28;
            this.lblEmployeeChoice.Text = "Medewerker:";
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(106, 75);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(111, 24);
            this.cbEmployee.TabIndex = 3;
            // 
            // lblDepartmentChoice
            // 
            this.lblDepartmentChoice.AutoSize = true;
            this.lblDepartmentChoice.Location = new System.Drawing.Point(15, 48);
            this.lblDepartmentChoice.Name = "lblDepartmentChoice";
            this.lblDepartmentChoice.Size = new System.Drawing.Size(59, 16);
            this.lblDepartmentChoice.TabIndex = 26;
            this.lblDepartmentChoice.Text = "Afdeling:";
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(80, 45);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(137, 24);
            this.cbDepartment.TabIndex = 2;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // groupBoxDepartment
            // 
            this.groupBoxDepartment.Controls.Add(this.cbDepartmentOffice);
            this.groupBoxDepartment.Controls.Add(this.label3);
            this.groupBoxDepartment.Controls.Add(this.btnNewDepartment);
            this.groupBoxDepartment.Controls.Add(this.lblLocation);
            this.groupBoxDepartment.Controls.Add(this.tbDepartmentName);
            this.groupBoxDepartment.Location = new System.Drawing.Point(590, 123);
            this.groupBoxDepartment.Name = "groupBoxDepartment";
            this.groupBoxDepartment.Size = new System.Drawing.Size(198, 111);
            this.groupBoxDepartment.TabIndex = 24;
            this.groupBoxDepartment.TabStop = false;
            this.groupBoxDepartment.Text = "Nieuwe Afdeling";
            // 
            // cbDepartmentOffice
            // 
            this.cbDepartmentOffice.FormattingEnabled = true;
            this.cbDepartmentOffice.Location = new System.Drawing.Point(68, 21);
            this.cbDepartmentOffice.Name = "cbDepartmentOffice";
            this.cbDepartmentOffice.Size = new System.Drawing.Size(124, 24);
            this.cbDepartmentOffice.TabIndex = 9;
            this.cbDepartmentOffice.SelectedIndexChanged += new System.EventHandler(this.cbDepartmentOffice_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kantoor:";
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
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(6, 54);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(50, 16);
            this.lblLocation.TabIndex = 8;
            this.lblLocation.Text = "Naam: ";
            // 
            // tbDepartmentName
            // 
            this.tbDepartmentName.Location = new System.Drawing.Point(59, 51);
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(133, 22);
            this.tbDepartmentName.TabIndex = 10;
            // 
            // tbOfficeLocation
            // 
            this.tbOfficeLocation.Location = new System.Drawing.Point(62, 21);
            this.tbOfficeLocation.Name = "tbOfficeLocation";
            this.tbOfficeLocation.Size = new System.Drawing.Size(130, 22);
            this.tbOfficeLocation.TabIndex = 7;
            // 
            // groupBoxOffice
            // 
            this.groupBoxOffice.Controls.Add(this.btnNewOffice);
            this.groupBoxOffice.Controls.Add(this.tbOfficeLocation);
            this.groupBoxOffice.Controls.Add(this.label4);
            this.groupBoxOffice.Location = new System.Drawing.Point(590, 12);
            this.groupBoxOffice.Name = "groupBoxOffice";
            this.groupBoxOffice.Size = new System.Drawing.Size(198, 81);
            this.groupBoxOffice.TabIndex = 23;
            this.groupBoxOffice.TabStop = false;
            this.groupBoxOffice.Text = "Nieuw Kantoor";
            // 
            // btnNewOffice
            // 
            this.btnNewOffice.Location = new System.Drawing.Point(9, 49);
            this.btnNewOffice.Name = "btnNewOffice";
            this.btnNewOffice.Size = new System.Drawing.Size(183, 26);
            this.btnNewOffice.TabIndex = 8;
            this.btnNewOffice.Text = "Voeg nieuw kantoor toe";
            this.btnNewOffice.UseVisualStyleBackColor = true;
            this.btnNewOffice.Click += new System.EventHandler(this.btnNewOffice_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Locatie:";
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.Controls.Add(this.label1);
            this.groupBoxEmployee.Controls.Add(this.tbEmployeeEmail);
            this.groupBoxEmployee.Controls.Add(this.btnNewEmployee);
            this.groupBoxEmployee.Controls.Add(this.cbEmployeeOffice);
            this.groupBoxEmployee.Controls.Add(this.label5);
            this.groupBoxEmployee.Controls.Add(this.cbEmployeeDepartment);
            this.groupBoxEmployee.Controls.Add(this.label2);
            this.groupBoxEmployee.Controls.Add(this.lblEmployeeName);
            this.groupBoxEmployee.Controls.Add(this.tbEmployeeName);
            this.groupBoxEmployee.Location = new System.Drawing.Point(590, 265);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Size = new System.Drawing.Size(198, 169);
            this.groupBoxEmployee.TabIndex = 22;
            this.groupBoxEmployee.TabStop = false;
            this.groupBoxEmployee.Text = "Nieuwe Medewerker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Email:";
            // 
            // tbEmployeeEmail
            // 
            this.tbEmployeeEmail.Location = new System.Drawing.Point(56, 109);
            this.tbEmployeeEmail.Name = "tbEmployeeEmail";
            this.tbEmployeeEmail.Size = new System.Drawing.Size(136, 22);
            this.tbEmployeeEmail.TabIndex = 15;
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Location = new System.Drawing.Point(9, 137);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(183, 26);
            this.btnNewEmployee.TabIndex = 16;
            this.btnNewEmployee.Text = "Voeg medewerker toe";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // cbEmployeeOffice
            // 
            this.cbEmployeeOffice.FormattingEnabled = true;
            this.cbEmployeeOffice.Location = new System.Drawing.Point(68, 21);
            this.cbEmployeeOffice.Name = "cbEmployeeOffice";
            this.cbEmployeeOffice.Size = new System.Drawing.Size(124, 24);
            this.cbEmployeeOffice.TabIndex = 12;
            this.cbEmployeeOffice.SelectedIndexChanged += new System.EventHandler(this.cbEmployeeOffice_SelectedIndexChanged);
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
            // cbEmployeeDepartment
            // 
            this.cbEmployeeDepartment.FormattingEnabled = true;
            this.cbEmployeeDepartment.Location = new System.Drawing.Point(71, 51);
            this.cbEmployeeDepartment.Name = "cbEmployeeDepartment";
            this.cbEmployeeDepartment.Size = new System.Drawing.Size(121, 24);
            this.cbEmployeeDepartment.TabIndex = 13;
            this.cbEmployeeDepartment.SelectedIndexChanged += new System.EventHandler(this.cbEmployeeDepartment_SelectedIndexChanged);
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
            this.tbEmployeeName.TabIndex = 14;
            // 
            // lblOfficeChoice
            // 
            this.lblOfficeChoice.AutoSize = true;
            this.lblOfficeChoice.Location = new System.Drawing.Point(15, 18);
            this.lblOfficeChoice.Name = "lblOfficeChoice";
            this.lblOfficeChoice.Size = new System.Drawing.Size(56, 16);
            this.lblOfficeChoice.TabIndex = 21;
            this.lblOfficeChoice.Text = "Kantoor:";
            // 
            // cbOffice
            // 
            this.cbOffice.FormattingEnabled = true;
            this.cbOffice.Location = new System.Drawing.Point(77, 15);
            this.cbOffice.Name = "cbOffice";
            this.cbOffice.Size = new System.Drawing.Size(140, 24);
            this.cbOffice.TabIndex = 1;
            this.cbOffice.SelectedIndexChanged += new System.EventHandler(this.cbOffice_SelectedIndexChanged);
            // 
            // Calender
            // 
            this.Calender.Location = new System.Drawing.Point(18, 168);
            this.Calender.Name = "Calender";
            this.Calender.TabIndex = 4;
            // 
            // VakantiePlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetAllHolidays);
            this.Controls.Add(this.dgvHolidays);
            this.Controls.Add(this.btnNewHoliday);
            this.Controls.Add(this.lblEmployeeChoice);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.lblDepartmentChoice);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.groupBoxDepartment);
            this.Controls.Add(this.groupBoxOffice);
            this.Controls.Add(this.groupBoxEmployee);
            this.Controls.Add(this.lblOfficeChoice);
            this.Controls.Add(this.cbOffice);
            this.Controls.Add(this.Calender);
            this.Name = "VakantiePlanner";
            this.Text = "Vakantie Planner";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHolidays)).EndInit();
            this.groupBoxDepartment.ResumeLayout(false);
            this.groupBoxDepartment.PerformLayout();
            this.groupBoxOffice.ResumeLayout(false);
            this.groupBoxOffice.PerformLayout();
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetAllHolidays;
        private System.Windows.Forms.DataGridView dgvHolidays;
        private System.Windows.Forms.Button btnNewHoliday;
        private System.Windows.Forms.Label lblEmployeeChoice;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Label lblDepartmentChoice;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.GroupBox groupBoxDepartment;
        private System.Windows.Forms.Button btnNewDepartment;
        private System.Windows.Forms.TextBox tbOfficeLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.GroupBox groupBoxOffice;
        private System.Windows.Forms.Button btnNewOffice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDepartmentName;
        private System.Windows.Forms.GroupBox groupBoxEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmployeeEmail;
        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.ComboBox cbEmployeeOffice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEmployeeDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.Label lblOfficeChoice;
        private System.Windows.Forms.ComboBox cbOffice;
        private System.Windows.Forms.MonthCalendar Calender;
        private System.Windows.Forms.ComboBox cbDepartmentOffice;
        private System.Windows.Forms.Label label3;
    }
}

