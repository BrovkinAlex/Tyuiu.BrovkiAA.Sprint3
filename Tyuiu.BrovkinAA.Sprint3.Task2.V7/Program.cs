using Tyuiu.BrovkinAA.Sprint3.Task2.V7.Lib;
namespace Tyuiu.BrovkinAA.Sprint3.Task2.V7
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
            Console.WriteLine("* Тема: Оператор цикла do-while                                               *");
            Console.WriteLine("* Задание #2                                                                  *");
            Console.WriteLine("* Вариант #7                                                                  *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу используя цикл do-while, которая вычисляет               *");
            Console.WriteLine("* сумму ряда по формуле                                                       *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine("          10  /     1     \\ 2");
            Console.WriteLine("       S = C  | --------- |");
            Console.WriteLine("          k=1 \\  sin(k)   /");

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            double res = ds.GetSumSeries(1,10);
            Console.WriteLine("Значение S = " + res);

            Console.ReadKey();
        }
    }
}
