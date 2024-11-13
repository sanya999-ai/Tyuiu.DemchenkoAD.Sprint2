using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DemchenkoAD.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            switch (n)
            {
                case 1:
                    return m == 31 ? "1.02" : $"{m + 1}.01";
                case 2:
                    return m == 28 ? "1.03" : $"{m + 1}.02";
                case 3:
                    return m == 31 ? "1.04" : $"{m + 1}.03";
                case 4:
                    return m == 30 ? "1.05" : $"{m + 1}.04";
                case 5:
                    return m == 31 ? "1.06" : $"{m + 1}.05";
                case 6:
                    return m == 30 ? "1.07" : $"{m + 1}.06";
                case 7:
                    return m == 31 ? "1.08" : $"{m + 1}.07";
                case 8:
                    return m == 31 ? "1.09" : $"{m + 1}.08";
                case 9:
                    return m == 30 ? "1.10" : $"{m + 1}.09";
                case 10:
                    return m == 31 ? "1.11" : $"{m + 1}.10";
                case 11:
                    return m == 30 ? "1.12" : $"{m + 1}.11";
                case 12:
                    return $"{m + 1}.12";
            }
            return "";
        }
    }
}

