using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareADelegateForAnEvent
{
    public class ThresholdReachedEventArgs
    {
	    public int Threshold { get; set; }
	    public DateTime TimeReached { get; set; }
    }
}
