using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitClass
{
    public class Rectangle
    {
        public double CalculateAreaRectangle(double x, double y)
        {
            double result = x * y;
            return result;
        }


        public double CalculatePerimetrRectangle(double x, double y)
        {
            double result = 2 * x + 2 *y;
            return result;
        }
    }
}
