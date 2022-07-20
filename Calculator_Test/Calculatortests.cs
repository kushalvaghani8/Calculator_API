using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator_Logic;
using System;

namespace Calculator_Test
{
    [TestClass]
    public class Calculatortests
    {
        [TestMethod]
        public void CalculatorClassIsInstantiable()

        {
            Calculator calc = new Calculator();
            Assert.IsNotNull(calc);
        }
    }
}



/*

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Calculator_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculatorClassIsInstantiable()

        {
            Calculator calc = new Calculator();
            Assert.IsNotNull(calc);
        }

        [TestMethod]
        [DataRow(2, 1, 1)]
        [DataRow(3, 2, 1)]
        [DataRow(5, 3, 2)]
        public void CalculatorCanAddTwoPositiveNumbers(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(2, 1, 1)]
        [DataRow(3, 2, 1)]
        [DataRow(5, 3, 2)]
        public void CalculatorCanAddTwoNegativeNumbers(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(2, 1, 1)]
        [DataRow(3, 2, 1)]
        [DataRow(5, 3, 2)]
        public void CalculatorCanAddTwoPositiveDecimalNumbers(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(2, 1, 1)]
        [DataRow(3, 2, 1)]
        [DataRow(5, 3, 2)]
        public void CalculatorCanAddTwoNegativeDecimalNumbers(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(2, 1, 1)]
        [DataRow(3, 2, 1)]
        [DataRow(5, 3, 2)]
        public void CalculatorCanAddOneNumbertoZero(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        public void CalculatorThrowsExcecptionWhenDividingByZero()

        {
            Calculator calc = new Calculator();
            Assert.ThrowsException<DivideByZeroException>(() => { calc.Divide(9, 0); });
        }

        [TestMethod]
        public void CalculatorDivididesPositiveNumberWithDenominatorGreaterThenZero()

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(9, calc.Divide(9, 1));
        }


    }
}


 */