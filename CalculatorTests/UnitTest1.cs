using System;
using Xunit;
using Calculator;

namespace CalculatorTests
{
    
    public class UnitTest1
    {
        [Fact]
        public void AdditionTest()
        {
            a = 5;
            b = 6.3;

            expectedResult = a + b;

            CalculatorTests calculator = new Calculator();

            double actualResult = calculator.Plus(a, b);

            Assert.Equals(expectedResult, actualResult, "The expected result was {0} , using a={1} and b={2}, but the actual result was {3}",
               expectedResult, a, b, actualResult);

        }
    }
}
