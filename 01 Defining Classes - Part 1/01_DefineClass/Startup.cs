using System;

namespace DefineClasses
{
    class Startup
    {
        static void Main()
        {
            GSM nikoa = new GSM("Nokia", "Asha 300",  new Display(5f,16000000));
            Console.WriteLine(GSM.IPhone4S.ToString());
        }
    }
}