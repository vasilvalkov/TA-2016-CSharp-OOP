namespace DefineClasses2.Models3D
{
    using System;

    public static class DistanceIn3D
    {
        public static double Calculate(Point3D firstPoint, Point3D secondPoint)
        {
            double dist = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) +
                                    Math.Pow(firstPoint.Y - secondPoint.Y, 2) +
                                    Math.Pow(firstPoint.Z - secondPoint.Z, 2));

            return dist;
        }
    }
}
