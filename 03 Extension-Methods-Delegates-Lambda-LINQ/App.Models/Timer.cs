namespace App.Models
{
    using System;

    public class Timer
    {
        public delegate string Start(int seconds);
        

        public static string Repeat(int seconds)
        {
            while (true)
            {
                DateTime now = DateTime.Now;

                if (now.Second % seconds == 0)
                {
                    // do something
                }
            }

        }
    }
}