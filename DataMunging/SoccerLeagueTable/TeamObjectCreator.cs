using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerLeagueTable
{
    class TeamObjectCreator
    {
        public static Team createObjectFromLine(string line)
        {
            string[] values = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            Team team = new Team();

            team.Name = values[1];
            team.Played = Int32.Parse(values[2]);
            team.Wins = Int32.Parse(values[3]);
            team.Losses = Int32.Parse(values[4]);
            team.Draws = Int32.Parse(values[5]);
            team.GoalsFor = Int32.Parse(values[6]);
            team.GoalsAgainst = Int32.Parse(values[8]);
            team.Points = Int32.Parse(values[9]);

            return team;
        }
    }
}
