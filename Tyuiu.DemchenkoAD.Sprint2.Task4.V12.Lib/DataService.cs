using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DemchenkoAD.Sprint2.Task4.V12.Lib
{
    public class DataService : ISprint2Task4V12
    {
        public double Calculate(double x, double y)
        {
            double a, b;

            a = Math.Pow((7 + (2 / Math.Pow(y, 2))), x);
            b = ((3 * Math.Pow(x, 2) - Math.Pow(Math.Cos(y), 2) + 10) / (Math.Pow(y, 2) - Math.Pow(Math.Sin(x), 2) + 12));


            double z = (Math.Sqrt(x) > y * 2) ? a : b;

            return Math.Round(z, 3);
        }
    }
}
