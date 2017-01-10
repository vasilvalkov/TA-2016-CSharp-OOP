namespace Shapes
{
    using Interfaces;
    using Models;
    using System;

    class Startup
    {
        static void Main()
        {
            IShape[] figures = new IShape[]
            {
                new Square(4.5m),
                new Rectangle(3.11m, 6.7m),
                new Triangle(3.11m, 6.7m)
            };

            foreach (var figure in figures)
            {
                Console.WriteLine("{0} - {1}", figure.GetType().Name, figure.CalculateSurface());
            }
        }
    }
}