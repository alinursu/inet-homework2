using System;
using System.Collections.Generic;
using System.Linq;
using DryFusion.interfaces;

namespace WeatherData
{
     class ComputeOutput : IComputeOutput<Weather>
    {
       public void Compute(IEnumerable<Weather> days)
        {   
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