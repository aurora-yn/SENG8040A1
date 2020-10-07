using NUnit.Framework;
using SENG8040A1;
using System;

namespace SENG8040A1.UnitTests
{
    [TestFixture]
    public class AnalyzeTests
    {
        [Test]
        public void Analyze_Input10and14and13_ValidScalene()
        {
            // Arrange
            int firstSide = 10;
            int secondSide = 14;
            int thirdSide = 13;
            string expectedResult = "The valid triangle as a scalene";

            // Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Analyze_Input5and5and9_ValidIsosceles()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 9;
            string expectedResult = "The valid triangle as an isosceles";

            // Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Analyze_Input5and5and5_ValidEquilateral()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 5;
            string expectedResult = "The valid triangle as an equilateral";

            // Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Analyze_Input5and5and10_Invalid()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 10;
            string expectedResult = "The invalid triangle";

            // Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Analyze_InputNegative_Invalid()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = -3;
            int thirdSide = 4;
            string expectedResult = "The invalid triangle";

            // Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Analyze_Input0and5and3_Invalid()
        {
            // Arrange
            int firstSide = 0;
            int secondSide = 5;
            int thirdSide = 3;
            string expectedResult = "The invalid triangle";

            // Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Analyze_InputMaxInt_Invalid()
        {
            // Arrange
            int firstSide = Int32.MaxValue;
            int secondSide = Int32.MaxValue;
            int thirdSide = Int32.MaxValue;
            string expectedResult = "The invalid triangle";

            // Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Analyze_InputMinInt_Invalid()
        {
            // Arrange
            int firstSide = Int32.MinValue;
            int secondSide = Int32.MinValue;
            int thirdSide = Int32.MinValue;
            string expectedResult = "The invalid triangle";

            // Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
