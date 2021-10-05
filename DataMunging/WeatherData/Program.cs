using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherData
{
	class Program
	{
		static void Main()
		{
			string[] lines = DatFileReader.readFile(@"../../weather.dat");
			List<Weather> days = new List<Weather>();

			// Converting text lines into Weather objects
			foreach (string line in lines) {
				string[] values = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

				Weather weather = new Weather();
				weather.Day = Int32.Parse(values[0]);

				if (values[1].EndsWith("*"))
				{
					values[1] = values[1].Substring(0, values[1].Length - 1);
				}
				weather.MaxTemperature = Int32.Parse(values[1]);

				if (values[2].EndsWith("*"))
				{
					values[2] = values[2].Substring(0, values[2].Length - 1);
				}
				weather.MinTemperature = Int32.Parse(values[2]);

				days.Add(weather);
			}

			// Choosing the day with the smallest temperature spread
			int chosenDayTemperatureSpread = 9999;
			Weather chosenDay = null;

			foreach(Weather day in days) {
				if (day.MaxTemperature - day.MinTemperature < chosenDayTemperatureSpread)
				{
					chosenDayTemperatureSpread = day.MaxTemperature - day.MinTemperature;
					chosenDay = day;
				}
			}

			if (chosenDay != null)
			{
				Console.WriteLine("Day " + chosenDay.Day + " " +
					"is the day with the smallest temperature spread (" + chosenDayTemperatureSpread + ")");
			}
			else
			{
				Console.WriteLine("No days found in weather.dat");
			}

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}
}
