﻿using System;

namespace CalcLibrary
{
    public class Calc
    {
        public static double RadQ(double num)
        {
            double resp = 0;
            if (num >= 0)
                resp = Math.Sqrt(num);
            else resp = double.NaN;
            return resp;
        }
    }
}
