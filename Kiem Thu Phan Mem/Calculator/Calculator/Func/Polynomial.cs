using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Polynomial
    {
        private int degree;
        private List<int> coefficients;

        public Polynomial(int degree, List<int> coefficients)
        {
            if (degree < 0)
                throw new ArgumentException("Invalid Data");
            if (coefficients.Count != degree + 1)
                throw new ArgumentException("Invalid Data");

            this.degree = degree;
            this.coefficients = coefficients;
        }

        public int Cal(double x)
        {
            int result = 0;
            for (int i = 0; i <= degree; i++)
            {
                result += (int)(coefficients[i] * Math.Pow(x, i));
            }
            return result;
        }
    }
}
