using FluentAssertions;
using Xunit;

namespace AreaCalculatorLib.Tests
{
    public class ShapeTests
    {
        [Fact]
        public void Circle_CalculateArea_ShouldReturnCorrectResult()
        {
            // Arrange
            var circle = new Circle(10);
            var expectedArea = Math.PI * 100;

            // Act
            var area = circle.CalculateArea();

            // Assert
            area.Should().BeApproximately(expectedArea, 0.00001);
        }

        [Fact]
        public void Triangle_CalculateArea_ShouldReturnCorrectResult()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            var expectedArea = 6;

            // Act
            var area = triangle.CalculateArea();

            // Assert
            area.Should().BeApproximately(expectedArea, 0.00001);
        }

        [Fact]
        public void Triangle_IsRightTriangle_ShouldReturnTrueForRightTriangle()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var isRightTriangle = triangle.IsRightTriangle();

            // Assert
            isRightTriangle.Should().BeTrue();
        }

        [Fact]
        public void Triangle_IsRightTriangle_ShouldReturnFalseForNonRightTriangle()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 6);

            // Act
            var isRightTriangle = triangle.IsRightTriangle();

            // Assert
            isRightTriangle.Should().BeFalse();
        }

        [Fact]
        public void Triangle_InvalidSides_ShouldThrowArgumentException()
        {
            // Arrange
            // Act
            Action act = () => new Triangle(1, 2, 3);

            // Assert
            act.Should().Throw<ArgumentException>()
               .WithMessage("The provided sides do not form a valid triangle.");
        }
    }
}