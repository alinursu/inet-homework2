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
			string[] lines = DatFileReader.readFile(@"../../weather.dat");
			List<Team> teams = new List<Team>();

			// Converting text lines into Team objects
			foreach(string line in lines)
            {
				if(line.Length > 0)
				{
					Console.WriteLine(line);
					Team team = TeamObjectCreator.createObjectFromLine(line);
					teams.Add(team);
				}
            }

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}
}
