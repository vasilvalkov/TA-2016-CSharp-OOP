namespace RangeExceptions
{
    using System;
    using System.Globalization;

    class Startup
    {
        static void Main()
        {
            try
            {
                int fromNumber = 1;
                int toNumber = 100;

                Console.WriteLine("Please enter a number outside the range: 1 - 100");

                int input = int.Parse(Console.ReadLine());

                if (input < 1 || input > 100)
                {
                    throw new InvalidRangeException<int>("Number must be in the range", fromNumber, toNumber);
                }
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                DateTime fromDate = new DateTime(2017, 1, 1);
                DateTime toDate = new DateTime(2017, 1, 10);

                Console.WriteLine("Please enter a date in the format dd.mm.yyyy outside the range: 1.1.1980 - 31.12.2013");

                DateTime inputDate;
                    bool parseInput = DateTime.TryParseExact(Console.ReadLine(), "dd:MM:yyyy", CultureInfo.CurrentCulture, DateTimeStyles.AllowLeadingWhite, out inputDate);
                
                if (inputDate < fromDate || inputDate > toDate)
                {
                    throw new InvalidRangeException<DateTime>("Date must be in the range", fromDate, toDate);
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}