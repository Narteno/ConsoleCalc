using System;
using Xunit;
using CalculatorProgram;

namespace Calc.Tests
{
    public class CalcTest
    {
        [Fact]
        public void IsRightDoOperation()
        {
            Calculator calc = new Calculator();
            Assert.Equal(7,calc.DoOperation(2, 5, "a"));
            Assert.Equal(-3, calc.DoOperation(2, 5, "s"));
            Assert.Equal(10, calc.DoOperation(2, 5, "m"));
            Assert.Equal(0.4, calc.DoOperation(2, 5, "d"));
            Assert.Equal(double.NaN, calc.DoOperation(2, 5, "e"));
            calc.Finish();
        }
    }
}
