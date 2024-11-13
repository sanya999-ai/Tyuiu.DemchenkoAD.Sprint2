﻿using Tyuiu.DemchenkoAD.Sprint2.Task5.V9.Lib;
namespace Tyuiu.DemchenkoAD.Sprint2.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


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
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите порядковый номер месяца: ");

            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число: ");
            int m = Convert.ToInt32(Console.ReadLine());
            if ((n > 12) || (m > 31))
            {
                Console.WriteLine("Введены неправильные данные");
            }
            else
            {
                if ((n == 2) && (m > 28))
                {
                    Console.WriteLine("Такого дня не существует");
                }
                else if ((n == 4) && (m > 30))
                {
                    Console.WriteLine("Такого дня не существует");
                }
                else if ((n == 6) && (m > 30))
                {
                    Console.WriteLine("Такого дня не существует");
                }
                else if ((n == 9) && (m > 30))
                {
                    Console.WriteLine("Такого дня не существует");
                }
                else if ((n == 11) && (m > 30))
                {
                    Console.WriteLine("Такого дня не существует");
                }
                else
                {
                    Console.WriteLine("********************************************************************************************");
                    Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
                    Console.WriteLine("********************************************************************************************");
                    Console.WriteLine("На следующий день будет " + ds.FindDateOfNextDay(m, n));

                }
            }
            Console.ReadKey();
        }
    }
}
