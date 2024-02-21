
using Shapes.ShapesAll;
using Shapes.ShapesAll.Interface;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CircleRadius()
        {
            //arange 
            double radius = 10;
            double expected = 314.15926535897933;
            //act
            ICalculateShapes circle = new CircleCalculator(radius);
            double actual = circle.Calculate();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TriangleRadius()
        {
            double sideA = 10;
            double sideB = 10;
            double sideC = 10;
            double expected = 43.30127018922193;
            //act
            ICalculateShapes triangle = new TriangleCalculator(sideA , sideB,sideC);
            double actual = triangle.Calculate();

            //assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TriangleRectangular()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            bool expected = true;

            //act
            TriangleCalculator triangle = new TriangleCalculator(sideA, sideB, sideC);
            bool actual = triangle.IsRightTriangle();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}