using System;

namespace Calculator_Logic
{
    public class Calculator

    {   //add method for calculator
        public static double Add(double left, double right)

        {
            return left + right;
        }
        //subtract method for calculator
        public static double Subtract(double left, double right)

        {
            return left - right;
        }
        //multiply method for calculator
        public static double Multiply(double left, double right)

        {
            return left * right;
        }

        //divide method for calculator
        public static double Divide(double left, double right)

         {
             if (right != 0)

             {
                 return left / right;
             }

             else //catching divide by zero exception

             {
                 throw new DivideByZeroException();
             }

         }
    }
}