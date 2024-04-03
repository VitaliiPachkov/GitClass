using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitClass
{
    public class square
    {
        public double CalculateAreaSquare(double A)
        {
            double result = A * A;
            return result;
        }


        public double CalculatePerimetrSquare(double A)
        {
            double result = 4 * A;
            return result;
        }
    }
}
