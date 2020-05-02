using System;
using DeclareADelegateForAnEvent;

namespace DeclareADelegateForAnEvent
{
	public delegate void ThresholdReachedEventHandler(Object sender, ThresholdReachedEventArgs e);
	public class CounterEvent
	{
		private int threshold;
		private int total;

		public CounterEvent(int passedThreshold)
		{
			threshold = passedThreshold;
		}

		public void Add(int x)
		{
			total += x;
			if (total >= threshold)
			{
				ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
				args.Threshold = threshold;
				args.TimeReached = DateTime.Now;
				OnThresholdReached(args);
			}
		}

		protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
		{
			ThresholdReachedEventHandler handler = ThresholdReached;
			if (handler != null)
			{
				handler(this, e);
			}
		}

		public event ThresholdReachedEventHandler ThresholdReached;
	}
}

