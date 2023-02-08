﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Delegate
delegate double BinaryNumericOperation(double n1, double n2);

namespace lambdaExpressionsLinqDelegates.Services
{
    internal class CalculationService
    {
        public static double Max(double x, double y)
        {
            return x > y ? x : y;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Square(double x)
        {
            return x * x;
        }
    }
}
