using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorLib
{
    public static class AreaCalculator
    {
        public static double GetArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
