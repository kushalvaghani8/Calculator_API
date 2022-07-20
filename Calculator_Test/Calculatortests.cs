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

        [TestMethod] 
        [DataRow(2, 1, 1)]
        [DataRow(3, 2, 1)]
        public void CalculatorCanAddTwoPositiveNumbers(double expected, double left, double right)

        {
            double result = Calculator.Add(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]  
        [DataRow(-4, -2, -2)]
        [DataRow(-5, -2, -3)]
        public void CalculatorCanAddTwoNegativeNumbers(double expected, double left, double right)

        {
            double result = Calculator.Add(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(2, 2, 0)]
        [DataRow(3, 3, 0)]
        public void CalculatorCanAddZeroToAPositiveNumber(double expected, double left, double right)

        {
            double result = Calculator.Add(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(-1, -1, 0)]
        [DataRow(-3, -3, 0)]
        public void CalculatorCanAddZeroToANegativeNumber(double expected, double left, double right)

        {
            double result = Calculator.Add(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(2.2, 1.1, 1.1)]
        [DataRow(3.2, 2.1, 1.1)]
        public void CalculatorCanAddTwoDecimalPositiveNumber(double expected, double left, double right)

        {
            double result = Calculator.Add(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(-2.2, -1.1, -1.1)]
        [DataRow(-3.2, -2.1, -1.1)]
        public void CalculatorCanAddTwoDecimalNegativeNumbers(double expected, double left, double right)

        {
            double result = Calculator.Add(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(4.1, 4.1, 0)]
        [DataRow(5.1, 5.1, 0)]
        public void CalculatorCanAddZeroToADecimalPositiveNumber(double expected, double left, double right)

        {
            double result = Calculator.Add(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(-2.1, -2.1, 0)]
        [DataRow(-3.1, -3.1, 0)]
        public void CalculatorCanAddZeroToADecimalNegativeNumber(double expected, double left, double right)

        {
            double result = Calculator.Add(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(0, -1, 1)]
        [DataRow(6, -3, 9)]
        public void CalculatorCanAddPositiveAndNegativeNumber(double expected, double left, double right)

        {
            double result = Calculator.Add(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(0, -1.1, 1.1)]
        [DataRow(1, 2.1, -1.1)]
        public void CalculatorCanAddPositiveAndNegativeDecimalNumbers(double expected, double left, double right)

        {
            double result = Calculator.Add(left, right);
            Assert.AreEqual(expected, result);
        }


        [TestMethod] 
        [DataRow(0, 1, 1)]
        [DataRow(1, 2, 1)]
        public void CalculatorCanSubtractTwoPositiveNumbers(double expected, double left, double right)

        {
            double result = Calculator.Subtract(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod] 
        [DataRow(0, -2, -2)]
        [DataRow(1, -2, -3)]
        public void CalculatorCanSubtractTwoNegativeNumbers(double expected, double left, double right)

        {
            double result = Calculator.Subtract(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(2, 2, 0)]
        [DataRow(3, 3, 0)]
        public void CalculatorCanSubtractZeroFromAPositiveNumber(double expected, double left, double right)

        {
            double result = Calculator.Subtract(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(-1, -1, 0)]
        [DataRow(-3, -3, 0)]
        public void CalculatorCanSubtractZeroFromANegativeNumber(double expected, double left, double right)

        {
            double result = Calculator.Subtract(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(0, 1.1, 1.1)]
        [DataRow(1, 2.1, 1.1)]
        public void CalculatorCanSubtractTwoDecimalPositiveNumber(double expected, double left, double right)

        {
            double result = Calculator.Subtract(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(0, -1.1, -1.1)]
        [DataRow(-1, -2.1, -1.1)]
        public void CalculatorCanSubtractTwoDecimalNegativeNumbers(double expected, double left, double right)

        {
            double result = Calculator.Subtract(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod] 
        [DataRow(4.1, 4.1, 0)]
        [DataRow(5.1, 5.1, 0)]
        public void CalculatorCanSubtractZeroFromADecimalPositiveNumber(double expected, double left, double right)

        {
            double result = Calculator.Subtract(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(-2.1, -2.1, 0)]
        [DataRow(-3.1, -3.1, 0)]
        public void CalculatorCanSubtractZeroFromADecimalNegativeNumber(double expected, double left, double right)

        {
            double result = Calculator.Subtract(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(-2, -1, 1)]
        [DataRow(-12, -3, 9)]
        public void CalculatorCanSubtractPositiveAndNegativeNumber(double expected, double left, double right)

        {
            double result = Calculator.Subtract(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(-2.2, -1.1, 1.1)]
        [DataRow(3.2, 2.1, -1.1)]
        public void CalculatorCanSubtractPositiveAndNegativeDecimalNumbers(double expected, double left, double right)

        {
            double result = Calculator.Subtract(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(2, 2, 1)]
        public void CalculatorCanMultiplyTwoPositiveNumbers(double expected, double left, double right)

        {
             double result = Calculator.Multiply(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod] 
        [DataRow(4, -2, -2)]
        [DataRow(6, -2, -3)]
        public void CalculatorCanMultiplyTwoNegativeNumbers(double expected, double left, double right)

        {
            double result = Calculator.Multiply(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(0, 2, 0)]
        [DataRow(0, 3, 0)]
        public void CalculatorCanMultiplyZeroWithAPositiveNumber(double expected, double left, double right)

        {
            double result = Calculator.Multiply(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(0, -1, 0)]
        [DataRow(0, -3, 0)]
        public void CalculatorCanMultiplyZeroWithANegativeNumber(double expected, double left, double right)

        {
            double result = Calculator.Multiply(left, right);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        [DataRow(0, 4.1, 0)]
        [DataRow(0, 5.1, 0)]
        public void CalculatorCanMultiplyZeroWithADecimalPositiveNumber(double expected, double left, double right)

        {
            double result = Calculator.Multiply(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(0, -2.1, 0)]
        [DataRow(0, -3.1, 0)]
        public void CalculatorCanMultiplyZeroWithADecimalNegativeNumber(double expected, double left, double right)

        {
            double result = Calculator.Multiply(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(-1, -1, 1)]
        [DataRow(-27, -3, 9)]
        public void CalculatorCanMultiplyPositiveAndNegativeNumber(double expected, double left, double right)

        {
            double result = Calculator.Multiply(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(2, 2, 1)]
        public void CalculatorCanDivideTwoPositiveNumbers(double expected, double left, double right)

        {
            double result = Calculator.Divide(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(1, -2, -2)]
        [DataRow(2, -4, -2)]
        public void CalculatorCanDivideTwoNegativeNumbers(double expected, double left, double right)

        {
            double result = Calculator.Divide(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(0, 0, 4)]
        [DataRow(0, 0, 6)]
        public void CalculatorDivideZeroWithAPositiveNumber(double expected, double left, double right)

        {
            double result = Calculator.Divide(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(0, 0, -1)]
        [DataRow(0, 0, -4)]
        public void CalculatorCanDivideZeroWithANegativeNumber(double expected, double left, double right)

        {
            double result = Calculator.Divide(left, right);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        [DataRow(0, 0, 4.1)]
        [DataRow(0, 0, 5.1)]
        public void CalculatorCanDivideZeroWithADecimalPositiveNumber(double expected, double left, double right)

        {
            double result = Calculator.Divide(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(0, 0, -5.1)]
        [DataRow(0, 0, -4.1)]
        public void CalculatorCanDivideZeroWithADecimalNegativeNumber(double expected, double left, double right)

        {
            double result = Calculator.Divide(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(-1, -1, 1)]
        [DataRow(-3, -9, 3)]
        public void CalculatorCanDividePositiveAndNegativeNumber(double expected, double left, double right)

        {
            double result = Calculator.Divide(left, right);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculatorThrowsExcecptionWhenDividingByZero()

        {
            Assert.ThrowsException<DivideByZeroException>(() => { Calculator.Divide(9, 0); });
        }

        [TestMethod]
        public void CalculatorDivididesPositiveNumberWithDenominatorGreaterThenZero()

        {
            Assert.AreEqual(9, Calculator.Divide(9, 1));
        }


    }
}
        


   


