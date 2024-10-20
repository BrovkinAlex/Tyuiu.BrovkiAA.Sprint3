using Tyuiu.BrovkinAA.Sprint3.Task7.V30.Lib;
namespace Tyuiu.BtovkinAA.Sprint3.Task7.V30
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
            Console.WriteLine("* Тема: Добавление к проекту итоговых решений по спринту                      *");
            Console.WriteLine("* Задание #7                                                                  *");
            Console.WriteLine("* Вариант #30                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу которая выводит таблицу значений функции f(x)             ");
            Console.WriteLine("* в зданном диапазоне [-5, 5] с шагом 1. произвести проверку деления на 0.    *");
            Console.WriteLine("* При делении на 0 вернуть 0. Значения круглить до двух знаков после запятой. *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine("            /   5x + 2,5   \\");
            Console.WriteLine("    F(x) =  | ------------ |  +  2x  +  2");
            Console.WriteLine("            \\ sin(x) + 2   /");

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            double[] res = ds.GetMassFunction(-5, 5);
            int[] xVal = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };

            Console.WriteLine("---------------------------------");
            Console.WriteLine("| Таблица значений функции f(x) |");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("|\tx\t|\tf(x)\t|");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"|\t{xVal[i]}\t|\t{res[i]}\t|");
            }
            Console.WriteLine("---------------------------------");

            Console.ReadKey();
        }
    }
}
