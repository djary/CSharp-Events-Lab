using System;
using EventHandlerExample;

namespace Events
{
	class Program
	{
		static void Main(string[] args)
		{
			//EventHandler Example
			CounterEvent counter = new CounterEvent(new Random().Next(10));
			counter.ThresholdReached += Counter_ThresholdReached;

			Console.WriteLine("press 'a' key to increase total");
			while (Console.ReadKey(true).KeyChar=='a')
			{
				Console.WriteLine("adding one");
				counter.Add(1);
			}
		}

		private static void Counter_ThresholdReached(object sender, EventArgs e)
		{
			Console.WriteLine("The threshold was reached.");
			Environment.Exit(0);
		}
	}
}
