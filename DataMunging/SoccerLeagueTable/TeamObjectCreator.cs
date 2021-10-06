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
            team.GoalsFor = Int32.Parse(values[6]);
            team.GoalsAgainst = Int32.Parse(values[8]);

            return team;
        }
    }
}
