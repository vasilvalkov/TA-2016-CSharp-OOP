using System;
using System.Threading;

namespace DefineClasses
{
    class GSMTest
    {
        static void Main()
        {
            GSM[] phones = new GSM[]
                {
                    new GSM("Nokia", "Asha 300", new Battery("BL-4U", 550, 7, BatteryType.LiIon), new Display(2.5f, 64000)),
                    new GSM("Samsung", "Galaxy S6", 950, "Telerik Academy", new Battery(null, null, 17, BatteryType.LiIon), new Display(5.1, 16000000)),
                    new GSM("LG", "G3"),
                    new GSM("Xiaomi", "Mi 5", 700, new Display(5.15, 16000000)),
                };

            #region Problem 7 // Uncomment region to test problem #7
            //int i = 1;
            //foreach (var phone in phones)
            //{
            //    Console.WriteLine("Phone {0} specs", i++);
            //    Console.WriteLine("==================================");
            //    Console.WriteLine(phone.ToString());
            //}
            //Console.WriteLine("iPhone 4S specs");
            //Console.WriteLine("==================================");
            //Console.WriteLine(GSM.IPhone4S.ToString()); 
            #endregion

            int milliseconds = 2000;
            phones[0].AddCall(new Call("0888555555", 120));
            Thread.Sleep(milliseconds);
            phones[0].AddCall(new Call("0888666666", 260.5));
            Thread.Sleep(milliseconds);
            phones[0].AddCall(new Call("0881424242", 40));
            Thread.Sleep(milliseconds);
            phones[0].AddCall(new Call("0888555555", 1352));

            foreach (var call in phones[0].CallHistory)
            {
                Console.WriteLine("On {0} at {1} > talked to {2} for {3:0.##} seconds", 
                    call.Date.ToString(@"dd-MMM-yyyy"), 
                    call.Time.ToString(@"hh\:mm\:ss"),
                    call.DialedNumber,
                    call.Duration);
            }
        }
    }
}