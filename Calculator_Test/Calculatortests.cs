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

        [TestMethod] //1
        [DataRow(2, 1, 1)]
        [DataRow(3, 2, 1)]
        public void CalculatorCanAddTwoPositiveNumbers(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod] //2
        [DataRow(-4, -2, -2)]
        [DataRow(-5, -2, -3)]
        public void CalculatorCanAddTwoNegativeNumbers(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]//3
        [DataRow(2, 2, 0)]
        [DataRow(3, 3, 0)]
        public void CalculatorCanAddZeroToAPositiveNumber(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]//4
        [DataRow(-1, -1, 0)]
        [DataRow(-3, -3, 0)]
        public void CalculatorCanAddZeroToANegativeNumber(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]//5
        [DataRow(2.2, 1.1, 1.1)]
        [DataRow(3.2, 2.1, 1.1)]
        public void CalculatorCanAddTwoDecimalPositiveNumber(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod] //6
        [DataRow(-2.2, -1.1, -1.1)]
        [DataRow(-3.2, -2.1, -1.1)]
        public void CalculatorCanAddTwoDecimaNegativeNumbers(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod] //7
        [DataRow(4.1, 4.1, 0)]
        [DataRow(5.1, 5.1, 0)]
        public void CalculatorCanAddZeroToADecimalPositiveNumber(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]//8
        [DataRow(-2.1, -2.1, 0)]
        [DataRow(-3.1, -3.1, 0)]
        public void CalculatorCanAddZeroToADecimalNegativeNumber(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]//9
        [DataRow(0, -1, 1)]
        [DataRow(6, -3, 9)]
        public void CalculatorCanAddPositiveAndNegativeNumber(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]//10
        [DataRow(0, -1.1, 1.1)]
        [DataRow(1, 2.1, -1.1)]
        public void CalculatorCanAddPositiveAndNegativeDecimalNumbers(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Add(left, right));
        }


    }
}



/*
        

        

        

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