﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DemchenkoAD.Sprint2.Task4.V12.Lib
{
    public class DataService : ISprint2Task4V12
    {
        public double Calculate(double x, double y)
        {
            double z;
            z = (Math.Sqrt(x) > y * 2) ? Math.Pow((7 + 2 / y * y), x) : (3 * x * x - Math.Pow(Math.Cos(y), 2) + 10) / (y * y - Math.Pow(Math.Sin(x), 2) + 12);
            return Math.Round(z, 3);
        }
    }
}
