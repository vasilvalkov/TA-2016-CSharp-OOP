namespace Shapes.Models
{
    using Interfaces;

    public class Square : Shape, IShape, ISquare
    {
        public Square(decimal side)
            : base(side, side)
        {
        }

        public override decimal CalculateSurface()
        {
            return width * height;
        }
    }
}