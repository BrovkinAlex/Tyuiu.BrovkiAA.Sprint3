using Tyuiu.BrovkinAA.Sprint3.Task1.V10.Lib;
namespace Tyuiu.BrovkinAA.Sprint3.Task1.V10
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
            Console.WriteLine("* Тема: Оператор цикла while                                                  *");
            Console.WriteLine("* Задание #1                                                                  *");
            Console.WriteLine("* Вариант #10                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет                  *");
            Console.WriteLine("* сумму ряда по формуле, при X=5                                              *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine("          17  /     1     \\ i");
            Console.WriteLine("       S = C  | --------- |");
            Console.WriteLine("          i=1 \\  1 + x^i  /");

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            double res = ds.GetSumSeries(5, 1, 17);
            Console.WriteLine("При Х = 5 значение S = " + res);

            Console.ReadKey();
        }
    }
}
