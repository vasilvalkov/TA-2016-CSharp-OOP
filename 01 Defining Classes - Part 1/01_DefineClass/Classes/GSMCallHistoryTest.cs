namespace DefineClasses
{
    using System;
    using System.Globalization;
    using System.Threading;

    class GSMCallHistoryTest
    {
        public static void RunTest()
        {
            /* 
             !!! PLEASE NOTE THAT A DELAY IS ADDED INTENTIONALLY AND PROGRAM WILL EXECUTE SLOWER !!!

             The delay is added so as to demonstrate generating the time of the call field from system watch.
             The date of the call field is generated the same way but noone would wait till tommorow to see it ;)

            */

            // Creating an instance of the GSM class
            GSM iPhone = GSM.IPhone4S;
            double maxDuration = 0.0;   // used for removing the longest call
            int maxDurationIndex = 0;   // used for removing the longest call
            int milliseconds = 2000;    // used for time delay

            // Adding few calls
            iPhone.AddCall(new Call("0888555555", 120));
            Thread.Sleep(milliseconds); // delay program
            iPhone.AddCall(new Call("0888666666", 260.5));
            Thread.Sleep(milliseconds);
            iPhone.AddCall(new Call("0881424242", 40));
            Thread.Sleep(milliseconds);
            iPhone.AddCall(new Call("0888555555", 1352));

            // Displaying the information about the calls.
            Console.WriteLine("Calls History");
            Console.WriteLine("=============");
            foreach (var call in iPhone.CallHistory)
            {
                Console.WriteLine("Call to {0} lasted {1:0.##} seconds, on {2} at {3}",
                    call.DialedNumber,
                    call.Duration,
                    call.Date.ToString(@"dd-MMM-yyyy"),
                    call.Time.ToString(@"hh\:mm\:ss"));
            }

            // Calculating the total price of the call in history
            Console.WriteLine();
            Console.WriteLine("Total price of the calls is {0}",
                iPhone.CalculatePriceOwed(0.37).ToString("C2", CultureInfo.GetCultureInfo("bg-BG")));

            // Removing the longest call in history
            for (int i = 0; i < iPhone.CallHistory.Count; i++)
            {
                Call currentCall = iPhone.CallHistory[i];

                if (currentCall.Duration > maxDuration)
                {
                    maxDurationIndex = i;
                    maxDuration = currentCall.Duration;
                }
            }

            iPhone.DeleteCall(maxDurationIndex);

            // Recalculating the total price of the calls in history
            Console.WriteLine();
            Console.WriteLine("Recalculated total price of the calls is {0}",
                iPhone.CalculatePriceOwed(0.37).ToString("C2", CultureInfo.GetCultureInfo("bg-BG")));

            // Clear the call history and print it
            Console.WriteLine();
            Console.WriteLine("Clearing Call history... ");
            Console.WriteLine();
            iPhone.ClearCallHistory();
            Console.WriteLine("Calls History");
            Console.WriteLine("=============");

            foreach (var call in iPhone.CallHistory)
            {
                Console.WriteLine("Call to {0} lasted {1:0.##} seconds, on {2} at {3}",
                    call.DialedNumber,
                    call.Duration,
                    call.Date.ToString(@"dd-MMM-yyyy"),
                    call.Time.ToString(@"hh\:mm\:ss"));
            }
            if (iPhone.CallHistory.Count == 0)
            {
                Console.WriteLine("Call History is empty");
                Console.WriteLine();
            }
        }
    }
}