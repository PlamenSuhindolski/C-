using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses2
{
    using System;
    public struct Point3D
    {
        public double x;
        public double y;
        public double z;
        private static readonly Point3D startPoint = new Point3D(0,0,0);

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        private static Point3D StartPoint
        {
            get
            {
                return startPoint;
            }
        }

        /*static Point3D()
        {
            startPoint = new Point3D(0, 0, 0);
        }*/
        
        public Point3D(double X, double Y, double Z)
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
        }

        public override string ToString()
        {
            return string.Format("[X: {0} ; Y: {1} ; Z: {2} ]", this.X, this.Y, this.Z);
        }

    }
}
