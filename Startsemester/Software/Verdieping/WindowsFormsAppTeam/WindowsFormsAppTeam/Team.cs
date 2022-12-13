﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppTeam
{
    public class Team
    {
        // a team consists of:
        // 0 / 1 coach and 11 players
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
