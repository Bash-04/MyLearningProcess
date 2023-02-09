namespace WindowsFormsAppTeam
{
    partial class FormTeamManager
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
            this.btnCreatePlayer = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.lblPlayerNumber = new System.Windows.Forms.Label();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.lblPlayerPos = new System.Windows.Forms.Label();
            this.cbPlayerPos = new System.Windows.Forms.ComboBox();
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.lblTeams = new System.Windows.Forms.Label();
            this.lblCityName = new System.Windows.Forms.Label();
            this.tbTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.cbCityName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreatePlayer
            // 
            this.btnCreatePlayer.Location = new System.Drawing.Point(12, 123);
            this.btnCreatePlayer.Name = "btnCreatePlayer";
            this.btnCreatePlayer.Size = new System.Drawing.Size(195, 49);
            this.btnCreatePlayer.TabIndex = 0;
            this.btnCreatePlayer.Text = "Create Player";
            this.btnCreatePlayer.UseVisualStyleBackColor = true;
            this.btnCreatePlayer.Click += new System.EventHandler(this.btnCreatePlayer_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(12, 37);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(89, 16);
            this.lblPlayerName.TabIndex = 1;
            this.lblPlayerName.Text = "Player Name:";
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Location = new System.Drawing.Point(104, 34);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(103, 22);
            this.tbPlayerName.TabIndex = 2;
            this.tbPlayerName.TextChanged += new System.EventHandler(this.tbPlayerName_TextChanged);
            // 
            // lbPlayers
            // 
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.ItemHeight = 16;
            this.lbPlayers.Location = new System.Drawing.Point(213, 34);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(295, 292);
            this.lbPlayers.TabIndex = 3;
            this.lbPlayers.SelectedIndexChanged += new System.EventHandler(this.lbPlayers_SelectedIndexChanged);
            // 
            // lblPlayerNumber
            // 
            this.lblPlayerNumber.AutoSize = true;
            this.lblPlayerNumber.Location = new System.Drawing.Point(12, 65);
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            this.lblPlayerNumber.Size = new System.Drawing.Size(100, 16);
            this.lblPlayerNumber.TabIndex = 4;
            this.lblPlayerNumber.Text = "Player Number:";
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(115, 65);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(92, 22);
            this.nudNumber.TabIndex = 5;
            this.nudNumber.ValueChanged += new System.EventHandler(this.nudNumber_ValueChanged);
            // 
            // lblPlayerPos
            // 
            this.lblPlayerPos.AutoSize = true;
            this.lblPlayerPos.Location = new System.Drawing.Point(12, 93);
            this.lblPlayerPos.Name = "lblPlayerPos";
            this.lblPlayerPos.Size = new System.Drawing.Size(76, 16);
            this.lblPlayerPos.TabIndex = 6;
            this.lblPlayerPos.Text = "Player Pos:";
            // 
            // cbPlayerPos
            // 
            this.cbPlayerPos.FormattingEnabled = true;
            this.cbPlayerPos.Location = new System.Drawing.Point(91, 93);
            this.cbPlayerPos.Name = "cbPlayerPos";
            this.cbPlayerPos.Size = new System.Drawing.Size(116, 24);
            this.cbPlayerPos.TabIndex = 7;
            this.cbPlayerPos.SelectedIndexChanged += new System.EventHandler(this.cbPlayerPos_SelectedIndexChanged);
            // 
            // lbTeams
            // 
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.ItemHeight = 16;
            this.lbTeams.Location = new System.Drawing.Point(514, 34);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(175, 292);
            this.lbTeams.TabIndex = 11;
            this.lbTeams.SelectedIndexChanged += new System.EventHandler(this.lbTeams_SelectedIndexChanged);
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Location = new System.Drawing.Point(210, 15);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(56, 16);
            this.lblPlayers.TabIndex = 12;
            this.lblPlayers.Text = "Players:";
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.Location = new System.Drawing.Point(511, 15);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(53, 16);
            this.lblTeams.TabIndex = 13;
            this.lblTeams.Text = "Teams:";
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Location = new System.Drawing.Point(12, 252);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(72, 16);
            this.lblCityName.TabIndex = 14;
            this.lblCityName.Text = "City Name:";
            // 
            // tbTeamName
            // 
            this.tbTeamName.Location = new System.Drawing.Point(103, 221);
            this.tbTeamName.Name = "tbTeamName";
            this.tbTeamName.Size = new System.Drawing.Size(104, 22);
            this.tbTeamName.TabIndex = 17;
            this.tbTeamName.TextChanged += new System.EventHandler(this.tbTeamName_TextChanged);
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(12, 224);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(86, 16);
            this.lblTeamName.TabIndex = 16;
            this.lblTeamName.Text = "Team Name:";
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.Location = new System.Drawing.Point(12, 277);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(195, 49);
            this.btnCreateTeam.TabIndex = 18;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            this.btnCreateTeam.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // cbCityName
            // 
            this.cbCityName.FormattingEnabled = true;
            this.cbCityName.Location = new System.Drawing.Point(90, 249);
            this.cbCityName.Name = "cbCityName";
            this.cbCityName.Size = new System.Drawing.Size(117, 24);
            this.cbCityName.TabIndex = 19;
            this.cbCityName.SelectedIndexChanged += new System.EventHandler(this.cbCityName_SelectedIndexChanged);
            // 
            // FormTeamManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 338);
            this.Controls.Add(this.cbCityName);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.tbTeamName);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.lblCityName);
            this.Controls.Add(this.lblTeams);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.lbTeams);
            this.Controls.Add(this.cbPlayerPos);
            this.Controls.Add(this.lblPlayerPos);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.lblPlayerNumber);
            this.Controls.Add(this.lbPlayers);
            this.Controls.Add(this.tbPlayerName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.btnCreatePlayer);
            this.MinimumSize = new System.Drawing.Size(719, 385);
            this.Name = "FormTeamManager";
            this.Text = "Team Manager";
            this.Load += new System.EventHandler(this.FormTeamManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreatePlayer;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.ListBox lbPlayers;
        private System.Windows.Forms.Label lblPlayerNumber;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Label lblPlayerPos;
        private System.Windows.Forms.ComboBox cbPlayerPos;
        private System.Windows.Forms.ListBox lbTeams;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.TextBox tbTeamName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Button btnCreateTeam;
        private System.Windows.Forms.ComboBox cbCityName;
    }
}

