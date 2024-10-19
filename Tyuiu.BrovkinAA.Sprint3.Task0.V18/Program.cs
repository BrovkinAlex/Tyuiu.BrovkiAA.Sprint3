using Tyuiu.BrovkinAA.Sprint3.Task0.V18.Lib;

namespace Tyuiu.BrovkinAA.Sprint3.Task0.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 3 | Выполнит Бровкин А. А. | ИБКСб-24-1";

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* Спринт #3                                                                   *");
            Console.WriteLine("* Тема: Оператор цикла for                                                    *");
            Console.WriteLine("* Задание #0                                                                  *");
            Console.WriteLine("* Вариант #18                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет                    *");
            Console.WriteLine("* произведение ряда по формуле, при X=1                                       *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine("           6 /       2        \\ k");
            Console.WriteLine("       р = П | -------------- |");
            Console.WriteLine("          k=1\\  cos(x) + 0.5  /");

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            double res = ds.GetMultiplySeries(1, 1, 6);
            Console.WriteLine("При Х = 1 значение p = " + res);

            Console.ReadKey();
        }
    }
}
