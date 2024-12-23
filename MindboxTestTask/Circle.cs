namespace MindboxTestTask
{
    public class Circle : IShape
    {
        private double _radius { get;}
        public Circle(double radius)
        {
            _radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
