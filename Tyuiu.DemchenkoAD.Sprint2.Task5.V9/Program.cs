using Tyuiu.DemchenkoAD.Sprint2.Task5.V9.Lib;
namespace Tyuiu.DemchenkoAD.Sprint2.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {           

            Console.Title = "Спринт #1 | Выполнила: Демченко А. Д. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнила: Демченко Александра Дмитриевна | ИСПб-24-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет, и печатает результат на экране                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите число:");
            
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите номер месяца (от 1 до 12):");
            int month = int.Parse(Console.ReadLine());

            DataService dataService = new DataService();
            string nextDate = dataService.FindDateOfNextDay(day, month);

            Console.WriteLine($"Следующая дата: {nextDate}");


        }
    }
}
