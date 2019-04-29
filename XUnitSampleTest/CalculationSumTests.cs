using System;
using NetCoreCalculator.Business;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitSampleTest
{
    public class CalculationSumTests
    {
        [Fact]
        public void CalculateSumCorrect()
        {
            //arrange  
            var calculate = new Calculation();
            double numberOne = 5;
            double numberTwo = 4;
            double expectedResult = 9;

            //act              
            var realResult = calculate.SumTwoNumbers(numberOne, numberTwo);

            //assert  
            Assert.Equal(expectedResult, realResult);
        }
        [Fact]
        public void CalculateSumFalse()
        {

            //arrange  
            var calculate = new Calculation();
            double numberOne = 1;
            double numberTwo = 8;
            double expectedResult = 7;

            //act  
            var realResult = calculate.SumTwoNumbers(numberOne, numberTwo);

            //assert  
            Assert.NotEqual(expectedResult, realResult);
        }
    }
}
