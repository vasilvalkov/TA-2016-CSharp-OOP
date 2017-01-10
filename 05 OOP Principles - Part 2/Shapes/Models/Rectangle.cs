namespace Shapes.Models
{
    using Interfaces;

    public class Rectangle : Shape, IShape, IRectangle
    {
        public Rectangle(decimal width, decimal height)
            : base(width, height)
        {
        }

        public override decimal CalculateSurface()
        {
            return this.width * this.height;
        }
    }
}