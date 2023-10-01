using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Policy;
using TriangleSolver;

namespace TriangleSolverTests
{
    [TestClass]
    public class TriangleTests
    {
        #region Test for a valid equilateral triangle. 

        [TestMethod]
        public void AnalyzeTriangle_VerifyingValidEuilateralTriangleTest()
        {
            // Arrange
            var firstSide = 6;
            var secondSide = 6;
            var thirdSide = 6;

            // Act
            var result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            var actual = "Equilateral triangle";
            Assert.AreEqual(result, actual);
        }

        #endregion

        #region Test for a valid equilateral triangle. 

        [TestMethod]
        public void AnalyzeTriangle_VerifyingValidIsoscelesTriangleTest1()
        {
            // Arrange
            var firstSide = 6;
            var secondSide = 6;
            var thirdSide = 7;

            // Act
            var result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            var actual = "Isosceles triangle";
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void AnalyzeTriangle_VerifyingValidIsoscelesTriangleTest2()
        {
            // Arrange
            var firstSide = 6;
            var secondSide = 7;
            var thirdSide = 6;

            // Act
            var result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            var actual = "Isosceles triangle";
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void AnalyzeTriangle_VerifyingValidIsoscelesTriangleTest3()
        {
            // Arrange
            var firstSide = 7;
            var secondSide = 6;
            var thirdSide = 6;

            // Act
            var result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            var actual = "Isosceles triangle";
            Assert.AreEqual(result, actual);
        }

        #endregion
    }
}
