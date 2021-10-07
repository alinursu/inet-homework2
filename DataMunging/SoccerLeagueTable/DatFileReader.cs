using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerLeagueTable
{
    class DatFileReader
    {
		public static string[] readFile(string filepath)
		{
			string text = System.IO.File.ReadAllText(filepath);
			text = String.Join("\n", text.Split('\n').Skip(1));

			List<string> lines = new List<string>(text.Split('\n'));
			string lineToBeRemoved = "";

			lines.ForEach(delegate (string line)
			{
				if(line.Contains("----"))
                {
					lineToBeRemoved = line;
					return;
                }
			});
			lines.Remove(lineToBeRemoved);

			return lines.ToArray();
		}
	}
}
