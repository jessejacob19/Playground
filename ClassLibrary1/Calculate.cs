using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class AddCalculate : ICalculate
    {
        public int PerformCal(int n1, int n2)
        {
            return n1 + n2;
        }
    }

    public class SubtractCalculate : ICalculate
    {
        public int PerformCal(int n1, int n2)
        {
            return n1 - n2;
        }
    }

    public class MultiplyCalculate : ICalculate
    {
        public int PerformCal(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}
