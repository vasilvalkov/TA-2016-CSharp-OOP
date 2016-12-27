namespace DefineClasses2.Models3D
{
    public struct Point3D
    {
        private static readonly Point3D o;
        private double x;
        private double y;
        private double z;

        static Point3D()
        {
            o = new Point3D(0, 0, 0);
        }
        
        public Point3D(double x, double y, double z) 
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D O
        {
            get { return o; }
        }
        public double X
        {
            get
            {
                return this.x;
            }
            private set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return this.y;
            }
            private set
            {
                this.y = value;
            }
        }
        public double Z
        {
            get
            {
                return this.z;
            }
            private set
            {
                this.z = value;
            }
        }

        public override string ToString()
        {
            return $"{{{this.x}, {this.y}, {this.z}}}";
        }
    }
}