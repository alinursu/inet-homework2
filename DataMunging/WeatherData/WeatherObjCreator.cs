using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherData
{
    class WeatherObjCreator
    {
        public static Weather createObjectFromLine(string line)
		{
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

			return weather;
		}
    }
}
