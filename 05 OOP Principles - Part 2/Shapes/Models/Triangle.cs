namespace Shapes.Models
{
    using Interfaces;

    public class Triangle : Shape, IShape, ITriangle
    {
        public Triangle(decimal sideA, decimal heightA)
            : base(sideA, heightA)
        {
        }

        public override decimal CalculateSurface()
        {
            return (this.width * this.height) / 2m;
        }
    }
}