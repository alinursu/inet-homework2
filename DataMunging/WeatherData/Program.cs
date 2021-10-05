using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherData
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] lines = DatFileReader.readFile(@"../../weather.dat");
			Console.WriteLine("Contents of WriteLines2.txt = ");
			foreach (string line in lines)
			{
				Console.WriteLine("\t" + line);
			}

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}
}
