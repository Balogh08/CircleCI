using System;
using NetCoreCalculator.Business;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitSampleTest
{
    public class CalculationSumTests
    {
        private Calculation calculation;

        public CalculationSumTests()
        {
            this.calculation = new Calculation();
        }

        [Fact]
        public void CalculateSumCorrect()
        {
            //arrange  
            double numberOne = 5;
            double numberTwo = 4;
            double expectedResult = 9;

            //act              
            var realResult = calculation.SumTwoNumbers(numberOne, numberTwo);

            //assert  
            Assert.Equal(expectedResult, realResult);
        }
        [Fact]
        public void CalculateSumFalse()
        {

            //arrange  
            double numberOne = 1;
            double numberTwo = 8;
            double expectedResult = 7;

            //act  
            var realResult = calculation.SumTwoNumbers(numberOne, numberTwo);

            //assert  
            Assert.NotEqual(expectedResult, realResult);
        }

        [Fact]
        public void CalculateSum_NegativeResult_True()
        {
            double num1 = 10;
            double num2 = -20;
            double expectedResult = -10;

            var realResult = calculation.SumTwoNumbers(num1, num2);

            Assert.Equal(expectedResult, realResult);
        }

        [Fact]
        public void CalculateSum_Zero_True()
        {
            double num1 = 0;
            double num2 = 0;
            double expectedResult = 0;

            var realResult = calculation.SumTwoNumbers(num1, num2);

            Assert.Equal(expectedResult, realResult);
        }
<<<<<<< Updated upstream

        [Fact]
        public void CalculateSum_100plus100_True()
        {
            double num1 = 100;
            double num2 = 100;
            double expectedResult = 200;

            var realResult = calculation.SumTwoNumbers(num1, num2);

            Assert.Equal(expectedResult, realResult);
        }

        [Fact]
        public void CalculateSum_200plus100_True()
        {
            double num1 = 200;
            double num2 = 100;
            double expectedResult = 300;

            var realResult = calculation.SumTwoNumbers(num1, num2);

            Assert.Equal(expectedResult, realResult);
        }
=======
>>>>>>> Stashed changes
    }
}
