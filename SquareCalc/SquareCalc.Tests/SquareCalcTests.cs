using SquareCalc.Shapes;

namespace SquareCalc.Tests
{
    [TestClass]
    public class SquareCalcTests
    {
        /// <summary>
        /// Тестируем отрицательный радиус круга
        /// </summary>
        [TestMethod]
        public void CircleNegativeRadiusTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-10));
        }

        /// <summary>
        /// Тестируем отрицательные стороны треугольника
        /// </summary>
        [TestMethod]
        public void TriangleNegativeSidesTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-10, 0, 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(0, -10, 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-10, -10, -10));
        }

        /// <summary>
        /// Тестируем вычисление площади круга
        /// </summary>
        [TestMethod]
        public void CircleSqrCalculationTest()
        {
            //Arrange
            var circle = new Circle(10);

            //Act
            var circleSquare = circle.Square;

            //Assert
            Assert.AreEqual(314.16, Math.Round(circleSquare, 2));
        }

        /// <summary>
        /// Тестируем вычисление площади треугольника
        /// </summary>
        [TestMethod]
        public void TriangleSqrCalculationTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var triangleSquare = triangle.Square;

            //Assert
            Assert.AreEqual(6, triangleSquare);
        }

        /// <summary>
        /// Тестируем прямоугольный треугольник
        /// </summary>
        [TestMethod]
        public void RightAngleTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var isTriangleRightAngled = triangle.IsRightTriangle;

            //Assert
            Assert.AreEqual(true, isTriangleRightAngled);
        }

        /// <summary>
        /// Тестируем не прямоугольный треугольник
        /// </summary>
        [TestMethod]
        public void NotRightAngleTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(6, 2, 5);

            //Act
            var isTriangleRightAngled = triangle.IsRightTriangle;

            //Assert
            Assert.AreEqual(false, isTriangleRightAngled);
        }
    }
}