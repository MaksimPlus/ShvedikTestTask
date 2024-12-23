using MindboxTestTask;

namespace Tests
{
    public class ShapeCalculatorTest
    {
        [Fact]
        public void Circle_CalculateArea_ShouldReturnCorrectArea()
        {
            var circle = new Circle(5);
            var area = circle.CalculateArea();
            Assert.Equal(78.53981633974483, area, 5);
        }

        [Fact]
        public void Triangle_CalculateArea_ShouldReturnCorrectArea()
        {
            var triangle = new Triangle(3, 4, 5);
            var area = triangle.CalculateArea();
            Assert.Equal(6, area);
        }
        [Fact]
        public void Triangle_IsRightTriangle_ShouldReturnTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle());
        }

        [Fact]
        public void Triangle_IsRightTriangle_ShouldReturnFalse()
        {
            var triangle = new Triangle(5, 5, 5);
            Assert.False(triangle.IsRightTriangle());
        }

        [Fact]
        public void Triangle_InvalidSides_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
        }
    }
}