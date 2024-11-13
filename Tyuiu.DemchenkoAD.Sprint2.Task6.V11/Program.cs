using Tyuiu.DemchenkoAD.Sprint2.Task6.V11.Lib;
namespace Tyuiu.DemchenkoAD.Sprint2.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int g, m, n;
            DataService ds = new DataService();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                      *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                               *");
            Console.WriteLine("* Задание #6                                                                     *");
            Console.WriteLine("* Вариант #11                                                                    *");
            Console.WriteLine("* Выполнила: Демченко Александра Дмитриевна | ИСПб-24-1                          *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами: g (год), m     *");
            Console.WriteLine("* (порядковый номер месяца) и n (число). По заданным g, n и m определить дату    *");
            Console.WriteLine("* следующего дня. Заданный год не является високосным.                           *");
            Console.WriteLine("*                                                                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Введите G:                                                                     *");
            g = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("* Введите M:                                                                     *");
            m = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("* Введите N:                                                                     *");
            n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine(ds.FindDateOfNextDay(g, m, n));

            Console.ReadLine();
        }
    }
}
