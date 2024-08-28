using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3___Objektorientering
{
    public class Rectangle(double x, double y, double length, double width) : Shape(x, y)
    {
        private double length = length;
        private double width = width;

        public double Length { get; set; }
        public double Width { get; set; }

        public Point GetCenter()
        {
            return new Point((int)(Y + (length / 2)), (int)(X + (width / 2)));
            /* OBS: de private felter x og
            y kan ikke ses her! Så vi
            bruger properties X og Y (stort!)
            */
        }

        public override double Area()
        {
            return length * width;
        }
    }
}
