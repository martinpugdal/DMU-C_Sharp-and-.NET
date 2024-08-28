namespace L3___Objektorientering
{
    public class Shape(double x, double y)
    {
        public Shape() : this(1, 1) { }

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public virtual double Area() { return y - x; }
    }
}
