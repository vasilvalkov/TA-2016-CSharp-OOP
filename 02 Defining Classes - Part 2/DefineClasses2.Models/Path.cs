namespace DefineClasses2.Models3D
{
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> pathOfPoints;

        public Path()
        {
            this.pathOfPoints = new List<Point3D>();
        }
        public Path(int pointsCount)
        {
            this.pathOfPoints = new List<Point3D>(pointsCount);
        }
        public Path(List<Point3D> path)
        {
            this.PathOfPoints = path;
        }
        public Path(params Point3D[] points)
        {
            foreach (var point in points)
            {
                AddPoint(point);
            }
        }

        public List<Point3D> PathOfPoints
        {
            get { return pathOfPoints; }
            private set { pathOfPoints = value; }
        }

        public void AddPoint(Point3D point)
        {
            this.PathOfPoints.Add(point);
        }
        public void InsertPoint(int index, Point3D point)
        {
            this.PathOfPoints.Insert(index, point);
        }
        public void RemovePoint(Point3D point)
        {
            this.PathOfPoints.Remove(point);
        }
        public void RemovePointAt(int index)
        {
            this.PathOfPoints.RemoveAt(index);
        }
        public void ClearPath()
        {
            this.pathOfPoints.Clear();
        }
        public override string ToString()
        {
            return string.Join(", ", pathOfPoints);
        }
    }
}