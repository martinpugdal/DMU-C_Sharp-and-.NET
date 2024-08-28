using System.Drawing;

namespace L3___Objektorientering
{
    public class Circle(double x, double y, double radius) : Shape(x, y)
    {
        private double radius = radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public Point GetCenter()
        {
            return new Point((int)(X + radius), (int)(Y + radius));
            /* OBS: de private felter x og
            y kan ikke ses her! Så vi
            bruger properties X og Y (stort!)
            */
        }
    }
}
