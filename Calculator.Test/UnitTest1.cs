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

            result = new Multiplication(new Fraction(6, 4), new Fraction(48, new Faculty(4))).print();
            expectedValue = "((6/4) * (48/(4!))) = 3";
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

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroTest()
        {
            new Division(5, 0).toResult();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "There is no factorial for negative numbers!")]
        public void NegativeFacultyTest()
        {
            new Faculty(-2).toResult();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "There is no factorial for fractional numbers!")]
        public void FractionalFacultyTest()
        {
            new Faculty(3.5).toResult();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroPrintTest()
        {
            new Division(2, new Subtraction(1, 1)).print();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroPrintSentenceTest()
        {
            new Division(2, new Subtraction(1, 1)).printSentence();
        }

        [TestMethod]
        public void InfinityTest()
        {
            var result = new Summation(double.MaxValue, double.MaxValue).toResult();
            var expectedValue = double.PositiveInfinity;
            Assert.AreEqual(expectedValue, result, $"result should be {expectedValue}");
        }

        [TestMethod]
        public void InfinityOperationTest()
        {
            var result = new Summation(double.PositiveInfinity, double.MaxValue).toResult();
            var expectedValue = double.PositiveInfinity;
            Assert.AreEqual(expectedValue, result, $"result should be {expectedValue}");

        }
    }
}