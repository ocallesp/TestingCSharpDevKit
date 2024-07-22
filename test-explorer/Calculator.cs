using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_explorer
{
    internal class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return a / b;
        }

        public int Modulus(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Modulus by zero is not allowed.");
            }
            return a % b;
        }

        public double Power(double baseVal, double exponent)
        {
            return Math.Pow(baseVal, exponent);
        }

        public double SquareRoot(double number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Cannot calculate the square root of a negative number.");
            }
            return Math.Sqrt(number);
        }

        public double CubeRoot(double number)
        {
            return Math.Pow(number, 1.0 / 3);
        }
    }
}
