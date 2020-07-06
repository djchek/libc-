using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLib;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod1()
        {
            new Triangle(3, 4, -1);
            new Triangle(1, 2, 4);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCircle()
        {
            new Circle(0);
        }

        [TestMethod]
        public void TestIsRight()
        {
            var triangle = new Triangle(3, 4, 5);
            var IsRightAngled = triangle.RightTriangle;

            Assert.AreEqual(true, IsRightAngled);
        }
        [TestMethod]
        public void TestIsNotRight()
        {
            var triangle = new Triangle(2, 6, 5);
            var IsRightAngled = triangle.RightTriangle;

            Assert.AreEqual(false, IsRightAngled);
        }

        [TestMethod]
        public void TriangleAreaTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var triangleArea = triangle.Square;

            //Assert
            Assert.AreEqual(6, triangleArea);
        }

        [TestMethod]
        public void CircleAreaTest()
        {
            //Arrange
            var circle = new Circle(3);

            //Act
            var circleArea = circle.Square;

            //Assert
            Assert.AreEqual(28.274333882308138, circleArea);
        }

    }
}
