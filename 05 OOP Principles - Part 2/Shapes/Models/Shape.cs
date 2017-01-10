namespace Shapes.Models
{
    using Interfaces;

    public abstract class Shape : IShape
    {
        protected decimal width;
        protected decimal height;

        public Shape(decimal width, decimal height)
        {
            this.width = width;
            this.height = height;
        }

        public abstract decimal CalculateSurface();
    }
}