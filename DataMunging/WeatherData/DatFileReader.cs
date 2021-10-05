using System;
using System.Linq;

namespace WeatherData
{
	class DatFileReader
	{
		public static string[] readFile(string filepath)
		{
			string text = System.IO.File.ReadAllText(@"../../weather.dat");
			text = String.Join("\n", text.Split('\n').Skip(2));
			return text.Split('\n');
		}
	}
}
