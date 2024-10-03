using AreaCalculator.Shapes;

namespace AreaCalculator.Tests
{
    public class ShapeTests
    {
        [Fact]
        public void CircleArea_ShouldCalculateCorrectly()
        {
            var circle = new Circle(5);
            Assert.Equal(78.53981633974483, circle.CalculateArea(), 5);
        }

        [Fact]
        public void TriangleArea_ShouldCalculateCorrectly()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.CalculateArea(), 5);
        }

        [Fact]
        public void CalculateArea_ShouldWorkForCircle()
        {
            var circle = new Circle(5);
            var areaCalculator = new AreaCalculator();
            Assert.Equal(78.53981633974483, areaCalculator.CalculateArea(circle), 5);
        }

        [Fact]
        public void CalculateArea_ShouldWorkForTriangle()
        {
            var triangle = new Triangle(3, 4, 5);
            var areaCalculator = new AreaCalculator();
            Assert.Equal(6, areaCalculator.CalculateArea(triangle), 5);
        }
    }
}
