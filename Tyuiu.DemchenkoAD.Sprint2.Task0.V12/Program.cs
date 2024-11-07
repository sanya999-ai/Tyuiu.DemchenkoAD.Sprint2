using Tyuiu.DemchenkoAD.Sprint2.Task0.V12.Lib;
namespace Tyuiu.DemchenkoAD.Sprint2.Task0.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 1095;
            int y = 475; bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #2 | Выполнила: Демченко А.Д. | ИСПб-24-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #2                                                            *");
            Console.WriteLine("* Тема: Операции сравнения                                             *");
            Console.WriteLine("* Задание #0                                                           *");
            Console.WriteLine("* Вариант #12                                                          *");
            Console.WriteLine("* Выполнила: Демченко Александра Дмитриевна | ИСПб-24-1                *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Написать программу из операций сравнений (==, !=, <, >, <=, *");
            Console.WriteLine("* >=, последовательность операций не должна нарушаться) и              *");
            Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):     *");
            Console.WriteLine("* (True, False, True, False, True, False), при x = 1095, y = 475       *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            for (int i = 0; i<6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();





        }
    }
}
