using Tyuiu.BrovkinAA.Sprint3.Task5.V17.Lib;
namespace Tyuiu.BrovkinAA.Sprint3.Task5.V17
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
            Console.WriteLine("* Тема: Вложенные циклы                                                       *");
            Console.WriteLine("* Задание #5                                                                  *");
            Console.WriteLine("* Вариант #17                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* вычислить значение функции y, используя вложенные циклы                     *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine("             3    12");
            Console.WriteLine("       y =   S    S    (sin(k) + x^2)");
            Console.WriteLine("            i=1  k=1");

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            double res = ds.GetSumSumSeries(2, 1, 3, 1, 12);
            Console.WriteLine("Значение y = " + res);

            Console.ReadKey();
        }
    }
}
