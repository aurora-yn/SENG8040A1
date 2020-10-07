using NUnit.Framework;
using SENG8040A1;

namespace SENG8040A1.UnitTests
{
    [TestFixture]
    public class AnalyzeTests
    {
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
        public void Analyze_Input10and14and13_ValidScalene()
        {
            int firstSide = 10;
            int secondSide = 14;
            int thirdSide = 13;
            string expectedResult = "The valid triangle as a scalene";

            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Analyze_Input5and5and9_ValidIsosceles()
        {
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 9;
            string expectedResult = "The valid triangle as an isosceles";

            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Analyze_Input5and5and5_ValidEquilateral()
        {
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 5;
            string expectedResult = "The valid triangle as an equilateral";

            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
