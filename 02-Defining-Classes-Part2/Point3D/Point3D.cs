using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public struct Point3D
    {
        private decimal x;
        private decimal y;
        private decimal z;

        private static readonly Point3D startCoordinates = new Point3D(0, 0, 0);

        // properties

        public decimal X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public decimal Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public decimal Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        public static Point3D StartCoordinates
        {
            get
            {
                return startCoordinates;
            }
        }

        public Point3D(decimal x, decimal y, decimal z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("X:" + this.X.ToString());
            result.Append("Y:" + this.Y.ToString());
            result.Append("X:" + this.Z.ToString());

            return result.ToString();
        }
    }
}
