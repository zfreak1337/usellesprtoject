﻿using System;

namespace Calculator.TwoArguments
{
   public class Division: ICalculator
    {/// <summary>
        /// calculate Division function
        /// </summary>
        /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Doest exsist");
            }

            return firstArgument / secondArgument;
        }
    }
}
