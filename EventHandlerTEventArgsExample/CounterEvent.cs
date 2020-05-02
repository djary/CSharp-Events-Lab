using System;

namespace EventHandlerTEventArgsExample
{
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
			EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
			if (handler != null)
			{
				handler(this, e);
			}
		}

		public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
	}


}

