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
    }
}
