using System;
using System.Linq;


namespace WeatherData
{
	class DatFileReader
	{
		public static string[] readFile(string filepath)
		{
			string text = System.IO.File.ReadAllText(filepath);
			text = String.Join("\n", text.Split('\n').Skip(2));
			text = String.Join("\n", text.Split('\n').Take(text.Split('\n').Length - 2));
			return text.Split('\n');
		}
	}
}
