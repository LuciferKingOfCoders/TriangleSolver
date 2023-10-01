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

        #region Test for a valid isosceles triangle triangle. 

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

        #region Test for a valid scalene triangle. 

        [TestMethod]
        public void AnalyzeTriangle_VerifyingValidScaleneTriangleTest1()
        {
            // Arrange
            var firstSide = 6;
            var secondSide = 7;
            var thirdSide = 8;

            // Act
            var result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            var actual = "Scalene triangle";
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void AnalyzeTriangle_VerifyingValidScaleneTriangleTest2()
        {
            // Arrange
            var firstSide = 10;
            var secondSide = 7;
            var thirdSide = 15;

            // Act
            var result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            var actual = "Scalene triangle";
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void AnalyzeTriangle_VerifyingValidScaleneTriangleTest3()
        {
            // Arrange
            var firstSide = 4;
            var secondSide = 9;
            var thirdSide = 8;

            // Act
            var result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            var actual = "Scalene triangle";
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void AnalyzeTriangle_VerifyingValidScaleneTriangleTest4()
        {
            // Arrange
            var firstSide = 7;
            var secondSide = 12;
            var thirdSide = 10;

            // Act
            var result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            var actual = "Scalene triangle";
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void AnalyzeTriangle_VerifyingValidScaleneTriangleTest5()
        {
            // Arrange
            var firstSide = 6;
            var secondSide = 13;
            var thirdSide = 9;

            // Act
            var result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            var actual = "Scalene triangle";
            Assert.AreEqual(result, actual);
        }
        #endregion

        #region Tests for verifying a zero length for one or more sides. 

        [TestMethod]
        public void AnalyzeTriangle_VerifyingZeroLengthForOneOrMoreSidesTest1()
        {
            // Test 1
            // Arrange
            var firstSide = 0;
            var secondSide = 5;
            var thirdSide = 6;

            // Act
            var result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            var actual = "Invalid Triangle - a zero has been detected";
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void AnalyzeTriangle_VerifyingZeroLengthForOneOrMoreSidesTest2()
        {
            // Arrange
            var firstSide = 5;
            var secondSide = 0;
            var thirdSide = 6;

            // Act
            var result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            var actual = "Invalid Triangle - a zero has been detected";
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void AnalyzeTriangle_VerifyingZeroLengthForOneOrMoreSidesTest3()
        {
            // Arrange
            var firstSide = 5;
            var secondSide = 6;
            var thirdSide = 0;

            // Act
            var result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            var actual = "Invalid Triangle - a zero has been detected";
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void AnalyzeTriangle_VerifyingZeroLengthForOneOrMoreSidesTest4()
        {
            // Arrange
            var firstSide = 5;
            var secondSide = 0;
            var thirdSide = 0;

            // Act
            var result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            var actual = "Invalid Triangle - a zero has been detected";
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void AnalyzeTriangle_VerifyingZeroLengthForOneOrMoreSidesTest5()
        {
            // Arrange
            var firstSide = 0;
            var secondSide = 0;
            var thirdSide = 6;

            // Act
            var result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            var actual = "Invalid Triangle - a zero has been detected";
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void AnalyzeTriangle_VerifyingZeroLengthForOneOrMoreSidesTest6()
        {
            // Arrange
            var firstSide = 0;
            var secondSide = 5;
            var thirdSide = 0;

            // Act
            var result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            var actual = "Invalid Triangle - a zero has been detected";
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void AnalyzeTriangle_VerifyingZeroLengthForOneOrMoreSidesTest7()
        {
            // Arrange
            var firstSide = 0;
            var secondSide = 0;
            var thirdSide = 0;

            // Act
            var result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            var actual = "Invalid Triangle - a zero has been detected";
            Assert.AreEqual(result, actual);
        }

        #endregion

        #region Test for verifying an invalid response (other than a zero length). 

        [TestMethod]
        public void AnalyzeTriangle_VerifyingAnInvalidResponseTest1()
        {
            // Arrange
            var firstSide = 5;
            var secondSide = 12;
            var thirdSide = 6;

            // Act
            var result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            var actual = "INVALID!!";
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void AnalyzeTriangle_VerifyingAnInvalidResponseTest2()
        {
            // Arrange
            var firstSide = 14;
            var secondSide = 8;
            var thirdSide = 5;

            // Act
            var result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            var actual = "INVALID!!";
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void AnalyzeTriangle_VerifyingAnInvalidResponseTest3()
        {
            // Arrange
            var firstSide = 6;
            var secondSide = 4;
            var thirdSide = 12;

            // Act
            var result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            var actual = "INVALID!!";
            Assert.AreEqual(result, actual);
        }

        #endregion
    }
}
