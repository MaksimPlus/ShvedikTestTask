namespace MindboxTestTask
{
    public class Triangle : IShape
    {
        private double _a;
        private double _b;
        private double _c;
        public Triangle(double a, double b, double c)
        {
            if (double.IsNaN(a) || double.IsNaN(b) || double.IsNaN(c) || a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Стороны треугольника должны быть положительными числами и не NaN.");
            }
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Стороны не могут образовать треугольник.");

            _a = a;
            _b = b;
            _c = c;
        }
        public double CalculateArea()
        {
            double s = (_a + _b + _c) / 2;
            return Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c));
        }
        public bool IsRightTriangle()
        {
            double[] sides = { _a, _b, _c };
            Array.Sort(sides);
            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }

    }
}
