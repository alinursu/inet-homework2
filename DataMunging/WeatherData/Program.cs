using System;
using System.Linq;
using DryFusion;

namespace WeatherData
{
	internal static class Program
	{

// TODO: Creeaza doua campuri private pentru DatFileReader si WeatherObjCreator (similar ca la SoccerLeagueTable).

		private static void Main()
		{
			Solve(new DatFileReader(),new WeatherObjCreator());
		}
		private static void Solve(IDatFileReader datFileReader,WeatherObjCreator weatherObjCreator)
		{
			var lines = datFileReader.ReadFile(@"../../weather.dat");
			var days = lines.Select(weatherObjCreator.CreateObjectFromLine).ToList();

			// Converting text lines into Weather objects

// TODO: Creeaza o interfata comuna (ex: IComputeOutput), cu o functie care va fi implementata pentru fiecare problema 

			// Choosing the day with the smallest temperature spread
			var chosenDayTemperatureSpread = 9999;
			Weather chosenDay = null;

			foreach (var day in days.Where(day => day.MaxTemperature - day.MinTemperature < chosenDayTemperatureSpread))
			{
				chosenDayTemperatureSpread = day.MaxTemperature - day.MinTemperature;
				chosenDay = day;
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
