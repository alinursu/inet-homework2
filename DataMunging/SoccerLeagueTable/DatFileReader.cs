using System;
using System.Collections.Generic;
using System.Linq;
using DryFusion;

namespace SoccerLeagueTable
{
    class DatFileReader : IDatFileReader
    {
		public  IEnumerable<string> ReadFile(string filepath)
		{
			var text = System.IO.File.ReadAllText(filepath);
			text = String.Join("\n", text.Split('\n').Skip(1));

			var lines = new List<string>(text.Split('\n'));
			var lineToBeRemoved = "";

			lines.ForEach(delegate (string line)
			{
				if (!line.Contains("----")) return;
				lineToBeRemoved = line;
			});
			lines.Remove(lineToBeRemoved);

			return lines.ToArray();
		}
	}
}
