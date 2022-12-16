using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTeam
{
    public partial class FormTeamManager : Form
    {
        public FormTeamManager()
        {
            InitializeComponent();
        }

        List<Team> teams = new List<Team>();    // New Object
        int selectedTeam = 0;

        private void FormTeamManager_Load(object sender, EventArgs e)
        {
            cbPlayerPos.DataSource = Enum.GetValues(typeof(FieldPosition));
            cbCityName.DataSource = Enum.GetValues(typeof(City));
        }

        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            string playerName = tbPlayerName.Text;
            int number = Convert.ToInt32(nudNumber.Value);
            FieldPosition fieldPosition = (FieldPosition) cbPlayerPos.SelectedItem;
            
            Player player = new Player(playerName, number, fieldPosition);  // New Object
            // player.Name = "Henk";

            if (teams.Count == 0)
            {
                MessageBox.Show("Creëer alstublieft eerst een team");
            }
            else if(playerName == "")
            {
                MessageBox.Show("Vul alstublieft eerst een spelers naam in");
            }
            else
            {
                Team team = teams[selectedTeam];

                team.TryAddPlayers(player);

                ShowTeam();
            }
        }

        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            string teamName = tbTeamName.Text;
            City cityName = (City)cbCityName.SelectedItem;

            if (teamName == "")
            {
                MessageBox.Show("Vul alstublieft eerst een team naam in");
            }
            else
            {
                Team team = new Team(teamName, cityName);   // New Object

                teams.Add(team);

                ShowTeams();
            }
        }

        private void ShowTeam()
        {
            Team team = teams[selectedTeam];

            lbPlayers.Items.Clear();
            for (int i = 0; i < team.players.Count; i++) {
                lbPlayers.Items.Add(team.players[i]);
            }
            //int i = 0;
            //while (team.players[i] != null)
            //{
            //    lbPlayers.Items.Add(team.players[i]);
            //    i++;
            //}
        }

        private void ShowTeams()
        {
            lbTeams.Items.Clear();
            for (int i = 0; i < teams.Count; i++)
            {
                lbTeams.Items.Add(teams[i]);
            }
        }

        private void lbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTeam = lbTeams.SelectedIndex;
            ShowTeam();
        }

        private void tbPlayerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbPlayerPos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbTeamName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCityName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
