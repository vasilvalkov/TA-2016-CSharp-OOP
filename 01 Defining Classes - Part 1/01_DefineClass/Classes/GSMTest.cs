using System;

namespace DefineClasses
{
    class GSMTest
    {
        public static void RunTest()
        {
            // Creating an array of few instances of the GSM class
            GSM[] phones = new GSM[]
                {
                    new GSM("Nokia", "Asha 300", new Battery("BL-4U", 550, 7, BatteryType.LiIon), new Display(2.5f, 64000)),
                    new GSM("Samsung", "Galaxy S6", 950, "Telerik Academy", new Battery(null, null, 17, BatteryType.LiIon), new Display(5.1, 16000000)),
                    new GSM("LG", "G3"),
                    new GSM("Xiaomi", "Mi 5", 700, new Display(5.15, 16000000)),
                };

            // Displaying the information about the GSMs in the array
            int currentPhone = 1;
            foreach (var phone in phones)
            {
                Console.WriteLine("Phone {0} specs", currentPhone++);
                Console.WriteLine("==================================");
                Console.WriteLine(phone.ToString());
            }

            // Displaying the information about the static property IPhone4S
            Console.WriteLine("iPhone 4S specs");
            Console.WriteLine("==================================");
            Console.WriteLine(GSM.IPhone4S.ToString());            
        }
    }
}