﻿The next example shows how to declare a delegate for an event.
The delegate is named ThresholdReachedEventHandler.
This is just an illustration. Typically, you do not have to declare a delegate for an event, because you can use either the EventHandler or the EventHandler<TEventArgs> delegate. 
You should declare a delegate only in rare scenarios, such as making your class available to legacy code that cannot use generics.


source code: https://docs.microsoft.com/en-us/dotnet/standard/events/how-to-raise-and-consume-events