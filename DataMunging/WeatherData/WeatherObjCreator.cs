using System;
using DryFusion;

namespace WeatherData
{
    class WeatherObjCreator : IObjectCreator<Weather>
    {
        public  Weather CreateObjectFromLine(string line)
		{
			var values = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
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

			weather.AvgTemperature = Int32.Parse(values[3]);

			if(values[4] == "_")
            {
				weather.HDDay = null;
            }
			else
            {
				weather.HDDay = Int32.Parse(values[4]);
			}

			weather.AvDP = Double.Parse(values[5]);

			if (values[6] == "_")
			{
				weather.OneHrP = null;
			}

			weather.TPcpn = Double.Parse(values[7]);

			if (values[8] == "_")
			{
				values[8] = null;
			}
			weather.WxType = values[8];

			weather.PDir = Int32.Parse(values[9]);

			weather.AvSp = Double.Parse(values[10]);

			weather.Dir = Int32.Parse(values[11]);

			if(values[12].EndsWith("*"))
            {
				values[12] = values[12].Substring(0, values[12].Length - 1);
			}
			weather.MxS = Int32.Parse(values[12]);

			weather.SkyC = Double.Parse(values[13]);

			weather.MxR = Int32.Parse(values[14]);

			weather.MnR = Int32.Parse(values[15]);

			weather.AvSLP = Double.Parse(values[16]);

			return weather;
		}
    }
}
