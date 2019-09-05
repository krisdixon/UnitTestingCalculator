using System;
using CalculatorWithTests;
using System.Linq;



namespace CalculatorWithTests
{
    public class Calculator
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        public int Subtract(int sub1, int sub2)
        {
            return sub1 - sub2;
        }
        public int Multiply(int multiply1, int multiply2)
        {
            return multiply1 * multiply2;
        }
        public decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend / divisor;
        }
        public long Factorial(long factNumber)
        {
            long result = 1;
            for (int i = 1; i <= factNumber; i++)
            {
                result = result * i;
            }
            return result;
                
        }















    }
}
