using System.Linq;

namespace WeatherData
{
	internal static class Program
	{
		private static DatFileReader _datFileReader;
		private static WeatherObjCreator _weatherObjCreator;
		private static ComputeOutput _computeOutput;
		
		private static void Main()
		{
			_datFileReader = new DatFileReader();
			_weatherObjCreator = new WeatherObjCreator();
			_computeOutput = new ComputeOutput();
			Solve();
		}
		private static void Solve()
		{
			var lines = _datFileReader.ReadFile(@"../../weather.dat");
			var days = lines.Select(_weatherObjCreator.CreateObjectFromLine).ToList();

			_computeOutput.Compute(days);
		}
	}
}
