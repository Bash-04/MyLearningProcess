using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppTeam
{
    public class Team
    {
        // a team consists of:
        // 0 / 1 coach and 11 fieldplayers
        // 1 goalkeeper
        // max 5 defenders
        // max 5 midfielders
        // max 4 attackers

        public List<Player> players { get; private set; }

        //private List<Player> Defenders
        //{
        //    get
        //    {
        //        return players.FindAll(e => e.FieldPosition.Equals(FieldPosition.Defender));    // e == element?
        //        //List<Player> defenders = new List<Player>();
        //        //for (int i = 0; i < players.Count; i++)
        //        //{
        //        //    if (players[i].FieldPosition == FieldPosition.Defender)
        //        //    {
        //        //        defenders.Add(players[i]);
        //        //    }
        //        //}
        //        //return defenders;
        //    }
        //}

        public Coach coach{ get; private set; }

        public string name { get; private set; }
        public City city { get; private set; }

        public Team(string name, City city)   // Constructor
        {
            players = new List<Player>();
            this.name = name;
            this.city = city;
        }

        public bool TryAddPlayers(Player newPlayer)
        {
            bool succes = false;

            if (PlayerCanBeAdded(newPlayer) == true)
            {
                succes = true;
                players.Add(newPlayer);
            }
            return succes;
        }

        private bool PlayerCanBeAdded(Player newPlayer)
        {
            bool succes = false;

            int goalkeeper = 0;
            int defenders = 0;
            int midfielders = 0;
            int attackers = 0;

            if (players.Count != 15)
            {
                foreach (Player player in players)
                {
                    switch (player.FieldPosition)
                    {
                        case FieldPosition.GoalKeeper:
                            goalkeeper += 1;
                            break;

                        case FieldPosition.Defender:
                            defenders += 1;
                            break;

                        case FieldPosition.Midfielder:
                            midfielders += 1;
                            break;

                        case FieldPosition.Attacker:
                            attackers += 1;
                            break;
                    }
                }

                switch (newPlayer.FieldPosition)
                {
                    case FieldPosition.GoalKeeper:
                        if (goalkeeper < 1)
                        {
                            succes = true;
                        }
                        break;

                    case FieldPosition.Defender:
                        if (defenders < 5)
                        {
                            succes = true;
                        }
                        break;

                    case FieldPosition.Midfielder:
                        if (midfielders < 5)
                        {
                            succes = true;
                        }
                        break;

                    case FieldPosition.Attacker:
                        if (attackers < 4)
                        {
                            succes = true;
                        }
                        break;

                    default:
                        return succes = false;
                }
            }

            return succes;
        }

        public override string ToString()
        {
            return name + " - " + city;
        }
    }
}
