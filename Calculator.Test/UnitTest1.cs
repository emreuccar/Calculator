using Calculator.Operations;

namespace Calculator.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateResultTest()
        {
            var result = new Summation(5.2, 1.5).toResult();
            var expectedValue = 6.7;
            Assert.AreEqual(expectedValue, result, $"result should be {expectedValue}");

            result = new Division(30, new Summation(2, 3)).toResult();
            expectedValue = 6;
            Assert.AreEqual(expectedValue, result, $"result should be {expectedValue}");

            result = new Faculty(4).toResult();
            expectedValue = 24;
            Assert.AreEqual(expectedValue, result, $"result should be {expectedValue}");

            result = new Multiplication(new Fraction(9, 4), new Fraction(2, 3)).toResult();
            expectedValue = 1.5;
            Assert.AreEqual(expectedValue, result, $"result should be {expectedValue}");
        }

        [TestMethod]
        public void PrintResultTest()
        {
            var result = new Summation(5.2, 1.5).print();
            var expectedValue = "(5.2 + 1.5) = 6.7";
            Assert.AreEqual(expectedValue, result.Replace(',', '.'), $"result should be {expectedValue}");

            result = new Division(30, new Summation(2, 3)).print();
            expectedValue = "(30 / (2 + 3)) = 6";
            Assert.AreEqual(expectedValue, result.Replace(',', '.'), $"result should be {expectedValue}");

            result = new Faculty(4).print();
            expectedValue = "(4!) = 24";
            Assert.AreEqual(expectedValue, result.Replace(',', '.'), $"result should be {expectedValue}");

            result = new Multiplication(new Fraction(9, 4), new Fraction(2, 3)).print();
            expectedValue = "((9/4) * (2/3)) = 1.5";
            Assert.AreEqual(expectedValue, result.Replace(',', '.'), $"result should be {expectedValue}");
        }

        [TestMethod]
        public void PrintSentenceTest()
        {
            var result = new Summation(5.2, 1.5).printSentence();
            var expectedValue = "sum of 5.2 and 1.5 is 6.7";
            Assert.AreEqual(expectedValue, result.Replace(',', '.'), $"result should be {expectedValue}");

            result = new Division(30, new Summation(2, 3)).printSentence();
            expectedValue = "division of 30 by sum of 2 and 3 is 6";
            Assert.AreEqual(expectedValue, result.Replace(',', '.'), $"result should be {expectedValue}");

            result = new Faculty(4).printSentence();
            expectedValue = "faculty of 4 is 24";
            Assert.AreEqual(expectedValue, result.Replace(',', '.'), $"result should be {expectedValue}");

            result = new Multiplication(new Fraction(9, 4), new Fraction(2, 3)).printSentence();
            expectedValue = "multiplication of 9/4 and 2/3 is 1.5";
            Assert.AreEqual(expectedValue, result.Replace(',', '.'), $"result should be {expectedValue}");
        }
    }
}