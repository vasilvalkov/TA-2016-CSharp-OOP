namespace App.Models
{
    using System.Threading;

    public delegate void Execute();

    public static class Timer
    {
        public static void RepeatEvery(int seconds, Execute action)
        {
            while (true)
            {
                action();
                Thread.Sleep(seconds * 1000);
            }
        }
    }
}