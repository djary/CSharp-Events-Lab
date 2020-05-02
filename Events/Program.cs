using System;
using EventHandlerExample;
using EventHandlerTEventArgsExample;
using CounterEvent = EventHandlerExample.CounterEvent;

namespace Events
{
	class Program
	{
		static void Main(string[] args)
		{
			////EventHandler Example
			//CounterEvent counter = new CounterEvent(new Random().Next(10));
			//counter.ThresholdReached += Counter_ThresholdReached;

			//Console.WriteLine("press 'a' key to increase total");
			//while (Console.ReadKey(true).KeyChar=='a')
			//{
			//	Console.WriteLine("adding one");
			//	counter.Add(1);
			//}

	

			////EventHandlerTEventArgs Example
			////send argument/customArgument from event to this class
			//EventHandlerTEventArgsExample.CounterEvent counter = new EventHandlerTEventArgsExample.CounterEvent(new Random().Next(10));
			//counter.ThresholdReached += Counter_ThresholdReached1;

			//Console.WriteLine("press 'a' key to increase total");
			//while (Console.ReadKey(true).KeyChar == 'a')
			//{
			//	Console.WriteLine("adding one");
			//	counter.Add(1);
			//}


			//declare a delegate for an event
			DeclareADelegateForAnEvent.CounterEvent counter=new DeclareADelegateForAnEvent.CounterEvent(new Random().Next(10));
			counter.ThresholdReached += Counter_ThresholdReached;
			Console.WriteLine("press 'a' key to increase total");
			while (Console.ReadKey(true).KeyChar == 'a')
			{
				Console.WriteLine("adding one");
				counter.Add(1);
			}
		}

	


		//private static void Counter_ThresholdReached(object sender, EventArgs e) //For EventHandler Example
		//{
		//	Console.WriteLine("The threshold was reached.");
		//  Console.ReadKey();
		//	Environment.Exit(0);
		//}
		//private static void Counter_ThresholdReached1(object sender, ThresholdReachedEventArgs  e)//For EventHandler Example EventHandlerTEventArgs Example
		//{
		//	Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold,  e.TimeReached);
		//	Console.ReadKey();
		//	Environment.Exit(0);
		//}

		private static void Counter_ThresholdReached(object sender, DeclareADelegateForAnEvent.ThresholdReachedEventArgs e)
		{
			Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold, e.TimeReached);
			Console.ReadKey();
			Environment.Exit(0);
		}

	}
}
