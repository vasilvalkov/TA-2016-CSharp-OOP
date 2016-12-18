using DefineClasses;

// Class members ordering in this project is strictly based on StyleCop Rules Documentation(http://stylecop.soyuz5.com/Ordering%20Rules.html). The rules are nicely explained in this thread (http://stackoverflow.com/questions/150479/order-of-items-in-classes-fields-properties-constructors-methods).
//
class Startup
{
    static void Main()
    {
        GSMTest.RunTest();

        /* 
            !!! PLEASE NOTE THAT A DELAY IS ADDED INTENTIONALLY TO THE CALL HISTORY TEST 
                AND THE PROGRAM WILL EXECUTE SLOWER

        The delay is added so as to demonstrate generating the time of call field from system watch.
        The date of call field is also generated this way but no one would wait till tommorow to see it working ;)
        */
        GSMCallHistoryTest.RunTest();
    }
}