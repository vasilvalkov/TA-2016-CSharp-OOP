namespace DefineClasses2
{
    using Models3D;
    using System;

    public class Models3DTest
    {
        public static void Run()
        {
            // Test calculating distance between two points
            Console.WriteLine("---- Distance test ----");
            Console.WriteLine();
            Point3D a = new Point3D();
            Point3D b = new Point3D(2, 2, 2);

            Console.WriteLine("Distance in 3d space is: {0:F5}", DistanceIn3D.Calculate(a, b));
            Console.WriteLine();

            // Test paths
            Console.WriteLine("---- Paths test ----");
            Console.WriteLine();
            Path path = new Path();
            path.AddPoint(a);
            path.AddPoint(b);
            path.AddPoint(new Point3D(3, 5, 1));
            path.AddPoint(new Point3D(3, 7, 4));
            Console.WriteLine("The built 3d path is: {0}", path);
            Console.WriteLine();
            path.RemovePointAt(0);
            Console.WriteLine("Path after removing first point: {0}", path);
            Console.WriteLine();

            // Test path storage
            Console.WriteLine("---- Path storage test ----");
            Console.WriteLine();
            path.AddPoint(new Point3D(2, 1, 6));
            PathStorage.SavePath(path);
            Console.WriteLine("Paths loaded from path storage: \r\n{0}", PathStorage.LoadAllPaths());
            PathStorage.Clear();
        }
    }
}
