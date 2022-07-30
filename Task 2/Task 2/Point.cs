using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public record Point
    {
        double x;
        double y;
        

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public double X
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
        public double Y
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
        public override int GetHashCode()
        {
            return this.X.GetHashCode()^this.Y.GetHashCode();
        }
    }
}
