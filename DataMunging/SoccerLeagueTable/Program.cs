using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerLeagueTable
{
	class Program
	{
		static void Main()
		{
			string[] lines = DatFileReader.readFile(@"../../football.dat");
			List<Team> teams = new List<Team>();

			// Converting text lines into Team objects
			foreach(string line in lines)
            {
				if(line.Length > 0)
				{
					Team team = TeamObjectCreator.createObjectFromLine(line);
					teams.Add(team);
				}
            }

			// Choosing the team with the smallest difference between 'for' and 'against' number of goals
			int chosenTeamDifference = 9999;
			Team chosenTeam = null;
			foreach (Team team in teams)
			{
				if (Math.Abs(team.GoalsFor - team.GoalsAgainst) < chosenTeamDifference)
				{
					chosenTeam = team;
					chosenTeamDifference = Math.Abs(team.GoalsFor - team.GoalsAgainst);
				}
			}

			if(chosenTeam != null)
            {
                Console.WriteLine("Team " + chosenTeam.Name + " is the team with the smallest difference between 'for' " +
					"and 'against' number of goals (" + chosenTeamDifference + ").");
            }
			else
            {
                Console.WriteLine("No teams found in football.dat");
            }

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}
}
