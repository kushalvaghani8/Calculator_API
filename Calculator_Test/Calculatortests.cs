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
        public void CalculatorCanAddTwoDecimalNegativeNumbers(double expected, double left, double right)

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


        [TestMethod] //11
        [DataRow(0, 1, 1)]
        [DataRow(1, 2, 1)]
        public void CalculatorCanSubtractTwoPositiveNumbers(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod] //12
        [DataRow(0, -2, -2)]
        [DataRow(1, -2, -3)]
        public void CalculatorCanSubtractTwoNegativeNumbers(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]//13
        [DataRow(2, 2, 0)]
        [DataRow(3, 3, 0)]
        public void CalculatorCanSubtractZeroFromAPositiveNumber(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]//14
        [DataRow(-1, -1, 0)]
        [DataRow(-3, -3, 0)]
        public void CalculatorCanSubtractZeroFromANegativeNumber(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]//15
        [DataRow(0, 1.1, 1.1)]
        [DataRow(1, 2.1, 1.1)]
        public void CalculatorCanSubtractTwoDecimalPositiveNumber(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod] //16
        [DataRow(0, -1.1, -1.1)]
        [DataRow(-1, -2.1, -1.1)]
        public void CalculatorCanSubtractTwoDecimalNegativeNumbers(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod] //17
        [DataRow(4.1, 4.1, 0)]
        [DataRow(5.1, 5.1, 0)]
        public void CalculatorCanSubtractZeroFromADecimalPositiveNumber(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]//18
        [DataRow(-2.1, -2.1, 0)]
        [DataRow(-3.1, -3.1, 0)]
        public void CalculatorCanSubtractZeroFromADecimalNegativeNumber(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]//19
        [DataRow(-2, -1, 1)]
        [DataRow(-12, -3, 9)]
        public void CalculatorCanSubtractPositiveAndNegativeNumber(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]//20
        [DataRow(-2.2, -1.1, 1.1)]
        [DataRow(3.2, 2.1, -1.1)]
        public void CalculatorCanSubtractPositiveAndNegativeDecimalNumbers(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(2, 2, 1)]
        public void CalculatorCanMultiplyTwoPositiveNumbers(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(4, -2, -2)]
        [DataRow(6, -2, -3)]
        public void CalculatorCanMultiplyTwoNegativeNumbers(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(0, 2, 0)]
        [DataRow(0, 3, 0)]
        public void CalculatorCanMultiplyZeroWithAPositiveNumber(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(0, -1, 0)]
        [DataRow(0, -3, 0)]
        public void CalculatorCanMultiplyZeroWithANegativeNumber(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }


        [TestMethod] 
        [DataRow(0, 4.1, 0)]
        [DataRow(0, 5.1, 0)]
        public void CalculatorCanMultiplyZeroWithADecimalPositiveNumber(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(0, -2.1, 0)]
        [DataRow(0, -3.1, 0)]
        public void CalculatorCanMultiplyZeroWithADecimalNegativeNumber(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(-1, -1, 1)]
        [DataRow(-27, -3, 9)]
        public void CalculatorCanMultiplyPositiveAndNegativeNumber(double expected, double left, double right)

        {
            Calculator calc = new Calculator();
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

    }
}
