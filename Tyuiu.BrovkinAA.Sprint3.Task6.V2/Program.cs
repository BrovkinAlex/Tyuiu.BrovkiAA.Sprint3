using Tyuiu.BrovkinAA.Sprint3.Task6.V2.Lib;
namespace Tyuiu.BrovkinAA.Sprint3.Task6.V2
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
            Console.WriteLine("* Задание #6                                                                  *");
            Console.WriteLine("* Вариант #2                                                                  *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих           *");
            Console.WriteLine("* числовому отрезку [12, 18] количество всех делителей                        *");
            Console.WriteLine("*                                                                             *");            
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            int res = ds.GetSumTheDivisors(12, 18);
            Console.WriteLine("Количество делителей: " + res);

            Console.ReadKey();
        }
    }
}
