using System;
using System.Collections.Generic;
using System.Linq;

namespace SoccerLeagueTable
{
	class Program
	{
		private static DatFileReader _datFileReader;
		private static TeamObjectCreator _teamObjectCreator;
		
		private static void Main()
		{
			_datFileReader = new DatFileReader();
			_teamObjectCreator = new TeamObjectCreator();
			Solve();
		}

		private static void Solve()
		{
			var lines = _datFileReader.ReadFile(@"../../football.dat");
			var teams = new List<Team>();

			// Converting text lines into Team objects
			foreach(string line in lines)
            {
				if(line.Length > 0)
				{
					Team team = _teamObjectCreator.CreateObjectFromLine(line);
					teams.Add(team);
				}
            }

			// Choosing the team with the smallest difference between 'for' and 'against' number of goals
			var chosenTeamDifference = 9999;
			Team chosenTeam = null;
			foreach (var team in teams.Where(team => Math.Abs(team.GoalsFor - team.GoalsAgainst) < chosenTeamDifference))
			{
				chosenTeam = team;
				chosenTeamDifference = Math.Abs(team.GoalsFor - team.GoalsAgainst);
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
