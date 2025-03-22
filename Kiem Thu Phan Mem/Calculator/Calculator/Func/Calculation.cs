using System;

namespace Calculator
{
    public class Calculation
    {
        private int a, b;

        public Calculation(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Execute(string CalSymbol)
        {
            switch (CalSymbol.Trim())
            {
                case "+":
                    return this.a + this.b;
                case "-":
                    return this.a - this.b;
                case "*":
                    return this.a * this.b;
                case "/":
                    if (this.b != 0)
                        return this.a / this.b;
                    throw new DivideByZeroException("Cannot divide by zero");
                default:
                    throw new ArgumentException("Invalid operation symbol");
            }
        }
    }
}
