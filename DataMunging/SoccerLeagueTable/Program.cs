using System.Collections.Generic;

namespace SoccerLeagueTable
{
	class Program
	{
		private static DatFileReader _datFileReader;
		private static TeamObjectCreator _teamObjectCreator;
		private static ComputeOutput _computeOutput;

		private static void Main()
		{
			_datFileReader = new DatFileReader();
			_teamObjectCreator = new TeamObjectCreator();
			_computeOutput = new ComputeOutput();
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
			_computeOutput.Compute(teams);
		}
		
	}
}
