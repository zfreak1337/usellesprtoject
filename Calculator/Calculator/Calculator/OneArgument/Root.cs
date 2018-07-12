﻿using System;

namespace Calculator.OneArgument
{
    public class Root : IOneCalculator
    {/// <summary>
        /// calculate Root function
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Sqrt(firstArgument);

        }
    }
}
