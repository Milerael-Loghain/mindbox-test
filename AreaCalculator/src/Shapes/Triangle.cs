using AreaCalculator.Abstraction;

namespace AreaCalculator.Shapes
{
    public class Triangle : IShape
    {
        public double[] Sides { get; }

        public Triangle(double a, double b, double c)
        {
            Sides = new double[] { a, b, c };
            Array.Sort(Sides);
        }

        private bool IsRightTriangle()
        {
            return Math.Pow(Sides[2], 2) == Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2);
        }

        public double CalculateArea()
        {
            if (IsRightTriangle())
            {
                return (Sides[0] * Sides[1]) / 2;
            }
            else
            {
                double s = (Sides[0] + Sides[1] + Sides[2]) / 2;
                return Math.Sqrt(s * (s - Sides[0]) * (s - Sides[1]) * (s - Sides[2]));
            }
        }
    }
}