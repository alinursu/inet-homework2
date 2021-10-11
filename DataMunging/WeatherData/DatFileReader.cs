using System;
using System.Collections.Generic;
using System.Linq;
using DryFusion;


namespace WeatherData
{
	class DatFileReader : IDatFileReader
	{
		public  IEnumerable<string> ReadFile(string filepath)
		{
			var text = System.IO.File.ReadAllText(filepath);
			text = String.Join("\n", text.Split('\n').Skip(2));
			text = String.Join("\n", text.Split('\n').Take(text.Split('\n').Length - 2));
			return text.Split('\n');
		}
	}
	
}
