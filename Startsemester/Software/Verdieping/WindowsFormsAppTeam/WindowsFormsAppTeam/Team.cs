using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppTeam
{
    public class Team
    {
        public List<Player> players { get; private set; }

        public string name { get; private set; }
        public City city { get; private set; }

        public Team(string name, City city)   // Constructor
        {
            players = new List<Player>();
            this.name = name;
            this.city = city;
        }

        public void AddPlayers(Player player)
        {
            this.players.Add(player);
        }

        public override string ToString()
        {
            return name + " - " + city;
        }
    }
}
