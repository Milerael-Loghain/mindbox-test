using AreaCalculator.Abstraction;

namespace AreaCalculator 
{
    public class AreaCalculator()
    {
        public double CalculateArea (IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}